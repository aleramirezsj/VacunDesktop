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
    public partial class FrmCalendariosVacunas : Form
    {
        private readonly ReportViewer reporte;
        public FrmCalendariosVacunas()
        {
            InitializeComponent();
            //instanciamos un Visor de Reportes
            reporte = new ReportViewer();
            //hacemos que ocupe toda el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmCalendariosVacunas_Load(object sender, EventArgs e)
        {
            //abrimos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"..\..\..\reportes\ReporteCalendariosVacunas.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte
            using var db = new VacunasContext();
            var calendarios = db.Calendarios.ToList();
            var detallecalendarios = db.DetalleCalendarios.ToList();
            var vacunas = db.Vacunas.ToList();
            
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            var calendariosVacunas = from calendario in db.Calendarios
                                      join detallecalendario in db.DetalleCalendarios
                                      on calendario.Id equals detallecalendario.CalendarioId
                                      join vacuna in db.Vacunas
                                      on detallecalendario.VacunaId equals vacuna.Id
                                      select new
                                      {
                                          Id=calendario.Id,
                                          Nombre = calendario.Nombre,
                                          IdVacuna = vacuna.Id,
                                          NombreVacuna = detallecalendario.Vacuna.Nombre,
                                          PeriodoAplicacion = vacuna.PeriodoAplicacion,
                                          Beneficios = vacuna.Beneficios
                                      };


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCalendariosyVacunas", calendariosVacunas.ToList()));
            reporte.RefreshReport();
        }
    }
}
