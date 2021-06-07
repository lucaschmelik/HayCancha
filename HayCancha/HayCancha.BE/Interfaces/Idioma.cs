using System.Collections.Generic;

namespace HayCancha.BE.Interfaces
{
    public abstract class Idioma
    {
        List<IOdiomable> _lstControles = new List<IOdiomable>();

        public void Suscribir(IOdiomable oComponente)
        {
            _lstControles.Add(oComponente);
        }

        public void Desuscribir(IOdiomable oComponente)
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
