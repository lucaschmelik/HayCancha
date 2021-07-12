using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class CanchaDAL : AbstractDAL
    {
        private static CanchaDAL _oInstanciaDAL;
        public static CanchaDAL Instancia => _oInstanciaDAL ?? new CanchaDAL();

        private DataTable RetornaDataTableCancha()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("TipoCancha", typeof(int));

            return oDt;
        }

        public DataTable ObtenerCanchas() => EjecutaStp("stpObtenerCanchas", new Dictionary<string, object>() { }, RetornaDataTableCancha());

        public DataTable ObtenerCanchasOcupadas(DateTime dtSeleccionado, TipoCanchaEnum enumTipoCancha) => EjecutaStp("stpObtenerCanchasOcupadas", new Dictionary<string, object>(){{ "FechaInicio", dtSeleccionado }, { "TipoCancha", (int) enumTipoCancha } }, RetornaDataTableCancha());
    }
}
