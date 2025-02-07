using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class techsupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7529e32-78d9-4cdc-a9d1-88bf6864b200", "AQAAAAIAAYagAAAAECzkd2BlCIKJeSq12y8sp+ftVx4Se6vLtoh4LIZp2rQ7Gds/tv0aNRstFpA53x9ZhA==", "2a28f2a8-6002-4dca-a1a5-241b6f777ca1" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(594), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(642), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1030), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1032), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1034), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1037), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1341), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1342), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1344), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1346), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1352), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1353), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1355), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1357), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1358), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1360), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1362), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1363), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1365), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1367), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1368), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1370), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1372), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1373), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1375), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1376), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1174), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1176), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1177), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1179), new DateTime(2025, 2, 5, 15, 32, 22, 532, DateTimeKind.Local).AddTicks(1179) });
        }
    }
}
