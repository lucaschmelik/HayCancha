using HayCancha.BE.Abstractas;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Clases
{
    public class Cancha : AbstractEntidad
    {
        public string Nombre { get; set; }
        public TipoCanchaEnum TipoCancha { get; set; }

    }
}
