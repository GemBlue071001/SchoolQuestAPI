using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 3, 31, 17, 79, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 11, 9, 3, 31, 17, 79, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { 10, new byte[] { 15, 45, 206, 76, 15, 152, 4, 164, 242, 35, 187, 167, 64, 54, 143, 46, 161, 20, 154, 24, 78, 74, 220, 87, 49, 150, 19, 110, 9, 87, 110, 9, 192, 9, 44, 30, 19, 231, 198, 163, 105, 149, 74, 166, 230, 245, 214, 167, 53, 249, 76, 145, 28, 85, 181, 137, 49, 180, 64, 218, 77, 59, 253, 85 }, new byte[] { 31, 152, 26, 173, 176, 105, 158, 195, 90, 80, 96, 200, 7, 224, 167, 144, 189, 189, 175, 149, 194, 195, 255, 107, 87, 63, 254, 152, 156, 81, 73, 97, 83, 234, 159, 168, 21, 64, 42, 64, 43, 35, 27, 124, 243, 104, 112, 204, 198, 228, 158, 200, 197, 220, 135, 122, 66, 147, 3, 98, 8, 19, 230, 152, 101, 140, 174, 231, 58, 254, 163, 143, 32, 171, 211, 173, 44, 232, 9, 142, 228, 134, 128, 213, 189, 90, 69, 191, 97, 80, 49, 19, 105, 93, 90, 138, 251, 191, 235, 39, 55, 52, 193, 177, 7, 146, 190, 121, 245, 102, 93, 105, 75, 93, 47, 201, 7, 217, 141, 147, 6, 204, 1, 244, 95, 111, 70, 3 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 7, 14, 59, 26, 820, DateTimeKind.Utc).AddTicks(5503), new DateTime(2023, 11, 8, 14, 59, 26, 820, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 126, 16, 215, 94, 93, 222, 250, 194, 157, 119, 224, 216, 114, 127, 97, 57, 238, 242, 78, 61, 243, 62, 92, 220, 12, 117, 42, 202, 169, 116, 111, 135, 56, 137, 189, 235, 110, 5, 241, 10, 49, 244, 105, 244, 61, 240, 245, 243, 150, 170, 173, 126, 223, 127, 86, 103, 213, 120, 222, 249, 101, 102, 64, 222 }, new byte[] { 225, 136, 196, 118, 124, 196, 117, 151, 148, 222, 217, 114, 56, 148, 108, 1, 151, 129, 92, 241, 13, 59, 252, 227, 180, 191, 54, 28, 229, 120, 108, 7, 215, 93, 32, 138, 209, 57, 6, 1, 78, 191, 233, 23, 86, 191, 45, 46, 16, 211, 12, 213, 112, 112, 32, 54, 84, 132, 115, 129, 33, 62, 189, 182, 104, 212, 47, 99, 180, 222, 171, 239, 40, 115, 174, 161, 177, 112, 235, 85, 65, 37, 239, 157, 161, 26, 250, 138, 170, 69, 146, 39, 227, 83, 151, 201, 57, 180, 118, 69, 158, 154, 130, 59, 125, 83, 181, 115, 102, 213, 18, 23, 118, 121, 15, 133, 87, 121, 210, 237, 213, 49, 185, 82, 165, 72, 148, 198 } });
        }
    }
}
