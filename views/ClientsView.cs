using System;
using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class ClientsView : UserControl
    {
        private readonly TextBox txtClientName;
        private readonly TextBox txtClientEmail;
        private readonly TextBox txtClientPhone;
        private readonly TextBox txtClientNotes;
        private readonly TextBox txtClientSearch;
        private readonly DataGridView dgvClients;
        private readonly Label lblClientStatus;
        private readonly Button btnAddClient;

        public event EventHandler AddClientClicked;
        public event EventHandler SearchTextChanged;

        public ClientsView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(24);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                BackColor = Color.Transparent
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var searchPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Height = 80
            };

            var lblSearch = new Label
            {
                Text = "Buscar clientes",
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(25, 39, 63),
                Dock = DockStyle.Top,
                Height = 26
            };

            txtClientSearch = new TextBox
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Height = 30,
                Margin = new Padding(0, 4, 0, 0)
            };
            txtClientSearch.TextChanged += (s, e) => SearchTextChanged?.Invoke(this, EventArgs.Empty);

            searchPanel.Controls.Add(txtClientSearch);
            searchPanel.Controls.Add(lblSearch);

            layout.SetColumnSpan(searchPanel, 2);
            layout.Controls.Add(searchPanel, 0, 0);

            var formPanel = new GroupBox
            {
                Text = "Nuevo cliente",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(25, 39, 63),
                Dock = DockStyle.Fill,
                Padding = new Padding(16),
                BackColor = Color.White
            };

            txtClientName = CreateInput("Nombre completo", formPanel, 0);
            txtClientEmail = CreateInput("Correo electrónico", formPanel, 1);
            txtClientPhone = CreateInput("Teléfono", formPanel, 2);

            var notesLabel = new Label
            {
                Text = "Notas",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(90, 104, 128),
                Location = new Point(16, 220),
                AutoSize = true
            };
            txtClientNotes = new TextBox
            {
                Multiline = true,
                Height = 80,
                Width = 320,
                Location = new Point(16, 240),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                BorderStyle = BorderStyle.FixedSingle
            };

            btnAddClient = new Button
            {
                Text = "Guardar cliente",
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point),
                BackColor = Color.FromArgb(33, 47, 74),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(16, 330)
            };
            btnAddClient.FlatAppearance.BorderSize = 0;
            btnAddClient.Click += (s, e) => AddClientClicked?.Invoke(this, EventArgs.Empty);

            lblClientStatus = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(90, 104, 128),
                Location = new Point(16, 370),
                AutoSize = true
            };

            formPanel.Controls.Add(notesLabel);
            formPanel.Controls.Add(txtClientNotes);
            formPanel.Controls.Add(btnAddClient);
            formPanel.Controls.Add(lblClientStatus);

            layout.Controls.Add(formPanel, 0, 1);

            dgvClients = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };

            dgvClients.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre", FillWeight = 25 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Correo", FillWeight = 25 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "Teléfono", FillWeight = 15 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Notes", HeaderText = "Notas", FillWeight = 20 },
                new DataGridViewTextBoxColumn { DataPropertyName = "CreatedAt", HeaderText = "Creado", FillWeight = 15, DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } }
            );

            layout.Controls.Add(dgvClients, 1, 1);

            Controls.Add(layout);
        }

        private TextBox CreateInput(string label, Control parent, int index)
        {
            var lbl = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(90, 104, 128),
                Location = new Point(16, 40 + (index * 60)),
                AutoSize = true
            };
            var txt = new TextBox
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                BorderStyle = BorderStyle.FixedSingle,
                Width = 320,
                Location = new Point(16, 60 + (index * 60))
            };

            parent.Controls.Add(lbl);
            parent.Controls.Add(txt);
            return txt;
        }

        public string ClientName => txtClientName.Text.Trim();
        public string ClientEmail => txtClientEmail.Text.Trim();
        public string ClientPhone => txtClientPhone.Text.Trim();
        public string ClientNotes => txtClientNotes.Text.Trim();

        public string SearchText
        {
            get => txtClientSearch.Text;
            set => txtClientSearch.Text = value;
        }

        public void BindClients(object dataSource)
        {
            dgvClients.DataSource = dataSource;
        }

        public void ClearForm()
        {
            txtClientName.Clear();
            txtClientEmail.Clear();
            txtClientPhone.Clear();
            txtClientNotes.Clear();
            txtClientName.Focus();
        }

        public void ShowStatus(string message, Color color)
        {
            lblClientStatus.Text = message;
            lblClientStatus.ForeColor = color;
        }
    }
}
