﻿using System;
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
                Contraseña = SessionManager.AplicarHash(sContraseña)
            };
        }

        public void Login()
        {
            _oUsuarioDAL = new UsuarioDAL()
            {
                oUsuario = _oUsuario
            };

            if (SessionManager.Session.IsLogged()) throw new Exception("Existe una sesión iniciada");

            var oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombre();

            if(oUsuarioEncontrado == null) throw new Exception("Ingreso un usuario que no existe");

            oUsuarioEncontrado = _oUsuarioDAL.ObtenerUsuarioPorNombreContraseña();

            if (oUsuarioEncontrado == null) throw new Exception("Ingreso una contraseña incorrecta");

            if (oUsuarioEncontrado.Nombre != _oUsuario.Nombre || oUsuarioEncontrado.Contraseña != _oUsuario.Contraseña) throw new Exception("Ingreso usuario incorrecto");

            SessionManager.Session.Login(_oUsuario);
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
