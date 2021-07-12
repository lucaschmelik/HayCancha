using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class ReservaDAL : AbstractDAL
    {
        private static ReservaDAL _oInstanciaDAL;
        public static ReservaDAL Instancia => _oInstanciaDAL ?? new ReservaDAL();

        private DataTable RetornaDatatableReserva()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("FechaFin", typeof(DateTime));
            oDt.Columns.Add("FechaInicio", typeof(DateTime));
            oDt.Columns.Add("Estado", typeof(int));
            oDt.Columns.Add("IdUsuario", typeof(int));
            oDt.Columns.Add("NombreUsuario", typeof(string));
            oDt.Columns.Add("IdCancha", typeof(int));
            oDt.Columns.Add("NombreCancha", typeof(string));

            return oDt;
        }

        private DataTable RetorndaDatatableReservaCantidad()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Cantidad", typeof(int));

            return oDt;
        }

        public int GuardarReserva(Reserva oReserva)
        {
            var iIdReserva = (int)EjecutaStp("stpGuardarReserva", new Dictionary<string, object>()
            {
                { "FechaFin", oReserva.FechaFin },
                { "Organizador", oReserva.Organizador.Id},
                { "FechaInicio", oReserva.FechaInicio },
                { "Cancha ", oReserva.Estadio.Id },
                { "Estado", (int)oReserva.EstadoReserva }
            }, RetornaDatatableId()).AsEnumerable().FirstOrDefault()["Id"];

            foreach (var jugador in oReserva.lstJugadores.AsEnumerable())
            {
                EjecutaStp("stpGuardarReservaJugador", new Dictionary<string, object>() { { "Reserva", iIdReserva }, { "Jugador", jugador.Id } }, new DataTable());
            }

            return iIdReserva;
        }

        public void CambiarEstadoReserva(Reserva oReserva, EstadoReservaEnum enumEstadoReserva) => EjecutaStp("stpAsignarEstadoReserva", new Dictionary<string, object>() { { "Reserva", oReserva.Id }, { "Estado", (int)enumEstadoReserva } }, new DataTable());

        public DataTable ObtenerReservasPorEstado(EstadoReservaEnum enumEstadoReserva) => EjecutaStp("stpObtenerReservasPorEstado", new Dictionary<string, object>() { { "Estado", (int)enumEstadoReserva } }, RetornaDatatableReserva());

        public void AsignarGestorReserva(Reserva oReserva, Usuario oGestor) => EjecutaStp("stpAsignarGestorReserva", new Dictionary<string, object>() { { "Reserva", oReserva.Id }, { "Gestor", oGestor.Id}}, new DataTable());

        public DataTable ObtenerReservasPorJugador(Usuario oJugador)
        {
            var oDt = RetornaDatatableReserva();
            oDt.Columns.Add("TipoCancha", typeof(int));
            oDt.Columns.Add("ReservaAceptada", typeof(bool));
            return EjecutaStp("stpObtenerReservasPorJugador", new Dictionary<string, object>() {{"Jugador", oJugador.Id}}, oDt);
        }

        public void AceptarRechazarReserva(Reserva oReserva, Usuario oJugador, bool bAcepta) => EjecutaStp("stpAceptarRechazarReserva", new Dictionary<string, object>() { { "Reserva", oReserva.Id }, { "Jugador", oJugador.Id }, { "Acepta", bAcepta}}, new DataTable());

        public int ObtenerCantidadJugadoresAceptadoReserva(Reserva oReserva) => (int)EjecutaStp("stpObtenerCantidadJugadoresAceptadoReserva", new Dictionary<string, object>() {{"Reserva", oReserva.Id}}, RetorndaDatatableReservaCantidad()).AsEnumerable().FirstOrDefault()["Cantidad"];
    }
}
