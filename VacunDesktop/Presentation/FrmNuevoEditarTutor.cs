using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarTutor : Form
    {
        public int? IdTutorEditar { get; set; }
        public Tutor tutor { get; set; }
        public FrmNuevoEditarTutor(int? idTutorSeleccionado=null)
        {
            InitializeComponent();
            //si recibimos el IdTutorSeleccionado significa que vamos a editar
            if (idTutorSeleccionado != null) { 
                IdTutorEditar = idTutorSeleccionado;
                CargarDatosDelTutorEnPantalla();
            }
            else
            {
                tutor = new Tutor();
            }

        }

        private void CargarDatosDelTutorEnPantalla()
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //a través del IdTutorEditar buscamos los datos del tutor en la base de datos
                tutor=db.Tutores.Find(IdTutorEditar);
                TxtApellido.Text=tutor.Apellido  ;
                TxtNombre.Text= tutor.Nombre;
                TxtEmail.Text=tutor.Email ;
                TxtContraseña.Text = tutor.Contraseña;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                tutor.Apellido = TxtApellido.Text;
                tutor.Nombre = TxtNombre.Text;
                tutor.Email = TxtEmail.Text;
                tutor.Contraseña = TxtContraseña.Text;

                if (IdTutorEditar==null)
                    //agregamos el objeto Tutor al objeto DbContext
                    db.Tutores.Add(tutor);
                else //configuramos el almacenamiento de la modificación
                {
                    db.Entry(tutor).State = EntityState.Modified;
                }

                //guardamos los cambios
                db.SaveChanges();
            }
            //cerramos el formulario
            this.Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //si está cargando a un nuevo tutor y contiene texto escrito en la pantalla
            //aparece una advertencia que dice "Los datos no fueron guardado, está seguro que desea cancelar", si pulsa que sí, sale del formulario y pierde los cambios, si pulsa que no, se queda en el formulario

            //NUEVO TUTOR
            if (tutor.Id==0)
            {
                if (TxtApellido.Text.Length == 0 && TxtNombre.Text.Length == 0 && TxtEmail.Text.Length == 0)
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            } else  //MODIFICANDO A UN TUTOR EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                {
                    this.Close();
                }
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }


            
        }

        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario sin guardar los datos?", "Datos sin guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el tutor a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (tutor.Apellido == TxtApellido.Text && tutor.Nombre == TxtNombre.Text && tutor.Email == TxtEmail.Text);
        }
    }
}
