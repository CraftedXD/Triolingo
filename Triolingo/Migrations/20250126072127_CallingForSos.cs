using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class CallingForSos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserProgress",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ea731fc-9f88-42e7-a6cd-39d831ee31ef", "AQAAAAIAAYagAAAAEINIUxGCnpXR91lD/31BZypixnqHhe7lxETi7tS4qw7ndO+HTDYDFxliDrhfesqQ1A==", "03ef4514-ff5a-4586-82fc-6fe7e5381ea5" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5441), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5463), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5642), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5644), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonId", "CreatedBy", "DateCreated", "DateUpdated", "LanguageId", "LessonContent", "LessonName", "LessonOrder", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5646), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5646), 2, "一 is the number 1 in chinese and it's pronouced 'yī'\n二 is the number 2 in chinese and it's pronouced 'èr'\n三 in the number 3 in chinese it's pronouced 'sān'\n四 in the number 4 in chinese it's pronouced 'sì'\n五 in the number 4 in chinese it's pronouced 'wǔ'\n", "Chinese Lesson 1", 1, "System" },
                    { 4, "System", new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5647), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5648), 2, "六 is the number 6 in chinese and it's pronouced 'liù'\n七 is the number 7 in chinese and it's pronouced 'qī'\n八 in the number 8 in chinese it's pronouced 'bā'\n九 in the number 9 in chinese it's pronouced 'jiǔ'\n十 in the number 10 in chinese it's pronouced 'shí'\n", "Chinese Lesson 2", 2, "System" }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5836), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5839), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5842), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5844), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5846), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5847), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5849), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5851), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5853), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5746), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5748), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5748) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "UserProgress",
                table: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c08bf51d-072f-431d-8fca-8e9c46a990e0", "AQAAAAIAAYagAAAAEIS+Osw2sAI1daFZAcl97O9KgV7MeXn8wfPYOAf6j5w/rqQHsuGEeowbL7EJj0VhHw==", "cb694cd5-7618-4ec9-9a8d-16422d092023" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3459), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3462), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3624), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3626), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3630), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3635), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3637), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3640), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3642), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3540), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3542), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3542) });
        }
    }
}
