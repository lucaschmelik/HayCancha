using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;

namespace HayCancha.DAL
{
    public class PermisoDAL : AbstractDAL
    {
        private static PermisoDAL _oPermisoDAL;
        public static PermisoDAL Instancia => _oPermisoDAL ?? new PermisoDAL();

        private DataTable RetornaDataTablePermiso()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            return oDt;
        }

        private DataTable RetornaDataTableFamilias()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Permiso", typeof(int));
            oDt.Columns.Add("FAMILIAS", typeof(string));
            return oDt;
        }

        private DataTable RetornaDataTablePatentes()
        {
            var oDt = new DataTable();
            oDt.Columns.Add("Permiso", typeof(int));
            oDt.Columns.Add("PATENTES", typeof(string));
            return oDt;
        }

        private DataTable RetornaDatatableSoloId()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));

            return oDt;
        }

        public DataRow ObtenerPermisoUsuario(string sNombre) => EjecutaStp("stpObtenerPermisoUsuario", new Dictionary<string, object>(){ { "Usuario", sNombre } } , RetornaDataTablePermiso()).AsEnumerable().FirstOrDefault();

        public DataTable ObtenerHijos(int iId)
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(string));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("EsRol", typeof(bool));


            var oDicParametros = new Dictionary<string, object>
            {
                {"IdPadre", iId}
            };

            return EjecutaStp("stpObtenerHijosPermiso", oDicParametros, oDt);

        }

        public DataTable ObtenerFamilias() => EjecutaStp("stpObtenerFamilias", new Dictionary<string, object>(), RetornaDataTableFamilias());

        public DataTable ObtenerPatentes() => EjecutaStp("stpObtenerPatentes", new Dictionary<string, object>(), RetornaDataTablePatentes());

        public int GuardarFamilia(string sNombre, IList<AbstractComponent> lstPermisos)
        {
            var iIdFamilia = int.Parse(EjecutaStp("stpGuardarPermiso", new Dictionary<string, object>() { { "Nombre", sNombre }, { "EsRol", 1 } }, RetornaDatatableSoloId()).AsEnumerable().FirstOrDefault()?["Id"].ToString() ?? throw new InvalidOperationException());

            foreach (var permiso in lstPermisos)
            {
                EjecutaStp("stpGuardarPermisoPermiso", new Dictionary<string, object>() { { "Permiso", iIdFamilia }, { "PermisoHijo", permiso.Permiso } }, new DataTable());
            }

            return iIdFamilia;
        }

        public void AsignarPermisoUsuario(string sNombre, int iPermiso, string sUsuarioModificador) => EjecutaStp("stpAsignarPermisoUsuario", new Dictionary<string, object>() {{"Usuario", sNombre}, {"Permiso", iPermiso}, { "UsuarioModificador", sUsuarioModificador } }, new DataTable());
        
        public int ObtenerIdFamiliaPorNombre(string sNombre) => int.Parse(EjecutaStp("stpObtenerIdFamiliaPorNombre", new Dictionary<string, object>() { { "Nombre", sNombre } }, RetornaDatatableSoloId()).AsEnumerable().FirstOrDefault()["Id"].ToString());

        private void EliminarPermisosFamilia(int iIdFamilia) => EjecutaStp("stpEliminarPermisosFamilia", new Dictionary<string, object>() {{"Id", iIdFamilia}}, new DataTable());

        public void ActualizarFamilia(Familia oFamilia)
        {
            EliminarPermisosFamilia(oFamilia.Permiso);

            oFamilia.lstHijos.ToList().ForEach(permiso => EjecutaStp("stpGuardarPermisoPermiso", new Dictionary<string, object>() { { "Permiso", oFamilia.Permiso }, { "PermisoHijo", permiso.Permiso } }, new DataTable()));

            oFamilia.lstHijos.Where(x => x.GetType() == typeof(Familia)).ToList().ForEach(permiso=>ActualizarFamilia((Familia)permiso));
        }

        public string ObtenerNombrePermisoPorUsuario(string sNombreUsuario) => EjecutaStp("stpObtenerNombreFamiliaPorUsuario", new Dictionary<string, object>() { { "NombreUsuario", sNombreUsuario } }, RetornaDataTableFamilias()).AsEnumerable().FirstOrDefault()["FAMILIAS"].ToString();
    }
}
