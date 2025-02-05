using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class sendsoss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserScore",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserScore" },
                values: new object[] { "d7529e32-78d9-4cdc-a9d1-88bf6864b200", "AQAAAAIAAYagAAAAECzkd2BlCIKJeSq12y8sp+ftVx4Se6vLtoh4LIZp2rQ7Gds/tv0aNRstFpA53x9ZhA==", "2a28f2a8-6002-4dca-a1a5-241b6f777ca1", 0 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserScore",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f626070-7321-4d41-8d32-38c26faaaa1c", "AQAAAAIAAYagAAAAEJRu18XWiO0v5QPCO18GrsysHpBOldVP+4QBk36qP3TAzZ7sXGQSta1rK41A5UH5JA==", "97bf5b3b-f5b4-487c-aced-15973d0b7ed1" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(1729), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(1777), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2158), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2167), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2171), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2709), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2713), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2717), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2721), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2729), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2733), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2737), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2741), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2749), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2753), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2757), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2760), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2768), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2775), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2778), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2782), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2786), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2789), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2793), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2537), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2541), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2545), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2548), new DateTime(2025, 2, 5, 15, 27, 33, 139, DateTimeKind.Local).AddTicks(2549) });
        }
    }
}
