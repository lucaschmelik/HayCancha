using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class MenuUI : Form, IOdiomable
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
            _UsuarioBLL = new UsuarioBLL(SessionService.Session.ObtenerNombreUsuario(), SessionService.Session.ObtenerContraseñaUsuario());
            RedondearPictureBox();
            lblNombreMenu.Text = SessionService.Session.ObtenerNombreUsuario().ToUpper();
            _fmAlquilerEtapaUno = new AlquilerEtapaUnoUI();
            _fmAlquilerEtapaUno.EventoEnviar += AbrirFmAlquilerEtapaUnoEtapaDos;
        }

        private LoginUI _frmLogin;
        private UsuarioBLL _UsuarioBLL;
        private AlquilerEtapaUnoUI _fmAlquilerEtapaUno;

        private int _iMov;
        private int _iMovX;
        private int _iMovY;

        public IdiomaEnum IdiomaControl { get; set; }

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
            if (SessionService.Session.Idioma != IdiomaEnum.Español)
                SessionService.Session.Idioma = IdiomaEnum.Español;
        }

        private void tsmIdiomaIngles_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != IdiomaEnum.Ingles)
                SessionService.Session.Idioma = IdiomaEnum.Ingles;
        }

        private void tsmIdiomaChino_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != IdiomaEnum.Chino)
                SessionService.Session.Idioma = IdiomaEnum.Chino;
        }

        public void Update()
        {
            TraductorBLL.Instancia.ActualizarControles(this.Controls);

            IdiomaControl = SessionService.Session.Idioma;
        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();

            DialogResult drImagen = ofdImagen.ShowDialog();

            if (drImagen != DialogResult.OK) return;

            _UsuarioBLL.CambiarImagenPerfil(File.ReadAllBytes(ofdImagen.FileName));

            imgPerfil.Load(ofdImagen.FileName);
        }

        private void tsmAlquiler_Click(object sender, EventArgs e)
        {
            VistaService.Instancia.AbrirFormEnPanel(panelMenus, _fmAlquilerEtapaUno);
            if (_fmAlquilerEtapaUno.IdiomaControl == this.IdiomaControl) return;
            Update();
            _fmAlquilerEtapaUno.IdiomaControl = SessionService.Session.Idioma;
        }

        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            VistaService.Instancia.AbrirFormEnPanel(panelMenus, new UsuariosUI());
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
            VistaService.Instancia.AbrirFormEnPanel(panelMenus, frmAlquilerEtapaDos);
            if(frmAlquilerEtapaDos.IdiomaControl != this.IdiomaControl) Update();
        }
    }
}
