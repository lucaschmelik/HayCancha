using System.Collections.Generic;
using HayCancha.BE.Abstractas;

namespace HayCancha.BE.Clases
{
    public class Patente : AbstractComponent
    {
        public override IList<AbstractComponent> lstHijos { get; }

        public override void AgregarHijo(AbstractComponent oComponente)
        {
            throw new System.NotImplementedException();
        }

        public override void VaciarHijos()
        {
            throw new System.NotImplementedException();
        }
    }
}
