using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class EndMySufferingPls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586baa4b-42d6-417f-a244-92b742e728fa", "AQAAAAIAAYagAAAAEJQXGsixBZxaGiFtL8nj11j8lXmwvQGmS0wso7h6/d16i/PEOUjYMPCMgdONqrdfFw==", "bf2d4c9d-2753-427e-83b7-593bf3935fff" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9135), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9167), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9346), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9348), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9352), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9559), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9562), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9564), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9565), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9567), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9569), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9571), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9572), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9574), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9576), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "CorrectAnswer", "CreatedBy", "DateCreated", "DateUpdated", "QuestionText", "QuizId", "UpdatedBy", "UserAnswer" },
                values: new object[,]
                {
                    { 11, "yi", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9578), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9578), "What is this Character? 一", 3, "System", "" },
                    { 12, "er", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9580), "What is this Character? 二", 3, "System", "" },
                    { 13, "san", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9581), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9582), "What is this Character? 三", 3, "System", "" },
                    { 14, "si", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9583), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9583), "What is this Character? 四", 3, "System", "" },
                    { 15, "wu", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9585), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9585), "What is this Character? 五", 3, "System", "" },
                    { 16, "liu", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9586), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9587), "What is this Character? 六", 4, "System", "" },
                    { 17, "qi", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9588), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9588), "What is this Character? 七", 4, "System", "" },
                    { 18, "ba", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9590), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9590), "What is this Character? 八", 4, "System", "" },
                    { 19, "jiu", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9592), "What is this Character? 九", 4, "System", "" },
                    { 20, "shi", "System", new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9593), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9594), "What is this Character? 十", 4, "System", "" }
                });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9464), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9466), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9467) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20);

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

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5646), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5647), new DateTime(2025, 1, 26, 15, 21, 26, 550, DateTimeKind.Local).AddTicks(5648) });

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
    }
}
