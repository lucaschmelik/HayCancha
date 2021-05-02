using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayCancha.Servicios
{
    public class SessionManager
    {
        private static Session _oInstancia;

        public static Session Session
        {
            get
            {
                if (_oInstancia == null) _oInstancia = new Session();

                return _oInstancia;
            }
        }
    }
}
