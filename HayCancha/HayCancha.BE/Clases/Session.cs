using System.Collections.Generic;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;

namespace HayCancha.BE.Clases
{
    public class Session : Idioma
    {
        private Usuario _oUsuario;

        private IdiomaEnum _Idioma = IdiomaEnum.Español;

        public IdiomaEnum Idioma
        {
            get => _Idioma;
            set
            {
                _Idioma = value;
                Notificar();
            }
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

        public void AgregarPermiso(AbstractComponent oComponente)
        {
            _oUsuario.lstPermisos.Add(oComponente);
        }

        public bool TienePermiso(PermisoEnum oPermiso, IList<AbstractComponent> lstPermisos)
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

        public List<AbstractComponent> ObtenerListaPermisos()
        {
            return _oUsuario.lstPermisos;
        }
    }
}
