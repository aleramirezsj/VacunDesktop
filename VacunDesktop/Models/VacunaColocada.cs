using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunDesktop.Models
{
    public class VacunaColocada
    {
        public int Id { get; set; }
        [Required]
        public int VacunaId { get; set; }
        public Vacuna Vacuna { get; set; }
        [Required]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
