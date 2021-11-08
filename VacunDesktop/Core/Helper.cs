using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;


namespace VacunDesktop.Core
{
    public static class Helper
    {
        public static string ObtenerHashSha256(string textoAEncriptar)
        {
            // Create a SHA256   
            using SHA256 sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textoAEncriptar));
            // Convert byte array to a string   
            StringBuilder hashObtenido = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                hashObtenido.Append(bytes[i].ToString("x2"));
            }
            return hashObtenido.ToString();
        }

        public static Image convertirBytesAImagen(Byte[] arregloImg)
        {
            MemoryStream imagenStream = new MemoryStream(arregloImg);
            Image imagen = Image.FromStream(imagenStream);
            return imagen;
        }
        public static void AlmacenarImagenEnArchivoDeRecursos(Image imagenFondo)
        {
            MemoryStream bitmapStream = new MemoryStream();
            Bitmap bmp = new Bitmap(imagenFondo);
            bmp.Save(bitmapStream, ImageFormat.Jpeg);
            using (ResourceWriter rw = new ResourceWriter(@".\Recursos.resources"))
            {
                rw.AddResource("fondo", bitmapStream);

            }

        }
        public static Image RecuperarImagenDeArchivoDeRecursos(string nombreImagen)
        {
            Image imagen;
            try
            {
                using (ResourceReader rr = new ResourceReader(@".\Recursos.resources"))
                {
                    string tipoRecurso = "";
                    byte[] bytesArchivo;
                    rr.GetResourceData(nombreImagen, out tipoRecurso, out bytesArchivo);
                    const int OFFSET = 4;
                    int size = BitConverter.ToInt32(bytesArchivo, 0);
                    Bitmap imagenBMP = new Bitmap(new MemoryStream(bytesArchivo, OFFSET, size));
                imagen = imagenBMP;
                }
                return imagen;
            }
            catch
            {
                using (ResourceWriter rw = new ResourceWriter(@".\Recursos.resources"))
                {
                    rw.AddResource("Sistema", "VacunDeskTop");

                }
                return null;
            }
        }
        public static byte[] convertirImagenABytes(Image img)
        {
            MemoryStream imagenStream = new MemoryStream();
            img.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imagenBytes = imagenStream.ToArray();
            return imagenBytes;
        }
        public static string ObtenerCadenaDeConexión()
        {
            string cadenaConexion;
            if (Properties.Settings.Default.localdb)
            {

                //string carpetalocal = Assembly.GetExecutingAssembly().Location;
                string carpetalocal= Directory.GetCurrentDirectory();
                cadenaConexion = $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {carpetalocal}\AppData\VacunDesktopContext.mdf; Integrated Security = True; Connect Timeout = 30";
            }
            else
            {
                cadenaConexion = "Server= " + Properties.Settings.Default.servidor;
                cadenaConexion += " ;Initial Catalog = " + Properties.Settings.Default.bbdd;
                cadenaConexion += " ;User Id = " + Properties.Settings.Default.usuario;
                cadenaConexion += " ;Password = " + Properties.Settings.Default.contraseña;
                cadenaConexion += "; MultipleActiveResultSets = True";
            }
            
            return cadenaConexion;
        }
    }
}
