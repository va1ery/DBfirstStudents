using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBfirstStudents.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "INT", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR (50)", nullable: true),
                    Credits = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "INT", nullable: false),
                    Grade = table.Column<int>(type: "INT", nullable: false),
                    CourseID = table.Column<int>(type: "INT", nullable: false),
                    StudentID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "INT", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR (50)", nullable: true),
                    FirstName = table.Column<string>(type: "NVARCHAR (50)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
