using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_GestionArticulos.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_Categoria_Id",
                table: "Articulo");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Etiqueta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Mascota",
                table: "DetalleUsuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Deporte",
                table: "DetalleUsuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Categoria_Id1",
                table: "Articulo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_Categoria_Id1",
                table: "Articulo",
                column: "Categoria_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id1",
                table: "Articulo",
                column: "Categoria_Id1",
                principalTable: "Categoria",
                principalColumn: "Categoria_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id1",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_Categoria_Id1",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Categoria_Id1",
                table: "Articulo");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Etiqueta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mascota",
                table: "DetalleUsuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deporte",
                table: "DetalleUsuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id",
                principalTable: "Categoria",
                principalColumn: "Categoria_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
