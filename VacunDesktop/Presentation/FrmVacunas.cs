
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
    public partial class FrmVacunas : Form
    {
        //constructor (método que no devuelve valores que se llama igual que la clase)
        public FrmVacunas()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            using (var db = new VacunasContext()) { 
                grid.DataSource = db.Vacunas.ToList();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //abrimos el formulario para la carga de un nuevo tutor
            var frmNuevoEditarVacuna = new FrmNuevoEditarVacuna();
            frmNuevoEditarVacuna.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos la fila del nuevo registro cargado
            grid.CurrentCell = grid.Rows[grid.RowCount-1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idTutorSeleccionado = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = grid.CurrentRow.Index;
            //abrimos el formulario para la edición de tutor seleccionado
            var frmNuevoEditarVacuna = new FrmNuevoEditarVacuna(idTutorSeleccionado);
            frmNuevoEditarVacuna.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre del tutor seleccionado en la grilla
            var idSeleccionado = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var nombreSeleccionado = grid.CurrentRow.Cells[1].Value.ToString() + " " + grid.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_tutor_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreSeleccionado}?","Eliminar tutor",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el tutor a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                using (var db=new VacunasContext())
                {
                    var vacuna = db.Vacunas.Find(idSeleccionado);
                    db.Vacunas.Remove(vacuna);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            using (var db=new VacunasContext())
            {
                grid.DataSource = db.Vacunas.Where(t => t.Nombre.Contains(TxtBusqueda.Text)).ToList();
                
            }
        }
    }
}
