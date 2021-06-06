using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Interfaces
{
    public abstract class Idioma
    {
        List<IOdiomable> _lstComponentes = new List<IOdiomable>();

        public void Suscribir(IOdiomable oComponente)
        {
            _lstComponentes.Add(oComponente);
        }

        public void Desuscribir(IOdiomable oComponente)
        {
            _lstComponentes.Remove(oComponente);
        }

        public void Notificar()
        {
            foreach (var oComponente in _lstComponentes)
            {
                oComponente.Update();   
            }
        }
    }
}
