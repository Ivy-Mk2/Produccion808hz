namespace Produccion808xHz.views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnCotizaciones = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSectionSubtitle = new System.Windows.Forms.Label();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.lblClientStatus = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClientSearch = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.grpNewClient = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtClientNotes = new System.Windows.Forms.TextBox();
            this.lblClientNotes = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.lblDashboardText = new System.Windows.Forms.Label();
            this.lblDashboardWelcome = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpNewClient.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.sidebarPanel.Controls.Add(this.panelUser);
            this.sidebarPanel.Controls.Add(this.btnReportes);
            this.sidebarPanel.Controls.Add(this.btnInventario);
            this.sidebarPanel.Controls.Add(this.btnReservas);
            this.sidebarPanel.Controls.Add(this.btnCotizaciones);
            this.sidebarPanel.Controls.Add(this.btnClientes);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.lblSystem);
            this.sidebarPanel.Controls.Add(this.lblBrand);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(220, 720);
            this.sidebarPanel.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.panelUser.Controls.Add(this.lblUserRole);
            this.panelUser.Controls.Add(this.lblUserName);
            this.panelUser.Location = new System.Drawing.Point(12, 600);
            this.panelUser.Name = "panelUser";
            this.panelUser.Padding = new System.Windows.Forms.Padding(12);
            this.panelUser.Size = new System.Drawing.Size(196, 92);
            this.panelUser.TabIndex = 8;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserRole.Location = new System.Drawing.Point(15, 55);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(122, 15);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Ejecutivo de Ventas";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(15, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Javier Rodríguez";
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.Location = new System.Drawing.Point(12, 360);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(196, 38);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.NavComingSoon);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventario.Location = new System.Drawing.Point(12, 316);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(196, 38);
            this.btnInventario.TabIndex = 6;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.NavComingSoon);
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservas.Location = new System.Drawing.Point(12, 272);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(196, 38);
            this.btnReservas.TabIndex = 5;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.NavComingSoon);
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.FlatAppearance.BorderSize = 0;
            this.btnCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCotizaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCotizaciones.Location = new System.Drawing.Point(12, 228);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Size = new System.Drawing.Size(196, 38);
            this.btnCotizaciones.TabIndex = 4;
            this.btnCotizaciones.Text = "Cotizaciones";
            this.btnCotizaciones.UseVisualStyleBackColor = true;
            this.btnCotizaciones.Click += new System.EventHandler(this.NavComingSoon);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.Location = new System.Drawing.Point(12, 184);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(196, 38);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Location = new System.Drawing.Point(12, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(196, 38);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSystem.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSystem.Location = new System.Drawing.Point(34, 90);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(109, 15);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.Text = "Sistema de Gestión";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(30, 55);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(98, 30);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "808xHz";
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.White;
            this.topBarPanel.Controls.Add(this.btnSettings);
            this.topBarPanel.Controls.Add(this.btnNotifications);
            this.topBarPanel.Controls.Add(this.btnSearch);
            this.topBarPanel.Controls.Add(this.txtSearch);
            this.topBarPanel.Controls.Add(this.lblSectionSubtitle);
            this.topBarPanel.Controls.Add(this.lblSectionTitle);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(220, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(980, 90);
            this.topBarPanel.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Location = new System.Drawing.Point(912, 28);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 34);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "⚙";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotifications.Location = new System.Drawing.Point(866, 28);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(40, 34);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "🔔";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(779, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(550, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSectionSubtitle
            // 
            this.lblSectionSubtitle.AutoSize = true;
            this.lblSectionSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSectionSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSectionSubtitle.Location = new System.Drawing.Point(32, 54);
            this.lblSectionSubtitle.Name = "lblSectionSubtitle";
            this.lblSectionSubtitle.Size = new System.Drawing.Size(0, 15);
            this.lblSectionSubtitle.TabIndex = 1;
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(30, 20);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(133, 32);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "Dashboard";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.contentPanel.Controls.Add(this.clientsPanel);
            this.contentPanel.Controls.Add(this.dashboardPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(220, 90);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(25);
            this.contentPanel.Size = new System.Drawing.Size(980, 630);
            this.contentPanel.TabIndex = 2;
            // 
            // clientsPanel
            // 
            this.clientsPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientsPanel.Controls.Add(this.lblClientStatus);
            this.clientsPanel.Controls.Add(this.dgvClients);
            this.clientsPanel.Controls.Add(this.lblClientSearch);
            this.clientsPanel.Controls.Add(this.txtClientSearch);
            this.clientsPanel.Controls.Add(this.grpNewClient);
            this.clientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsPanel.Location = new System.Drawing.Point(25, 25);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(930, 580);
            this.clientsPanel.TabIndex = 1;
            this.clientsPanel.Visible = false;
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClientStatus.AutoSize = true;
            this.lblClientStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblClientStatus.Location = new System.Drawing.Point(20, 548);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(0, 15);
            this.lblClientStatus.TabIndex = 4;
            // 
            // dgvClients
            // 
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientName,
            this.colClientEmail,
            this.colClientPhone,
            this.colClientNotes,
            this.colClientCreated});
            this.dgvClients.Location = new System.Drawing.Point(20, 220);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(890, 320);
            this.dgvClients.TabIndex = 3;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "Name";
            this.colClientName.HeaderText = "Nombre";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colClientEmail
            // 
            this.colClientEmail.DataPropertyName = "Email";
            this.colClientEmail.HeaderText = "Correo";
            this.colClientEmail.Name = "colClientEmail";
            this.colClientEmail.ReadOnly = true;
            // 
            // colClientPhone
            // 
            this.colClientPhone.DataPropertyName = "Phone";
            this.colClientPhone.HeaderText = "Teléfono";
            this.colClientPhone.Name = "colClientPhone";
            this.colClientPhone.ReadOnly = true;
            // 
            // colClientNotes
            // 
            this.colClientNotes.DataPropertyName = "Notes";
            this.colClientNotes.HeaderText = "Notas";
            this.colClientNotes.Name = "colClientNotes";
            this.colClientNotes.ReadOnly = true;
            // 
            // colClientCreated
            // 
            this.colClientCreated.DataPropertyName = "CreatedAt";
            this.colClientCreated.HeaderText = "Creado";
            this.colClientCreated.Name = "colClientCreated";
            this.colClientCreated.ReadOnly = true;
            // 
            // lblClientSearch
            // 
            this.lblClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientSearch.AutoSize = true;
            this.lblClientSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblClientSearch.Location = new System.Drawing.Point(620, 25);
            this.lblClientSearch.Name = "lblClientSearch";
            this.lblClientSearch.Size = new System.Drawing.Size(86, 15);
            this.lblClientSearch.TabIndex = 2;
            this.lblClientSearch.Text = "Buscar cliente";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientSearch.Location = new System.Drawing.Point(623, 45);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(287, 25);
            this.txtClientSearch.TabIndex = 1;
            this.txtClientSearch.TextChanged += new System.EventHandler(this.txtClientSearch_TextChanged);
            // 
            // grpNewClient
            // 
            this.grpNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNewClient.BackColor = System.Drawing.Color.White;
            this.grpNewClient.Controls.Add(this.btnAddClient);
            this.grpNewClient.Controls.Add(this.txtClientNotes);
            this.grpNewClient.Controls.Add(this.lblClientNotes);
            this.grpNewClient.Controls.Add(this.txtClientPhone);
            this.grpNewClient.Controls.Add(this.lblClientPhone);
            this.grpNewClient.Controls.Add(this.txtClientEmail);
            this.grpNewClient.Controls.Add(this.lblClientEmail);
            this.grpNewClient.Controls.Add(this.txtClientName);
            this.grpNewClient.Controls.Add(this.lblClientName);
            this.grpNewClient.Location = new System.Drawing.Point(20, 20);
            this.grpNewClient.Name = "grpNewClient";
            this.grpNewClient.Size = new System.Drawing.Size(570, 184);
            this.grpNewClient.TabIndex = 0;
            this.grpNewClient.TabStop = false;
            this.grpNewClient.Text = "Registrar nuevo cliente";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(182)))), ((int)(((byte)(122)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(420, 132);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(130, 34);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "Guardar";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtClientNotes
            // 
            this.txtClientNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientNotes.Location = new System.Drawing.Point(20, 132);
            this.txtClientNotes.Multiline = true;
            this.txtClientNotes.Name = "txtClientNotes";
            this.txtClientNotes.Size = new System.Drawing.Size(380, 34);
            this.txtClientNotes.TabIndex = 7;
            // 
            // lblClientNotes
            // 
            this.lblClientNotes.AutoSize = true;
            this.lblClientNotes.Location = new System.Drawing.Point(17, 114);
            this.lblClientNotes.Name = "lblClientNotes";
            this.lblClientNotes.Size = new System.Drawing.Size(38, 15);
            this.lblClientNotes.TabIndex = 6;
            this.lblClientNotes.Text = "Notas";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientPhone.Location = new System.Drawing.Point(294, 84);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(256, 23);
            this.txtClientPhone.TabIndex = 5;
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(291, 66);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(51, 15);
            this.lblClientPhone.TabIndex = 4;
            this.lblClientPhone.Text = "Teléfono";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientEmail.Location = new System.Drawing.Point(20, 84);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(256, 23);
            this.txtClientEmail.TabIndex = 3;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(17, 66);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(103, 15);
            this.lblClientEmail.TabIndex = 2;
            this.lblClientEmail.Text = "Correo electrónico";
            // 
            // txtClientName
            // 
            this.txtClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Location = new System.Drawing.Point(20, 38);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(530, 23);
            this.txtClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(17, 20);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(108, 15);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Nombre del cliente";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.White;
            this.dashboardPanel.Controls.Add(this.lblDashboardText);
            this.dashboardPanel.Controls.Add(this.lblDashboardWelcome);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(25, 25);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(930, 580);
            this.dashboardPanel.TabIndex = 0;
            // 
            // lblDashboardText
            // 
            this.lblDashboardText.AutoSize = true;
            this.lblDashboardText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboardText.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboardText.Location = new System.Drawing.Point(40, 110);
            this.lblDashboardText.Name = "lblDashboardText";
            this.lblDashboardText.Size = new System.Drawing.Size(436, 20);
            this.lblDashboardText.TabIndex = 1;
            this.lblDashboardText.Text = "Revisa tus indicadores clave y mantén el control de tu operación.";
            // 
            // lblDashboardWelcome
            // 
            this.lblDashboardWelcome.AutoSize = true;
            this.lblDashboardWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDashboardWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.lblDashboardWelcome.Location = new System.Drawing.Point(35, 50);
            this.lblDashboardWelcome.Name = "lblDashboardWelcome";
            this.lblDashboardWelcome.Size = new System.Drawing.Size(303, 45);
            this.lblDashboardWelcome.TabIndex = 0;
            this.lblDashboardWelcome.Text = "Bienvenido a 808xHz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.sidebarPanel);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "808xHz - Dashboard";
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.clientsPanel.ResumeLayout(false);
            this.clientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpNewClient.ResumeLayout(false);
            this.grpNewClient.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSectionSubtitle;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCotizaciones;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Panel clientsPanel;
        private System.Windows.Forms.GroupBox grpNewClient;
        private System.Windows.Forms.TextBox txtClientNotes;
        private System.Windows.Forms.Label lblClientNotes;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblClientSearch;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientCreated;
        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label lblDashboardText;
        private System.Windows.Forms.Label lblDashboardWelcome;
    }
}
