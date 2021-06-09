using System.Collections.Generic;
using System.Data;
using System.Linq;
using HayCancha.BE;
using HayCancha.BE.Enumerables;

namespace HayCancha.DAL
{
    public class UsuarioDAL : AbstractDAL
    {
        public Usuario oUsuario;

        public UsuarioDAL()
        {
            oUsuario = new Usuario(){ };
        }

        public Usuario GetOne()
        {
            var oDrEncontrado = EjecutaStp("Obtener" + oUsuario.Tabla, new Dictionary<string, object>() { { "Id", oUsuario.Id } }, RetornaTabla()).AsEnumerable().FirstOrDefault();

            return new Usuario
            {
                Nombre = oDrEncontrado["Nombre"].ToString(),
                Contraseña = oDrEncontrado["Contraseña"].ToString()
            };
        }

        public Usuario ObtenerUsuarioPorNombreContraseña()
        {
            var oDrUsuario = EjecutaStp("stpObtenerPorNombreContraseña" + oUsuario.Tabla, new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "Contraseña", oUsuario.Contraseña } }, RetornaTabla()).AsEnumerable().FirstOrDefault();

            return oDrUsuario == null? null : new Usuario { Nombre = oDrUsuario["Nombre"].ToString(), Contraseña = oDrUsuario["Contraseña"].ToString()};
        }

        public Usuario ObtenerUsuarioPorNombre()
        {
            var oDrUsuario = EjecutaStp("stpObtenerPorNombre" + oUsuario.Tabla, new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre } }, RetornaTabla()).AsEnumerable().FirstOrDefault();

            return oDrUsuario == null ? null : new Usuario { Nombre = oDrUsuario["Nombre"].ToString() };
        }

        public void RegistrarUsuario(PermisoEnum oRol, byte[] btImagen)
        {
            EjecutaStp("stpAlta" + oUsuario.Tabla, new Dictionary<string, object>() { { "Nombre", oUsuario.Nombre }, { "Contraseña", oUsuario.Contraseña }, { "Permiso", (int)oRol }, { "Imagen", btImagen} }, new DataTable());
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

        public DataTable RetornaTabla()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("Nombre", typeof(string));
            oDt.Columns.Add("Contraseña", typeof(string));

            return oDt;
        }
    }
}
