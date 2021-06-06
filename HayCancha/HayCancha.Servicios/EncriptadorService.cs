using System.Security.Cryptography;
using System.Text;


namespace HayCancha.Servicios
{
    public class EncriptadorService
    {
        public static string AplicarHash(string sContraseña)//MD5 es el algoritmo implementado
        {
            var md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(sContraseña));
            var result = md5.Hash;
            var str = new StringBuilder();
            for (var i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            var ContraseñaHash = str.ToString();

            return ContraseñaHash;
        }
    }
}
