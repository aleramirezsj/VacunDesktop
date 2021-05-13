using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunDesktop.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public SexoEnum SexoPaciente { get; set; }
        [Required]
        public bool PrematuroPaciente { get; set; }


        public virtual ObservableCollection<DetalleCalendario> DetalleCalendarios { get; set; }

    }
}
