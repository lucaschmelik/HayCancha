using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public static class BitacoraService
    {
        public static void Escribir(TipoEventoBitacoraEnum tipo, string mensaje)
        {
            var bitacora = new Bitacora(DateTime.Now, tipo, mensaje, SessionService.Session.UsuarioLogueado == null ? "Intento de acceso" : SessionService.Session.UsuarioLogueado.Nombre);

            BitacoraDAL.Instancia.Guardar(bitacora);
        }

        public static void EscribirArchivo()
        {
            var bitacoraRestore = new Bitacora(DateTime.Now, TipoEventoBitacoraEnum.SISTEMA, "Se realizó restore de la base de datos.", SessionService.Session.UsuarioLogueado.Nombre);

            SerializacionService.SerializarBitacoraRestore(bitacoraRestore);
        }

        public static void EscribirRestore() => BitacoraDAL.Instancia.Guardar(SerializacionService.Deserializar());
        
        public static List<Bitacora> ListarBitacoras() => Enumerable.Select(BitacoraDAL.Instancia.CargarBitacora().AsEnumerable(), oBitacora => new Bitacora((DateTime) oBitacora["Fecha"], (TipoEventoBitacoraEnum) Enum.Parse(typeof(TipoEventoBitacoraEnum), oBitacora["TipoEvento"].ToString()), oBitacora["Mensaje"].ToString(), oBitacora["Nombre"].ToString())).ToList();

        public static List<Bitacora> ListarBitacorasPorFiltrosVarios(Dictionary<string, object> dicParametros) => Enumerable.Select(BitacoraDAL.Instancia.ObtenerBitacorasPorFiltrosVarios(dicParametros).AsEnumerable(), oBitacora => new Bitacora((DateTime) oBitacora["Fecha"], (TipoEventoBitacoraEnum) Enum.Parse(typeof(TipoEventoBitacoraEnum), oBitacora["TipoEvento"].ToString()), oBitacora["Mensaje"].ToString(), oBitacora["Nombre"].ToString())).ToList();
    }
}
