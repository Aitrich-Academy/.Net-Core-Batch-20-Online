using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foreign_key.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "JobCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategory_CategoryId",
                table: "JobPosts",
                column: "CategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategory_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropTable(
                name: "JobCategory");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "JobPosts");
        }
    }
}
