using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class ReservasView : UserControl
    {
        public ReservasView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(32, 24, 32, 24);

            var header = CreateHeader("Reservas", "Agenda de próximos eventos y compromisos");
            var board = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
            };
            board.Columns.Add("Fecha", 120);
            board.Columns.Add("Cliente", 200);
            board.Columns.Add("Servicio", 220);
            board.Columns.Add("Estado", 120);

            board.Items.Add(new ListViewItem(new[] { "12/08", "Casa Blanca", "Producción boda", "Confirmada" }));
            board.Items.Add(new ListViewItem(new[] { "18/08", "Boca Club", "Sonido fiesta", "En montaje" }));
            board.Items.Add(new ListViewItem(new[] { "21/08", "Hotel Sol", "Conferencia corporativa", "Por confirmar" }));

            Controls.Add(board);
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
