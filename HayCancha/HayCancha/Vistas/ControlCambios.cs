using System.Collections;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;
using Microsoft.VisualBasic;

namespace HayCancha.Vistas
{
    public partial class ControlCambios : Form, Idiomable
    {
        public ControlCambios()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
            BuscarUsuarioAuditoriaPorNombre(SessionService.Session.UsuarioLogueado.Nombre);
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

        private void lblBuscarUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            lblBuscarUsuario.Visible = false;
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            if (txtBuscar.Text != string.Empty) return;
            lblBuscarUsuario.Visible = true;
            lblCambios.Focus();
        }

        private void imgBuscar_Click(object sender, System.EventArgs e)
        {
            BuscarUsuarioAuditoriaPorNombre(txtBuscar.Text);
        }

        private void btnRestaurarUsuario_Click(object sender, System.EventArgs e)
        {
            var usuarioSeleccionado = dgvUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString();

            var cerrarSession = usuarioSeleccionado == SessionService.Session.UsuarioLogueado.Nombre;

            if (cerrarSession && Interaction.MsgBox("Luego de ejecutar la restauración del usuario se cerrará la sesión. ¿Desea continuar?", MsgBoxStyle.OkCancel, "Restauración") == MsgBoxResult.Cancel) return;
            
            UsuarioBLL.RestaurarUsuario((int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

            BitacoraService.Escribir(TipoEventoBitacoraEnum.SISTEMA, $"El usuario {usuarioSeleccionado} restauró el perfil a un estado anterior.");

            BuscarUsuarioAuditoriaPorNombre(txtBuscar.Text);

            MessageBox.Show($"El usuario {usuarioSeleccionado} fue restaurado exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!cerrarSession) return;

            ((MenuUI)Parent.Parent).CerrarSesion();
            Close();
        }

        private void BuscarUsuarioAuditoriaPorNombre(string sNombre)
        {
            dgvUsuarios.DataSource = UsuarioBLL.ObtenerUsuariosAuditoriaPorNombre(sNombre);
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["Imagen"].Width = 70;
            dgvUsuarios.Columns["Contraseña"].Width = 70;
        }
    }
}
