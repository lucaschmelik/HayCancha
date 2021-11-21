using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

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
    }
}
