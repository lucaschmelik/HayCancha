using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayCancha.BLL
{
    public class AlquilerBLL
    {
        private static AlquilerBLL _oInstanciaBLL;
        public static AlquilerBLL Instancia => _oInstanciaBLL ?? new AlquilerBLL();


    }
}
