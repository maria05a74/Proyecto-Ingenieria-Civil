using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class Cua1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "tipoClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tipoClientes_ClienteId",
                table: "tipoClientes",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_tipoClientes_clientes_ClienteId",
                table: "tipoClientes",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tipoClientes_clientes_ClienteId",
                table: "tipoClientes");

            migrationBuilder.DropIndex(
                name: "IX_tipoClientes_ClienteId",
                table: "tipoClientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "tipoClientes");
        }
    }
}
