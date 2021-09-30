using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario { get; set; } 
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            if (Properties.Settings.Default.imagenFondo != "")
                BackgroundImage = Image.FromFile(Properties.Settings.Default.imagenFondo);


        }

        private void mnuItemTutores_Click(object sender, EventArgs e)
        {
            var frmTutores = new FrmTutores();
            frmTutores.ShowDialog();
        }

        private void MnuItemCalendarios_Click(object sender, EventArgs e)
        {
            var frmCalendarios = new FrmCalendarios(new DbAdminCalendarios());
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
            //var frmCalendarios = new FrmCalendarios(new DbAdminCalendarios());
            //frmCalendarios.ShowDialog();
            var frmCalendarios = new FrmBase(new DbAdminCalendarios(),new FrmNuevoEditarCalendario());
            frmCalendarios.ShowDialog();
        }

        private void MnuListadoVacunas_Click(object sender, EventArgs e)
        {
            //var frmListadoVacunas = new FrmListadoVacunas();
            //frmListadoVacunas.ShowDialog();
            var frmListadoVacunas = new FrmBase(new DbAdminVacunas(),new FrmNuevoEditarVacuna());
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

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmParámetros = new FrmParámetros();
            frmParámetros.ShowDialog();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    configuraciónToolStripMenuItem.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador ? true : false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
