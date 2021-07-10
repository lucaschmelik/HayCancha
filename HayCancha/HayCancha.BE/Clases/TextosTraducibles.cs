using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Interfaces;

namespace HayCancha.BE.Clases
{
    public class TextosTraducibles : AbstractEntidad
    {
        public TextosTraducibles(int iId, string sDescripcion, Idioma oIdioma)
        {
            Id = iId;
            Descripcion = sDescripcion;
            Idioma = oIdioma;
        }

        public string Descripcion { get; set; }
        public Idioma Idioma { get; set; }
    }
}
