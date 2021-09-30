using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VacunDesktop.ExtensionMethods
{
    public static class MyExtensions
    {
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
