using System;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class Menu : Form, IOdiomable
    {
        public Menu(Login frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SessionService.Session.Suscribir(this);
            if(IdiomaControl != _frmLogin.IdiomaControl) Update();
            VerificarPermisos();
        }

        private UsuarioBLL _oUsuarioBLL;
        private Login _frmLogin;

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
            foreach (Control oComponente in this.Controls)
            {
                if (oComponente.GetType() == typeof(MenuStrip))
                {
                    foreach (ToolStripMenuItem oComponenteMenu in (oComponente as MenuStrip).Items)
                    {
                        if (oComponenteMenu.DropDownItems.Count > 0)
                        {
                            foreach (ToolStripMenuItem oComponentePanelMenu in oComponenteMenu.DropDownItems)
                            {
                                oComponentePanelMenu.Text = TraductorService.RetornaTraduccion(oComponentePanelMenu.Name);
                            }
                        }
                        oComponenteMenu.Text = TraductorService.RetornaTraduccion(oComponenteMenu.Name);
                    }
                }
                oComponente.Text = TraductorService.RetornaTraduccion(oComponente.Name);
            }
            IdiomaControl = SessionService.Session.Idioma;
        }

        public void VerificarPermisos()
        {
            foreach (ToolStripMenuItem oComponenteMenu in msMenu.Items)
            {
                if (oComponenteMenu.Tag != null)
                {
                    oComponenteMenu.Visible = SessionService.Session.TienePermiso((PermisoEnum) Enum.GetValues(typeof(PermisoEnum)).GetValue(int.Parse(oComponenteMenu.Tag.ToString()) - 1), SessionService.Session.ObtenerListaPermisos());
                }
            }
        }
    }
}
