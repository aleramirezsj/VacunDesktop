using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.ExtensionMethods;

namespace VacunDesktop.Presentation
{
    public partial class FrmParámetros : Form
    {
        public FrmParámetros()
        {
            InitializeComponent();
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            TxtUsuario.Text= Properties.Settings.Default.usuario;
            TxtServidor.Text = Properties.Settings.Default.servidor;
            TxtBbdd.Text = Properties.Settings.Default.bbdd;
            TxtContraseña.Text = Properties.Settings.Default.contraseña;
        }

        private void BtnGuardarModificar_Click(object sender, EventArgs e)
        {
            if (BtnGuardarModificar.Text == "Modificar")
            {
                BtnGuardarModificar.Text = "Guardar";
                this.HabilitarDeshabilitarTextBox(true);
            }
            else
            {
                Properties.Settings.Default.usuario = TxtUsuario.Text;
                Properties.Settings.Default.servidor=TxtServidor.Text ;
                Properties.Settings.Default.bbdd=TxtBbdd.Text ;
                Properties.Settings.Default.contraseña=TxtContraseña.Text ;
                Properties.Settings.Default.imagenFondo = TxtImagen.Text;
                BtnGuardarModificar.Text = "Modificar";
                this.HabilitarDeshabilitarTextBox(false);
                Properties.Settings.Default.Save();
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|GIF* (*.gif)|*.gif";
            filtro += "|PNG* (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";

            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();

            if (ofdAbrirArchivo.FileName != "")
            {

                PbxImagen.Image = new Bitmap(ofdAbrirArchivo.FileName);
                TxtImagen.Text = ofdAbrirArchivo.FileName;
                


            }
        }
    }
}
