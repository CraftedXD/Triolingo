using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class techsupportpls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "QuizResult",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "QuizResult");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dbb5621-cb95-4744-95b6-465be08afa05", "AQAAAAIAAYagAAAAEGm62rmMn1Js83tbw2jpc/NotxcBShZBlKWiFA8W0nnVHgn+S0uffrnfBsf/kzqqjQ==", "e7a61671-461f-48e5-a824-6db6bc2f289d" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(6780), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(6802), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7050), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7230), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7232), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7234), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7237), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7238), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7240), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7242), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7243), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7245), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7248), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7249), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7251), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7254), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7256), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7258), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7259), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7261), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7262), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7264), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7154), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 2, 7, 15, 25, 30, 886, DateTimeKind.Local).AddTicks(7157) });
        }
    }
}
