using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VacunDesktop.Inferfaces
{
    public interface IFormBase
    {
        public int? IdEditar { get; set; }
        public DialogResult ShowDialog();
        public void CargarDatosEnPantalla();
        public void LimpiarDatosDeLaPantalla();
    }
}
