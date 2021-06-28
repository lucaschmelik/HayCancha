using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha
{
    public partial class AlquilerEtapaDosUI : Form
    {
        public AlquilerEtapaDosUI(Reserva oReserva)
        {
            InitializeComponent();

            foreach (DataRow oRow in dgvEncontrado.Rows)
            {
                oRow[0] = "Uno";
            }

            _oReserva = oReserva;
        }

        private Reserva _oReserva;
        public IdiomaEnum IdiomaControl { get; set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(dgvEncontrado.Rows[0].DataBoundItem == null) return;
            var oItem = dgvEncontrado.Rows[0].DataBoundItem;
            dgvEncontrado.Rows.Remove(dgvEncontrado.Rows[0]);
            dgvSeleccionado.Rows.Add(oItem);
        }
        
        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionado.Rows[0].DataBoundItem == null) return;
            var oItem = dgvSeleccionado.Rows[0].DataBoundItem;
            dgvEncontrado.Rows.Add(oItem);
            dgvSeleccionado.Rows.Remove(dgvSeleccionado.Rows[0]);
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

        }

        private void AlquilerEtapaDosUI_Load(object sender, EventArgs e)
        {

        }
    }
}
