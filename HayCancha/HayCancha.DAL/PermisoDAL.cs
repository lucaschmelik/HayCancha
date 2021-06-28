using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE;

namespace HayCancha.DAL
{
    public class PermisoDAL : AbstractDAL
    {
        private static PermisoDAL _oPermisoDAL;
        public static PermisoDAL Instancia => _oPermisoDAL ?? new PermisoDAL();

        public DataRow ObtenerPermisoUsuario(string sNombre)
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));

            var oDicParametros = new Dictionary<string, object>
            {
                {"Usuario", sNombre}
            };

            return EjecutaStp("stpObtenerPermisoUsuario", oDicParametros, oDt).AsEnumerable().FirstOrDefault();
        }

        public DataTable ObtenerHijos(int iId)
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(string));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("EsRol", typeof(bool));


            var oDicParametros = new Dictionary<string, object>
            {
                {"IdPadre", iId}
            };

            return EjecutaStp("stpObtenerHijosPermiso", oDicParametros, oDt);

        }
    }
}
