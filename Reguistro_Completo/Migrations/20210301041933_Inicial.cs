using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reguistro_Completo.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    PermisoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    DetallePermiso = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    VecesAsignado = table.Column<bool>(type: "INTEGER", nullable: false),
                    PermisosID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.PermisoID);
                    table.ForeignKey(
                        name: "FK_MyProperty_MyProperty_PermisosID",
                        column: x => x.PermisosID,
                        principalTable: "MyProperty",
                        principalColumn: "PermisoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    esActivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "RolesDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolID = table.Column<int>(type: "INTEGER", nullable: false),
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false),
                    esAsignado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Roles_RolID",
                        column: x => x.RolID,
                        principalTable: "Roles",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "INTEGER", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RolID = table.Column<string>(type: "TEXT", nullable: true),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_usuario_Roles_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Roles",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "PermisoID", "Descripcion", "DetallePermiso", "Nombre", "PermisosID", "VecesAsignado" },
                values: new object[] { 1, "Producto en venta", "Descuento", "Papita", null, false });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "PermisoID", "Descripcion", "DetallePermiso", "Nombre", "PermisosID", "VecesAsignado" },
                values: new object[] { 2, "Vendedor en puesto", "Venta", "Juan", null, false });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "PermisoID", "Descripcion", "DetallePermiso", "Nombre", "PermisosID", "VecesAsignado" },
                values: new object[] { 3, "Cobradora en turno", "Cobrar", "Paola", null, false });

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_PermisosID",
                table: "MyProperty",
                column: "PermisosID");

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_RolID",
                table: "RolesDetalle",
                column: "RolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropTable(
                name: "RolesDetalle");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
