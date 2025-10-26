using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class project : Migration
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
                name: "FK_JobApplications_Resume_Resume_id",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_Applicant",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Applicant",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "Datesubmitted",
                table: "JobApplications",
                newName: "DateSubmitted");

            migrationBuilder.RenameColumn(
                name: "Resume_id",
                table: "JobApplications",
                newName: "ResumeId");

            migrationBuilder.RenameColumn(
                name: "JobPost_id",
                table: "JobApplications",
                newName: "JobPostId");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "JobApplications",
                newName: "ApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_Resume_id",
                table: "JobApplications",
                newName: "IX_JobApplications_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPost_id",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_ApplicantId",
                table: "JobApplications",
                column: "ApplicantId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_ApplicantId",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "DateSubmitted",
                table: "JobApplications",
                newName: "Datesubmitted");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "JobApplications",
                newName: "Resume_id");

            migrationBuilder.RenameColumn(
                name: "JobPostId",
                table: "JobApplications",
                newName: "JobPost_id");

            migrationBuilder.RenameColumn(
                name: "ApplicantId",
                table: "JobApplications",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_ResumeId",
                table: "JobApplications",
                newName: "IX_JobApplications_Resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPostId",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPost_id");

            migrationBuilder.AddColumn<Guid>(
                name: "Applicant",
                table: "JobApplications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_Applicant",
                table: "JobApplications",
                column: "Applicant");

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
                name: "FK_JobApplications_Resume_Resume_id",
                table: "JobApplications",
                column: "Resume_id",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
