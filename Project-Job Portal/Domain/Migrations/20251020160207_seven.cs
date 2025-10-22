using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Interviews");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateScheduled",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateScheduled",
                table: "Interviews");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Interviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
