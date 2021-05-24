using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class Menu : Form
    {
        public Menu(Login frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        private UsuarioBLL _oUsuarioBLL;
        private Login _frmLogin;

        private int iMov;
        private int iMovX;
        private int iMovY;
        
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            iMov = 1;
            iMovX = e.X;
            iMovY = e.Y;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (iMov == 1) SetDesktopLocation(MousePosition.X - iMovX, MousePosition.Y - iMovY);
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            iMov = 0;
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            SessionManager.Session.Logout();
            Close();
            _frmLogin.Show();
        }
    }
}
