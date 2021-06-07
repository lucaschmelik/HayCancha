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
        public static string RetornaTraduccion(string sNombreComponente)
        {
            return IdiomaDAL.Instancia.RetornaTraduccion(sNombreComponente, (int) SessionService.Session.Idioma);
        }
    }
}
