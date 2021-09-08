using System.Collections.Generic;
using HayCancha.BE.Abstractas;

namespace HayCancha.BE.Clases
{
    public class Patente : AbstractComponent
    {
        private readonly IList<AbstractComponent> _lstHijos;

        public override IList<AbstractComponent> lstHijos
        {
            get => _lstHijos;
            set => throw new System.NotImplementedException();
        }

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
