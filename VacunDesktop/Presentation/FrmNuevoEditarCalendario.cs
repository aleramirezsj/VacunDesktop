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
    public partial class FrmNuevoEditarCalendario : Form
    {
        public int? IdEditar { get; set; }
        public Calendario calendario { get; set; }
        public FrmNuevoEditarCalendario(int? idSeleccionado=null)
        {
            InitializeComponent();
            //si recibimos el IdTutorSeleccionado significa que vamos a editar
            LlenarComboSexo();
            if (idSeleccionado != null) { 
                IdEditar = idSeleccionado;
                CargarDatosDelCalendarioEnPantalla();
            }
            else
            {
                calendario = new Calendario();
            }

        }

        private void LlenarComboSexo()
        {
            cboSexo.DataSource= Enum.GetValues(typeof(SexoEnum));
        }

        private void CargarDatosDelCalendarioEnPantalla()
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //a través del IdCalendarioEditar buscamos los datos del Calendario en la base de datos
                calendario=db.Calendarios.Find(IdEditar);
                TxtNombre.Text= calendario.Nombre;
                cboSexo.SelectedIndex= ((int)calendario.SexoPaciente)-1;
                chkPrematuro.Checked = calendario.PrematuroPaciente;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                calendario.Nombre = TxtNombre.Text;
                calendario.SexoPaciente = (SexoEnum)cboSexo.SelectedValue;
                calendario.PrematuroPaciente = chkPrematuro.Checked;

                if (IdEditar==null)
                    //agregamos el objeto Tutor al objeto DbContext
                    db.Calendarios.Add(calendario);
                else //configuramos el almacenamiento de la modificación
                {
                    db.Entry(calendario).State = EntityState.Modified;
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
            if (calendario.Id==0)
            {
                if (TxtNombre.Text.Length == 0)
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
            return (calendario.Nombre == TxtNombre.Text && calendario.SexoPaciente == (SexoEnum)cboSexo.SelectedValue && calendario.PrematuroPaciente == chkPrematuro.Checked);
        }
    }
}
