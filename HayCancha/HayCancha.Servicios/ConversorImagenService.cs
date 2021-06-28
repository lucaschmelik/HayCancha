using System.IO;
using System.Drawing;
using System;

namespace HayCancha.Servicios
{
    public static class ConversorImagenService
    {
        public static Image ConvetirByteAImagen(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
