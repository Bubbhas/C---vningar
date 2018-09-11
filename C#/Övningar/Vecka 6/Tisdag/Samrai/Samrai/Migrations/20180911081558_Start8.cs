using Microsoft.EntityFrameworkCore.Migrations;

namespace Samrai.Migrations
{
    public partial class Start8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HairCut",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairCut",
                table: "Samurais");
        }
    }
}
