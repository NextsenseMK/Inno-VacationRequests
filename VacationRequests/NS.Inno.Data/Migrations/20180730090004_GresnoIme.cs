using Microsoft.EntityFrameworkCore.Migrations;

namespace NS.Inno.Data.Migrations
{
    public partial class GresnoIme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacationDayss_Users_UserId",
                table: "VacationDayss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationDayss",
                table: "VacationDayss");

            migrationBuilder.RenameTable(
                name: "VacationDayss",
                newName: "VacationDays");

            migrationBuilder.RenameIndex(
                name: "IX_VacationDayss_UserId",
                table: "VacationDays",
                newName: "IX_VacationDays_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationDays",
                table: "VacationDays",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacationDays_Users_UserId",
                table: "VacationDays",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacationDays_Users_UserId",
                table: "VacationDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationDays",
                table: "VacationDays");

            migrationBuilder.RenameTable(
                name: "VacationDays",
                newName: "VacationDayss");

            migrationBuilder.RenameIndex(
                name: "IX_VacationDays_UserId",
                table: "VacationDayss",
                newName: "IX_VacationDayss_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationDayss",
                table: "VacationDayss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacationDayss_Users_UserId",
                table: "VacationDayss",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
