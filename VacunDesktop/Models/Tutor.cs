using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace VacunDesktop.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }

        public  ICollection<Paciente> Pacientes { get; set; }
    }
}
