using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
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
                Contraseña = sContraseña
            };
        }

        public void Login()
        {
            _oUsuarioDAL = new UsuarioDAL();

            if (SessionManager.Session.IsLogged()) throw new Exception("Existe una sesión iniciada");

            if (_oUsuarioDAL.GetOne().Nombre != _oUsuario.Nombre) throw new Exception("Ingreso un usuario incorrecto");

            if (_oUsuarioDAL.GetOne().Contraseña != _oUsuario.Contraseña) throw new Exception("Ingreso la contraseña incorrecta");

            SessionManager.Session.Login(_oUsuario);
        }

    }
}
