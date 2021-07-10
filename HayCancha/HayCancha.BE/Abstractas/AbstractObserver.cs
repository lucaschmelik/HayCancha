using System.Collections.Generic;

namespace HayCancha.BE.Interfaces
{
    public abstract class AbstractObserver
    {
        List<Idiomable> _lstControles = new List<Idiomable>();

        public void Suscribir(Idiomable oComponente)
        {
            _lstControles.Add(oComponente);
        }

        public void Desuscribir(Idiomable oComponente)
        {
            _lstControles.Remove(oComponente);
        }

        public void Notificar()
        {
            foreach (var oComponente in _lstControles)
            {
                oComponente.Update();   
            }
        }
    }
}
