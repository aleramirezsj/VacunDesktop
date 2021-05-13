using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmPacientes : Form
    {
        Paciente pacienteSeleccionado;
        public FrmPacientes()
        {
            InitializeComponent();
            ActualizarGrilla();

        }

        private void CargarCboVacunas(int? idCalendario)
        {
            using (var db = new VacunWebContext())
            {
                CboVacuna.DisplayMember = "nombre";
                CboVacuna.ValueMember = "id";
                Debug.WriteLine("calendario seleccionado:"+idCalendario.ToString());
                var listaVacunas = from vacuna in db.Vacunas
                                   join detalle in db.DetalleCalendarios
                                   on vacuna.Id equals detalle.VacunaId
                                   join calendario in db.Calendarios
                                   on detalle.CalendarioId equals calendario.Id
                                   where calendario.Id== idCalendario
                                   select new { id = vacuna.Id, nombre = vacuna.Nombre.Trim() };
                CboVacuna.DataSource = listaVacunas.ToList();
                CboVacuna.SelectedValue = 0;
            }
        }
        private void ActualizarGrilla()
        {
            using (var db = new VacunWebContext())
            {
                var pacientesAListar = from paciente in db.Pacientes
                                       select new { id = paciente.Id, nombre = paciente.Nombre +" "+paciente.Apellido, fechaNacimiento = paciente.FechaNacimiento, sexo = paciente.Sexo , prematuro = paciente.Prematuro};
                Grid.DataSource = pacientesAListar.ToList();
            }
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPaciente = new FrmNuevoEditarPaciente();
            frmNuevoEditarPaciente.ShowDialog();
            ActualizarGrilla();
            //seleccionamos la fila del nuevo registro cargado
            Grid.CurrentCell = Grid.Rows[Grid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = Grid.CurrentRow.Index;
            //abrimos el formulario para la edición de Calendario seleccionado
            var frmNuevoEditarPaciente= new FrmNuevoEditarPaciente(idSeleccionado);
            frmNuevoEditarPaciente.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void Grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //tomamos el ID del paciente
            var idPaciente = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            using var db = new VacunWebContext();
            this.pacienteSeleccionado= db.Pacientes.Find(idPaciente);
            CargarCboVacunas(pacienteSeleccionado.CalendarioId);
            CargarCboVacunasColocadas(idPaciente);
        }

        private void CargarCboVacunasColocadas(int idPaciente)
        {
            using (var db = new VacunWebContext())
            {
                var listaVacunasColocadas = from vacuna in db.Vacunas
                                   join colocada in db.VacunasColocadas
                                   on vacuna.Id equals colocada.VacunaId
                                   join paciente in db.Pacientes
                                   on colocada.PacienteId equals paciente.Id
                                   where paciente.Id == idPaciente
                                            select new { id = vacuna.Id, nombre = vacuna.Nombre.Trim(), fecha=colocada.Fecha.ToShortDateString() };
                GridVacunas.DataSource = listaVacunasColocadas.ToList();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CboVacuna.SelectedValue != null)
            {
                var idPaciente = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
                var vacunaColocada = new VacunaColocada()
                {
                    PacienteId = idPaciente,
                    VacunaId = (int)CboVacuna.SelectedValue,
                    Fecha = DateTime.Now.Date
                };
                using var db = new VacunWebContext();
                db.VacunasColocadas.Add(vacunaColocada);
                db.SaveChanges();
                CargarCboVacunasColocadas(idPaciente);

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
