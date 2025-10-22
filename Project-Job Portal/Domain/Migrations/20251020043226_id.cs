using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "EmailVerifications");

            migrationBuilder.AddColumn<Guid>(
                name: "JobProviderId",
                table: "EmailVerifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerifications_JobProviderId",
                table: "EmailVerifications",
                column: "JobProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailVerifications_JobProviderCompany_JobProviderId",
                table: "EmailVerifications",
                column: "JobProviderId",
                principalTable: "JobProviderCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailVerifications_JobProviderCompany_JobProviderId",
                table: "EmailVerifications");

            migrationBuilder.DropIndex(
                name: "IX_EmailVerifications_JobProviderId",
                table: "EmailVerifications");

            migrationBuilder.DropColumn(
                name: "JobProviderId",
                table: "EmailVerifications");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "EmailVerifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
