using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeluqueriaDesktop.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Cantidad = table.Column<double>(nullable: false),
                    Codigo = table.Column<double>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleTrabajos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    DetalleTrabajo = table.Column<string>(nullable: false),
                    FormaDePago = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleTrabajos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleTrabajos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    DetalleTrabajosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_DetalleTrabajos_DetalleTrabajosId",
                        column: x => x.DetalleTrabajosId,
                        principalTable: "DetalleTrabajos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    TrabajoARealizar = table.Column<string>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turnos_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turnos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "Password", "TipoUsuario", "User", "UsuarioId", "UsuarioId1" },
                values: new object[,]
                {
                    { 1, false, null, "Ivan Valle", "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", 3, "ivan", null, null },
                    { 2, false, null, "Juan Pablo Colombo", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 3, "juan", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_DetalleTrabajosId",
                table: "Cliente",
                column: "DetalleTrabajosId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_UsuarioId",
                table: "Cliente",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTrabajos_ClienteId",
                table: "DetalleTrabajos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTrabajos_UsuarioId",
                table: "DetalleTrabajos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_UsuarioId",
                table: "Producto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_ClienteId",
                table: "Turnos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_UsuarioId",
                table: "Turnos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleTrabajos_Cliente_ClienteId",
                table: "DetalleTrabajos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_DetalleTrabajos_DetalleTrabajosId",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "DetalleTrabajos");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
