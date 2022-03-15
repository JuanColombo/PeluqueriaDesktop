using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class Ultima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "Password", "TipoUsuario", "User", "UsuarioId", "UsuarioId1" },
                values: new object[] { 3, false, null, "Andrea Dellguste", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 1, "andrea", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "DetalleTrabajosId", "Eliminado", "FechaHoraEliminacion", "Nombre", "Telefono", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Valle", null, false, null, "Ivan Carlos", 3498459297.0, null },
                    { 2, "Colombo", null, false, null, "Juan Pablo", 3498463367.0, null }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Cantidad", "Codigo", "Descripcion", "Eliminado", "FechaHoraEliminacion", "Marca", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1.0, 3145.0, "Tintura color morado", false, null, "Avon", null },
                    { 2, 5.0, 10444584.0, "Shampoo manzana", false, null, "Plusbelle", null }
                });
        }
    }
}
