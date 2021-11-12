using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Core;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarPaciente : Form
    {
        //creamos la propiedad para manejar la webcam
        WebCam webcam;
        public int? IdEditar { get; set; }
        Paciente paciente= new Paciente();
        //Nuevo paciente desde el formulario FrmTutores
        public FrmNuevoEditarPaciente(Tutor tutor)
        {
            InitializeComponent();
            //inicializamos la Webcam pasándole el formulario actual, que no se inicialice automáticamente y el PictureBox  
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
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
            //inicializamos la Webcam pasándole el formulario actual, que no se inicialice automáticamente y el PictureBox  
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
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
            //inicializamos la Webcam pasándole el formulario actual, que no se inicialice automáticamente y el PictureBox  
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
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
            //inicializamos la Webcam pasándole el formulario actual, que no se inicialice automáticamente y el PictureBox  
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
        }

        private void CargarDatosDelPaciente()
        {
            using (var db=new VacunasContext())
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
                if (paciente.Imagen != null)
                    PbxImagen.Image = Helper.convertirBytesAImagen(paciente.Imagen);
            }
        }

        private void CargarCboTutor()
        {
            using (var db = new VacunasContext())
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
            using (var db = new VacunasContext())
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
            using (var db = new VacunasContext())
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
                //si hay una imagen definida la almacenamos en la propiedad correspondiente
                if (PbxImagen.Image != null)
                { 
                    paciente.Imagen = Helper.convertirImagenABytes(PbxImagen.Image);
                    BtnCapturarFoto.Enabled = true;
                }else
                    BtnCapturarFoto.Enabled = false;

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

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|GIF* (*.gif)|*.gif";
            filtro += "|PNG* (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";
            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();
            if (ofdAbrirArchivo.FileName != "")
            {
                PbxImagen.Image = new Bitmap(ofdAbrirArchivo.FileName);
                //TxtImagen.Text = ofdAbrirArchivo.FileName;
            }
        }

        private void BtnIniciarDetenerCamara_Click(object sender, EventArgs e)
        {
            if (BtnIniciarDetenerCamara.Text == "Iniciar cámara")
            {
                InicializarCamara();
            }
            else
            {
                DetenerCamara();
            }
        }
        private void InicializarCamara()
        {
            webcam.Initalize();
            BtnIniciarDetenerCamara.Text = "Detener cámara";
            BtnCapturarFoto.Text = "Capturar foto";
            //RefrescarPaneles();
            BtnCapturarFoto.Enabled = true;
        }
        private void DetenerCamara()
        {
            webcam.Deinitalize();
            BtnIniciarDetenerCamara.Text = "Iniciar cámara";
            BtnCapturarFoto.Text = "Borrar foto";
        }

        private void BtnCapturarFoto_Click(object sender, EventArgs e)
        {
            if (BtnCapturarFoto.Text == "Borrar foto")
            {
                PbxImagen.Image = null;
                BtnCapturarFoto.Enabled = false;
            }
            else
                DetenerCamara();
        }
    }
}
