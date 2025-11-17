using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class ReportesView : UserControl
    {
        public ReportesView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(32, 24, 32, 24);

            var header = CreateHeader("Reportes", "Indicadores y métricas clave");
            var chartPlaceholder = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(24)
            };

            var lblChartTitle = new Label
            {
                Text = "Ingresos trimestrales",
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(25, 39, 63),
                Dock = DockStyle.Top,
                Height = 32
            };

            var chartImage = new Label
            {
                Text = "[Gráfico en desarrollo]",
                Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point),
                ForeColor = Color.FromArgb(146, 156, 177),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            chartPlaceholder.Controls.Add(chartImage);
            chartPlaceholder.Controls.Add(lblChartTitle);

            Controls.Add(chartPlaceholder);
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
    }
}
