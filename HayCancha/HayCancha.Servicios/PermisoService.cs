using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static DataTable ObtenerPatentesPorFamilia(Familia oFamilia)
        {
            var lstPatentes = new List<AbstractComponent>();

            ListarPermisosEnLista(oFamilia, lstPatentes);

            var oDt = new DataTable();

            oDt.Columns.Add("Permiso", typeof(int));
            oDt.Columns.Add("PATENTES", typeof(string));

            lstPatentes.Where(x => x.GetType() == typeof(Patente)).ToList().ForEach(x => oDt.Rows.Add(x.Permiso, x.Nombre));

            return oDt;
        }

        public static int CrearFamilia(string sNombre, DataTable oDtPermisos) => PermisoDAL.Instancia.GuardarFamilia(sNombre, oDtPermisos);

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

        public static void AsignarPermisoUsuario(string sNombre, int iPermiso) => PermisoDAL.Instancia.AsignarPermisoUsuario(sNombre, iPermiso);

        public static void ActualizarFamilia(string sNombreUsuario, DataTable oDtPermisos)
        {
            var iIdPermisoNuevo = CrearFamilia(PermisoDAL.Instancia.ObtenerPermisoUsuario(sNombreUsuario)["Nombre"].ToString(), oDtPermisos);

            PermisoDAL.Instancia.ActualizarFamilia(int.Parse(PermisoDAL.Instancia.ObtenerPermisoUsuario(sNombreUsuario)["Id"].ToString()), iIdPermisoNuevo);
        }
    }
}
