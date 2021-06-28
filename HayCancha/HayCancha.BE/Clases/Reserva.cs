using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Clases
{
    public class Reserva : AbstractEntidad
    {
        public Reserva()
        {
            lstJugadores = new List<Usuario>();
            EstadoReserva = EstadoReservaEnum.Nueva;
        }

        public Usuario Gestor { get; set; }
        public Usuario Organizador { get; set; }
        public List<Usuario> lstJugadores { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Cancha Estadio { get; set; }
        public EstadoReservaEnum EstadoReserva { get; set; }
    }
}
