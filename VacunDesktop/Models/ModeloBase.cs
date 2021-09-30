using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacunDesktop.Models
{
    public class ModeloBase 
    {
        public int? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime? FechaHoraEliminacion { get; set; }
        public bool Eliminado { get; set; }

    }
}
