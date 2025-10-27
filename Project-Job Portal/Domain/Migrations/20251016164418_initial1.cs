using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfileSkill_JobSeekerProfiles_JobSeekerProfileId",
                table: "JobSeekerProfileSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfileSkill_Skill_SkillId",
                table: "JobSeekerProfileSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerProfileSkill",
                table: "JobSeekerProfileSkill");

            migrationBuilder.RenameTable(
                name: "JobSeekerProfileSkill",
                newName: "JobSeekerProfileSkills");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerProfileSkill_SkillId",
                table: "JobSeekerProfileSkills",
                newName: "IX_JobSeekerProfileSkills_SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerProfileSkills",
                table: "JobSeekerProfileSkills",
                columns: new[] { "JobSeekerProfileId", "SkillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfileSkills_JobSeekerProfiles_JobSeekerProfileId",
                table: "JobSeekerProfileSkills",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfileSkills_Skill_SkillId",
                table: "JobSeekerProfileSkills",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfileSkills_JobSeekerProfiles_JobSeekerProfileId",
                table: "JobSeekerProfileSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfileSkills_Skill_SkillId",
                table: "JobSeekerProfileSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerProfileSkills",
                table: "JobSeekerProfileSkills");

            migrationBuilder.RenameTable(
                name: "JobSeekerProfileSkills",
                newName: "JobSeekerProfileSkill");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerProfileSkills_SkillId",
                table: "JobSeekerProfileSkill",
                newName: "IX_JobSeekerProfileSkill_SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerProfileSkill",
                table: "JobSeekerProfileSkill",
                columns: new[] { "JobSeekerProfileId", "SkillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfileSkill_JobSeekerProfiles_JobSeekerProfileId",
                table: "JobSeekerProfileSkill",
                column: "JobSeekerProfileId",
                principalTable: "JobSeekerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfileSkill_Skill_SkillId",
                table: "JobSeekerProfileSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
