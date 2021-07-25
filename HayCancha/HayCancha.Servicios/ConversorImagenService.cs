using System.IO;
using System.Drawing;
using System;

namespace HayCancha.Servicios
{
    public static class ConversorImagenService
    {
        public static Image ConvetirByteAImagen(byte[] byteArrayIn) => Image.FromStream(new MemoryStream(byteArrayIn, 0, byteArrayIn.Length));
    }
}
