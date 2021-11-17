using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE;
using HayCancha.BE.Clases;

namespace HayCancha.Servicios
{ 
    public static class SerializacionService
    {
        public static void SerializarBitacoraRestore(Bitacora objetoASerializar)
        {
            var archivo = File.Create("bitacoraRestore.bin");

            new BinaryFormatter().Serialize(archivo, objetoASerializar);

            archivo.Close();
        }

        public static Bitacora Deserializar() => (Bitacora) new BinaryFormatter().Deserialize(File.Open("bitacoraRestore.bin", FileMode.Open));
        
    }
}
