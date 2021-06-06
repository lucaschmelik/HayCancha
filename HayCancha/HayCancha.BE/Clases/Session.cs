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
    }
}
