using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class sendhelp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd850585-69c4-41c9-a567-7cf01f6d6981", "AQAAAAIAAYagAAAAELkQexTucEIawVqhwE4kRIcy03usThK2ojn5O/OHuQYrokBIShnzxUasE1J2LSMNIw==", "af337604-3883-41ed-86c5-712d7c22e9c7" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8188), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8286), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8288), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8375), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8378), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8562), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8564), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8566), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8567), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8569), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8571), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8573), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8574), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8576), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8578), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8579), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8581), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8583), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8584), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8586), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8588), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8589), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8591), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8593), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8594), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8474), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8476), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "QuizId", "CreatedBy", "DateCreated", "DateUpdated", "LessonId", "LevelDifficultly", "QuizTitle", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8477), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8478), 3, 1, "Chinese Quiz 1", "System" },
                    { 4, "System", new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8480), 4, 2, "Chinese Quiz 2", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9578), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9581), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9583), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9585), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9586), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9588), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9590), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9593), new DateTime(2025, 1, 26, 15, 45, 11, 411, DateTimeKind.Local).AddTicks(9594) });

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
    }
}
