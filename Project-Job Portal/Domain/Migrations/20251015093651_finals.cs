using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class finals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop old FK first
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser");

            // 1️⃣ Add SystemUserId column as nullable (no default invalid Guid)
            migrationBuilder.AddColumn<Guid>(
                name: "SystemUserId",
                table: "AuthUser",
                type: "uniqueidentifier",
                nullable: true);

            // 2️⃣ Create index for SystemUserId
            migrationBuilder.CreateIndex(
                name: "IX_AuthUser_SystemUserId",
                table: "AuthUser",
                column: "SystemUserId",
                unique: true,
                filter: "[SystemUserId] IS NOT NULL");

            // 3️⃣ Add FK but allow nulls (and set null on delete)
            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_SystemUsers_SystemUserId",
                table: "AuthUser",
                column: "SystemUserId",
                principalTable: "SystemUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
