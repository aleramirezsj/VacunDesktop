using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
           
        }

        private void InicioConexionConSql()
        {
            using (var db = new VacunWebContext())
            {
               var listaVacunas = db.Vacunas.ToList();
            }
            //MessageBox.Show("Ya se conectó a Sql Server");
        }

        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            PbaBarraProgreso.Value = PbaBarraProgreso.Value + 1;
            LblPorcentaje.Text = PbaBarraProgreso.Value.ToString() + "%";
            if(PbaBarraProgreso.Value==100)
            {
                TmrCronometro.Enabled = false;
                var frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.ShowDialog();
                this.Close();
            }
        }

        private void FrmInicio_Activated(object sender, EventArgs e)
        {
            InicioConexionConSql();
            ImpresionDeReporte();
        }

        private void ImpresionDeReporte()
        {
            //************TRATAMOS DE EVITAR QUE LOS ARCHIVOS DE REPORTES ESTÉN VISIBLES EN PRODUCCIÓN CON ESTE CÓDIG PERO NO FUNCIONÓ 
            //String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //String strFilePath = Path.Combine(strAppPath, "reportes");
            //String strFullFilename = Path.Combine(strFilePath, "ReporteCalendarios.rdlc");
            //*********************************

            var reporte = new ReportViewer();
            using var fs = new FileStream(@"reportes\ReporteCalendarios.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte
            using var db = new VacunWebContext();
            var calendarios = db.Calendarios.ToList();
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetCalendarios", calendarios));
            reporte.RefreshReport();
           // MessageBox.Show("El reporte ya se imprimió");
        }
    }
}
