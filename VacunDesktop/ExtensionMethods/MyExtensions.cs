using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VacunDesktop.ExtensionMethods
{
    public static class MyExtensions
    {
        public static void HabilitarDeshabilitarTextBox(this Form form, bool valor)
        {
            foreach (Object obj in form.Controls)
            {
                if (obj.GetType().Name == "TextBox")
                {
                    TextBox o = (TextBox)obj;
                    o.Enabled = valor;
                }
            }
        }
        public static void HabilitarDeshabilitarRadioButton(this Form form, bool valor)
        {
            foreach (Object obj in form.Controls)
            {
                if (obj.GetType().Name == "RadioButton")
                {
                    TextBox o = (TextBox)obj;
                    o.Enabled = valor;
                }
            }
        }
        /// <summary>
        /// Fecha: 30/09/2021
        /// Creamos un método genérico que pregunte (en formularios y momentos especiales)
        /// si está seguro que desea salir
        /// </summary>
        /// <param name="form"></param>
        public static void MensajeAdvertenciaDeSalida (this Form form)
        {
            var respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario {form.Text}","Atención",MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
                form.Close();
        }
        /// <summary>
        /// Método que oculta las columnas con información de eliminación, para utilizar en
        /// todas las grillas
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="ocultarMostrar"></param>
        public static void OcultarColumnas(this DataGridView grid, bool ocultarMostrar = false)
        {
            //como entendemos que nunca será necesario ver la columna UsuarioId, hacemos que
            //siempre se oculte
            if (grid.Columns["UsuarioId"] != null)
                grid.Columns["UsuarioId"].Visible = false;

            if (grid.Columns["Usuario"] != null)
                grid.Columns["Usuario"].Visible = ocultarMostrar;
            if (grid.Columns["Eliminado"] != null)
                grid.Columns["Eliminado"].Visible = ocultarMostrar;
            if (grid.Columns["FechaHoraEliminacion"] != null)
                grid.Columns["FechaHoraEliminacion"].Visible = ocultarMostrar;
            if (grid.Columns["Contraseña"] != null)
                grid.Columns["Contraseña"].Visible = ocultarMostrar;
            if (grid.Columns["Pacientes"] != null)
                grid.Columns["Pacientes"].Visible = ocultarMostrar;
        }
        public static int ObtenerIdSeleccionado(this DataGridView grid)
        {
            return int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
        }
        public static string ObtenerNombreSeleccionado(this DataGridView grid, int nroColumnaNombre)
        {
            return grid.CurrentRow.Cells[nroColumnaNombre].Value.ToString();
        }
    }
}
