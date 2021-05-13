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

        private void MnuItemVacunas_Click(object sender, EventArgs e)
        {
            var frmVacunas = new FrmVacunas();
            frmVacunas.ShowDialog();
        }

        private void MnuItemPacientes_Click(object sender, EventArgs e)
        {
            var frmPacientes = new FrmPacientes();
            frmPacientes.ShowDialog();
        }

        private void BtnTutores_Click(object sender, EventArgs e)
        {
            var frmTutores = new FrmTutores();
            frmTutores.ShowDialog();
        }

        private void BtnCalendarios_Click(object sender, EventArgs e)
        {
            var frmCalendarios = new FrmCalendarios();
            frmCalendarios.ShowDialog();
        }

        private void MnuListadoVacunas_Click(object sender, EventArgs e)
        {
            var frmListadoVacunas = new FrmListadoVacunas();
            frmListadoVacunas.ShowDialog();
        }

        private void MnuListadoCalendarios_Click(object sender, EventArgs e)
        {
            var frmListadoCalendarios = new FrmListadoCalendarios();
            frmListadoCalendarios.ShowDialog();
        }

        private void MnuListadoCalendariosYVacunas_Click(object sender, EventArgs e)
        {
            var frmCalendariosVacunas = new FrmCalendariosyVacunas();
            frmCalendariosVacunas.ShowDialog();
        }

        private void MnuListadoTutoresyPacientes_Click(object sender, EventArgs e)
        {
            var frmTutoresyPacientes = new FrmTutoresyPacientes();
            frmTutoresyPacientes.ShowDialog(); 
        }
    }
}
