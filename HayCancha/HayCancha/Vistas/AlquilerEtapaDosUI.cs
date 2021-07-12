using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class AlquilerEtapaDosUI : Form, Idiomable
    {
        public AlquilerEtapaDosUI(Reserva oReserva)
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);

            foreach (DataRow oRow in dgvEncontrado.Rows)
            {
                oRow[0] = "Uno";
            }
            _oReserva = oReserva;

            if (IdiomaControl != SessionService.Session.Idioma) Update();

            imgBuscar_Click(this, EventArgs.Empty);

            lblContadorJugadores.Text = $"0 / {int.Parse(_oReserva.Estadio.TipoCancha.ToString().Last().ToString()) * 2}";

            VistaService.DisableControl(btnSacar);
            VistaService.DisableControl(btnEnviarAutorizarEtapaDos);
        }

        private Reserva _oReserva;
        public int IdiomaControl { get; set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var oItem = ((DataRowView)dgvEncontrado.SelectedRows[0].DataBoundItem).Row;
                VistaService.AddRowInDataGridView(dgvSeleccionado, oItem);
                VistaService.DeleteRowInDataGridView(dgvEncontrado, oItem);
                VistaService.EnableControl(btnSacar);
                
                dgvEncontrado.Columns["Id"].Visible = false;
                dgvSeleccionado.Columns["Id"].Visible = false;

                var cadenaContador = lblContadorJugadores.Text.Split(' ');
                lblContadorJugadores.Text = $"{(int.Parse(cadenaContador[0]) + 1)} / {cadenaContador[2]}";

                if (dgvEncontrado.RowCount == 0) VistaService.DisableControl(btnAgregar);

                ValidarBotonEnviarAutorizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void ValidarBotonEnviarAutorizar()
        {
            if (dgvSeleccionado.RowCount >= int.Parse(_oReserva.Estadio.TipoCancha.ToString().Last().ToString()) * 2)
            {
                VistaService.EnableControl(btnEnviarAutorizarEtapaDos);
            }
            else
            {
                VistaService.DisableControl(btnEnviarAutorizarEtapaDos);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            var oItem = ((DataRowView)dgvSeleccionado.SelectedRows[0].DataBoundItem).Row;
            VistaService.AddRowInDataGridView(dgvEncontrado, oItem);
            VistaService.DeleteRowInDataGridView(dgvSeleccionado, oItem);
            VistaService.EnableControl(btnAgregar);

            dgvEncontrado.Columns["Id"].Visible = false;
            dgvSeleccionado.Columns["Id"].Visible = false;

            var cadenaContador = lblContadorJugadores.Text.Split(' ');
            lblContadorJugadores.Text = $"{(int.Parse(cadenaContador[0]) - 1)} / {cadenaContador[2]}";

            if (dgvSeleccionado.RowCount == 0) VistaService.DisableControl(btnSacar);

            ValidarBotonEnviarAutorizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") lblBuscarJugadorEtapaDos.Visible = false;
        }

        private void lblBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            lblBuscarJugadorEtapaDos.Visible = false;
            txtBuscar.Focus();
        }

        private void btnEnviarAutorizar_Click(object sender, EventArgs e)
        {
            try
            {
                _oReserva.Organizador = SessionService.Session.UsuarioLogueado;
                _oReserva.FechaFin = _oReserva.FechaInicio.AddHours(1);

                foreach (var usuario in VistaService.GetDatatableFromDatagridView(dgvSeleccionado).AsEnumerable())
                {
                    _oReserva.lstJugadores.Add(new Usuario()
                    {
                        Id = int.Parse(usuario["Id"].ToString()),
                        Nombre = usuario["Nombre"].ToString()
                    });
                }

                _oReserva.Id = AlquilerBLL.GuardarReserva(_oReserva);
                AlquilerBLL.CambiarEstadoReserva(_oReserva, EstadoReservaEnum.PendienteAutorizacion);
                MessageBox.Show("La reserva se generó correctamente, se envió a autorizar!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public new void Update()
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

        private void imgBuscar_Click(object sender, EventArgs e)
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("NOMBRE", typeof(string));

            foreach (var usuario in UsuarioBLL.ObtenerUsuariosPorNombre(txtBuscar.Text))
            {
                if (VistaService.GetDatatableFromDatagridView(dgvSeleccionado).AsEnumerable().Any(x => int.Parse(x["Id"].ToString()) == usuario.Id)) continue;
                oDt.Rows.Add(usuario.Id, usuario.Nombre.ToUpper());
            }

            VistaService.LoadDatagripView(dgvEncontrado, oDt);

            dgvEncontrado.Columns["Id"].Visible = false;
        }
    }
}
