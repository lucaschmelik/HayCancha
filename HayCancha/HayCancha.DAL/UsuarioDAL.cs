using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class UsuarioDAL : AbstractDAL
    {
        public Usuario oUsuario;

        public UsuarioDAL()
        {
            oUsuario = new Usuario();
        }
        
        public Usuario ObtenerUsuarioPorNombreContraseña()
        {
            var oDrUsuario = EjecutaStp("stpObtenerPorNombreContraseñaUsuario", new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "Contraseña", oUsuario.Contraseña } }, RetornaTablaUsuario()).AsEnumerable().FirstOrDefault();

            return oDrUsuario == null? null : new Usuario { Id = int.Parse(oDrUsuario["Id"].ToString()), Nombre = oDrUsuario["Nombre"].ToString(), Contraseña = oDrUsuario["Contraseña"].ToString()};
        }

        public Usuario ObtenerUsuarioPorNombre()
        {
            var oDrUsuario = EjecutaStp("stpObtenerPorNombreUsuario", new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre } }, RetornaTablaUsuario()).AsEnumerable().FirstOrDefault();

            return oDrUsuario == null ? null : new Usuario { Id = int.Parse(oDrUsuario["Id"].ToString()), Nombre = oDrUsuario["Nombre"].ToString() };
        }

        public IList<Usuario> ObtenerUsuariosNoAdmin()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Permiso", typeof(int));

            var oDtUsuario = EjecutaStp("stpObtenerUsuariosNoAdmin", new Dictionary<string, object>() {}, oDt);

            return Enumerable.Select(oDtUsuario.AsEnumerable(), oUsuario => new Usuario() {Id = (int) oUsuario["Id"], Nombre = oUsuario["Nombre"].ToString(), lstPermisos = {new Familia() {Permiso = (int) oUsuario["Permiso"]}}}).ToList();
        }

        public IList<Usuario> ObtenerUsuariosPorNombre(string sNombre)
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));

            var oDtUsuario = EjecutaStp("stpObtenerUsuarioPorNombre", new Dictionary<string, object>() { { "Nombre", sNombre} }, oDt);
            return Enumerable.Select(oDtUsuario.AsEnumerable(), oUsuario => new Usuario() { Id = (int)oUsuario["Id"], Nombre = oUsuario["Nombre"].ToString() }).ToList();
        }
             
        public void RegistrarUsuario(PermisoEnum oRol, byte[] btImagen)
        {
            EjecutaStp("stpAltaUsuario", new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "Contraseña", oUsuario.Contraseña }, { "Permiso", (int)oRol }, { "Imagen", btImagen} }, new DataTable());
        }

        public byte[] ObtenerImagenDefault()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Imagen", typeof(byte[]));

            var oDrImagen = EjecutaStp("stpObtenerImagenDefaultUsuario", new Dictionary<string, object>(), oDt).AsEnumerable().FirstOrDefault();

            return (byte[]) oDrImagen["Imagen"];
        }

        public void GuardarImagenPerfil(byte[] btImagen)
        {
            EjecutaStp("stpGuardarImagenUsuario", new Dictionary<string, object>() {{"Nombre", oUsuario.Nombre}, {"Imagen", btImagen}}, new DataTable());
        }

        public byte[] ObtenerImagenPerfil()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Imagen", typeof(byte[]));

            var oDrImagen = EjecutaStp("stpObtenerImagenPerfilUsuario", new Dictionary<string, object>() {{"Nombre", oUsuario.Nombre}}, oDt).AsEnumerable().FirstOrDefault(); ;

            return (byte[])oDrImagen[0];
        }

        public DataTable RetornaTablaUsuario()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Contraseña", typeof(string));

            return oDt;
        }

        public DataTable ObtenerUsuariosAuditoriaPorNombre(string sNombre)
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Contraseña", typeof(string));
            oDt.Columns.Add("Imagen", typeof(string));
            oDt.Columns.Add("Permiso", typeof(string));
            oDt.Columns.Add("Usuario Modificacion", typeof(string));
            oDt.Columns.Add("Fecha Modificacion", typeof(DateTime));

            return EjecutaStp("stpObtenerPorNombreUsuarioAuditoria", new Dictionary<string, object> { { "Nombre", sNombre } }, oDt);
        }

        public void CambiarContraseña(string sNombre, string sContraseña, string sUsuarioModificador) => EjecutaStp("stpCambiarContraseñaUsuario", new Dictionary<string, object> { { "Nombre", sNombre }, { "Contraseña", sContraseña }, { "UsuarioModificador", sUsuarioModificador } }, new DataTable());

        public void RestaurarUsuario(int iIdUsuarioAuditoria) => EjecutaStp("stpRestaurarUsuario", new Dictionary<string, object> { { "IdUsuarioAuditoria", iIdUsuarioAuditoria }}, new DataTable());

        public DataTable ObtenerTodosLosHashUsuario()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("PreHash", typeof(string));

            return EjecutaStp("stpObtenerTodosLosHashUsuario", new Dictionary<string, object>() { }, oDt);
        }

        public string ObtenerHashPorTablaUsuario()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Hash", typeof(string));

            return EjecutaStp("stpObtenerHashPorTablaUsuario", new Dictionary<string, object>() { }, oDt).AsEnumerable().FirstOrDefault()?["Hash"].ToString();
        }

        public Usuario ObtenerUsuarioPorHash(string sHash)
        {
            var oDrUsuario = EjecutaStp("stpObtenerPorHashUsuario", new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "hash", sHash } }, RetornaTablaUsuario()).AsEnumerable().FirstOrDefault();

            return oDrUsuario == null ? null : new Usuario { Nombre = oDrUsuario["Nombre"].ToString() };
        }

        public int ObtenerRol()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Permiso", typeof(int));

            return (int)EjecutaStp("stpObtenerRolUsuario", new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "Contraseña", oUsuario.Contraseña } }, oDt).AsEnumerable().FirstOrDefault()["Permiso"];
        }

        public void ModificarHashUsuario(string sNombre, string sHash)
        {
            EjecutaStp("stpModificarHashUsuario", new Dictionary<string, object>() { { "Nombre", sNombre }, { "Hash", sHash } }, new DataTable());
        }

        public void ModificarTablaUsuarioDigitoVerificadorVertical(string sHashUsuario)
        {
            EjecutaStp("stpModificarUsuarioDigitoVerificadorVertical", new Dictionary<string, object>() { { "HashUsuario", sHashUsuario } }, new DataTable());
        }

        public IList<Usuario> ObtenerTodosLosUsuarios()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Contraseña", typeof(string));
            oDt.Columns.Add("Permiso", typeof(int));

            var oDtUsuario = EjecutaStp("stpObtenerTodosLosUsuarios", new Dictionary<string, object>() { }, oDt);

            return Enumerable.Select(oDtUsuario.AsEnumerable(), oUsuario => new Usuario() { Nombre = oUsuario["Nombre"].ToString(), Contraseña = oUsuario["Contraseña"].ToString(), lstPermisos = { new Familia() { Permiso = (int)oUsuario["Permiso"] } } }).ToList();
        }
    }
}
