using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class DetalleTrabajos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleTrabajos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    clienteId = table.Column<int>(nullable: true),
                    DetalleTrabajo = table.Column<string>(nullable: false),
                    FormaDePago = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleTrabajos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleTrabajos_Cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTrabajos_clienteId",
                table: "DetalleTrabajos",
                column: "clienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleTrabajos");
        }
    }
}
