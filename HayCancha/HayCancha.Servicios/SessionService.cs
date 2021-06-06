using HayCancha.BE.Clases;

namespace HayCancha.Servicios
{
    public class SessionService
    {
        private static Session _oInstancia;

        public static Session Session => _oInstancia ?? (_oInstancia = new Session());
    }
}
