using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class NUEVARELACIONCONCIUDADYDEPARTAMENTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "proyectos");

            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "proyectos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "proyectos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "proyectos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
