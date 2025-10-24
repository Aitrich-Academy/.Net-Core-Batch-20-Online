using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Resume_Resume_id",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_Resume_id",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Resume_id",
                table: "JobApplications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Resume_id",
                table: "JobApplications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_Resume_id",
                table: "JobApplications",
                column: "Resume_id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Resume_Resume_id",
                table: "JobApplications",
                column: "Resume_id",
                principalTable: "Resume",
                principalColumn: "Id");
        }
    }
}
