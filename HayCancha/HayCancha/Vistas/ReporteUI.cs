using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;
using System.Drawing;

namespace HayCancha.Vistas
{
    public partial class ReporteUI : Form, Idiomable
    {
        public ReporteUI()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }

        public int IdiomaControl { get; set; }

        public void Update()
        {
            ActualizarControles(this.Controls);
        }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        private bool JugadoresChecked = true;

        private void ReporteUI_Load(object sender, EventArgs e)
        {
            CargarDdlReporte();
        }

        private void rdbCanchas_CheckedChanged(object sender, EventArgs e)
        {
            JugadoresChecked = rdbJugadores.Checked;
            CargarDdlReporte();
        }

        private void CargarDdlReporte()
        {
            ddIReporte.Items = (from object reportesEnum in JugadoresChecked ?
                Enum.GetValues(typeof(ReportesEnum.ReportesJugadoresEnum)) : Enum.GetValues(typeof(ReportesEnum.ReportesCanchasEnum)) 
                select reportesEnum.ToString().Replace('_', ' ')).ToArray();
            ddIReporte.selectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvReporte.DataSource = JugadoresChecked ? ReporteBLL.ObtenerReporteJugadoresEnum((ReportesEnum.ReportesJugadoresEnum)Enum.GetValues(typeof(ReportesEnum.ReportesJugadoresEnum)).GetValue(ddIReporte.selectedIndex), dtFechaDesde.Value, dtFechaHasta.Value)
                : ReporteBLL.ObtenerReporteJugadoresEnum((ReportesEnum.ReportesCanchasEnum)Enum.GetValues(typeof(ReportesEnum.ReportesCanchasEnum)).GetValue(ddIReporte.selectedIndex), dtFechaDesde.Value, dtFechaHasta.Value);
        }

        private void GenerarReporte()
        {
            printDialog1.ShowDialog();
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            var fila = 20;
            var columna = 370;
            e.Graphics.DrawString("| HAY CANCHA |", font, Brushes.Black, columna, fila);
            Image image = new Bitmap(Properties.Resources.icons8_soccer_ball);
            e.Graphics.DrawImage(image, new Point(400, fila += 40));
            fila += 60;
            e.Graphics.DrawLine(Pens.Black, new Point(10, fila += 25), new Point(800, fila));
            font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            columna = 60;
            fila += 5;
            e.Graphics.DrawString("POSICION", font, Brushes.Black, columna, fila);
            e.Graphics.DrawString(rdbJugadores.Checked ? "JUGADOR" : "CANCHA", font, Brushes.Black, columna += 110, fila);
            e.Graphics.DrawString("CANTIDAD DE RESERVAS", font, Brushes.Black, columna += 150, fila);
            fila += 20;
            e.Graphics.DrawLine(Pens.Black, new Point(10, fila), new Point(800, fila));

            foreach (var row in VistaService.GetDatatableFromDatagridView(dgvReporte).AsEnumerable())
            {
                var items = row.ItemArray;
                columna = 60;
                fila += 20;
                e.Graphics.DrawString($"{items[0].ToString().ToUpper()}", font, Brushes.Black, columna, fila);
                e.Graphics.DrawString($"{items[1].ToString().ToUpper()}", font, Brushes.Black, columna += 110, fila);
                e.Graphics.DrawString($"{items[2].ToString().ToUpper()}", font, Brushes.Black, columna += 200, fila);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
