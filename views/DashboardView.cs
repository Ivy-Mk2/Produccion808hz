using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class DashboardView : UserControl
    {
        public DashboardView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(32, 24, 32, 24);

            var lblWelcome = new Label
            {
                Text = "¡Bienvenido de nuevo!",
                Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(26, 39, 60),
                Dock = DockStyle.Top,
                Height = 48
            };

            var lblSubtitle = new Label
            {
                Text = "Resumen general del negocio",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(90, 104, 128),
                Dock = DockStyle.Top,
                Height = 32
            };

            var cardsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = true,
                Padding = new Padding(0, 16, 0, 0)
            };

            cardsPanel.Controls.Add(CreateSummaryCard("Ventas del mes", "$125,430", "+12% respecto al mes anterior", Color.FromArgb(58, 134, 255)));
            cardsPanel.Controls.Add(CreateSummaryCard("Clientes activos", "248", "5 nuevos esta semana", Color.FromArgb(98, 190, 102)));
            cardsPanel.Controls.Add(CreateSummaryCard("Eventos programados", "17", "3 para hoy", Color.FromArgb(255, 170, 76)));
            cardsPanel.Controls.Add(CreateSummaryCard("Tareas pendientes", "9", "Revisa tu bandeja de trabajo", Color.FromArgb(221, 102, 121)));

            Controls.Add(cardsPanel);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
        }

        private Control CreateSummaryCard(string title, string value, string description, Color accent)
        {
            var container = new Panel
            {
                Width = 260,
                Height = 140,
                Margin = new Padding(0, 0, 20, 20),
                BackColor = Color.White,
                Padding = new Padding(20),
                BorderStyle = BorderStyle.FixedSingle
            };

            var indicator = new Panel
            {
                BackColor = accent,
                Size = new Size(32, 4),
                Dock = DockStyle.Top
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(120, 134, 158),
                Dock = DockStyle.Top,
                Height = 24
            };

            var lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(25, 39, 63),
                Dock = DockStyle.Top,
                Height = 48
            };

            var lblDescription = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(146, 156, 177),
                Dock = DockStyle.Fill
            };

            container.Controls.Add(lblDescription);
            container.Controls.Add(lblValue);
            container.Controls.Add(lblTitle);
            container.Controls.Add(indicator);

            return container;
        }
    }
}
