using System.Collections;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Interfaces
{
    public interface Idiomable
    {
        int IdiomaControl { get; set; }
        void Update();
        void ActualizarControles(IEnumerable Coleccion);
    }
}
