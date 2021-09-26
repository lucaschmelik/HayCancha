using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha.Vistas
{
    public partial class ReservasUI : Form, Idiomable
    {
        public ReservasUI()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
            CargarGrilla();
        }

        public int IdiomaControl { get; set; }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        public new void Update()
        {
            ActualizarControles(this.Controls);
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBLL.AutorizarReserva(int.Parse(((DataRowView) dgvReservas.SelectedRows[0].DataBoundItem).Row["Id"].ToString()));
                MessageBox.Show("La reserva fue autorizada correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBLL.RechazarReserva(int.Parse(((DataRowView)dgvReservas.SelectedRows[0].DataBoundItem).Row["Id"].ToString()));
                MessageBox.Show("La reserva fue rechazada correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Cancha", typeof(string));
            oDt.Columns.Add("Organizador", typeof(string));
            oDt.Columns.Add("Fecha", typeof(string));
            oDt.Columns.Add("Hora", typeof(string));

            VistaService.DisableControl(btnAutorizar);
            VistaService.DisableControl(btnRechazar);

            foreach (var reserva in ReservaBLL.ObtenerReservasPendienteAutorizacion())
            {
                oDt.Rows.Add(reserva.Id, reserva.Estadio.Nombre.ToUpper(), reserva.Organizador.Nombre.ToUpper(), reserva.FechaInicio.ToShortDateString(), $"{reserva.FechaInicio.Hour} hs - {reserva.FechaFin.Hour} hs");
                VistaService.EnableControl(btnAutorizar);
                VistaService.EnableControl(btnRechazar);
            }

            VistaService.LoadDatagripView(dgvReservas, oDt);
        }
    }
}
