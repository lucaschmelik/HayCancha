using System.Collections;
using System.Windows.Forms;
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
            dgvBitacora.DataSource = BitacoraService.ListarBitacoras();
        }
    }
}
