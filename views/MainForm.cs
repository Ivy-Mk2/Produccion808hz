using Produccion808xHz.models;
using Produccion808xHz.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public partial class MainForm : Form
    {
        private readonly ClientService _clientService;
        private readonly string _clientsPath;
        private readonly BindingSource _clientsBinding;
        private List<Client> _clientCache;
        private Button[] _menuButtons;

        public MainForm()
        {
            InitializeComponent();
            _clientService = new ClientService(new JsonStorageService());
            _clientsBinding = new BindingSource();
            _clientCache = new List<Client>();
            _clientsPath = ResolveDataPath("Clients.json");
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _menuButtons = new[] { btnDashboard, btnClientes, btnCotizaciones, btnReservas, btnInventario, btnReportes };
            LoadClients();
            ShowDashboard();
        }

        private void LoadClients()
        {
            try
            {
                _clientCache = _clientService.GetClients(_clientsPath) ?? new List<Client>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los clientes. " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _clientCache = new List<Client>();
            }

            ApplyClientFilter(txtClientSearch.Text);
        }

        private void ApplyClientFilter(string filter)
        {
            IEnumerable<Client> query = _clientCache;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter = filter.ToLowerInvariant();
                query = query.Where(c =>
                    (!string.IsNullOrEmpty(c.Name) && c.Name.ToLowerInvariant().Contains(filter)) ||
                    (!string.IsNullOrEmpty(c.Email) && c.Email.ToLowerInvariant().Contains(filter)) ||
                    (!string.IsNullOrEmpty(c.Phone) && c.Phone.ToLowerInvariant().Contains(filter)));
            }

            _clientsBinding.DataSource = new BindingList<Client>(query.ToList());
            dgvClients.DataSource = _clientsBinding;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ShowClientsView();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var name = txtClientName.Text.Trim();
            var email = txtClientEmail.Text.Trim();
            var phone = txtClientPhone.Text.Trim();
            var notes = txtClientNotes.Text.Trim();

            var validation = ValidateClient(name, email);
            if (validation.Count > 0)
            {
                ShowClientStatus(string.Join(" ", validation), Color.DarkRed);
                return;
            }

            var client = new Client
            {
                Name = name,
                Email = email,
                Phone = phone,
                Notes = notes,
                CreatedAt = DateTime.Now
            };

            _clientCache.Add(client);
            try
            {
                _clientService.SaveClients(_clientsPath, _clientCache);
                ApplyClientFilter(txtClientSearch.Text);
                ClearClientForm();
                ShowClientStatus("Cliente agregado correctamente.", Color.FromArgb(0, 120, 80));
            }
            catch (Exception ex)
            {
                _clientCache.Remove(client);
                MessageBox.Show("No se pudo guardar el cliente. " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowClientStatus("No se pudo guardar el cliente.", Color.DarkRed);
            }
        }

        private List<string> ValidateClient(string name, string email)
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(name))
                errors.Add("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Add("El correo es obligatorio.");
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errors.Add("Correo electrónico inválido.");
            }
            return errors;
        }

        private void ClearClientForm()
        {
            txtClientName.Text = string.Empty;
            txtClientEmail.Text = string.Empty;
            txtClientPhone.Text = string.Empty;
            txtClientNotes.Text = string.Empty;
            txtClientName.Focus();
        }

        private void ShowClientStatus(string message, Color color)
        {
            lblClientStatus.Text = message;
            lblClientStatus.ForeColor = color;
        }

        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyClientFilter(txtClientSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clientsPanel.Visible)
            {
                txtClientSearch.Text = txtSearch.Text;
            }
            else
            {
                MessageBox.Show("Usa la sección Clientes para aplicar búsquedas.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NavComingSoon(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                MessageBox.Show($"La sección '{button.Text}' estará disponible pronto.", "En construcción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowDashboard()
        {
            lblSectionTitle.Text = "Dashboard";
            lblSectionSubtitle.Text = "Bienvenido, revisa el estado de tu empresa";
            dashboardPanel.Visible = true;
            dashboardPanel.BringToFront();
            clientsPanel.Visible = false;
            SetActiveMenuButton(btnDashboard);
        }

        private void ShowClientsView()
        {
            lblSectionTitle.Text = "Clientes";
            lblSectionSubtitle.Text = "Gestiona y registra nuevos clientes";
            dashboardPanel.Visible = false;
            clientsPanel.Visible = true;
            clientsPanel.BringToFront();
            SetActiveMenuButton(btnClientes);
        }

        private void SetActiveMenuButton(Button active)
        {
            if (_menuButtons == null)
                return;

            foreach (var button in _menuButtons)
            {
                if (button == null)
                    continue;

                button.BackColor = Color.FromArgb(17, 27, 45);
                button.ForeColor = Color.WhiteSmoke;
            }

            if (active != null)
            {
                active.BackColor = Color.FromArgb(33, 47, 74);
            }
        }

        private string ResolveDataPath(string fileName)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var candidate = Path.Combine(baseDir, "data", fileName);
            if (File.Exists(candidate))
                return candidate;

            try
            {
                var parent = Directory.GetParent(baseDir)?.Parent?.Parent?.FullName;
                if (!string.IsNullOrEmpty(parent))
                {
                    var fromParent = Path.Combine(parent, "data", fileName);
                    return fromParent;
                }
            }
            catch
            {
                // ignored, we will fall back to default
            }

            return candidate;
        }
    }
}
