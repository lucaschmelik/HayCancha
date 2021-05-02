using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BE;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private UsuarioBLL _oUsuarioBLL;
        private Menu _oForm;

        private int iMov;
        private int iMovX;
        private int iMovY;

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            _oForm = new Menu();
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            iMov = 0;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            iMov = 1;
            iMovX = e.X;
            iMovY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (iMov == 1 ) SetDesktopLocation(MousePosition.X - iMovX, MousePosition.Y - iMovY);
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _oUsuarioBLL = new UsuarioBLL(txtUsuario.Text, txtContraseña.Text);

                _oUsuarioBLL.Login();

                this.Hide();

                _oForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
