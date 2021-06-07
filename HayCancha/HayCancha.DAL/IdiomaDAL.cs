using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;

namespace HayCancha.DAL
{
    public class IdiomaDAL : AbstractDAL
    {
        private static IdiomaDAL _oIdiomaDAL;
        public static IdiomaDAL Instancia => _oIdiomaDAL ?? new IdiomaDAL();

        public string RetornaTraduccion(string sNombreControl, int iIdioma)
        {
            var dicParametros = new Dictionary<string, object>()
            {
                {
                    "NombreControl", sNombreControl
                },
                {
                    "Idioma", iIdioma.ToString()
                }
            };

            var oDt = new DataTable();

            oDt.Columns.Add("Texto", typeof(string));

            var oDrEncontrado = EjecutaStp("stpObtenerTextoPorNombreIdioma", dicParametros, oDt).AsEnumerable().FirstOrDefault();

            return oDrEncontrado?["Texto"].ToString();
        }
    }
}
