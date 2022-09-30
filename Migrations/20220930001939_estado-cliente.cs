using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeighbodFood2.Migrations
{
    public partial class estadocliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CLI_Estado",
                table: "Cliente",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CLI_Estado",
                table: "Cliente");
        }
    }
}
