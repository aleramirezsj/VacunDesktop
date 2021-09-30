
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.AdminData;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Inferfaces;
using VacunDesktop.Models;

namespace VacunDesktop.Presentation
{
    public partial class FrmCalendarios : Form
    {
        IDbAdmin dbAdmin;
        //constructor (método que no devuelve valores que se llama igual que la clase)
        public FrmCalendarios(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
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
           grid.DataSource = dbAdmin.ObtenerTodos();
           grid.OcultarColumnas();
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
            var idSeleccionado = grid.ObtenerIdSeleccionado();
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
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            var nombreSeleccionado = grid.CurrentRow.Cells[1].Value.ToString() + " " + grid.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_Calendario_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreSeleccionado}?","Eliminar ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                dbAdmin.Eliminar(idSeleccionado);
                ActualizarGrilla();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
            
        }

        private void FrmCalendarios_Activated(object sender, EventArgs e)
        {
            //controlamos que ya haya calendarios cargados
            if (grid.CurrentRow != null) {
                //leemos el id del calendario seleccionado,
                try { 
                var idSeleccionado = grid.ObtenerIdSeleccionado();
                    //MessageBox.Show("Nº de calendario seleccionado:" + idSeleccionado.ToString());
                    ActualizarGrillaDetalle(idSeleccionado);
                }
                catch
                {
                    //no tiene datos la grilla
                }
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
            var idCalendario = grid.ObtenerIdSeleccionado();
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
            try { 
                var idCalendario = grid.ObtenerIdSeleccionado();
                ActualizarGrillaDetalle(idCalendario);
            }
            catch
            {
                //no tiene datos
            }
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
            var idSeleccionado = GridDetalle.ObtenerIdSeleccionado();
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
