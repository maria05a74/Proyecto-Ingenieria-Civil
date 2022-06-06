using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class NUEVARELACIONCONCIUDADYDEPARTAMENTO3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_CiudadId",
                table: "proyectos",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos",
                column: "CiudadId",
                principalTable: "ciudades",
                principalColumn: "CiudadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos");

            migrationBuilder.DropIndex(
                name: "IX_proyectos_CiudadId",
                table: "proyectos");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "proyectos");
        }
    }
}
