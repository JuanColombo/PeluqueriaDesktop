using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Cantidad",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Cantidad", "Codigo", "Descripcion", "Eliminado", "FechaHoraEliminacion", "Marca", "UsuarioId" },
                values: new object[] { 1, 1.0, 3145.0, "Tintura color morado", false, null, "Avon", null });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Cantidad", "Codigo", "Descripcion", "Eliminado", "FechaHoraEliminacion", "Marca", "UsuarioId" },
                values: new object[] { 2, 5.0, 10444584.0, "Shampoo manzana", false, null, "Plusbelle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Cantidad",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
