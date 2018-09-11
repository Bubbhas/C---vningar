using Microsoft.EntityFrameworkCore.Migrations;

namespace Samrai.Migrations
{
    public partial class Start25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvents_Battles_BattleId",
                table: "BattleEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs");

            migrationBuilder.DropIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "BattleEvents",
                newName: "BattleLogsId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEvents_BattleId",
                table: "BattleEvents",
                newName: "IX_BattleEvents_BattleLogsId");

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "BattleLogs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogsId",
                table: "BattleEvents",
                column: "BattleLogsId",
                principalTable: "BattleLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogsId",
                table: "BattleEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs");

            migrationBuilder.DropIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs");

            migrationBuilder.RenameColumn(
                name: "BattleLogsId",
                table: "BattleEvents",
                newName: "BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleEvents_BattleLogsId",
                table: "BattleEvents",
                newName: "IX_BattleEvents_BattleId");

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "BattleLogs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvents_Battles_BattleId",
                table: "BattleEvents",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
