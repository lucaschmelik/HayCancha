using HayCancha.BE.Abstractas;

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
