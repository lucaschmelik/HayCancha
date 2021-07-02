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

        public string RetornaTraduccion(string sNombreTexto, int iIdioma)
        {
            var dicParametros = new Dictionary<string, object>()
            {
                {
                    "Texto", sNombreTexto
                },
                {
                    "Idioma", iIdioma.ToString()
                }
            };

            var oDt = new DataTable();

            oDt.Columns.Add("Traduccion", typeof(string));

            var oDrEncontrado = EjecutaStp("stpObtenerTraduccionPorTextoIdioma", dicParametros, oDt).AsEnumerable().FirstOrDefault();

            return oDrEncontrado?["Traduccion"].ToString();
        }
    }
}
