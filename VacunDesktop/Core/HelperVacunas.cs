using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace VacunDesktop.Core
{
    public static class HelperVacunas
    {
        public static string ObtenerSha256Hash(string textoAEncriptar)
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
        public static string ObtenerCadenaDeConexión()
        {
            string cadenaConexion = "Server= " + Properties.Settings.Default.servidor;
            cadenaConexion += " ;Initial Catalog = " + Properties.Settings.Default.bbdd;
            cadenaConexion += " ;User Id = " + Properties.Settings.Default.usuario;
            cadenaConexion += " ;Password = " + Properties.Settings.Default.contraseña;
            cadenaConexion += "; MultipleActiveResultSets = True";
            return cadenaConexion;
        }
    }
}
