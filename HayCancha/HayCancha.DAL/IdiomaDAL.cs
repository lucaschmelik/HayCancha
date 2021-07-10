using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class IdiomaDAL : AbstractDAL
    {
        private static IdiomaDAL _oIdiomaDAL;
        public static IdiomaDAL Instancia => _oIdiomaDAL ?? new IdiomaDAL();

        private DataTable ObtenerDataTableTraduccion()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Traduccion", typeof(string));
            return oDt;
        }

        private DataTable ObtenerDataTableId()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Id", typeof(int));
            return oDt;
        }

        public string RetornaTraduccion(string sNombreTexto, int iIdioma)
        {
            var dicParametros = new Dictionary<string, object>()
            {
                {
                    "Texto", sNombreTexto
                },
                {
                    "Idioma", iIdioma.ToString()
                }
            };

            var oDrEncontrado = EjecutaStp("stpObtenerTraduccionPorTextoIdioma", dicParametros, ObtenerDataTableTraduccion()).AsEnumerable().FirstOrDefault();

            return oDrEncontrado?["Traduccion"].ToString();
        }

        public IList<TextosTraducibles> RetornaTextosTraduciblesPorDefecto()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Descripcion", typeof(string));

            EjecutaStp("stpObtenerTextosTraducibles", new Dictionary<string, object>(), oDt);

            return Enumerable.Select(oDt.AsEnumerable(), oTexto => new TextosTraducibles((int) oTexto["Id"], oTexto["Descripcion"].ToString(), new Idioma((int)IdiomaEnum.Español, IdiomaEnum.Español.ToString()))).ToList();
        }

        public void GuardarIdioma(string sIdioma, DataTable oDtTraducciones)
        {
            //TODO VALIDAR QUE NO SE GUARDEN DOS IDIOMAS IGUALES!!
            var IdIdiomaNuevo = EjecutaStp("stpGuardarIdioma", new Dictionary<string, object>() {{"Idioma", sIdioma.ToUpper()}}, ObtenerDataTableId()).AsEnumerable().FirstOrDefault()?["Id"];

            foreach (var row in oDtTraducciones.AsEnumerable())
            {
                if (row["Traduccion"].ToString() != string.Empty && RetornaTraduccion(row["Traduccion"].ToString(), (int)IdIdiomaNuevo) != null)
                    throw new Exception($"La palabra {row["Traduccion"]} ya existe para este idioma, verifique las traducciones!!");
                
                EjecutaStp("stpGuardarTraduccion", new Dictionary<string, object>() {{ "Texto", row["Id"]}, { "Idioma", sIdioma.ToUpper() }, {"Traduccion", row["Traduccion"]}}, new DataTable());
            }
        }

        public DataTable ObtenerIdiomas()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Descripcion", typeof(string));
            return EjecutaStp("stpObtenerIdiomas", new Dictionary<string, object>(), oDt);
        }

        public int ObtenerIdIdiomaPorDescripcion(string sDescripcion)
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Id", typeof(int));
            return (int)EjecutaStp("stpObtenerPorDescripcionIdIdioma", new Dictionary<string, object>() { { "Descripcion", sDescripcion } }, oDt).AsEnumerable().FirstOrDefault()?["Id"];
        }
    }
}
