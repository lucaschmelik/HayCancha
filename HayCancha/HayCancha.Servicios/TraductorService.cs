using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE.Clases;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public static class TraductorService
    {
        public static string RetornaTraduccion(string sNombreTexto) => IdiomaDAL.Instancia.RetornaTraduccion(sNombreTexto, (int) SessionService.Session.Idioma);

        public static IList<TextosTraducibles> ObtenerTextosTraduciblesPorDefecto() => IdiomaDAL.Instancia.ObtenerTextosTraduciblesPorDefecto();

        public static void GuardarIdioma(string sNombre, DataTable oDtTraducciones)
        {
            foreach (var texto in oDtTraducciones.AsEnumerable())
            {
                if (texto["Traduccion"].ToString() == string.Empty) texto["Traduccion"] = texto["Descripcion"];
            }

            IdiomaDAL.Instancia.GuardarIdioma(sNombre, oDtTraducciones);
        }

        public static DataTable ObtenerIdiomas() => IdiomaDAL.Instancia.ObtenerIdiomas();

        public static int ObtenerIdIdiomaPorDescripcion(string sDescripcion) => IdiomaDAL.Instancia.ObtenerIdIdiomaPorDescripcion(sDescripcion);

        public static DataTable ObtenerTraduccionesPorIdioma(int iId) => IdiomaDAL.Instancia.ObtenerTraduccionesPorIdioma(iId);

        public static void ActualizarIdioma(int iIdioma, DataTable oDtTraducciones)
        {
            foreach (var oDrTraduccion in oDtTraducciones.AsEnumerable())
            {
                IdiomaDAL.Instancia.ActualizarTraduccion(iIdioma, int.Parse(oDrTraduccion["Id"].ToString()), oDrTraduccion["Traduccion"].ToString());
            }
        }
    }
}
