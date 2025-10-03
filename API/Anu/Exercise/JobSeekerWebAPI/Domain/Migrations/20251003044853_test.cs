using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedJobs_RegisterUsers_JobSeekerId",
                table: "AppliedJobs");

            migrationBuilder.DropIndex(
                name: "IX_AppliedJobs_JobSeekerId",
                table: "AppliedJobs");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "AppliedJobs");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedJobs_SavedBy",
                table: "AppliedJobs",
                column: "SavedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedJobs_RegisterUsers_SavedBy",
                table: "AppliedJobs",
                column: "SavedBy",
                principalTable: "RegisterUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedJobs_RegisterUsers_SavedBy",
                table: "AppliedJobs");

            migrationBuilder.DropIndex(
                name: "IX_AppliedJobs_SavedBy",
                table: "AppliedJobs");

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerId",
                table: "AppliedJobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppliedJobs_JobSeekerId",
                table: "AppliedJobs",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedJobs_RegisterUsers_JobSeekerId",
                table: "AppliedJobs",
                column: "JobSeekerId",
                principalTable: "RegisterUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
