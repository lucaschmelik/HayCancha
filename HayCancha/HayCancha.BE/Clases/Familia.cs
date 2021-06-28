using System.Collections.Generic;
using HayCancha.BE.Abstractas;

namespace HayCancha.BE.Clases
{
    public class Familia : AbstractComponent
    {
        public Familia()
        {
            _lstHijos = new List<AbstractComponent>();
        }
        
        private IList<AbstractComponent> _lstHijos;

        public override IList<AbstractComponent> lstHijos => _lstHijos;

        public override void AgregarHijo(AbstractComponent oComponente)
        {
            _lstHijos.Add(oComponente);
        }

        public override void VaciarHijos()
        {
            _lstHijos = new List<AbstractComponent>();
        }

    }
}
