using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_GestionArticulos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Categoria_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Categoria_Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleUsuario",
                columns: table => new
                {
                    DetalleUsuario_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mascota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleUsuario", x => x.DetalleUsuario_Id);
                });

            migrationBuilder.CreateTable(
                name: "Etiqueta",
                columns: table => new
                {
                    Etiqueta_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiqueta", x => x.Etiqueta_Id);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    Articulo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Calificacion = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Categoria_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.Articulo_Id);
                    table.ForeignKey(
                        name: "FK_Articulo_Categoria_Categoria_Id",
                        column: x => x.Categoria_Id,
                        principalTable: "Categoria",
                        principalColumn: "Categoria_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetalleUsuario_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_DetalleUsuario_DetalleUsuario_Id",
                        column: x => x.DetalleUsuario_Id,
                        principalTable: "DetalleUsuario",
                        principalColumn: "DetalleUsuario_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloEtiqueta",
                columns: table => new
                {
                    Articulo_Id = table.Column<int>(type: "int", nullable: false),
                    Etiqueta_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloEtiqueta", x => new { x.Etiqueta_Id, x.Articulo_Id });
                    table.ForeignKey(
                        name: "FK_ArticuloEtiqueta_Articulo_Articulo_Id",
                        column: x => x.Articulo_Id,
                        principalTable: "Articulo",
                        principalColumn: "Articulo_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticuloEtiqueta_Etiqueta_Etiqueta_Id",
                        column: x => x.Etiqueta_Id,
                        principalTable: "Etiqueta",
                        principalColumn: "Etiqueta_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloEtiqueta_Articulo_Id",
                table: "ArticuloEtiqueta",
                column: "Articulo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DetalleUsuario_Id",
                table: "Usuario",
                column: "DetalleUsuario_Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticuloEtiqueta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Etiqueta");

            migrationBuilder.DropTable(
                name: "DetalleUsuario");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
