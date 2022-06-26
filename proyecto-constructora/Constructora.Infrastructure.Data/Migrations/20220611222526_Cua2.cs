using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    public partial class Cua2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TipoCliente",
                table: "clientes");

            migrationBuilder.AddColumn<int>(
                name: "TipoClienteId",
                table: "clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_TipoClienteId",
                table: "clientes",
                column: "TipoClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_tipoClientes_TipoClienteId",
                table: "clientes",
                column: "TipoClienteId",
                principalTable: "tipoClientes",
                principalColumn: "TipoClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_tipoClientes_TipoClienteId",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_clientes_TipoClienteId",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "TipoClienteId",
                table: "clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "tipoClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TipoCliente",
                table: "clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
