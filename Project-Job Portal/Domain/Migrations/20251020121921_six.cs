using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobCategory",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_CategoryId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Interviews");

            migrationBuilder.AddColumn<Guid>(
                name: "JobCategoryId",
                table: "JobPost",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost",
                column: "JobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobCategory_JobCategoryId",
                table: "JobPost",
                column: "JobCategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobCategory_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "JobPost");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "JobPost",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_CategoryId",
                table: "JobPost",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobCategory",
                table: "JobPost",
                column: "CategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
