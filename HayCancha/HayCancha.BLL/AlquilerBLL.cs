using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;
using HayCancha.Servicios;

namespace HayCancha.BLL
{
    public static class AlquilerBLL
    {
        public static IList<Cancha> ObtenerCanchasDisponibles(DateTime dtSeleccionado, TipoCanchaEnum enumTipoCancha)
        {
            var lstReservas = new List<Cancha>();

            var lstCanchasOcupadas = CanchaDAL.Instancia.ObtenerCanchasOcupadas(dtSeleccionado, enumTipoCancha);

            var lstCanchas = CanchaDAL.Instancia.ObtenerCanchas().AsEnumerable().Where(x => (int) x["TipoCancha"] == (int) enumTipoCancha).CopyToDataTable();

            foreach (var cancha in lstCanchas.AsEnumerable())
            {
                if (lstCanchasOcupadas.AsEnumerable().Any(x => (int) x["Id"] == (int) cancha["Id"])) continue;

                lstReservas.Add(new Cancha()
                {
                    Id = int.Parse(cancha["Id"].ToString()),
                    Nombre = cancha["Nombre"].ToString(),
                    TipoCancha = (TipoCanchaEnum)cancha["TipoCancha"]
                });
            }

            return lstReservas;
        }

        public static int GuardarReserva(Reserva oReserva) => ReservaDAL.Instancia.GuardarReserva(oReserva);

        public static void CambiarEstadoReserva(Reserva oReserva, EstadoReservaEnum enumEstado) => ReservaDAL.Instancia.CambiarEstadoReserva(oReserva, enumEstado);
    }
}
