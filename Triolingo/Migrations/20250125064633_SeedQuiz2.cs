using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuiz2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3624), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3624), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3626), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3626), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3627), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3630), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3630), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3634), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3635), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3636), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3637), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3637), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3639), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3640), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3640), "System" });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3642), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3642), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3540), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3540), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3542), new DateTime(2025, 1, 25, 14, 46, 32, 572, DateTimeKind.Local).AddTicks(3542), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
