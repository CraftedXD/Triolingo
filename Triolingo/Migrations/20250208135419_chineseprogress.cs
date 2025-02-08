using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class chineseprogress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChineseProgress",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ChineseProgress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "6daf9262-353d-4d7e-af6d-af8e74d8a2fc", "AQAAAAIAAYagAAAAEKK0fRSMhPGMzBlNXIMjj047L+NP9tHgmPHltxH0/qGGPpV3+SsUc4pq/VqvvYbpfQ==", "f571b087-718c-4c93-8e9b-4df64d788812" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChineseProgress",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b065ee37-89df-4713-bbcb-01110bbc28d4", "AQAAAAIAAYagAAAAEOyfvTqi25Q8GJU0MWM20J6Dzht/1IvNOVd0UbWDIxi5BIUnYjzKYQILBGmme+q35w==", "cf0e2cb8-40c9-4e6c-a55f-2f8934ec4c60" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(358), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(361), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(569), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(572), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(576), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(583), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(588), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(590), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(591), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(593), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(594), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(596), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(597), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(599), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(600), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(602), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(466), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 2, 7, 15, 29, 40, 438, DateTimeKind.Local).AddTicks(469) });
        }
    }
}
