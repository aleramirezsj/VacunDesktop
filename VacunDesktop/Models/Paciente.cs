﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunDesktop.Models
{
    public class Paciente : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public SexoEnum Sexo { get; set; }
        public bool Prematuro { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        
        public int? CalendarioId { get; set; }
        public Calendario Calendario { get; set; }
        public byte[] Imagen { get; set; }
    }
}
