using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class Caja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalCaja = table.Column<double>(nullable: false),
                    RetiroCaja = table.Column<double>(nullable: false),
                    DetalleTrabajosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caja_DetalleTrabajos_DetalleTrabajosId",
                        column: x => x.DetalleTrabajosId,
                        principalTable: "DetalleTrabajos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caja_DetalleTrabajosId",
                table: "Caja",
                column: "DetalleTrabajosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caja");
        }
    }
}
