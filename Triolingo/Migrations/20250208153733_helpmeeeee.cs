using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class helpmeeeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ChineseProgress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserProgress" },
                values: new object[] { 100, "afaa0422-6d2a-4c59-807c-f1b70e0183ed", "AQAAAAIAAYagAAAAEDTHhwLOrRN9ccpO+1Pt5pJfgs+tozY+Joha14J+arw0TIbcdg8l4BIe5kl5DAiPjA==", "b8ce4ee5-796c-4947-a17d-393bf5590864", 100 });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9202), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9205), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9207), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9209), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9435), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9438), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9439), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9441), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9443), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9444), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9446), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9447), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9449), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9451), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9452), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9454), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9455), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9457), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9506), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9508), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9510), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9512), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9513), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9515), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9327), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9330), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9333), new DateTime(2025, 2, 8, 23, 37, 33, 576, DateTimeKind.Local).AddTicks(9333) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ChineseProgress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserProgress" },
                values: new object[] { 0, "6daf9262-353d-4d7e-af6d-af8e74d8a2fc", "AQAAAAIAAYagAAAAEKK0fRSMhPGMzBlNXIMjj047L+NP9tHgmPHltxH0/qGGPpV3+SsUc4pq/VqvvYbpfQ==", "f571b087-718c-4c93-8e9b-4df64d788812", 0 });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3348), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3361), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3467), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3469), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3472), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3586), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3587), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3588), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3591), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3595), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3596), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3597), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3598), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3600), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3601), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3605), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3606), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3607), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3610), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3611), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3528), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3530), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3531), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3532), new DateTime(2025, 2, 8, 21, 54, 19, 219, DateTimeKind.Local).AddTicks(3533) });
        }
    }
}
