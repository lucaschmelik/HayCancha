using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class BitacoraDAL : AbstractDAL
    {
        private static BitacoraDAL instancia;
        public static BitacoraDAL Instancia => instancia ?? new BitacoraDAL();

        public DataTable CargarBitacora() => EjecutaStp("stpObtenerBitacora", new Dictionary<string, object>(), CrearDatatableBitacora());

        public DataTable ObtenerBitacorasPorFiltrosVarios(Dictionary<string, object> dicParametros) => EjecutaStp("stpObtenerBitacoraPorFiltrosVarios", dicParametros, CrearDatatableBitacora());

        public void Guardar(Bitacora oBitacora)
        {
            var oDicParametros = new Dictionary<string, object>
            {
                {"Nombre", oBitacora.Usuario},
                {"Mensaje", oBitacora.Mensaje},
                {"TipoEvento", (int)oBitacora.Evento}
            };

            EjecutaStp("stpInsertarBitacora", oDicParametros, new DataTable());
        }

        private DataTable CrearDatatableBitacora()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Fecha", typeof(DateTime));
            oDt.Columns.Add("Mensaje", typeof(string));
            oDt.Columns.Add("TipoEvento", typeof(int));

            return oDt;
        }
    }
}
