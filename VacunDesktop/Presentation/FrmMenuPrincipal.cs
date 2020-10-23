using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacunDesktop.Presentation
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void mnuItemTutores_Click(object sender, EventArgs e)
        {
            var frmTutores = new FrmTutores();
            frmTutores.ShowDialog();
        }

        private void MnuItemCalendarios_Click(object sender, EventArgs e)
        {
            var frmCalendarios = new FrmCalendarios();
            frmCalendarios.ShowDialog();
        }
    }
}
