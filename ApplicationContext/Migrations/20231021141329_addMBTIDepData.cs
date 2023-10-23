using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addMBTIDepData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MBTI_Department",
                columns: new[] { "DepartmentId", "MBTI_Id" },
                values: new object[,]
                {
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), 2 },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), 2 },
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MBTI_Department",
                keyColumns: new[] { "DepartmentId", "MBTI_Id" },
                keyValues: new object[] { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), 2 });

            migrationBuilder.DeleteData(
                table: "MBTI_Department",
                keyColumns: new[] { "DepartmentId", "MBTI_Id" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), 2 });

            migrationBuilder.DeleteData(
                table: "MBTI_Department",
                keyColumns: new[] { "DepartmentId", "MBTI_Id" },
                keyValues: new object[] { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), 9 });
        }
    }
}
