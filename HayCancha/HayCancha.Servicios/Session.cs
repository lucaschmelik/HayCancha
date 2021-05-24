using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using HayCancha.BE;

namespace HayCancha.Servicios
{
    public class Session
    {
        private Usuario _oUsuario;

        public Usuario Usuario
        {
            get { return _oUsuario; }
        }

        public void Login(Usuario oUsuario)
        {
            _oUsuario = oUsuario;
        }

        public void Logout()
        {
            _oUsuario = null;
        }

        public bool IsLogged()
        {
            return _oUsuario != null;
        }
    }
}
