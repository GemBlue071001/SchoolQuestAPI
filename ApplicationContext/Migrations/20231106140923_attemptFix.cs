using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class attemptFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attempts",
                columns: new[] { "Id", "AttempType", "CreatedBy", "CreatedDate", "ExamDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Result", "Score", "UserId" },
                values: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), 0, null, new DateTime(2023, 11, 6, 14, 9, 22, 956, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 11, 7, 14, 9, 22, 956, DateTimeKind.Utc).AddTicks(1655), false, null, null, "Pass", 10, new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 179, 29, 245, 67, 124, 24, 47, 160, 144, 89, 241, 104, 246, 179, 218, 149, 49, 163, 156, 7, 78, 168, 214, 46, 227, 253, 105, 126, 24, 182, 11, 9, 151, 231, 225, 226, 67, 187, 137, 93, 79, 250, 39, 155, 109, 187, 230, 206, 54, 132, 124, 175, 8, 157, 251, 148, 187, 225, 214, 61, 93, 198, 17, 100 }, new byte[] { 31, 194, 36, 40, 148, 224, 16, 253, 195, 25, 64, 22, 2, 23, 98, 250, 21, 161, 172, 66, 121, 217, 238, 128, 198, 163, 39, 139, 60, 225, 81, 240, 244, 45, 206, 212, 72, 89, 239, 219, 104, 139, 237, 7, 228, 164, 149, 29, 120, 246, 199, 234, 219, 48, 62, 2, 188, 51, 213, 205, 140, 210, 180, 208, 151, 220, 181, 72, 99, 164, 115, 141, 226, 145, 21, 17, 47, 122, 79, 213, 53, 185, 189, 102, 214, 189, 185, 231, 61, 133, 67, 157, 122, 1, 156, 152, 10, 226, 108, 7, 72, 87, 122, 215, 28, 86, 51, 167, 60, 238, 179, 194, 222, 100, 230, 191, 195, 145, 87, 51, 136, 126, 29, 107, 13, 115, 214, 145 } });

            migrationBuilder.InsertData(
                table: "AttemptDetails",
                columns: new[] { "AttemptId", "ExaminationQuestionId", "IsCorrect", "UserAnswered" },
                values: new object[,]
                {
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("046b0f97-130a-48c7-b1ad-40033ae41fff"), true, "7" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("139c3a57-af40-4c80-96fc-508957db3780"), true, "London" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("2339983b-33db-4333-9b1b-a5514faa280a"), true, "1776-07-04" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), true, "Paris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttemptDetails",
                keyColumns: new[] { "AttemptId", "ExaminationQuestionId" },
                keyValues: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("046b0f97-130a-48c7-b1ad-40033ae41fff") });

            migrationBuilder.DeleteData(
                table: "AttemptDetails",
                keyColumns: new[] { "AttemptId", "ExaminationQuestionId" },
                keyValues: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("139c3a57-af40-4c80-96fc-508957db3780") });

            migrationBuilder.DeleteData(
                table: "AttemptDetails",
                keyColumns: new[] { "AttemptId", "ExaminationQuestionId" },
                keyValues: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("2339983b-33db-4333-9b1b-a5514faa280a") });

            migrationBuilder.DeleteData(
                table: "AttemptDetails",
                keyColumns: new[] { "AttemptId", "ExaminationQuestionId" },
                keyValues: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec") });

            migrationBuilder.DeleteData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 3, 111, 145, 72, 11, 57, 171, 133, 59, 247, 141, 175, 27, 13, 70, 124, 222, 144, 78, 17, 6, 4, 25, 20, 174, 182, 242, 251, 210, 48, 158, 145, 232, 57, 132, 104, 177, 196, 8, 108, 124, 228, 213, 244, 206, 21, 144, 246, 182, 185, 105, 23, 191, 49, 151, 212, 254, 30, 210, 66, 173, 190, 220 }, new byte[] { 39, 162, 234, 103, 228, 112, 214, 53, 253, 200, 154, 227, 70, 25, 141, 13, 113, 154, 75, 67, 65, 41, 94, 247, 206, 246, 125, 217, 214, 64, 237, 160, 56, 198, 241, 24, 45, 169, 35, 54, 194, 176, 22, 73, 5, 155, 3, 63, 171, 240, 150, 133, 251, 246, 168, 251, 77, 146, 165, 249, 63, 215, 75, 103, 81, 239, 151, 128, 131, 195, 60, 62, 201, 173, 8, 168, 183, 38, 99, 53, 64, 24, 103, 126, 85, 65, 197, 58, 166, 246, 129, 106, 188, 31, 193, 58, 51, 5, 215, 213, 223, 11, 229, 188, 131, 19, 53, 77, 102, 35, 136, 152, 88, 245, 209, 104, 88, 84, 95, 11, 165, 171, 183, 92, 113, 125, 201, 22 } });
        }
    }
}
