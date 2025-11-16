using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public class InventarioView : UserControl
    {
        public InventarioView()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(244, 247, 252);
            Padding = new Padding(32, 24, 32, 24);

            var header = CreateHeader("Inventario", "Disponibilidad de equipos y recursos");
            var grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };

            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Equipo", Width = 200 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", Width = 150 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", Width = 100 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", Width = 120 });

            grid.Rows.Add("Consola X32", "Audio", "2", "Disponible");
            grid.Rows.Add("Cabina DJ", "Escenario", "1", "Reservado");
            grid.Rows.Add("Micrófonos inalámbricos", "Audio", "6", "Mantenimiento");

            Controls.Add(grid);
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
