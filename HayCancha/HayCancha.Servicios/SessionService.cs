using System;
using System.Data;
using System.Security;
using HayCancha.BE;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public class SessionService
    {
        private static Session _oInstancia;

        public static Session Session => _oInstancia ?? (_oInstancia = new Session());

        public static void CargarPermisos(Usuario oUsuario)
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

    }
}
