using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VacunDesktop.Presentation
{
    public partial class FrmError : Form
    {
        public FrmError(Exception exception)
        {
            InitializeComponent();
            TxtNroError.Text = exception.HResult.ToString();
            TxtMensajeError.Text = exception.Message;
            TxtCodigo.Text = exception.Source;
            TxtPilaDeLlamadas.Text = exception.StackTrace;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
