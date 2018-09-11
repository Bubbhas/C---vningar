using Microsoft.EntityFrameworkCore.Migrations;

namespace Samrai.Migrations
{
    public partial class Start7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeOfQuote",
                table: "Quotes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfQuote",
                table: "Quotes");
        }
    }
}
