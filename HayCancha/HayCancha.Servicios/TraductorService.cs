using System.Collections.Generic;
using System.Data;
using HayCancha.BE.Clases;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public static class TraductorService
    {
        public static string RetornaTraduccion(string sNombreTexto) => IdiomaDAL.Instancia.RetornaTraduccion(sNombreTexto, (int) SessionService.Session.Idioma);

        public static IList<TextosTraducibles> RetornaTextosTraduciblesPorDefecto() => IdiomaDAL.Instancia.RetornaTextosTraduciblesPorDefecto();

        public static void GuardarIdioma(string sNombre, DataTable oDtTraducciones)
        {
            IdiomaDAL.Instancia.GuardarIdioma(sNombre, oDtTraducciones);
        }

        public static DataTable ObtenerIdiomas() => IdiomaDAL.Instancia.ObtenerIdiomas();

        public static int ObtenerIdIdiomaPorDescripcion(string sDescripcion) => IdiomaDAL.Instancia.ObtenerIdIdiomaPorDescripcion(sDescripcion);
    }
}
