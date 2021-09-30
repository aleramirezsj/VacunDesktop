using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VacunDesktop.ExtensionMethods;
using VacunDesktop.Inferfaces;

namespace VacunDesktop.Presentation
{
    public partial class FrmBase : Form
    {
        IDbAdmin dbAdmin;
        IFormBase FrmNuevoEditar;
        public FrmBase(IDbAdmin objetoDbAdmin, IFormBase frmNuevoEditar)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            FrmNuevoEditar = frmNuevoEditar;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminados.Checked)
            {
                grid.DataSource = dbAdmin.ObtenerEliminados();
                grid.OcultarColumnas(ocultarMostrar:true);
            }
            else
            {
                grid.DataSource = dbAdmin.ObtenerTodos();
                grid.OcultarColumnas();

            }
            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //abrimos el formulario para la carga de un nuevo Calendario
            FrmNuevoEditar.LimpiarDatosDeLaPantalla();
            FrmNuevoEditar.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos la fila del nuevo registro cargado
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            //abrimos el formulario para la edición de Calendario seleccionado
            FrmNuevoEditar.IdEditar = idSeleccionado;
            FrmNuevoEditar.CargarDatosEnPantalla();
            FrmNuevoEditar.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre del Calendario seleccionado en la grilla
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            var nombreSeleccionado = grid.ObtenerNombreSeleccionado(nroColumnaNombre:1) ;
            //preguntar si realmente desea eliminar al [nombre_Calendario_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea {BtnEliminar.Text} a {nombreSeleccionado}?", BtnEliminar.Text , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar")
            {
                dbAdmin.Eliminar(idSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar")
            {
                dbAdmin.Restaurar(idSeleccionado);
                ActualizarGrilla();
            }
        }

        private void ChkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerEliminados.Checked)
                BtnEliminar.Text = "Restaurar";
            else
                BtnEliminar.Text = "Eliminar";

            ActualizarGrilla();
        }
    }
}
