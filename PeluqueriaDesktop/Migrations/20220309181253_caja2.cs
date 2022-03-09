using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class caja2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caja_DetalleTrabajos_DetalleTrabajosId",
                table: "Caja");

            migrationBuilder.DropIndex(
                name: "IX_Caja_DetalleTrabajosId",
                table: "Caja");

            migrationBuilder.DropColumn(
                name: "DetalleTrabajosId",
                table: "Caja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetalleTrabajosId",
                table: "Caja",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Caja_DetalleTrabajosId",
                table: "Caja",
                column: "DetalleTrabajosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caja_DetalleTrabajos_DetalleTrabajosId",
                table: "Caja",
                column: "DetalleTrabajosId",
                principalTable: "DetalleTrabajos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
