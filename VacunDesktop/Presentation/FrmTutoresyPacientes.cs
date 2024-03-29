﻿using Microsoft.Reporting.WinForms;
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
    public partial class FrmTutoresyPacientes : Form
    {
        private readonly ReportViewer reporte;
        public FrmTutoresyPacientes()
        {
            InitializeComponent();
            //instanciamos un Visor de Reportes
            reporte = new ReportViewer();
            //hacemos que ocupe toda el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmTutoresyPacientes_Load(object sender, EventArgs e)
        {
            //abrimos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"..\..\..\reportes\ReporteTutoresPacientes.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte
            using var db = new VacunasContext();
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            var tutores = from tutor in db.Tutores
                                     join paciente in db.Pacientes
                                     on tutor.Id equals paciente.TutorId
                                     select new
                                     {
                                         Id = tutor.Id,
                                         Nombre = tutor.Nombre,
                                         IdPaciente = paciente.Id,
                                         NombrePaciente = paciente.Nombre
                                     };


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetTutoresPacientes", tutores.ToList()));
            reporte.RefreshReport();
        }
    }
}
