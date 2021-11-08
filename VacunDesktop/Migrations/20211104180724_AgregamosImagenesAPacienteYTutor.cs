using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacunDesktop.Migrations
{
    public partial class AgregamosImagenesAPacienteYTutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Tutores",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Pacientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Pacientes");
        }
    }
}
