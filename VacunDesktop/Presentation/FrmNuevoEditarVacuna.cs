﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Inferfaces;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarVacuna : Form, IFormBase
    {
        public int? IdEditar { get; set; }
        public Vacuna vacuna { get; set; }
        public FrmNuevoEditarVacuna(int? idVacunaSeleccionada = null)
        {
            InitializeComponent();
            //si recibimos el idTutorSeleccionado significa que vamos a editar
            if (idVacunaSeleccionada != null)
            {
                IdEditar = idVacunaSeleccionada;
                //llamamos al metodo de carga datos
                CargarDatosEnPantalla();
                this.Text = "Editar Vacuna";
            }
            else
            {
                vacuna = new Vacuna();
                this.Text = "Nueva Vacuna";
            }
        }

        public void CargarDatosEnPantalla()
        {
            using (var db = new VacunasContext())
            {

                //colocamos en las cajas de texto los datos de la BBDD 
                vacuna = db.Vacunas.Find(IdEditar);
                TxtNombreV.Text = vacuna.Nombre;
                TxtBeneficios.Text = vacuna.Beneficios;
                NUpDownPeriodo.Value = vacuna.PeriodoAplicacion;
            }

        }
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {
            using (var db = new VacunasContext())
            {

                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                vacuna.Nombre = TxtNombreV.Text;
                vacuna.PeriodoAplicacion = Convert.ToInt32(NUpDownPeriodo.Value);
                vacuna.Beneficios = TxtBeneficios.Text;

                //si el id de la vacuna a editar es nulo agregamos una vacuna a la tabla
                if (IdEditar == null)
                    //lo agregamos al objeto Vacuna al objeto DbCOntext
                    db.Vacunas.Add(vacuna);
                else //configuramos el almacenamiento de la modificacion si el id de la vacuna es distinto de nulo
                {
                    db.Entry(vacuna).State = EntityState.Modified;
                }

                //guardamos los cambios
                db.SaveChanges();
            }
            //cerramos el formulario
            this.Close();

        }

        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UNA NUEVA VACUNA

            if (vacuna.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtNombreV.Text.Length == 0 && TxtBeneficios.Text.Length == 0 && NUpDownPeriodo.Value == 0)
                    this.Close();

                else
                {
                    this.MensajeAdvertenciaDeSalida();

                }
            }
            else  //CAMINO SI ES MODIFICANDO A UNA VACUNA EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                    this.Close();
                else
                {
                    this.MensajeAdvertenciaDeSalida();

                }
            }
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (vacuna.Nombre == TxtNombreV.Text && vacuna.Beneficios == TxtBeneficios.Text && vacuna.PeriodoAplicacion == NUpDownPeriodo.Value);
        }



        public void LimpiarDatosDeLaPantalla()
        {
            vacuna = new Vacuna(); 
            TxtNombreV.Text = "";
            TxtBeneficios.Text ="";
            NUpDownPeriodo.Value = 0;
            IdEditar = null;
        }
    }
}


