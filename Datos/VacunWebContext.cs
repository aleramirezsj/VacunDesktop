﻿using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class VacunWebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = 209.151.154.164; Initial Catalog = VacunWebContext; User Id = sa; Password = 0HT55b84_; MultipleActiveResultSets = True");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=VacunWebContext; Trusted_Connection=True;");
            /* optionsBuilder.UseMySql(@"server=104.236.251.46;user=smartsof_muttiro;password=@3z&AsG$@HiJ;port=3306;database=VacunWebContext;", mySqlOptions => mySqlOptions
                             .ServerVersion(new Version(5, 7, 31), ServerType.MySql)
                             .CharSetBehavior(CharSetBehavior.NeverAppend));*/
            /*optionsBuilder.UseMySql(@"server=209.151.154.164;user=noticiasctc;password=67A#yM%ko5Or;port=3306;database=VacunWebContext;", mySqlOptions => mySqlOptions
                  .ServerVersion(new Version(8, 0, 21), ServerType.MySql)
                  .CharSetBehavior(CharSetBehavior.NeverAppend));*/

            // optionsBuilder.UseSqlServer(@"Server =.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //public DbSet<Calendario> Calendarios { get; set; }
        //public DbSet<Vacuna> Vacunas { get; set; }
        //public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        //public DbSet<DetalleCalendario> DetalleCalendarios { get; set; }
        //public DbSet<VacunaColocada> VacunasColocadas { get; set; }
        public VacunWebContext(DbContextOptions<VacunWebContext> options) : base(options)
        {


        }

        public VacunWebContext()
        {


        }


    }
}