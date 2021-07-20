using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Abstractas;

namespace HayCancha.BE.Clases
{
    public class Idioma : AbstractEntidad
    {
        public Idioma() { }
        public Idioma(int iId, string sNombre)
        {
            Id = iId;
            Nombre = sNombre;
        }

        public string Nombre { get; set; }
    }
}
