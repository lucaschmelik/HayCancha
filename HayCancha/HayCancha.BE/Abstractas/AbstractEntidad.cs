using System;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractEntidad
    {
        protected AbstractEntidad()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}
