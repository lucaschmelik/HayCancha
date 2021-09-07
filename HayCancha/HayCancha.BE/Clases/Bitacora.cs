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
            Evento = tipoEvento;
            Mensaje = mensaje;
            Usuario = nombreUsuario;
        }

        public DateTime Fecha { get; set; }
        public TipoEventoBitacoraEnum Evento { get; set; }
        public string Mensaje { get; set; }
        public string Usuario { get; set; }
    }
}
