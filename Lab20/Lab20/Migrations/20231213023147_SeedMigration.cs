using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab20.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, "Introduction to Mathematics", new DateOnly(2024, 3, 13), "Mathematics", 100f, new DateOnly(2023, 12, 13) },
                    { 2, "Fundamentals of Programming", new DateOnly(2024, 4, 13), "Computer Science", 150f, new DateOnly(2023, 12, 13) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "John Doe", "1234567890" },
                    { 2, "Jane Doe", "9876543210" }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, "Homework content 1", 0, 1, 1, new DateTime(2023, 12, 13, 4, 31, 46, 637, DateTimeKind.Local).AddTicks(8697) },
                    { 2, "Homework content 2", 1, 2, 2, new DateTime(2023, 12, 13, 4, 31, 46, 637, DateTimeKind.Local).AddTicks(8705) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Video Lecture 1", 0, "https://example.com/lecture1" },
                    { 2, 2, "Presentation Slide", 1, "https://example.com/presentation" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);
        }
    }
}
