using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class CotizacionesView : UserControl
    {
        public CotizacionesView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(32, 24, 32, 24);

            var header = CreateHeader("Cotizaciones", "Seguimiento de propuestas y aprobaciones");
            var cards = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 180,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = false,
                Margin = new Padding(0, 16, 0, 24)
            };

            cards.Controls.Add(CreateCard("Pendientes", "14", "Esperando respuesta", Color.FromArgb(255, 170, 76)));
            cards.Controls.Add(CreateCard("Aprobadas", "9", "Contratos firmados", Color.FromArgb(98, 190, 102)));
            cards.Controls.Add(CreateCard("Rechazadas", "3", "Revisar feedback", Color.FromArgb(221, 102, 121)));

            var pipeline = new ListView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                View = View.Details,
                FullRowSelect = true
            };
            pipeline.Columns.Add("Cliente", 200);
            pipeline.Columns.Add("Evento", 200);
            pipeline.Columns.Add("Estado", 120);
            pipeline.Columns.Add("Monto", 100);

            pipeline.Items.Add(new ListViewItem(new[] { "Agencia Aurora", "Fiesta Corporativa", "Enviada", "$12,500" }));
            pipeline.Items.Add(new ListViewItem(new[] { "Studio Kids", "Show infantil", "Negociando", "$3,800" }));
            pipeline.Items.Add(new ListViewItem(new[] { "Urban Live", "Concierto", "Firmada", "$25,000" }));

            Controls.Add(pipeline);
            Controls.Add(cards);
            Controls.Add(header);
        }

        private Control CreateHeader(string title, string subtitle)
        {
            var panel = new Panel { Dock = DockStyle.Top, Height = 70 };
            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(25, 39, 63),
                Dock = DockStyle.Top,
                Height = 40
            };
            var lblSubtitle = new Label
            {
                Text = subtitle,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(90, 104, 128),
                Dock = DockStyle.Top,
                Height = 24
            };
            panel.Controls.Add(lblSubtitle);
            panel.Controls.Add(lblTitle);
            return panel;
        }

        private Control CreateCard(string title, string value, string description, Color accent)
        {
            var container = new Panel
            {
                Width = 220,
                Height = 120,
                Margin = new Padding(0, 0, 20, 0),
                BackColor = Color.White,
                Padding = new Padding(16),
                BorderStyle = BorderStyle.FixedSingle
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
                Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = accent,
                Dock = DockStyle.Top,
                Height = 40
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
            return container;
        }
    }
}
