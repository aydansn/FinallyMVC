using Microsoft.EntityFrameworkCore.Migrations;

namespace FinallyMVC.Domain.Migrations
{
    public partial class skilltypeexperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillType",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceType",
                table: "Backgrounds",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillType",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ExperienceType",
                table: "Backgrounds");
        }
    }
}
