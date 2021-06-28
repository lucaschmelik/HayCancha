using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Clases;

namespace HayCancha.DAL
{
    public class CanchaDAL : AbstractDAL
    {
        private static CanchaDAL _oInstanciaDAL;
        public static CanchaDAL Instancia => _oInstanciaDAL ?? new CanchaDAL();

        public IList<Cancha> RetornaCanchasPorTipoFecha(DateTime dtFecha, int iTipoCancha)
        {
            var dicParametros = new Dictionary<string, object>()
            {
                {
                    "Fecha", dtFecha
                },
                {
                    "TipoCancha", iTipoCancha
                }
            };

            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Hora", typeof(DateTime));

            var oDrEncontrado = EjecutaStp("stpObtenerCanchaPorFechaTipoCancha", dicParametros, oDt).AsEnumerable().FirstOrDefault();

            oDrEncontrado?["Texto"].ToString();

            return null;
        }
    }
}
