using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baigiamasisdarbas.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Users_UserId1",
                table: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_UserId1",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_UserId1",
                table: "UserInfo",
                column: "UserId1",
                unique: true,
                filter: "[UserId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Users_UserId1",
                table: "UserInfo",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
