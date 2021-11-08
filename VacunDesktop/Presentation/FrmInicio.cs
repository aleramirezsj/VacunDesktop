using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmInicio : Form
    {
        private bool CargaBBDDCompleta = false;
        private bool CargaReporteCompleta = false;
        public FrmInicio()
        {
            InitializeComponent();
           
        }



        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            PbaBarraProgreso.Value = PbaBarraProgreso.Value + 1;
            LblPorcentaje.Text = PbaBarraProgreso.Value.ToString() + "%";

            if(PbaBarraProgreso.Value==100||CargaBBDDCompleta&&CargaReporteCompleta)
            {
                if (CargaBBDDCompleta && CargaReporteCompleta)
                {
                    TmrCronometro.Enabled = false;
                    var frmMenuPrincipal = new FrmMenuPrincipal();
                    frmMenuPrincipal.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    PbaBarraProgreso.Value = 0;
                }
            }
        }

        private async void FrmInicio_Activated(object sender, EventArgs e)
        {
            await ConsultaDatosSqlAsync();
            await ImpresionDeReporteAsync();
        }
        private async Task ConsultaDatosSqlAsync()
        {
            await Task.Run(() =>
            {
                using (var db = new VacunWebContext())
                {
                    var listaVacunas = db.Vacunas.ToList();
                }
                CargaBBDDCompleta = true;
            });        
        }
        private async Task ImpresionDeReporteAsync()
        {
            await Task.Run(() =>
            {
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
                CargaReporteCompleta = true;
            });
        }
    }
}
