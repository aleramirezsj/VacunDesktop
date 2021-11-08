using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using VacunDesktop.Core;

namespace VacunDesktop.Models
{
    public class VacunWebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.ObtenerCadenaDeConexión());

            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=VacunWebContext; User Id = sa; Password = 123; MultipleActiveResultSets = True;");
            /* optionsBuilder.UseMySql(@"server=192.168.1.100;user=admin;password=123;port=3306;database=VacunWebContext;", mySqlOptions => mySqlOptions
                             .ServerVersion(new Version(5, 7, 31), ServerType.MySql)
                             .CharSetBehavior(CharSetBehavior.NeverAppend));*/
            /*optionsBuilder.UseMySql(@"server=192.168.1.100;user=admin;password=123;port=3306;database=VacunWebContext;", mySqlOptions => mySqlOptions
                  .ServerVersion(new Version(8, 0, 21), ServerType.MySql)
                  .CharSetBehavior(CharSetBehavior.NeverAppend));*/

            // optionsBuilder.UseSqlServer(@"Server =.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Definicion de filtros de eliminacion
            modelBuilder.Entity<Usuario>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Calendario>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Paciente>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Tutor>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Vacuna>().HasQueryFilter(m => !m.Eliminado);
            #endregion
            #region Datos semilla Calendarios
            var CV = new Calendario { Id = 1, Nombre = "Calendario Varon", SexoPaciente = SexoEnum.Masculino, PrematuroPaciente = false };
            var CVP = new Calendario { Id = 2, Nombre = "Calendario Varon Prematuro", SexoPaciente = SexoEnum.Masculino, PrematuroPaciente = true };
            var CM = new Calendario { Id = 3, Nombre = "Calendario Mujer", SexoPaciente = SexoEnum.Femenino, PrematuroPaciente = false };
            var CMP = new Calendario { Id = 4, Nombre = "Calendario Mujer Prematuro", SexoPaciente = SexoEnum.Femenino, PrematuroPaciente = true };

            modelBuilder.Entity<Calendario>().HasData(CV, CVP, CM, CMP);

            #endregion
            #region Datos Semilla Pacientes

            #endregion
            #region Datos semilla Tutor
            var tutor1 = new Tutor { Id = 1, Nombre = "Juan", Apellido = "Carlos", Contraseña = "1234",Email = "juancarlos1@gmail.com" };
            var tutor2 = new Tutor { Id = 2, Nombre = "Pedro", Apellido = "Picapiedra", Contraseña = "1234", Email = "pedropicapiedra@gmail.com" };
            var tutor3 = new Tutor { Id = 3, Nombre = "Enrique", Apellido = "Rodriguez", Contraseña = "1234", Email = "enriquerodriguez@gmail.com" };
            var tutor4 = new Tutor { Id = 4, Nombre = "Pepito", Apellido = "Martinez", Contraseña = "1234", Email = "pepitomartinez@gmail.com" };
            modelBuilder.Entity<Tutor>().HasData(tutor1, tutor2, tutor3, tutor4);
            #endregion
            #region Datos semilla Vacunas
            var BCG = new Vacuna { Id = 1, Nombre = "BCG", PeriodoAplicacion = 0, Beneficios = "Tuberculosis (formas invasivas)" };
            var HBHB = new Vacuna { Id = 2, Nombre = "Hepatitis B HB", PeriodoAplicacion = 0, Beneficios = "Hepatitis B" };
            var NC = new Vacuna { Id = 3, Nombre = "Neumococo Conjugada Primer Dosis", PeriodoAplicacion = 2, Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo" };
            var NC2 = new Vacuna { Id = 4, Nombre = "Neumococo Conjugada Segunda Dosis", PeriodoAplicacion = 4, Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo" };
            var NCRefuerzo = new Vacuna { Id = 5, Nombre = "Neumococo Conjugada Refuerzo", PeriodoAplicacion = 12, Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo" };
            var QP = new Vacuna { Id = 6, Nombre = "Quintuple pentavalente DTP-HB-Hib Primer Dosis", PeriodoAplicacion = 2, Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b" };
            var QP2 = new Vacuna { Id = 7, Nombre = "Quintuple pentavalente DTP-HB-Hib Segunda Dosis", PeriodoAplicacion = 4, Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b" };
            var QP3 = new Vacuna { Id = 8, Nombre = "Quintuple pentavalente DTP-HB-Hib Tercer Dosis", PeriodoAplicacion = 6, Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b" };
            var P = new Vacuna { Id = 9, Nombre = "Polio IPV Primer dosis", PeriodoAplicacion = 2, Beneficios = "Poliovirus inactiva" };
            var P2 = new Vacuna { Id = 10, Nombre = "Polio IPV Segunda dosis", PeriodoAplicacion = 4, Beneficios = "Poliovirus inactiva" };
            var P3 = new Vacuna { Id = 11, Nombre = "Polio IPV Tercer dosis", PeriodoAplicacion = 6, Beneficios = "Poliovirus inactiva" };
            var Pr = new Vacuna { Id = 12, Nombre = "Polio IPV Refuerzo", PeriodoAplicacion = 60, Beneficios = "Poliovirus inactiva" };
            var R = new Vacuna { Id = 13, Nombre = "Rotavirus Primer dosis", PeriodoAplicacion = 2, Beneficios = "Rotavirus" };
            var R2 = new Vacuna { Id = 14, Nombre = "Rotavirus Segunda dosis", PeriodoAplicacion = 4, Beneficios = "Rotavirus" };
            var M = new Vacuna { Id = 15, Nombre = "Meningococo Primer dosis", PeriodoAplicacion = 3, Beneficios = "Meningococo" };
            var M2 = new Vacuna { Id = 16, Nombre = "Meningococo Segunda dosis", PeriodoAplicacion = 5, Beneficios = "Meningococo" };
            var Mr = new Vacuna { Id = 17, Nombre = "Meningococo Refuerzo dosis", PeriodoAplicacion = 15, Beneficios = "Meningococo" };
            var Mud = new Vacuna { Id = 18, Nombre = "Meningococo Unica dosis", PeriodoAplicacion = 132, Beneficios = "Meningococo" };
            var Grip1 = new Vacuna { Id = 19, Nombre = "Gripe", PeriodoAplicacion = 12, Beneficios = "Antigripal" };
            var Grip2 = new Vacuna { Id = 20, Nombre = "Gripe", PeriodoAplicacion = 24, Beneficios = "Antigripal" };
            var hepa = new Vacuna { Id = 21, Nombre = "Hepatitis A HA", PeriodoAplicacion = 12, Beneficios = "HA Hepatitis A" };
            var triple1 = new Vacuna { Id = 22, Nombre = "Triple Viral SRP Primer Dosis", PeriodoAplicacion = 12, Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas" };
            var triple2 = new Vacuna { Id = 23, Nombre = "Triple Viral SRP Segunda Dosis", PeriodoAplicacion = 60, Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas" };
            var triple3 = new Vacuna { Id = 24, Nombre = "Triple Viral SRP Iniciar o Completar Esquema", PeriodoAplicacion = 132, Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas" };
            var vari = new Vacuna { Id = 25, Nombre = "Varicela", PeriodoAplicacion = 15, Beneficios = "Varicela" };
            var cuadru = new Vacuna { Id = 26, Nombre = "Cuadruple o Quintuple pentavalente DTP-HB-Hib Refuerzo", PeriodoAplicacion = 15, Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b" };
            var triBac = new Vacuna { Id = 27, Nombre = "Triple Bacteriana Celular DTP", PeriodoAplicacion = 60, Beneficios = "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa" };
            var triBac2 = new Vacuna { Id = 28, Nombre = "Triple Bacteriana Acelular dTpa", PeriodoAplicacion = 132, Beneficios = "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa" };
            var virPap = new Vacuna { Id = 29, Nombre = "Virus Papiloma Humano VPH", PeriodoAplicacion = 132, Beneficios = "Virus Papiloma Humano" };
            var dobBac = new Vacuna { Id = 30, Nombre = "Doble Bacteriana dT ADULTOS Refuerzo c/10 años", PeriodoAplicacion = 120, Beneficios = "dT (Doble Bacteriana) Difteria, Tetanos" };
            var dobVir = new Vacuna { Id = 31, Nombre = "Doble Viral SR o Triple Viral SRP Iniciar o completar esquema", PeriodoAplicacion = 180, Beneficios = "SR: (Doble Viral) Sarampión, Rubeóla" };
            var fieAma = new Vacuna { Id = 32, Nombre = "Fiebre Amarilla FA", PeriodoAplicacion = 18, Beneficios = "Fiebre Amarilla" };
            var fieAma2 = new Vacuna { Id = 33, Nombre = "Fiebre Amarilla FA Refuerzo", PeriodoAplicacion = 132, Beneficios = "Fiebre Amarilla" };
            var fieHemo = new Vacuna { Id = 34, Nombre = "Fiebre Hemorrágica Argentina FHA", PeriodoAplicacion = 180, Beneficios = "FHA: Fiebre Hemorragica Argentina" };

            modelBuilder.Entity<Vacuna>().HasData(BCG, HBHB, NC, NC2, NCRefuerzo, QP, QP2, QP3, P, P2, P3, Pr, R, R2, M, M2, Mr, Mud, Grip1, Grip2, hepa, triple1, triple2, triple3, vari, cuadru, triBac, triBac2, virPap, dobBac, dobVir, fieAma, fieAma2, fieHemo);
            #endregion

        }
        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DetalleCalendario> DetalleCalendarios { get; set; }
        public DbSet<VacunaColocada> VacunasColocadas { get; set; }
        public VacunWebContext(DbContextOptions<VacunWebContext> options) : base(options)
        {

            

        }

        public VacunWebContext()
        {

        }


    }
}