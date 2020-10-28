using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmNuevoEditarVacuna : Form
    {
        public int? IdVacunaEditar { get; set; }
        public Vacuna vacuna { get; set; }
        public FrmNuevoEditarVacuna(int? idVacunaSeleccionada = null)
        {
            InitializeComponent();
            //si recibimos el idTutorSeleccionado significa que vamos a editar
            if (idVacunaSeleccionada != null)
            {
                IdVacunaEditar = idVacunaSeleccionada;
                //llamamos al metodo de carga datos
                CargarDatosDelaVacunaEnPantalla();
                this.Text = "Editar Vacuna";
            }
            else
            {
                vacuna = new Vacuna();
                this.Text = "Nueva Vacuna";
            }
        }

        private void CargarDatosDelaVacunaEnPantalla()
        {
            using (var db = new VacunWebContext())
            {

                //colocamos en las cajas de texto los datos de la BBDD 
                vacuna = db.Vacunas.Find(IdVacunaEditar);
                TxtNombreV.Text = vacuna.Nombre;
                TxtBeneficios.Text = vacuna.Beneficios;
                NUpDownPeriodo.Value = vacuna.PeriodoAplicacion;
            }

        }
        private void BtnGuardarV_Click(object sender, EventArgs e)
        {
            using (var db = new VacunWebContext())
            {

                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                vacuna.Nombre = TxtNombreV.Text;
                vacuna.PeriodoAplicacion = Convert.ToInt32(NUpDownPeriodo.Value);
                vacuna.Beneficios = TxtBeneficios.Text;

                //si el id de la vacuna a editar es nulo agregamos una vacuna a la tabla
                if (IdVacunaEditar == null)
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
                    PreguntarSiSaleSinGuardar();
                }
            }
            else  //CAMINO SI ES MODIFICANDO A UNA VACUNA EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (vacuna.Nombre == TxtNombreV.Text && vacuna.Beneficios == TxtBeneficios.Text && vacuna.PeriodoAplicacion == NUpDownPeriodo.Value);
        }

        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea salir del formulario sin guardar los datos? ", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
    }
}


