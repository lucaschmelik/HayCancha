using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public static class TraductorService
    {
        public static string RetornaTraduccion(string sNombreTexto) => IdiomaDAL.Instancia.RetornaTraduccion(sNombreTexto, (int) SessionService.Session.Idioma);
    }
}
