using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableResumeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobPost_JobPost_id",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_Applicant",
                table: "JobApplications");

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
                name: "Date",
                table: "Interviews");

            migrationBuilder.RenameColumn(
                name: "Datesubmitted",
                table: "JobApplications",
                newName: "DateSubmitted");

            migrationBuilder.RenameColumn(
                name: "JobPost_id",
                table: "JobApplications",
                newName: "JobPostId");

            migrationBuilder.RenameColumn(
                name: "Applicant",
                table: "JobApplications",
                newName: "ApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPost_id",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_Applicant",
                table: "JobApplications",
                newName: "IX_JobApplications_ApplicantId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Location",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Location",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Location",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Location",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePictureData",
                table: "JobProviderCompany",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApplicationDeadline",
                table: "JobPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "JobCategoryId",
                table: "JobPost",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "JobPost",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "JobPost",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "JobApplications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "JobApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateScheduled",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Mode",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobProviderId",
                table: "AuthUser",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_ResumeId",
                table: "JobApplications",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobPost_JobPostId",
                table: "JobApplications",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobSeekers_ApplicantId",
                table: "JobApplications",
                column: "ApplicantId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Resume_ResumeId",
                table: "JobApplications",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

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
                name: "FK_JobApplications_JobPost_JobPostId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_ApplicantId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Resume_ResumeId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobCategory_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_ResumeId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "ProfilePictureData",
                table: "JobProviderCompany");

            migrationBuilder.DropColumn(
                name: "ApplicationDeadline",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "DateScheduled",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "JobProviderId",
                table: "AuthUser");

            migrationBuilder.RenameColumn(
                name: "DateSubmitted",
                table: "JobApplications",
                newName: "Datesubmitted");

            migrationBuilder.RenameColumn(
                name: "JobPostId",
                table: "JobApplications",
                newName: "JobPost_id");

            migrationBuilder.RenameColumn(
                name: "ApplicantId",
                table: "JobApplications",
                newName: "Applicant");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPostId",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPost_id");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_ApplicantId",
                table: "JobApplications",
                newName: "IX_JobApplications_Applicant");

            migrationBuilder.AlterColumn<Guid>(
                name: "Location",
                table: "JobProviderCompany",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "JobPost",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Interviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_CategoryId",
                table: "JobPost",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobPost_JobPost_id",
                table: "JobApplications",
                column: "JobPost_id",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobSeekers_Applicant",
                table: "JobApplications",
                column: "Applicant",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
