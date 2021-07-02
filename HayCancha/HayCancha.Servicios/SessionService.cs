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
            var oFamilia = new Familia()
            {
                Permiso = (PermisoEnum) Enum.GetValues(typeof(PermisoEnum)).GetValue((int) PermisoDAL.Instancia.ObtenerPermisoUsuario(Session.ObtenerNombreUsuario())["Id"] - 1)
            };

            Session.AgregarPermiso(oFamilia);

            ListarPermisos(oFamilia);
        }

        private static void ListarPermisos(AbstractComponent oComponente)
        {
            var oDt = PermisoDAL.Instancia.ObtenerHijos((int)oComponente.Permiso);

            foreach (var oDrHijo in oDt.AsEnumerable())
            {
                if ((bool)oDrHijo["EsRol"])
                {
                    var oComponenteHijo = new Familia() { Permiso = (PermisoEnum)Enum.GetValues(typeof(PermisoEnum)).GetValue(int.Parse(oDrHijo["Id"].ToString()) - 1) };
                    oComponente.AgregarHijo(oComponenteHijo);
                    ListarPermisos(oComponenteHijo);
                }
                else
                {
                    var oComponenteHijo = new Patente() { Permiso = (PermisoEnum)Enum.GetValues(typeof(PermisoEnum)).GetValue(int.Parse(oDrHijo["Id"].ToString()) - 1) };
                    oComponente.AgregarHijo(oComponenteHijo);
                }
            }
        }

        public void VerificarPermisos(MenuStrip oMenuStrip)
        {
            foreach (ToolStripMenuItem oComponenteMenu in oMenuStrip.Items)
            {
                if (oComponenteMenu.Tag != null)
                {
                    oComponenteMenu.Visible = Session.TienePermiso((PermisoEnum)Enum.GetValues(typeof(PermisoEnum)).GetValue(int.Parse(oComponenteMenu.Tag.ToString()) - 1), Session.ObtenerListaPermisos());
                }
            }
        }
    }
}
