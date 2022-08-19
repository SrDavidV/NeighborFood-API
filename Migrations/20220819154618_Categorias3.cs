using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeighbodFood2.Migrations
{
    public partial class Categorias3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaPK_CategoriaID",
                table: "Plato",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaImagen",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plato_CategoriaPK_CategoriaID",
                table: "Plato",
                column: "CategoriaPK_CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Plato_Categoria_CategoriaPK_CategoriaID",
                table: "Plato",
                column: "CategoriaPK_CategoriaID",
                principalTable: "Categoria",
                principalColumn: "PK_CategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plato_Categoria_CategoriaPK_CategoriaID",
                table: "Plato");

            migrationBuilder.DropIndex(
                name: "IX_Plato_CategoriaPK_CategoriaID",
                table: "Plato");

            migrationBuilder.DropColumn(
                name: "CategoriaPK_CategoriaID",
                table: "Plato");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaImagen",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
