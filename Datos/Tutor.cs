using System;
using System.ComponentModel.DataAnnotations;

namespace Datos
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

        //public ICollection<Paciente> Pacientes { get; set; }
    }
}
