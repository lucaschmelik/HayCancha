using System;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.DAL;
using HayCancha.Servicios;

namespace HayCancha.BLL
{
    public class UsuarioBLL
    {
        private Usuario _oUsuario;
        private UsuarioDAL _oUsuarioDAL;

        public UsuarioBLL(string sNombre, string sContraseña)
        {
            _oUsuario = new Usuario
            {
                Nombre = sNombre,
                Contraseña = EncriptadorService.AplicarHash(sContraseña)
            };
        }

        public void Login()
        {
            _oUsuarioDAL = new UsuarioDAL()
            {
                oUsuario = _oUsuario
            };

            if (SessionService.Session.IsLogged()) throw new Exception("Existe una sesión iniciada");

            var oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombre();

            if(oUsuarioEncontrado == null) throw new Exception("Ingreso un usuario que no existe");

            oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombreContraseña();

            if (oUsuarioEncontrado == null) throw new Exception("Ingreso una contraseña incorrecta");

            if (oUsuarioEncontrado.Nombre != _oUsuario.Nombre || oUsuarioEncontrado.Contraseña != _oUsuario.Contraseña) throw new Exception("Ingreso usuario incorrecto");

            SessionService.Session.Login(_oUsuario);

            SessionService.CargarPermisos(_oUsuario);
        }

        public void RegistrarUsuario()
        {
            _oUsuarioDAL = new UsuarioDAL()
            {
                oUsuario = _oUsuario
            };
            
            if(_oUsuarioDAL.ObtenerUsuarioPorNombre() != null) throw new Exception("El usuario ingresado ya existe");

            _oUsuarioDAL.RegistrarUsuario();
        }

    }
}
