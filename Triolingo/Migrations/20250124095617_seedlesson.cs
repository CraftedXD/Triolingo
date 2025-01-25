using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Triolingo.Migrations
{
    /// <inheritdoc />
    public partial class seedlesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd8cab6-ce6f-4659-b551-ba7e16fbc726", "AQAAAAIAAYagAAAAEFk88RWUFgqIDWc3JuBGy/fhvPUuA+1JxsDI1Rq7DdEjD+TUzYqfYOSyA1pKAXN19w==", "824994e9-374f-4214-87c2-b34c3a7fdd8f" });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "CreatedBy", "DateCreated", "DateUpdated", "LessonId", "Name", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2195), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2233), 0, "Japanese", "System", 0 },
                    { 2, "System", new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2234), 0, "Chinese", "System", 0 }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonId", "CreatedBy", "DateCreated", "DateUpdated", "LanguageId", "LessonContent", "LessonName", "LessonOrder", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2378), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2379), 1, "あ is pronounced like 'ah!' like when you come to a realization. It also sounds like the 'a' in 'car'.\nい is pronounced like the 'ee' in 'eel'.\nう is pronounced like theu in 'UNO' the card game, or the number one in Spanish.\nえ is pronounced like the e in 'egg'\nお is pronounced like you're saying 'oh.' It also sounds like the o in 'origami'.", "Japanese Lesson 1", 1, "System" },
                    { 2, "System", new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2380), new DateTime(2025, 1, 24, 17, 56, 16, 751, DateTimeKind.Local).AddTicks(2381), 1, "か is just the K sound plus あ, making a ka sound. It's pronounced like ka in 'karma.'\nき is just the K sound plus い, making a ki sound. It sounds ike the word 'key'\nく is just the K sound plus う, making a ku sound. It's pronounced 'coo' like both syllables of the word 'cuckoo'.\nけ is just the K sound plus え, making a ke sound. It's pronounced like ke in 'kelp.'\nこ is just the K sound plus お, making a ko sound. It's pronounced like co in 'coin'.", "Japanese Lesson 2", 2, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c594a423-4169-423d-9b10-d3264eeef3ab", "AQAAAAIAAYagAAAAEKH+d4pY3BI8HZhq2nNWCF9k/3kjRR2vT+OOgvgX4nAPgZLtw+ZxkXIpajIyx+Mahg==", "e7e9e163-6651-4f5a-b269-72b903efe1b0" });
        }
    }
}
