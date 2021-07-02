using System.Collections;
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
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }

        public IdiomaEnum IdiomaControl { get; set; }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                if (oComponente.GetType() == typeof(Panel))
                {
                    ActualizarControles(((Panel)oComponente).Controls);
                }
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text);
            }
        }

        public new void Update()
        {
            ActualizarControles(this.Controls);

            IdiomaControl = SessionService.Session.Idioma;
        }
    }
}
