using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class IlikeWomen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "PostedOn",
                table: "Community",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3209dffc-3638-44a9-b0ab-81ea487fcf93", "AQAAAAIAAYagAAAAEIW5VjUdFfQchV0sdNZaQebrf2wyqnHw+oaP8tIF4oc9AiC5MjwuX+WOC8+DA0U79g==", "fb9a81a5-a7c3-4800-8629-58f47b861619" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4547), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4567), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4739), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4741), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4743), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4745), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5022), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5026), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5028), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5029), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5031), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5034), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5037), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5040), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5042), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5043), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5045), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5046), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5048), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5049), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5052), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5054), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "QuestionId",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5056), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4869), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4871), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4872), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4874), new DateTime(2025, 2, 3, 11, 16, 46, 75, DateTimeKind.Local).AddTicks(4874) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostedOn",
                table: "Community");

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
    }
}
