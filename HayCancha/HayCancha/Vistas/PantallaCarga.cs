using System;
using System.Drawing;
using System.Windows.Forms;

namespace HayCancha.Vistas
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            picCargando.Image = Image.FromFile($"{Environment.CurrentDirectory}\\cargando.gif");
            picCargando.Load($"{Environment.CurrentDirectory}\\cargando.gif");
            picCargando.Location = new Point(Width/2 - picCargando.Width/2, Height / 2 - picCargando.Height / 2);
        }
    }
}
