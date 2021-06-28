using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayCancha.Servicios
{
    public class VistaService
    {
        private static VistaService _oInstancia;
        public static VistaService Instancia => _oInstancia ?? (_oInstancia = new VistaService());

        public void AbrirFormEnPanel(Control oPanel, object oFormhijo)
        {
            if (oPanel.Controls.Count > 0)
                oPanel.Controls.RemoveAt(0);
            var fmHijo = oFormhijo as Form;
            fmHijo.TopLevel = false;
            fmHijo.Dock = DockStyle.Fill;
            oPanel.Controls.Add(fmHijo);
            fmHijo.Show();
        }
    }
}
