
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
    public partial class FrmCalendarios : Form
    {
        //constructor (método que no devuelve valores que se llama igual que la clase)
        public FrmCalendarios()
        {
            InitializeComponent();
            ActualizarGrilla();
            CargarCboVacunas();
        }

        private void CargarCboVacunas()
        {
            using (var db = new VacunWebContext())
            {
                CboVacuna.DisplayMember = "nombre";
                CboVacuna.ValueMember = "id";
                var listaVacunas = from vacuna in db.Vacunas
                                   select new { id = vacuna.Id, nombre = vacuna.Nombre.Trim() };
                CboVacuna.DataSource = listaVacunas.ToList();
                CboVacuna.SelectedValue = 0;
            }
        }

        private void ActualizarGrilla()
        {
            using (var db = new VacunWebContext()) { 
                grid.DataSource = db.Calendarios.ToList();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //abrimos el formulario para la carga de un nuevo Calendario
            var frmNuevoEditarCalendario = new FrmNuevoEditarCalendario();
            frmNuevoEditarCalendario.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos la fila del nuevo registro cargado
            grid.CurrentCell = grid.Rows[grid.RowCount-1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = grid.CurrentRow.Index;
            //abrimos el formulario para la edición de Calendario seleccionado
            var frmNuevoEditarCalendario = new FrmNuevoEditarCalendario(idSeleccionado);
            frmNuevoEditarCalendario.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre del Calendario seleccionado en la grilla
            var idSeleccionado = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var nombreSeleccionado = grid.CurrentRow.Cells[1].Value.ToString() + " " + grid.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_Calendario_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreSeleccionado}?","Eliminar ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                using (var db=new VacunWebContext())
                {
                    var Calendario = db.Calendarios.Find(idSeleccionado);
                    db.Calendarios.Remove(Calendario);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            using (var db=new VacunWebContext())
            {
                grid.DataSource = db.Calendarios.Where(c => c.Nombre.Contains(TxtBusqueda.Text)).ToList();
                
            }
        }

        private void FrmCalendarios_Activated(object sender, EventArgs e)
        {
            //controlamos que ya haya calendarios cargados
            if (grid.CurrentRow != null) { 
                //leemos el id del calendario seleccionado, 
                var idSeleccionado = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                //MessageBox.Show("Nº de calendario seleccionado:" + idSeleccionado.ToString());
                ActualizarGrillaDetalle(idSeleccionado);
            }
        }

        private void ActualizarGrillaDetalle(int idSeleccionado)
        {
            using (var db = new VacunWebContext())
            {
                var listaVacunas = from detalle in db.DetalleCalendarios.Where(c=>c.CalendarioId==                                                                    idSeleccionado)
                                   select new { id = detalle.Id, vacuna = detalle.Vacuna.Nombre };
                GridDetalle.DataSource = listaVacunas.ToList();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var idCalendario = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var idVacuna = (int)CboVacuna.SelectedValue;
            using var db = new VacunWebContext();
            var detalleCalendario = new DetalleCalendario();
            detalleCalendario.CalendarioId = idCalendario;
            detalleCalendario.VacunaId = idVacuna;
            db.DetalleCalendarios.Add(detalleCalendario);
            db.SaveChanges();
            ActualizarGrillaDetalle(idCalendario);
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var idCalendario = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            ActualizarGrillaDetalle(idCalendario);
        }

        private void CboVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboVacuna.SelectedValue!=null)
            {
                if ((int)CboVacuna.SelectedValue > 0)
                    BtnAgregar.Enabled = true;
                else
                    BtnAgregar.Enabled = false;
            }

        }

        private void BtnEliminarVacuna_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre de la vacuna seleccionada en la grilla detalle
            var idSeleccionado = int.Parse(GridDetalle.CurrentRow.Cells[0].Value.ToString());
            var nombreSeleccionado = GridDetalle.CurrentRow.Cells[1].Value.ToString() ;
            var nombreCalendario = grid.CurrentRow.Cells[1].Value.ToString();
            var idCalendario = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            //preguntar si realmente desea eliminar a la vacuna seleccionada
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea quitar a la vacuna {nombreSeleccionado} del calendario {nombreCalendario}?", "Quitar vacuna ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                using (var db = new VacunWebContext())
                {
                    var detalle = db.DetalleCalendarios.Find(idSeleccionado);
                    db.DetalleCalendarios.Remove(detalle);
                    db.SaveChanges();
                }
                ActualizarGrillaDetalle(idCalendario);
            }
        }


    }
}
