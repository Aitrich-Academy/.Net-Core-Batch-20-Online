using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class Loginsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_SystemUsers_SystemUserId",
                table: "AuthUser");

            migrationBuilder.DropIndex(
                name: "IX_AuthUser_SystemUserId",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "SystemUserId",
                table: "AuthUser");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser",
                column: "Id",
                principalTable: "SystemUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser");

            migrationBuilder.AddColumn<Guid>(
                name: "SystemUserId",
                table: "AuthUser",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AuthUser_SystemUserId",
                table: "AuthUser",
                column: "SystemUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_SystemUsers_SystemUserId",
                table: "AuthUser",
                column: "SystemUserId",
                principalTable: "SystemUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
