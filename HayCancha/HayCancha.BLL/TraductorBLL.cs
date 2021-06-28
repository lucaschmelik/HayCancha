using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HayCancha.Servicios;

namespace HayCancha.BLL
{
    public class TraductorBLL
    {
        private static TraductorBLL _oTraductorBLL;
        public static TraductorBLL Instancia => _oTraductorBLL ?? new TraductorBLL();

        public void ActualizarControles(Control.ControlCollection lstControles)
        {
            foreach (Control oComponente in lstControles)
            {
                if (oComponente.GetType() == typeof(MenuStrip))
                {
                    foreach (ToolStripMenuItem oComponenteMenu in (oComponente as MenuStrip)?.Items)
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
                else if(oComponente.GetType() == typeof(Panel))
                {
                    foreach (Control oComponentePanel in oComponente.Controls)
                    {
                        if (oComponentePanel.Controls != null)
                        {
                            ActualizarControles(oComponentePanel.Controls);
                        }
                        oComponentePanel.Text = TraductorService.RetornaTraduccion(oComponentePanel.Name)?? oComponentePanel.Text;
                    }
                }
                oComponente.Text = TraductorService.RetornaTraduccion(oComponente.Name);
            }
        }
    }
}
