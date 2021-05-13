using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarPaciente : Form
    {
        public int? IdEditar { get; set; }
        Paciente paciente= new Paciente();
        //Nuevo paciente desde el formulario FrmTutores
        public FrmNuevoEditarPaciente(Tutor tutor)
        {
            InitializeComponent();
            CargarCboTutor();
            LlenarComboSexo();
            CargarCboCalendario();
            CboTutor.Enabled = false;
            CboTutor.SelectedValue = tutor.Id;
        }
        //Editar paciente existente desde el formulario FrmTutores
        public FrmNuevoEditarPaciente(Tutor tutor, int idPacienteSeleccionado)
        {
            InitializeComponent();
            CargarCboTutor();
            LlenarComboSexo();
            CargarCboCalendario();
            CboTutor.Enabled = false;
            CboTutor.SelectedValue = tutor.Id;
            if (idPacienteSeleccionado != 0)
            {
                IdEditar = idPacienteSeleccionado;
                CargarDatosDelPaciente();
            }

        }
        //editando un paciente desde FrmPacientes
        public FrmNuevoEditarPaciente(int idSeleccionado)
        {
            InitializeComponent();
            CargarCboTutor();
            LlenarComboSexo();
            CargarCboCalendario();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                CargarDatosDelPaciente();
            }
        }
        //nuevo paciente ejecutado desde el formulario de FrmPacientes
        public FrmNuevoEditarPaciente()
        {
            InitializeComponent();
            CargarCboTutor();
            LlenarComboSexo();
            CargarCboCalendario();
        }

        private void CargarDatosDelPaciente()
        {
            using (var db=new VacunWebContext())
            {
                paciente=db.Pacientes.Find(IdEditar);
                TxtApellido.Text = paciente.Apellido;
                TxtNombre.Text = paciente.Nombre;
                TxtDomicilio.Text = paciente.Domicilio;
                CboSexo.SelectedItem = paciente.Sexo;
                CboTutor.SelectedValue = paciente.TutorId;
                CboCalendario.SelectedValue = paciente.CalendarioId;
                ChkPrematuro.Checked = paciente.Prematuro;
                DtpFechaNacimiento.Value = paciente.FechaNacimiento.Date;
                NudDni.Value = paciente.Dni;
                NudPeso.Value = (decimal)paciente.Peso;
            }
        }

        private void CargarCboTutor()
        {
            using (var db = new VacunWebContext())
            {
                var listaTutores = from tutor in db.Tutores
                                   select new { id = tutor.Id, nombre = tutor.Apellido.Trim() + " " + tutor.Nombre.Trim() };
                CboTutor.DataSource = listaTutores.ToList();
                CboTutor.DisplayMember = "nombre";
                CboTutor.ValueMember = "id";
            }
        }

        private void CargarCboCalendario()
        {
            using (var db = new VacunWebContext())
            {
                var listaCalendarios = from calendario in db.Calendarios
                                   select new { id = calendario.Id, nombre = calendario.Nombre };
                CboCalendario.DataSource = listaCalendarios.ToList();
                CboCalendario.DisplayMember = "nombre";
                CboCalendario.ValueMember = "id";
            }
        }

        private void LlenarComboSexo()
        {
            CboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //instanciamos un objeto DbContext
            using (var db = new VacunWebContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                paciente.Apellido = TxtApellido.Text;
                paciente.Nombre = TxtNombre.Text;
                paciente.Sexo = (SexoEnum)CboSexo.SelectedValue;
                paciente.Prematuro = ChkPrematuro.Checked;
                paciente.Domicilio = TxtDomicilio.Text;
                paciente.TutorId = (int)CboTutor.SelectedValue;
                paciente.CalendarioId = (int)CboCalendario.SelectedValue;
                paciente.Dni = (int)NudDni.Value;
                paciente.Peso = (double)NudPeso.Value;
                paciente.FechaNacimiento = DtpFechaNacimiento.Value.Date;

                if (IdEditar == null)
                    //agregamos el objeto Tutor al objeto DbContext
                    db.Pacientes.Add(paciente);
                else //configuramos el almacenamiento de la modificación
                {
                    db.Entry(paciente).State = EntityState.Modified;
                }

                //guardamos los cambios
                db.SaveChanges();
            }
            //cerramos el formulario
            this.Close();
        }
    }
}
