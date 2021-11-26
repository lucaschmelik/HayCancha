using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;

namespace HayCancha.BLL
{
    public static class ReporteBLL
    {
        public static DataTable ObtenerReporteJugadoresEnum(Enum reportesJugadoresEnum, DateTime fechaDesde, DateTime fechaHasta) => ReporteDAL.Instancia.ObtenerReporteJugadoresEnum(reportesJugadoresEnum, fechaDesde, fechaHasta);
    }
}
