using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class NUEVARELACIONCONCIUDADYDEPARTAMENTO4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "CiudadId",
                table: "proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos",
                column: "CiudadId",
                principalTable: "ciudades",
                principalColumn: "CiudadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "CiudadId",
                table: "proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_ciudades_CiudadId",
                table: "proyectos",
                column: "CiudadId",
                principalTable: "ciudades",
                principalColumn: "CiudadId");
        }
    }
}
