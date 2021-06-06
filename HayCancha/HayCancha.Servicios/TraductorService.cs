using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public class TraductorService
    {
        private static IdiomaDAL _oUsuarioDal = new IdiomaDAL();
        public static string RetornaTraduccion(string sNombreComponente)
        {
            return _oUsuarioDal.RetornaTraduccion(sNombreComponente, (int) SessionService.Session.Idioma);
        }
    }
}
