using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;

namespace HayCancha.Servicios
{ 
    public static class SerializacionService
    {
        //public static object Serializar(object objetoASerializar)
        //{
        //    var miStream = new MemoryStream();

        //    new BinaryFormatter().Serialize(miStream, objetoASerializar);

        //    var captura = new UsuarioSerializado()
        //    {
        //        objetoSerializacion = miStream.ToArray(),
        //        FechaModificacion = DateTime.Now,
        //        usuarioModificacion = SessionService.Session.ObtenerNombreUsuario()
        //    };

        //    miStream.Close();

        //    return captura;
        //}

        //public static Usuario Deserializar(Usuario captura)
        //{
        //    var memoryStream = new MemoryStream(captura.objetoSerializacion);

        //    return (Usuario)(new BinaryFormatter().Deserialize(memoryStream));
        //}
    }
}
