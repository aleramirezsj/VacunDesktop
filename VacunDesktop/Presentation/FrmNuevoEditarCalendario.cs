using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.Inferfaces;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarCalendario : Form , IFormBase
    {
        DbAdminCalendarios dbAdmin = new DbAdminCalendarios();
        public int? IdEditar { get; set; }
        public Calendario calendario = new Calendario();
        public FrmNuevoEditarCalendario(int? idSeleccionado=null)
        {
            InitializeComponent();
            //si recibimos el IdTutorSeleccionado significa que vamos a editar
            LlenarComboSexo();
            if (idSeleccionado != null) { 
                IdEditar = idSeleccionado;
                CargarDatosEnPantalla();
            }

        }

        private void LlenarComboSexo()
        {
            cboSexo.DataSource= Enum.GetValues(typeof(SexoEnum));
        }

        public void CargarDatosEnPantalla()
        {
                //a través del IdCalendarioEditar buscamos los datos del Calendario en el repositorio
                calendario=(Calendario)dbAdmin.Obtener(IdEditar);
                TxtNombre.Text= calendario.Nombre;
                cboSexo.SelectedIndex= ((int)calendario.SexoPaciente)-1;
                chkPrematuro.Checked = calendario.PrematuroPaciente;
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
            calendario.Nombre = TxtNombre.Text;
            calendario.SexoPaciente = (SexoEnum)cboSexo.SelectedValue;
            calendario.PrematuroPaciente = chkPrematuro.Checked;

            if (IdEditar==null)
                //agregamos el objeto Calendario al repositorio
                dbAdmin.Agregar(calendario);
            else //configuramos el almacenamiento de la modificación
            {
                dbAdmin.Actualizar(calendario);
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

        public void LimpiarDatosDeLaPantalla()
        {
            calendario = new Calendario();
            TxtNombre.Text = "";
            cboSexo.SelectedIndex = 0;
            chkPrematuro.Checked = false;
            IdEditar = null;
        }
    }
}
