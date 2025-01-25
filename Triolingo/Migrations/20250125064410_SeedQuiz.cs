using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f06958a9-9deb-4982-a0a7-17a87473bb0f", "AQAAAAIAAYagAAAAEDSCjxqfXnWiKMLG6G4456aF09hSVzbJWwTUS6/HpDbaM0C3Od70p3eN9cxGI3I7WA==", "eba985a6-7ecc-4897-972c-6f6b39996bdc" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(142), new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(161), new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(315), new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(317), new DateTime(2025, 1, 25, 14, 44, 9, 668, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "QuestionId", "CorrectAnswer", "CreatedBy", "DateCreated", "DateUpdated", "QuestionText", "QuizId", "UpdatedBy", "UserAnswer" },
                values: new object[,]
                {
                    { 1, "a", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? あ", 1, null, "" },
                    { 2, "i", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? い", 1, null, "" },
                    { 3, "u", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? う", 1, null, "" },
                    { 4, "e", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? え", 1, null, "" },
                    { 5, "o", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? お", 1, null, "" },
                    { 6, "ka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? か", 2, null, "" },
                    { 7, "ki", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? き", 2, null, "" },
                    { 8, "ku", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? く", 2, null, "" },
                    { 9, "ke", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? け", 2, null, "" },
                    { 10, "ko", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is this hiragana? こ", 2, null, "" }
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "QuizId", "CreatedBy", "DateCreated", "DateUpdated", "LessonId", "LevelDifficultly", "QuizTitle", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Japanese Quiz 1", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Japanese Quiz 2", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd8cab6-ce6f-4659-b551-ba7e16fbc726", "AQAAAAIAAYagAAAAEFk88RWUFgqIDWc3JuBGy/fhvPUuA+1JxsDI1Rq7DdEjD+TUzYqfYOSyA1pKAXN19w==", "824994e9-374f-4214-87c2-b34c3a7fdd8f" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2195), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2378), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2380), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2381) });
        }
    }
}
