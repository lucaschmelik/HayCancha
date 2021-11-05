using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using HayCancha.BE;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;


namespace HayCancha.Servicios
{
    public static class EncriptadorService
    {
        private static UsuarioDAL _oUsuarioDAL = new UsuarioDAL()
        {
            oUsuario = SessionService.Session.UsuarioLogueado
        };

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

        public static void CorroborarDigitosVerificadores(Usuario oUsuario)
        {
            _oUsuarioDAL.oUsuario = oUsuario;

            if (_oUsuarioDAL.ObtenerRol() != (int) PermisoEnum.Administrador) VerficarHashHorizontal(oUsuario);

            VerificarHashVerticalUsuario();
        }

        public static void RecalcularDigitosVerificadores()
        {
            _oUsuarioDAL.ObtenerTodosLosUsuarios().ToList().ForEach(RecalcularHashHorizontalUsuario);

            RecalcularHashTablaUsuario();
        }

        private static void VerificarHashVerticalUsuario()
        {
            var hashtabla = string.Empty;

            foreach (DataRow hash in _oUsuarioDAL.ObtenerTodosLosHashUsuario().Rows)
            {
                hashtabla += AplicarHash(hash["PreHash"].ToString());
            }

            if (AplicarHash(hashtabla) == _oUsuarioDAL.ObtenerHashPorTablaUsuario()) return;

            if (_oUsuarioDAL.ObtenerRol() != (int)PermisoEnum.Administrador) throw new Exception("La tabla usuarios fue alterada, por favor realice una restore de la base de datos.");

            throw new Exception("La base de datos fue alterada, por favor comuniquese con el administrador.");
        }

        private static void VerficarHashHorizontal(Usuario oUsuario)
        {
            var HashNuevo = AplicarHash(oUsuario.Nombre + oUsuario.Contraseña + _oUsuarioDAL.ObtenerRol());

            if (_oUsuarioDAL.ObtenerUsuarioPorHash(HashNuevo) == null) throw new Exception($"El usuario {oUsuario.Nombre} fue alterado en la base de datos, por favor comuniquese con el administrador.");
        }

        private static void RecalcularHashHorizontalUsuario(Usuario oUsuario)
        {
            var HashNuevo = AplicarHash(oUsuario.Nombre + oUsuario.Contraseña + oUsuario.lstPermisos[0].Permiso);

            _oUsuarioDAL.ModificarHashUsuario(oUsuario.Nombre, HashNuevo);
        }

        private static void RecalcularHashTablaUsuario()
        {
            var hashtabla = string.Empty;

            foreach (DataRow hash in _oUsuarioDAL.ObtenerTodosLosHashUsuario().Rows)
            {
                hashtabla += AplicarHash(hash["PreHash"].ToString());
            }

            _oUsuarioDAL.ModificarTablaUsuarioDigitoVerificadorVertical(AplicarHash(hashtabla));
        }
    }
}
