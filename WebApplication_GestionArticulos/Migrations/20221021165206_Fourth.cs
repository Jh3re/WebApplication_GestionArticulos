using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_GestionArticulos.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_DetalleUsuario_DetalleUsuario_Id",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_DetalleUsuario_Id",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "DetalleUsuario_Id",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DetalleUsuario_Id",
                table: "Usuario",
                column: "DetalleUsuario_Id",
                unique: true,
                filter: "[DetalleUsuario_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_DetalleUsuario_DetalleUsuario_Id",
                table: "Usuario",
                column: "DetalleUsuario_Id",
                principalTable: "DetalleUsuario",
                principalColumn: "DetalleUsuario_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_DetalleUsuario_DetalleUsuario_Id",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_DetalleUsuario_Id",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "DetalleUsuario_Id",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DetalleUsuario_Id",
                table: "Usuario",
                column: "DetalleUsuario_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_DetalleUsuario_DetalleUsuario_Id",
                table: "Usuario",
                column: "DetalleUsuario_Id",
                principalTable: "DetalleUsuario",
                principalColumn: "DetalleUsuario_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
