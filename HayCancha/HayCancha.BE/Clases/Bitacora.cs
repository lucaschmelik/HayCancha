using System;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Clases
{
    public class Bitacora
    {
        public Bitacora() { }
        public Bitacora(DateTime fecha, TipoEventoBitacoraEnum tipoEvento, string mensaje, string nombreUsuario)
        {
            Fecha = fecha;
            TipoEvento = tipoEvento;
            Mensaje = mensaje;
            NombreUsuario = nombreUsuario;
        }

        public DateTime Fecha { get; set; }
        public TipoEventoBitacoraEnum TipoEvento { get; set; }
        public string Mensaje { get; set; }
        public string NombreUsuario { get; set; }
    }
}
