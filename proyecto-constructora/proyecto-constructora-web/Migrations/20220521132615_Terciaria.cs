using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class Terciaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoObra",
                table: "proyectos");

            migrationBuilder.AddColumn<int>(
                name: "TipoObraId",
                table: "proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_TipoObraId",
                table: "proyectos",
                column: "TipoObraId");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos",
                column: "TipoObraId",
                principalTable: "tipoObra",
                principalColumn: "TipodeObraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos");

            migrationBuilder.DropIndex(
                name: "IX_proyectos_TipoObraId",
                table: "proyectos");

            migrationBuilder.DropColumn(
                name: "TipoObraId",
                table: "proyectos");

            migrationBuilder.AddColumn<string>(
                name: "TipoObra",
                table: "proyectos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
