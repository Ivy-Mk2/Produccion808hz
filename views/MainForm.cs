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
        private DashboardView _dashboardView;
        private ClientsView _clientsView;
        private CotizacionesView _cotizacionesView;
        private ReservasView _reservasView;
        private InventarioView _inventarioView;
        private ReportesView _reportesView;
        private UserControl _currentView;

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
            InitializeViews();
            LoadClients();
            ShowDashboard();
        }

        private void InitializeViews()
        {
            _dashboardView = new DashboardView();
            _clientsView = new ClientsView();
            _cotizacionesView = new CotizacionesView();
            _reservasView = new ReservasView();
            _inventarioView = new InventarioView();
            _reportesView = new ReportesView();

            _clientsView.AddClientClicked += ClientsView_AddClientClicked;
            _clientsView.SearchTextChanged += ClientsView_SearchTextChanged;

            AddView(_dashboardView);
            AddView(_clientsView);
            AddView(_cotizacionesView);
            AddView(_reservasView);
            AddView(_inventarioView);
            AddView(_reportesView);
        }

        private void AddView(UserControl view)
        {
            view.Dock = DockStyle.Fill;
            view.Visible = false;
            contentPanel.Controls.Add(view);
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

            ApplyClientFilter(_clientsView?.SearchText);
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
            _clientsView?.BindClients(_clientsBinding);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ShowClientsView();
        }

        private void ClientsView_AddClientClicked(object sender, EventArgs e)
        {
            var name = _clientsView.ClientName;
            var email = _clientsView.ClientEmail;
            var phone = _clientsView.ClientPhone;
            var notes = _clientsView.ClientNotes;

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
                ApplyClientFilter(_clientsView.SearchText);
                _clientsView.ClearForm();
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

        private void ShowClientStatus(string message, Color color)
        {
            _clientsView?.ShowStatus(message, color);
        }

        private void ClientsView_SearchTextChanged(object sender, EventArgs e)
        {
            ApplyClientFilter(_clientsView.SearchText);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_currentView == _clientsView)
            {
                _clientsView.SearchText = txtSearch.Text;
            }
            else
            {
                MessageBox.Show("Usa la sección Clientes para aplicar búsquedas.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowDashboard()
        {
            lblSectionTitle.Text = "Dashboard";
            lblSectionSubtitle.Text = "Bienvenido, revisa el estado de tu empresa";
            ShowView(_dashboardView);
            SetActiveMenuButton(btnDashboard);
        }

        private void ShowClientsView()
        {
            lblSectionTitle.Text = "Clientes";
            lblSectionSubtitle.Text = "Gestiona y registra nuevos clientes";
            ShowView(_clientsView);
            SetActiveMenuButton(btnClientes);
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            ShowCotizacionesView();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ShowReservasView();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ShowInventarioView();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowReportesView();
        }

        private void ShowCotizacionesView()
        {
            lblSectionTitle.Text = "Cotizaciones";
            lblSectionSubtitle.Text = "Supervisa tus propuestas en curso";
            ShowView(_cotizacionesView);
            SetActiveMenuButton(btnCotizaciones);
        }

        private void ShowReservasView()
        {
            lblSectionTitle.Text = "Reservas";
            lblSectionSubtitle.Text = "Coordina la agenda de eventos";
            ShowView(_reservasView);
            SetActiveMenuButton(btnReservas);
        }

        private void ShowInventarioView()
        {
            lblSectionTitle.Text = "Inventario";
            lblSectionSubtitle.Text = "Controla tus equipos y recursos";
            ShowView(_inventarioView);
            SetActiveMenuButton(btnInventario);
        }

        private void ShowReportesView()
        {
            lblSectionTitle.Text = "Reportes";
            lblSectionSubtitle.Text = "Analiza métricas clave";
            ShowView(_reportesView);
            SetActiveMenuButton(btnReportes);
        }

        private void ShowView(UserControl view)
        {
            if (view == null)
                return;

            foreach (Control ctrl in contentPanel.Controls)
            {
                ctrl.Visible = ctrl == view;
            }

            view.BringToFront();
            _currentView = view;
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
