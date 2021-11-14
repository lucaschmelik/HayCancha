﻿using System;
using System.Collections;
using System.Windows.Forms;
using HayCancha.BE;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class LoginUI : Form, Idiomable
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private MenuUI _frmMenu;

        private int _iMov;
        private int _iMovX;
        private int _iMovY;

        public int IdiomaControl { get; set; }

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

                UsuarioBLL.CargarUsuario(txtUsuario.Text, txtContraseña.Text);

                UsuarioBLL.Login();

                BitacoraService.Escribir(TipoEventoBitacoraEnum.INFORMACION, "Logeo en el sistema");

                this.Hide();

                _frmMenu = new MenuUI(this);

                _frmMenu.Show();

            }
            catch (Exception ex)
            {
                BitacoraService.Escribir(TipoEventoBitacoraEnum.ERROR, ex.Message);
                SessionService.Session.Logout();
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarNombreContraseña();

                //VER SI ESTO FUNCIONA PORQUE VA A BUSCAR EL ROL Y QUIZÁS NECESITE QUE EL USUARIO PASADO POR PARAMETRO SEA REAL
                EncriptadorService.CorroborarDigitosVerificadores(new Usuario());

                UsuarioBLL.CargarUsuario(txtUsuario.Text, txtContraseña.Text);

                UsuarioBLL.RegistrarUsuario();

                EncriptadorService.RecalcularDigitosVerificadores();

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
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Español) 
                SessionService.Session.Idioma = (int)IdiomaEnum.Español;
        }

        private void imgIdiomaIngles_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Ingles) 
                SessionService.Session.Idioma = (int)IdiomaEnum.Ingles;
        }

        private void imgIdiomaChino_Click(object sender, EventArgs e)
        {
            if (SessionService.Session.Idioma != (int)IdiomaEnum.Chino)
                SessionService.Session.Idioma = (int)IdiomaEnum.Chino;
        }

        public new void Update()
        {
            ActualizarControles(this.Controls);
            IdiomaControl = SessionService.Session.Idioma;
        }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                if (oComponente.GetType() == typeof(Panel))
                {
                    ActualizarControles(((Panel)oComponente).Controls);
                }

                ((Control) oComponente).Text = TraductorService.RetornaTraduccion(((Control) oComponente).Text);
            }
        }
    }
}
