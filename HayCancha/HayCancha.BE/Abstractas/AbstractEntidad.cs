using System;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractEntidad
    {
        protected AbstractEntidad()
        {
            Id = 0;
        }

        public int Id { get; set; }
    }
}
