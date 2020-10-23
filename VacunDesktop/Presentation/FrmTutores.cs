
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
    public partial class FrmTutores : Form
    {
        //constructor (método que no devuelve valores que se llama igual que la clase)
        public FrmTutores()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            using (var db = new VacunWebContext()) { 
                gridTutores.DataSource = db.Tutores.ToList();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //abrimos el formulario para la carga de un nuevo tutor
            var frmNuevoEditarTutor = new FrmNuevoEditarTutor();
            frmNuevoEditarTutor.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos la fila del nuevo registro cargado
            gridTutores.CurrentCell = gridTutores.Rows[gridTutores.RowCount-1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idTutorSeleccionado = int.Parse(gridTutores.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = gridTutores.CurrentRow.Index;
            //abrimos el formulario para la edición de tutor seleccionado
            var frmNuevoEditarTutor = new FrmNuevoEditarTutor(idTutorSeleccionado);
            frmNuevoEditarTutor.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            gridTutores.CurrentCell = gridTutores.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre del tutor seleccionado en la grilla
            var idTutorSeleccionado = int.Parse(gridTutores.CurrentRow.Cells[0].Value.ToString());
            var nombreTutorSeleccionado = gridTutores.CurrentRow.Cells[1].Value.ToString() + " " + gridTutores.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_tutor_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreTutorSeleccionado}?","Eliminar tutor",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el tutor a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                using (var db=new VacunWebContext())
                {
                    var tutor = db.Tutores.Find(idTutorSeleccionado);
                    db.Tutores.Remove(tutor);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            using (var db=new VacunWebContext())
            {
                gridTutores.DataSource = db.Tutores.Where(t => t.Apellido.Contains(TxtBusqueda.Text) || t.Nombre.Contains(TxtBusqueda.Text) || t.Email.Contains(TxtBusqueda.Text)).ToList();
                
            }
        }
    }
}
