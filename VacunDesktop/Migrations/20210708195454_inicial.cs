using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacunDesktop.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calendarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    SexoPaciente = table.Column<int>(nullable: false),
                    PrematuroPaciente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    PeriodoAplicacion = table.Column<int>(nullable: false),
                    Beneficios = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacunas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Prematuro = table.Column<bool>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    TutorId = table.Column<int>(nullable: false),
                    CalendarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Calendarios_CalendarioId",
                        column: x => x.CalendarioId,
                        principalTable: "Calendarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCalendarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarioId = table.Column<int>(nullable: false),
                    VacunaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCalendarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCalendarios_Calendarios_CalendarioId",
                        column: x => x.CalendarioId,
                        principalTable: "Calendarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCalendarios_Vacunas_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacunasColocadas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacunaId = table.Column<int>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunasColocadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacunasColocadas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacunasColocadas_Vacunas_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Calendarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "PrematuroPaciente", "SexoPaciente", "UsuarioId" },
                values: new object[,]
                {
                    { 1, false, null, "Calendario Varon", false, 1, null },
                    { 2, false, null, "Calendario Varon Prematuro", true, 1, null },
                    { 3, false, null, "Calendario Mujer", false, 2, null },
                    { 4, false, null, "Calendario Mujer Prematuro", true, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "Apellido", "Contraseña", "Eliminado", "Email", "FechaHoraEliminacion", "Nombre", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Carlos", "1234", false, "juancarlos1@gmail.com", null, "Juan", null },
                    { 2, "Picapiedra", "1234", false, "pedropicapiedra@gmail.com", null, "Pedro", null },
                    { 3, "Rodriguez", "1234", false, "enriquerodriguez@gmail.com", null, "Enrique", null },
                    { 4, "Martinez", "1234", false, "pepitomartinez@gmail.com", null, "Pepito", null }
                });

            migrationBuilder.InsertData(
                table: "Vacunas",
                columns: new[] { "Id", "Beneficios", "Eliminado", "FechaHoraEliminacion", "Nombre", "PeriodoAplicacion", "UsuarioId" },
                values: new object[,]
                {
                    { 19, "Antigripal", false, null, "Gripe", 12, null },
                    { 20, "Antigripal", false, null, "Gripe", 24, null },
                    { 21, "HA Hepatitis A", false, null, "Hepatitis A HA", 12, null },
                    { 22, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Primer Dosis", 12, null },
                    { 23, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Segunda Dosis", 60, null },
                    { 24, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Iniciar o Completar Esquema", 132, null },
                    { 25, "Varicela", false, null, "Varicela", 15, null },
                    { 29, "Virus Papiloma Humano", false, null, "Virus Papiloma Humano VPH", 132, null },
                    { 27, "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa", false, null, "Triple Bacteriana Celular DTP", 60, null },
                    { 28, "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa", false, null, "Triple Bacteriana Acelular dTpa", 132, null },
                    { 18, "Meningococo", false, null, "Meningococo Unica dosis", 132, null },
                    { 30, "dT (Doble Bacteriana) Difteria, Tetanos", false, null, "Doble Bacteriana dT ADULTOS Refuerzo c/10 años", 120, null },
                    { 31, "SR: (Doble Viral) Sarampión, Rubeóla", false, null, "Doble Viral SR o Triple Viral SRP Iniciar o completar esquema", 180, null },
                    { 32, "Fiebre Amarilla", false, null, "Fiebre Amarilla FA", 18, null },
                    { 26, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Cuadruple o Quintuple pentavalente DTP-HB-Hib Refuerzo", 15, null },
                    { 17, "Meningococo", false, null, "Meningococo Refuerzo dosis", 15, null },
                    { 13, "Rotavirus", false, null, "Rotavirus Primer dosis", 2, null },
                    { 15, "Meningococo", false, null, "Meningococo Primer dosis", 3, null },
                    { 1, "Tuberculosis (formas invasivas)", false, null, "BCG", 0, null },
                    { 2, "Hepatitis B", false, null, "Hepatitis B HB", 0, null },
                    { 3, "Previene la Meningitis,Neumonia y Sepsis por Neumococo", false, null, "Neumococo Conjugada Primer Dosis", 2, null },
                    { 4, "Previene la Meningitis,Neumonia y Sepsis por Neumococo", false, null, "Neumococo Conjugada Segunda Dosis", 4, null },
                    { 5, "Previene la Meningitis,Neumonia y Sepsis por Neumococo", false, null, "Neumococo Conjugada Refuerzo", 12, null },
                    { 6, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Primer Dosis", 2, null },
                    { 16, "Meningococo", false, null, "Meningococo Segunda dosis", 5, null },
                    { 7, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Segunda Dosis", 4, null },
                    { 9, "Poliovirus inactiva", false, null, "Polio IPV Primer dosis", 2, null },
                    { 10, "Poliovirus inactiva", false, null, "Polio IPV Segunda dosis", 4, null },
                    { 11, "Poliovirus inactiva", false, null, "Polio IPV Tercer dosis", 6, null },
                    { 12, "Poliovirus inactiva", false, null, "Polio IPV Refuerzo", 60, null },
                    { 33, "Fiebre Amarilla", false, null, "Fiebre Amarilla FA Refuerzo", 132, null },
                    { 14, "Rotavirus", false, null, "Rotavirus Segunda dosis", 4, null },
                    { 8, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Tercer Dosis", 6, null },
                    { 34, "FHA: Fiebre Hemorragica Argentina", false, null, "Fiebre Hemorrágica Argentina FHA", 180, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendarios_UsuarioId",
                table: "Calendarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCalendarios_CalendarioId",
                table: "DetalleCalendarios",
                column: "CalendarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCalendarios_VacunaId",
                table: "DetalleCalendarios",
                column: "VacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_CalendarioId",
                table: "Pacientes",
                column: "CalendarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_UsuarioId",
                table: "Tutores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vacunas_UsuarioId",
                table: "Vacunas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasColocadas_PacienteId",
                table: "VacunasColocadas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasColocadas_VacunaId",
                table: "VacunasColocadas",
                column: "VacunaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCalendarios");

            migrationBuilder.DropTable(
                name: "VacunasColocadas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropTable(
                name: "Calendarios");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
