using System.Collections.Generic;
using System.Drawing;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;

namespace HayCancha.BE.Clases
{
    public class Session : AbstractObserver
    {
        private Usuario _oUsuario;

        private int _Idioma = (int)IdiomaEnum.Español;

        public int Idioma
        {
            get => _Idioma;
            set
            {
                _Idioma = value;
                Notificar();
            }
        }

        public Usuario UsuarioLogueado { get => _oUsuario; }

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

        public void AgregarPermiso(AbstractComponent oComponente)
        {
            _oUsuario.lstPermisos.Add(oComponente);
        }

        public void AgregarImagenPerfil(Image imgPerfil)
        {
            _oUsuario.Imagen = imgPerfil;
        }

        public bool TienePermiso(int oPermiso, IList<AbstractComponent> lstPermisos)
        {
            foreach (var oComponente in lstPermisos)
            {
                if (oComponente.Permiso == oPermiso) return true;

                if (oComponente.lstHijos == null) continue;

                if (TienePermiso(oPermiso, oComponente.lstHijos))
                    return true;
            }

            return false;
        }

        public string ObtenerNombreUsuario()
        {
            return _oUsuario.Nombre;
        }

        public string ObtenerContraseñaUsuario()
        {
            return _oUsuario.Contraseña;
        }

        public List<AbstractComponent> ObtenerListaPermisos()
        {
            return _oUsuario.lstPermisos;
        }

        public Image ObtenerImagenPerfil()
        {
            return _oUsuario.Imagen;
        }
    }
}
