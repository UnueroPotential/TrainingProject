using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingProject.Migrations
{
    public partial class Day2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationTab",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(maxLength: 20, nullable: true),
                    ApplicantPhoneNumber = table.Column<string>(maxLength: 15, nullable: true),
                    ApplicantEmail = table.Column<string>(maxLength: 15, nullable: true),
                    ApplicantAddress = table.Column<string>(maxLength: 100, nullable: true),
                    PositionApply = table.Column<string>(maxLength: 100, nullable: true),
                    DateApplied = table.Column<DateTime>(nullable: false),
                    ApplicationStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTab", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationTab");
        }
    }
}
