using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;
using HayCancha.DAL;

namespace HayCancha.Servicios 
{
    public static class PermisoService
    {
        public static DataTable ObtenerFamilias() => PermisoDAL.Instancia.ObtenerFamilias();

        public static DataTable ObtenerPatentes() => PermisoDAL.Instancia.ObtenerPatentes();

        public static DataTable ObtenerPatentesPorNombreUsuario(string sNombre)
        {
            var oDrEncontrada = PermisoDAL.Instancia.ObtenerPermisoUsuario(sNombre);

            var Familia = new Familia()
            {
                Permiso = (int)oDrEncontrada["Id"],
                Nombre = oDrEncontrada["Nombre"].ToString()
            };

            var lstPatentes = new List<AbstractComponent>();

            ListarPermisosEnLista(Familia, lstPatentes);

            var oDt = new DataTable();

            oDt.Columns.Add("Permiso", typeof(int));
            oDt.Columns.Add("ACCESOS", typeof(string));

            lstPatentes.ForEach(x=>oDt.Rows.Add(x.Permiso, x.Nombre));

            return oDt;
        }

        private static int ObtenerIdFamiliaPorNombre(string sNombre) => PermisoDAL.Instancia.ObtenerIdFamiliaPorNombre(sNombre);

        public static void ListarPermisos(AbstractComponent oComponente)
        {
            var oDt = PermisoDAL.Instancia.ObtenerHijos(oComponente.Permiso);

            foreach (var oDrHijo in oDt.AsEnumerable())
            {
                if ((bool)oDrHijo["EsRol"])
                {
                    var oComponenteHijo = new Familia() { Permiso = int.Parse(oDrHijo["Id"].ToString()), Nombre = oDrHijo["Nombre"].ToString() };
                    oComponente.AgregarHijo(oComponenteHijo);
                    ListarPermisos(oComponenteHijo);
                }
                else
                {
                    var oComponenteHijo = new Patente() { Permiso = int.Parse(oDrHijo["Id"].ToString()), Nombre = oDrHijo["Nombre"].ToString() };
                    oComponente.AgregarHijo(oComponenteHijo);
                }
            }
        }

        private static void ListarPermisosEnLista(AbstractComponent oComponente, IList<AbstractComponent> lstPatentes)
        {
            ListarPermisos(oComponente);

            foreach (var oPatenteHijo in oComponente.lstHijos)
            {
                if (lstPatentes.Any(x => x.Permiso == oPatenteHijo.Permiso)) continue;

                if (oPatenteHijo.lstHijos != null)
                {
                    lstPatentes.Add(new Familia()
                    {
                        Nombre = oPatenteHijo.Nombre,
                        Permiso = oPatenteHijo.Permiso
                    });
                    ListarPermisosEnLista(oPatenteHijo, lstPatentes);
                }
                else
                {
                    lstPatentes.Add(new Patente()
                    {
                        Nombre = oPatenteHijo.Nombre,
                        Permiso = oPatenteHijo.Permiso
                    });
                }
            }
        }

        public static bool TienePermiso(string oPermiso, IList<AbstractComponent> lstPermisos)
        {
            foreach (var oComponente in lstPermisos)
            {
                if (oComponente.Nombre == oPermiso) return true;

                if (oComponente.lstHijos == null) continue;

                if (TienePermiso(oPermiso, oComponente.lstHijos))
                    return true;
            }
            return false;
        }

        public static int CrearFamilia(string sNombre, IList<AbstractComponent> lstPermisos) => PermisoDAL.Instancia.GuardarFamilia(sNombre, FiltrarPermisosRepetidos(lstPermisos));

        public static List<AbstractComponent> FiltrarPermisosRepetidos(IList<AbstractComponent> lstPermisos)
        {
            var lstPermisosFiltrados = new List<AbstractComponent>();

            lstPermisos.ToList().ForEach(permiso => { if (lstPermisosFiltrados.All(x => x.Nombre != permiso.Nombre)) { lstPermisosFiltrados.Add(permiso); } });

            return lstPermisosFiltrados;
        }
        
        public static void AsignarPermisoUsuario(string sNombre, int iPermiso) => PermisoDAL.Instancia.AsignarPermisoUsuario(sNombre, iPermiso, SessionService.Session.ObtenerNombreUsuario());

        public static void ActualizarFamilia(string sNombre, IList<AbstractComponent> permisosActualizados)
        {
            var oFamilia = new Familia()
            {
                Nombre = sNombre,
                Permiso = ObtenerIdFamiliaPorNombre(sNombre),
            };

            permisosActualizados.ToList().ForEach(permiso => oFamilia.AgregarHijo(permiso));

            PermisoDAL.Instancia.ActualizarFamilia(oFamilia);
        }

        public static string ObtenerNombreFamiliaPorNombreUsuario(string sUsuario) => PermisoDAL.Instancia.ObtenerNombrePermisoPorUsuario(sUsuario);
    }
}
