using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApi.Migrations
{
    /// <inheritdoc />
    public partial class @in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_PostedByUserId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PostedByUserId",
                table: "Jobs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_PostedByUserId",
                table: "Jobs",
                newName: "IX_Jobs_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Jobs",
                newName: "PostedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                newName: "IX_Jobs_PostedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_PostedByUserId",
                table: "Jobs",
                column: "PostedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
