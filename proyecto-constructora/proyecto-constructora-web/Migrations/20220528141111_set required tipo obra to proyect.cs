using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class setrequiredtipoobratoproyect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoObraId",
                table: "proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos",
                column: "TipoObraId",
                principalTable: "tipoObra",
                principalColumn: "TipodeObraId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoObraId",
                table: "proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_proyectos_tipoObra_TipoObraId",
                table: "proyectos",
                column: "TipoObraId",
                principalTable: "tipoObra",
                principalColumn: "TipodeObraId");
        }
    }
}
