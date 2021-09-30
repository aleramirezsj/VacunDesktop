using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunDesktop.Models
{
    public class Vacuna:ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int PeriodoAplicacion { get; set; }
        [Required]
        public string Beneficios { get; set; }
    }
}
