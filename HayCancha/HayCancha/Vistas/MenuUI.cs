using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;
using HayCancha.Vistas;
using Microsoft.VisualBasic;

namespace HayCancha
{
    public partial class MenuUI : Form, Idiomable
    {
        public MenuUI(LoginUI frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SessionService.Session.Suscribir(this);
            if(IdiomaControl != _frmLogin.IdiomaControl) Update();
            SessionService.Instancia.VerificarPermisos(msMenu);
            imgPerfil.Image = SessionService.Session.ObtenerImagenPerfil();
            RedondearPictureBox();
            lblNombreMenu.Text = SessionService.Session.ObtenerNombreUsuario().ToUpper();
            _fmAlquilerEtapaUno = new AlquilerEtapaUnoUI();
            _fmAlquilerEtapaUno.EventoEnviar += AbrirFmAlquilerEtapaUnoEtapaDos;
        }

        private LoginUI _frmLogin;
        private AlquilerEtapaUnoUI _fmAlquilerEtapaUno;

        private int _iMov;
        private int _iMovX;
        private int _iMovY;

        public int IdiomaControl { get; set; }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            _iMov = 1;
            _iMovX = e.X;
            _iMovY = e.Y;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (_iMov == 1) SetDesktopLocation(MousePosition.X - _iMovX, MousePosition.Y - _iMovY);
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            _iMov = 0;
        }

        private void RedondearPictureBox()
        {
            var graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(10, 0, imgPerfil.Width - 20, imgPerfil.Height - 1);
            var imgPerfilRegion = new Region(graphicsPath);
            imgPerfil.Region = imgPerfilRegion;
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            SessionService.Session.Logout();
            Close();
            _frmLogin.Show();
        }

        private void tsmIdiomaEspañol_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Español)
                SessionService.Session.Idioma = (int)IdiomaEnum.Español;
        }

        private void tsmIdiomaIngles_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Ingles)
                SessionService.Session.Idioma = (int)IdiomaEnum.Ingles;
        }

        private void tsmIdiomaChino_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Chino)
                SessionService.Session.Idioma = (int)IdiomaEnum.Chino;
        }

        public new void Update()
        {
            ActualizarControles(Controls);

            IdiomaControl = SessionService.Session.Idioma;
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();

            ofdImagen.Filter = "|*.jpg;*.png;";

            DialogResult drImagen = ofdImagen.ShowDialog();

            if (drImagen != DialogResult.OK) return;

            UsuarioBLL.CambiarImagenPerfil(File.ReadAllBytes(ofdImagen.FileName));

            BitacoraService.Escribir(TipoEventoBitacoraEnum.SISTEMA, $"El usuario {SessionService.Session.UsuarioLogueado.Nombre} cambió la foto de perfil");

            imgPerfil.Load(ofdImagen.FileName);
        }

        private void tsmAlquiler_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, _fmAlquilerEtapaUno);
        }

        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new PermisosUI());
        }

        private void tsmReservas_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new ReservasUI());
        }

        private void tsmPartidos_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new PartidosUI());
        }

        private void tsmBitacora_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new BitacoraUI());
        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new BackupUI());
        }

        private void tsmUsuarios_Click_1(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new ControlCambios());
        }

        private void imgNotificacion_Click(object sender, EventArgs e)
        {
            if (ucNotificacion.Visible)
            {
                ucNotificacion.Visible = false;
                return;
            }

            imgPuntoNotificacion.Visible = false;
            ucNotificacion.Show();
            ucNotificacion.Focus();
        }

        private void ucNotificacion_Leave(object sender, EventArgs e)
        {
            ucNotificacion.Visible = false;
        }

        private void AbrirFmAlquilerEtapaUnoEtapaDos(object senderReserva, EventArgs e)
        {
            var frmAlquilerEtapaDos = new AlquilerEtapaDosUI(senderReserva as Reserva);
            VistaService.AbrirFormEnPanel(panelMenus, frmAlquilerEtapaDos);
            if(frmAlquilerEtapaDos.IdiomaControl != this.IdiomaControl) Update();
        }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                if (oComponente.GetType() == typeof(Panel))
                {
                    ActualizarControles(((Panel)oComponente).Controls);
                }

                if (oComponente.GetType() == typeof(MenuStrip))
                {
                    ActualizarControles(((MenuStrip)oComponente).Items);
                }

                if (oComponente.GetType() == typeof(ToolStripMenuItem))
                {
                    if (((ToolStripMenuItem)oComponente).DropDownItems.Count > 0)
                    {
                        ActualizarControles(((ToolStripMenuItem)oComponente).DropDownItems);
                    }
                    ((ToolStripMenuItem)oComponente).Text = TraductorService.RetornaTraduccion(((ToolStripMenuItem)oComponente).Text) ?? ((ToolStripMenuItem)oComponente).Text;
                    continue;
                }

                ((Control) oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaService.AbrirFormEnPanel(panelMenus, new IdiomasUI());
        }

        public void CerrarSesion()
        {
            btnMenuSalir_Click(new object(), new EventArgs());
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            var contraseñaNueva = Interaction.InputBox("Ingrese el nombre de la nueva contraseña", $"NUEVA CONTRASEÑA: {SessionService.Session.ObtenerNombreUsuario()}");

            if (contraseñaNueva == string.Empty) return;

            UsuarioBLL.CambiarContraseña(SessionService.Session.ObtenerNombreUsuario(), EncriptadorService.AplicarHash(contraseñaNueva));

            BitacoraService.Escribir(TipoEventoBitacoraEnum.SISTEMA, $"El usuario {SessionService.Session.ObtenerNombreUsuario()} cambió la contraseña.");

            MessageBox.Show($"La contraseña del usuario {SessionService.Session.ObtenerNombreUsuario()} fue cambiada exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
