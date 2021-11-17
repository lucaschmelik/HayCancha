using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
