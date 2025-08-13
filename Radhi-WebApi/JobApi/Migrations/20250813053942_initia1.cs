using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApi.Migrations
{
    /// <inheritdoc />
    public partial class initia1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostedByUserId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PostedByUserId",
                table: "Jobs",
                column: "PostedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_PostedByUserId",
                table: "Jobs",
                column: "PostedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_PostedByUserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PostedByUserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PostedByUserId",
                table: "Jobs");
        }
    }
}
