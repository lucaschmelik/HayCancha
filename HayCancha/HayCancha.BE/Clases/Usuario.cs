using HayCancha.BE.Abstractas;

namespace HayCancha.BE
{
    public class Usuario : AbstractEntidad
    {
        public Usuario(): base("Usuario") { }
        
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

    }
}
