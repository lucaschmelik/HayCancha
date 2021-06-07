using System;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractEntidad
    {
        public AbstractEntidad(string sTabla)
        {
            Id = new Guid();
            Tabla = sTabla;
        }

        public Guid Id { get; }
        public string Tabla { get; }
    }
}
