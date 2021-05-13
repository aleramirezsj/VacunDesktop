using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VacunDesktop.Models
{
    public class VacunWebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source = 192.168.1.100; Initial Catalog = VacunWebContext; User Id = sa; Password = 123; MultipleActiveResultSets = True");
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=VacunWebContext; User Id = sa; Password = 123; MultipleActiveResultSets = True;");
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
        }
        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
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