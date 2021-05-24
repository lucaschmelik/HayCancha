using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static string AplicarHash(string sContraseña)//MD5 es el algoritmo implementado
        {
            var md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(sContraseña));
            var result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            string ContraseñaHash = str.ToString();

            return ContraseñaHash;
        }
    }
}
