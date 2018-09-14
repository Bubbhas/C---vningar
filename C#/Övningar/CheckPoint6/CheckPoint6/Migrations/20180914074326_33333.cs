using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint6.Migrations
{
    public partial class _33333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Spaceships_SpaceshipId",
                table: "Food");

            migrationBuilder.RenameColumn(
                name: "SpaceshipId",
                table: "Food",
                newName: "SpaceshipaId");

            migrationBuilder.RenameIndex(
                name: "IX_Food_SpaceshipId",
                table: "Food",
                newName: "IX_Food_SpaceshipaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Spaceships_SpaceshipaId",
                table: "Food",
                column: "SpaceshipaId",
                principalTable: "Spaceships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Spaceships_SpaceshipaId",
                table: "Food");

            migrationBuilder.RenameColumn(
                name: "SpaceshipaId",
                table: "Food",
                newName: "SpaceshipId");

            migrationBuilder.RenameIndex(
                name: "IX_Food_SpaceshipaId",
                table: "Food",
                newName: "IX_Food_SpaceshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Spaceships_SpaceshipId",
                table: "Food",
                column: "SpaceshipId",
                principalTable: "Spaceships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
