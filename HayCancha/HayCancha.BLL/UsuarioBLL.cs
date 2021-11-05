using System;
using System.Collections.Generic;
using System.Data;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;
using HayCancha.Servicios;

namespace HayCancha.BLL
{
    public static class UsuarioBLL
    {
        private static Usuario _oUsuario;
        private static UsuarioDAL _oUsuarioDAL;
        
        public static void CargarUsuario(string sNombre, string sContraseña)
        {
            _oUsuario = new Usuario
            {
                Nombre = sNombre,
                Contraseña = EncriptadorService.AplicarHash(sContraseña)
            };

            _oUsuarioDAL = new UsuarioDAL()
            {
                oUsuario = _oUsuario
            };
        }

        public static void Login()
        {
            if (SessionService.Session.IsLogged()) throw new Exception("Existe una sesión iniciada");

            var oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombre();

            if(oUsuarioEncontrado == null) throw new Exception("Ingreso un usuario que no existe");

            oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombreContraseña();

            if (oUsuarioEncontrado == null) throw new Exception("Ingreso una contraseña incorrecta");

            if (oUsuarioEncontrado.Nombre != _oUsuario.Nombre || oUsuarioEncontrado.Contraseña != _oUsuario.Contraseña) throw new Exception("Ingreso usuario incorrecto");

            _oUsuario = oUsuarioEncontrado;

            EncriptadorService.CorroborarDigitosVerificadores(_oUsuario);

            SessionService.Session.Login(_oUsuario);

            SessionService.Session.AgregarImagenPerfil(ConversorImagenService.ConvetirByteAImagen(_oUsuarioDAL.ObtenerImagenPerfil()));

            SessionService.Instancia.CargarPermisos(_oUsuario);
        }

        public static void RegistrarUsuario()
        {
            _oUsuarioDAL = new UsuarioDAL()
            {
                oUsuario = _oUsuario
            };

            if(_oUsuarioDAL.ObtenerUsuarioPorNombre() != null) throw new Exception("El usuario ingresado ya existe");

            _oUsuarioDAL.RegistrarUsuario(PermisoEnum.Jugador, _oUsuarioDAL.ObtenerImagenDefault());
        }

        public static void CambiarImagenPerfil(byte[] btPerfil)
        {
            _oUsuarioDAL.GuardarImagenPerfil(btPerfil);
        }

        public static IList<Usuario> ObtenerUsuariosNoAdmin() => _oUsuarioDAL.ObtenerUsuariosNoAdmin();

        public static IList<Usuario> ObtenerUsuariosPorNombre(string sNombre) => _oUsuarioDAL.ObtenerUsuariosPorNombre(sNombre);

        public static Usuario ObtenerUsuarioPorNombre (string sNombre) => _oUsuarioDAL.ObtenerUsuarioPorNombre();

        public static DataTable ObtenerUsuariosAuditoriaPorNombre(string sNombre) => _oUsuarioDAL.ObtenerUsuariosAuditoriaPorNombre(sNombre);

        public static void CambiarContraseña(string sNombre, string sContraseña) => _oUsuarioDAL.CambiarContraseña(sNombre, sContraseña, SessionService.Session.UsuarioLogueado.Nombre);

        public static void RestaurarUsuario(int iIdUsuarioAuditoria) => _oUsuarioDAL.RestaurarUsuario(iIdUsuarioAuditoria, SessionService.Session.UsuarioLogueado.Nombre);
    }
}
