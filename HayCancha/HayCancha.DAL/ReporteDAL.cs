using System;
using System.Collections.Generic;
using System.Data;
using HayCancha.BE;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class ReporteDAL : AbstractDAL
    {
        private static ReporteDAL _oInstanciaDAL;
        public static ReporteDAL Instancia => _oInstanciaDAL ?? new ReporteDAL();

        public DataTable ObtenerReporteJugadoresEnum(Enum reportesJugadoresEnum, DateTime fechaDesde, DateTime fechaHasta) => 
            EjecutaStp($"stpReporte{reportesJugadoresEnum.ToString().Replace("_", "")}",
                reportesJugadoresEnum.GetType() == typeof(ReportesEnum.ReportesJugadoresEnum) ? new Dictionary<string, object> {{"FechaDesde", fechaDesde}, {"FechaHasta", fechaHasta}} : new Dictionary<string, object>(), 
                reportesJugadoresEnum.GetType() == typeof(ReportesEnum.ReportesJugadoresEnum) ? retornaDataTableReporteJugadores() : retornaDataTableReporteCanchas());

        private DataTable retornaDataTableReporteJugadores()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Posicion", typeof(int));
            oDt.Columns.Add("Jugador", typeof(string));
            oDt.Columns.Add("Cantidad de Reservas", typeof(int));
            return oDt;
        }

        private DataTable retornaDataTableReporteCanchas()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Posicion", typeof(int));
            oDt.Columns.Add("Cancha", typeof(string));
            oDt.Columns.Add("Cantidad de Reservas", typeof(int));
            return oDt;
        }
    }
}
