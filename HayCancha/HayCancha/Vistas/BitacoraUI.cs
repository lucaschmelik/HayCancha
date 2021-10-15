using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.Servicios;

namespace HayCancha.Vistas
{
    public partial class BitacoraUI : Form, Idiomable
    {
        public BitacoraUI()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
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

        private void BitacoraUI_Load(object sender, System.EventArgs e)
        {
            CargarDatetimePickers();
            CargarDropDown();
            dgvBitacora.DataSource = BitacoraService.ListarBitacoras();
        }

        private void lblIngresarMensaje_Click(object sender, System.EventArgs e)
        {
            lblIngresarMensaje.Visible = false;
            txtIngresarMensaje.Focus();
        }

        private void lblIngresarUsuario_Click(object sender, System.EventArgs e)
        {
            lblIngresarUsuario.Visible = false;
            txtIngresarUsuario.Focus();
        }

        private void ddTipoEvento_onItemSelected(object sender, EventArgs e)
        {
            lblTipoEvento.Visible = false;
        }

        private void CargarDatetimePickers()
        {
            dtFechaDesde.Value = DateTime.Now.Date;
            dtFechaHasta.Value = DateTime.Now.AddDays(1);
        }

        private void CargarDropDown()
        {
            foreach (var TipoCancha in Enum.GetValues(typeof(TipoEventoBitacoraEnum)))
            {
                ddTipoEvento.AddItem(TipoCancha.ToString());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = BitacoraService.ListarBitacorasPorFiltrosVarios(new Dictionary<string, object>()
            {
                {
                    "FechaDesde", dtFechaDesde.Value
                },
                {
                    "FechaHasta", dtFechaHasta.Value
                },
                {
                    "TipoEvento", ddTipoEvento.selectedIndex == -1? (object) null : ddTipoEvento.selectedIndex + 1
                },
                {
                    "Mensaje", string.IsNullOrEmpty(txtIngresarMensaje.Text)? null : txtIngresarMensaje.Text
                },
                {
                    "NombreUsuario", string.IsNullOrEmpty(txtIngresarUsuario.Text)? null : txtIngresarUsuario.Text
                }
            });
        }
    }
}
