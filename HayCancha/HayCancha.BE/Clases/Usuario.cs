using System.Collections.Generic;
using HayCancha.BE.Abstractas;

namespace HayCancha.BE
{
    public class Usuario : AbstractEntidad
    {
        public Usuario() : base("Usuario")
        {
            lstPermisos = new List<AbstractComponent>();
        }
        
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public List<AbstractComponent> lstPermisos { get; }
    }
}
