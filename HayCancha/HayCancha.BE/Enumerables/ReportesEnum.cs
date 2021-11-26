using System.ComponentModel;

namespace HayCancha.BE.Enumerables
{
    public class ReportesEnum
    {
        public enum ReportesJugadoresEnum
        {
            Jugadores_Ordenados_Por_Cantidad_De_Reservas_Totales = 1,
            Jugadores_Ordenados_Por_Cantidad_De_Partidos_Rechazados = 2,
            Jugadores_Ordenados_Por_Cantidad_De_Partidos_No_Respondidos = 3,
            Jugadores_Ordenados_Por_Cantidad_De_Partidos_Finalizados = 4
        }

        public enum ReportesCanchasEnum
        {
            Canchas_Ordenadas_Por_Cantidad_De_Reservas_Totales = 1,
            Canchas_Ordenadas_Por_Cantidad_De_Reservas_Turno_Mañana = 2,
            Canchas_Ordenadas_Por_Cantidad_De_Reservas_Turno_Tarde = 3,
            Canchas_Ordenadas_Por_Cantidad_De_Reservas_Turno_Noche = 4
        }
    }
}
