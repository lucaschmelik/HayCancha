using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;

namespace HayCancha
{
    public partial class NotificacionUC : UserControl, IOdiomable
    {
        public NotificacionUC()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
        }

        public IdiomaEnum IdiomaControl { get; set; }

        public void Update()
        {
            TraductorBLL.Instancia.ActualizarControles(this.Controls);

            IdiomaControl = SessionService.Session.Idioma;
        }
    }
}
