using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baigiamasisdarbas.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_UserInfo_UserInfoId",
                table: "UserAddresses");

            migrationBuilder.RenameColumn(
                name: "UserInfoId",
                table: "UserAddresses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAddresses_UserInfoId",
                table: "UserAddresses",
                newName: "IX_UserAddresses_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Users_UserId",
                table: "UserAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Users_UserId",
                table: "UserAddresses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserAddresses",
                newName: "UserInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAddresses_UserId",
                table: "UserAddresses",
                newName: "IX_UserAddresses_UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_UserInfo_UserInfoId",
                table: "UserAddresses",
                column: "UserInfoId",
                principalTable: "UserInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
