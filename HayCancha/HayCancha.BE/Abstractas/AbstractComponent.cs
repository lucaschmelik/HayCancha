using System.Collections.Generic;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractComponent
    {
        public string Nombre { get; set; }

        public int Permiso { get; set; }

        public abstract IList<AbstractComponent> lstHijos { get; set; }

        public abstract void AgregarHijo(AbstractComponent oComponente);

        public abstract void VaciarHijos();
    }
}
