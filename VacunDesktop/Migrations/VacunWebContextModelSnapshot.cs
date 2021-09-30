﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacunDesktop.Models;

namespace VacunDesktop.Migrations
{
    [DbContext(typeof(VacunWebContext))]
    partial class VacunWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VacunDesktop.Models.Calendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrematuroPaciente")
                        .HasColumnType("bit");

                    b.Property<int>("SexoPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Calendarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Calendario Varon",
                            PrematuroPaciente = false,
                            SexoPaciente = 1
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Calendario Varon Prematuro",
                            PrematuroPaciente = true,
                            SexoPaciente = 1
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Nombre = "Calendario Mujer",
                            PrematuroPaciente = false,
                            SexoPaciente = 2
                        },
                        new
                        {
                            Id = 4,
                            Eliminado = false,
                            Nombre = "Calendario Mujer Prematuro",
                            PrematuroPaciente = true,
                            SexoPaciente = 2
                        });
                });

            modelBuilder.Entity("VacunDesktop.Models.DetalleCalendario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendarioId")
                        .HasColumnType("int");

                    b.Property<int>("VacunaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioId");

                    b.HasIndex("VacunaId");

                    b.ToTable("DetalleCalendarios");
                });

            modelBuilder.Entity("VacunDesktop.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CalendarioId")
                        .HasColumnType("int");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<bool>("Prematuro")
                        .HasColumnType("bit");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioId");

                    b.HasIndex("TutorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("VacunDesktop.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tutores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Carlos",
                            Contraseña = "1234",
                            Eliminado = false,
                            Email = "juancarlos1@gmail.com",
                            Nombre = "Juan"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Picapiedra",
                            Contraseña = "1234",
                            Eliminado = false,
                            Email = "pedropicapiedra@gmail.com",
                            Nombre = "Pedro"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Rodriguez",
                            Contraseña = "1234",
                            Eliminado = false,
                            Email = "enriquerodriguez@gmail.com",
                            Nombre = "Enrique"
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Martinez",
                            Contraseña = "1234",
                            Eliminado = false,
                            Email = "pepitomartinez@gmail.com",
                            Nombre = "Pepito"
                        });
                });

            modelBuilder.Entity("VacunDesktop.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("VacunDesktop.Models.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beneficios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodoAplicacion")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vacunas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Beneficios = "Tuberculosis (formas invasivas)",
                            Eliminado = false,
                            Nombre = "BCG",
                            PeriodoAplicacion = 0
                        },
                        new
                        {
                            Id = 2,
                            Beneficios = "Hepatitis B",
                            Eliminado = false,
                            Nombre = "Hepatitis B HB",
                            PeriodoAplicacion = 0
                        },
                        new
                        {
                            Id = 3,
                            Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo",
                            Eliminado = false,
                            Nombre = "Neumococo Conjugada Primer Dosis",
                            PeriodoAplicacion = 2
                        },
                        new
                        {
                            Id = 4,
                            Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo",
                            Eliminado = false,
                            Nombre = "Neumococo Conjugada Segunda Dosis",
                            PeriodoAplicacion = 4
                        },
                        new
                        {
                            Id = 5,
                            Beneficios = "Previene la Meningitis,Neumonia y Sepsis por Neumococo",
                            Eliminado = false,
                            Nombre = "Neumococo Conjugada Refuerzo",
                            PeriodoAplicacion = 12
                        },
                        new
                        {
                            Id = 6,
                            Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b",
                            Eliminado = false,
                            Nombre = "Quintuple pentavalente DTP-HB-Hib Primer Dosis",
                            PeriodoAplicacion = 2
                        },
                        new
                        {
                            Id = 7,
                            Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b",
                            Eliminado = false,
                            Nombre = "Quintuple pentavalente DTP-HB-Hib Segunda Dosis",
                            PeriodoAplicacion = 4
                        },
                        new
                        {
                            Id = 8,
                            Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b",
                            Eliminado = false,
                            Nombre = "Quintuple pentavalente DTP-HB-Hib Tercer Dosis",
                            PeriodoAplicacion = 6
                        },
                        new
                        {
                            Id = 9,
                            Beneficios = "Poliovirus inactiva",
                            Eliminado = false,
                            Nombre = "Polio IPV Primer dosis",
                            PeriodoAplicacion = 2
                        },
                        new
                        {
                            Id = 10,
                            Beneficios = "Poliovirus inactiva",
                            Eliminado = false,
                            Nombre = "Polio IPV Segunda dosis",
                            PeriodoAplicacion = 4
                        },
                        new
                        {
                            Id = 11,
                            Beneficios = "Poliovirus inactiva",
                            Eliminado = false,
                            Nombre = "Polio IPV Tercer dosis",
                            PeriodoAplicacion = 6
                        },
                        new
                        {
                            Id = 12,
                            Beneficios = "Poliovirus inactiva",
                            Eliminado = false,
                            Nombre = "Polio IPV Refuerzo",
                            PeriodoAplicacion = 60
                        },
                        new
                        {
                            Id = 13,
                            Beneficios = "Rotavirus",
                            Eliminado = false,
                            Nombre = "Rotavirus Primer dosis",
                            PeriodoAplicacion = 2
                        },
                        new
                        {
                            Id = 14,
                            Beneficios = "Rotavirus",
                            Eliminado = false,
                            Nombre = "Rotavirus Segunda dosis",
                            PeriodoAplicacion = 4
                        },
                        new
                        {
                            Id = 15,
                            Beneficios = "Meningococo",
                            Eliminado = false,
                            Nombre = "Meningococo Primer dosis",
                            PeriodoAplicacion = 3
                        },
                        new
                        {
                            Id = 16,
                            Beneficios = "Meningococo",
                            Eliminado = false,
                            Nombre = "Meningococo Segunda dosis",
                            PeriodoAplicacion = 5
                        },
                        new
                        {
                            Id = 17,
                            Beneficios = "Meningococo",
                            Eliminado = false,
                            Nombre = "Meningococo Refuerzo dosis",
                            PeriodoAplicacion = 15
                        },
                        new
                        {
                            Id = 18,
                            Beneficios = "Meningococo",
                            Eliminado = false,
                            Nombre = "Meningococo Unica dosis",
                            PeriodoAplicacion = 132
                        },
                        new
                        {
                            Id = 19,
                            Beneficios = "Antigripal",
                            Eliminado = false,
                            Nombre = "Gripe",
                            PeriodoAplicacion = 12
                        },
                        new
                        {
                            Id = 20,
                            Beneficios = "Antigripal",
                            Eliminado = false,
                            Nombre = "Gripe",
                            PeriodoAplicacion = 24
                        },
                        new
                        {
                            Id = 21,
                            Beneficios = "HA Hepatitis A",
                            Eliminado = false,
                            Nombre = "Hepatitis A HA",
                            PeriodoAplicacion = 12
                        },
                        new
                        {
                            Id = 22,
                            Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas",
                            Eliminado = false,
                            Nombre = "Triple Viral SRP Primer Dosis",
                            PeriodoAplicacion = 12
                        },
                        new
                        {
                            Id = 23,
                            Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas",
                            Eliminado = false,
                            Nombre = "Triple Viral SRP Segunda Dosis",
                            PeriodoAplicacion = 60
                        },
                        new
                        {
                            Id = 24,
                            Beneficios = "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas",
                            Eliminado = false,
                            Nombre = "Triple Viral SRP Iniciar o Completar Esquema",
                            PeriodoAplicacion = 132
                        },
                        new
                        {
                            Id = 25,
                            Beneficios = "Varicela",
                            Eliminado = false,
                            Nombre = "Varicela",
                            PeriodoAplicacion = 15
                        },
                        new
                        {
                            Id = 26,
                            Beneficios = "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b",
                            Eliminado = false,
                            Nombre = "Cuadruple o Quintuple pentavalente DTP-HB-Hib Refuerzo",
                            PeriodoAplicacion = 15
                        },
                        new
                        {
                            Id = 27,
                            Beneficios = "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa",
                            Eliminado = false,
                            Nombre = "Triple Bacteriana Celular DTP",
                            PeriodoAplicacion = 60
                        },
                        new
                        {
                            Id = 28,
                            Beneficios = "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa",
                            Eliminado = false,
                            Nombre = "Triple Bacteriana Acelular dTpa",
                            PeriodoAplicacion = 132
                        },
                        new
                        {
                            Id = 29,
                            Beneficios = "Virus Papiloma Humano",
                            Eliminado = false,
                            Nombre = "Virus Papiloma Humano VPH",
                            PeriodoAplicacion = 132
                        },
                        new
                        {
                            Id = 30,
                            Beneficios = "dT (Doble Bacteriana) Difteria, Tetanos",
                            Eliminado = false,
                            Nombre = "Doble Bacteriana dT ADULTOS Refuerzo c/10 años",
                            PeriodoAplicacion = 120
                        },
                        new
                        {
                            Id = 31,
                            Beneficios = "SR: (Doble Viral) Sarampión, Rubeóla",
                            Eliminado = false,
                            Nombre = "Doble Viral SR o Triple Viral SRP Iniciar o completar esquema",
                            PeriodoAplicacion = 180
                        },
                        new
                        {
                            Id = 32,
                            Beneficios = "Fiebre Amarilla",
                            Eliminado = false,
                            Nombre = "Fiebre Amarilla FA",
                            PeriodoAplicacion = 18
                        },
                        new
                        {
                            Id = 33,
                            Beneficios = "Fiebre Amarilla",
                            Eliminado = false,
                            Nombre = "Fiebre Amarilla FA Refuerzo",
                            PeriodoAplicacion = 132
                        },
                        new
                        {
                            Id = 34,
                            Beneficios = "FHA: Fiebre Hemorragica Argentina",
                            Eliminado = false,
                            Nombre = "Fiebre Hemorrágica Argentina FHA",
                            PeriodoAplicacion = 180
                        });
                });

            modelBuilder.Entity("VacunDesktop.Models.VacunaColocada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("VacunaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("VacunaId");

                    b.ToTable("VacunasColocadas");
                });

            modelBuilder.Entity("VacunDesktop.Models.Calendario", b =>
                {
                    b.HasOne("VacunDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("VacunDesktop.Models.DetalleCalendario", b =>
                {
                    b.HasOne("VacunDesktop.Models.Calendario", "Calendario")
                        .WithMany("DetalleCalendarios")
                        .HasForeignKey("CalendarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacunDesktop.Models.Vacuna", "Vacuna")
                        .WithMany()
                        .HasForeignKey("VacunaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VacunDesktop.Models.Paciente", b =>
                {
                    b.HasOne("VacunDesktop.Models.Calendario", "Calendario")
                        .WithMany()
                        .HasForeignKey("CalendarioId");

                    b.HasOne("VacunDesktop.Models.Tutor", "Tutor")
                        .WithMany("Pacientes")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacunDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("VacunDesktop.Models.Tutor", b =>
                {
                    b.HasOne("VacunDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("VacunDesktop.Models.Usuario", b =>
                {
                    b.HasOne("VacunDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");
                });

            modelBuilder.Entity("VacunDesktop.Models.Vacuna", b =>
                {
                    b.HasOne("VacunDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("VacunDesktop.Models.VacunaColocada", b =>
                {
                    b.HasOne("VacunDesktop.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacunDesktop.Models.Vacuna", "Vacuna")
                        .WithMany()
                        .HasForeignKey("VacunaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
