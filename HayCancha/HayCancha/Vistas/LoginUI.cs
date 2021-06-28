using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class LoginUI : Form, IOdiomable
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private UsuarioBLL _oUsuarioBLL;
        private MenuUI _frmMenu;

        private int _iMov;
        private int _iMovX;
        private int _iMovY;

        public IdiomaEnum IdiomaControl { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {
            SessionService.Session.Suscribir(this);
            this.CenterToScreen();
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _iMov = 0;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _iMov = 1;
            _iMovX = e.X;
            _iMovY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_iMov == 1 ) SetDesktopLocation(MousePosition.X - _iMovX, MousePosition.Y - _iMovY);
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarNombreContraseña();

                _oUsuarioBLL = new UsuarioBLL(txtUsuario.Text, txtContraseña.Text);

                _oUsuarioBLL.Login();

                this.Hide();

                _frmMenu = new MenuUI(this);

                _frmMenu.Show();

            }
            catch (Exception ex)
            {
                SessionService.Session.Logout();
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarNombreContraseña();

                _oUsuarioBLL = new UsuarioBLL(txtUsuario.Text, txtContraseña.Text);

                _oUsuarioBLL.RegistrarUsuario();

                MessageBox.Show("El usuario se registro correctamente");

                btnIngresar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ValidarNombreContraseña()
        {
            if(txtUsuario.Text == string.Empty) throw new Exception("Debe ingresar un nombre de usuario!");
            if (txtContraseña.Text == string.Empty) throw new Exception("Debe ingresar una contraseña!");

        }

        private void imgIdiomaEspañol_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != IdiomaEnum.Español) 
                SessionService.Session.Idioma = IdiomaEnum.Español;
        }

        private void imgIdiomaIngles_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != IdiomaEnum.Ingles) 
                SessionService.Session.Idioma = IdiomaEnum.Ingles;
        }

        private void imgIdiomaChino_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != IdiomaEnum.Chino)
                SessionService.Session.Idioma = IdiomaEnum.Chino;
        }

        public void Update()
        {
            TraductorBLL.Instancia.ActualizarControles(this.Controls);

            IdiomaControl = SessionService.Session.Idioma;
        }
    }
}
