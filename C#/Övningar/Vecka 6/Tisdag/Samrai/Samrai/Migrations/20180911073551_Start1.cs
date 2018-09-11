using Microsoft.EntityFrameworkCore.Migrations;

namespace Samrai.Migrations
{
    public partial class Start1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clan",
                table: "Samurais",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clan",
                table: "Samurais");
        }
    }
}
