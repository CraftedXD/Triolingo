using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class cum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    CommunityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationTopic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conversation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.CommunityId);
                });

            migrationBuilder.CreateTable(
                name: "Scoreboard",
                columns: table => new
                {
                    ScoreboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalScore = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scoreboard", x => x.ScoreboardId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75777807-1b88-4aef-affe-09acd8ed7226", "AQAAAAIAAYagAAAAEHxTarkRmFAIuvP6CmG4l8jCpNI/ZyZstuDHYkOQO5+9MaevpmwzRXpm7Wdzh7KaEA==", "1773e1a7-8968-41a9-ac82-e261c3998dd3" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1414), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1447), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1711), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1726), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2115), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2119), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2124), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2128), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2147), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2156), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2161), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2165), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2170), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2180), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2184), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2188), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2193), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1920), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1926), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1930), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1934), new DateTime(2025, 1, 30, 14, 17, 35, 573, DateTimeKind.Local).AddTicks(1935) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "Scoreboard");

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

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8477), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 1, 26, 15, 47, 51, 938, DateTimeKind.Local).AddTicks(8480) });
        }
    }
}
