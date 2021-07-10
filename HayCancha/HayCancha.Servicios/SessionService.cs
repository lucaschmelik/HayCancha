using System;
using System.Data;
using System.Windows.Forms;
using HayCancha.BE;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public class SessionService
    {
        //TODO => Arreglar el Singleton de Session y SessionManager debería ser statico, podría llamarse LoginService quizás o PermisoServices.
        private static Session _oSession;
        public static Session Session => _oSession ?? (_oSession = new Session());

        private static SessionService _oInstancia;
        public static SessionService Instancia => _oInstancia ?? (_oInstancia = new SessionService());

        public void CargarPermisos(Usuario oUsuario)
        {
            var oDrEncontrada = PermisoDAL.Instancia.ObtenerPermisoUsuario(Session.ObtenerNombreUsuario());

            var oFamilia = new Familia()
            {
                Permiso = (int)oDrEncontrada["Id"],
                Nombre = oDrEncontrada["Nombre"].ToString()
            };

            Session.AgregarPermiso(oFamilia);

            PermisoService.ListarPermisos(oFamilia);
        }

        public void VerificarPermisos(Control oMenuStrip)
        {
            foreach (ToolStripMenuItem oComponenteMenu in ((MenuStrip)oMenuStrip).Items)
            {
                if (oComponenteMenu.Tag != null)
                {
                    oComponenteMenu.Visible = Session.TienePermiso(int.Parse(oComponenteMenu.Tag.ToString()), Session.ObtenerListaPermisos());
                }
            }
        }
    }
}
