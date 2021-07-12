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
    public static class ReservaBLL
    {
        public static IList<Reserva> ObtenerReservasPendienteAutorizacion() =>
            Enumerable.Select(ReservaDAL.Instancia.ObtenerReservasPorEstado(EstadoReservaEnum.PendienteAutorizacion).AsEnumerable(), oReserva => new Reserva()
            {
                Id = (int)oReserva["Id"], 
                FechaInicio = (DateTime)oReserva["FechaInicio"],
                FechaFin = (DateTime)oReserva["FechaFin"],
                Estadio = new Cancha()
                {
                    Id = (int)oReserva["IdCancha"],
                    Nombre = oReserva["NombreCancha"].ToString()
                },
                EstadoReserva = (EstadoReservaEnum)((int)oReserva["Estado"]),
                Organizador = new Usuario()
                {
                    Id = (int)oReserva["IdUsuario"],
                    Nombre = oReserva["NombreUsuario"].ToString()
                }
            }).ToList();

        public static IList<Reserva> ObtenerReservasAutorizadaPorJugador() => 
            Enumerable.Select(ReservaDAL.Instancia.ObtenerReservasPorJugador(SessionService.Session.UsuarioLogueado).AsEnumerable().Where(x => x["ReservaAceptada"] == DBNull.Value), oReserva => new Reserva()
            {
                Id = (int)oReserva["Id"],
                FechaInicio = (DateTime)oReserva["FechaInicio"],
                FechaFin = (DateTime)oReserva["FechaFin"],
                Estadio = new Cancha()
                {
                    Id = (int)oReserva["IdCancha"],
                    Nombre = oReserva["NombreCancha"].ToString(),
                    TipoCancha = (TipoCanchaEnum)oReserva["TipoCancha"]
                },
                EstadoReserva = (EstadoReservaEnum)((int)oReserva["Estado"]),
                Organizador = new Usuario()
                {
                    Id = (int)oReserva["IdUsuario"],
                    Nombre = oReserva["NombreUsuario"].ToString()
                }
            }).ToList();

        public static void AutorizarReserva(int iIdReserva)
        {
            var oReserva = new Reserva() { Id = iIdReserva};
            ReservaDAL.Instancia.AsignarGestorReserva(oReserva, SessionService.Session.UsuarioLogueado);
            ReservaDAL.Instancia.CambiarEstadoReserva(oReserva, EstadoReservaEnum.Autorizada);
        }

        public static void RechazarReserva(int iIdReserva)
        {
            var oReserva = new Reserva() { Id = iIdReserva };
            ReservaDAL.Instancia.AsignarGestorReserva(oReserva, SessionService.Session.UsuarioLogueado);
            ReservaDAL.Instancia.CambiarEstadoReserva(oReserva, EstadoReservaEnum.Rechazada);
        }

        public static void AceptarReservaJugador(int iIdReserva)
        {
            var oReserva = new Reserva() { Id = iIdReserva };
            ReservaDAL.Instancia.AceptarRechazarReserva(oReserva, SessionService.Session.UsuarioLogueado, true);
        }

        public static void RechazarReservaJugador(int iIdReserva)
        {
            var oReserva = new Reserva() { Id = iIdReserva };
            ReservaDAL.Instancia.AceptarRechazarReserva(oReserva, SessionService.Session.UsuarioLogueado, false);
        }

        public static bool VerificarTotalidadJugadoresReserva(int iIdReserva, int iCantidad)
        {
            var oReserva = new Reserva() { Id = iIdReserva };

            if (ReservaDAL.Instancia.ObtenerCantidadJugadoresAceptadoReserva(oReserva) < iCantidad * 2) return false;

            ReservaDAL.Instancia.CambiarEstadoReserva(oReserva, EstadoReservaEnum.Confirmada);

            return true;
        }
    }
}
