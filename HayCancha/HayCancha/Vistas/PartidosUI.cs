using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha.Vistas
{
    public partial class PartidosUI : Form, Idiomable
    {
        public PartidosUI()
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

        private void CargarGrilla()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Cancha", typeof(string));
            oDt.Columns.Add("Organizador", typeof(string));
            oDt.Columns.Add("Fecha", typeof(string));
            oDt.Columns.Add("Hora", typeof(string));
            oDt.Columns.Add("Cantidad", typeof(int));

            VistaService.DisableControl(btnAceptar);
            VistaService.DisableControl(btnRechazar);

            foreach (var reserva in ReservaBLL.ObtenerReservasAutorizadaPorJugador())
            {
                oDt.Rows.Add(reserva.Id, reserva.Estadio.Nombre.ToUpper(), reserva.Organizador.Nombre.ToUpper(), reserva.FechaInicio.ToShortDateString(), $"{reserva.FechaInicio.Hour} hs - {reserva.FechaFin.Hour} hs", (int)reserva.Estadio.TipoCancha);
                
                VistaService.EnableControl(btnAceptar);
                VistaService.EnableControl(btnRechazar);
            }

            VistaService.LoadDatagripView(dgvReservas, oDt);
            dgvReservas.Columns["Cantidad"].Visible = false;
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var oDr = ((DataRowView) dgvReservas.SelectedRows[0].DataBoundItem).Row;

                ReservaBLL.AceptarReservaJugador(int.Parse(oDr["Id"].ToString()));

                MessageBox.Show("El partido fue aceptado correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ReservaBLL.VerificarTotalidadJugadoresReserva(int.Parse(oDr["Id"].ToString()), int.Parse(oDr["Cantidad"].ToString())))
                    MessageBox.Show("El partido está confirmado!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

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
                ReservaBLL.RechazarReservaJugador(int.Parse(((DataRowView)dgvReservas.SelectedRows[0].DataBoundItem).Row["Id"].ToString()));

                MessageBox.Show("El partido fue rechazado correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
