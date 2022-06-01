using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrumWin21WebAPI.DAL.Migrations
{
    public partial class updateUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email_UserName",
                table: "Users",
                newName: "IX_Users_Email_Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email_Username",
                table: "Users",
                newName: "IX_Users_Email_UserName");
        }
    }
}
