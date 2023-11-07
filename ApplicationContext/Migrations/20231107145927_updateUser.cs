using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HighestScore",
                table: "Users",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighestScore",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 6, 14, 9, 22, 956, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 11, 7, 14, 9, 22, 956, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 179, 29, 245, 67, 124, 24, 47, 160, 144, 89, 241, 104, 246, 179, 218, 149, 49, 163, 156, 7, 78, 168, 214, 46, 227, 253, 105, 126, 24, 182, 11, 9, 151, 231, 225, 226, 67, 187, 137, 93, 79, 250, 39, 155, 109, 187, 230, 206, 54, 132, 124, 175, 8, 157, 251, 148, 187, 225, 214, 61, 93, 198, 17, 100 }, new byte[] { 31, 194, 36, 40, 148, 224, 16, 253, 195, 25, 64, 22, 2, 23, 98, 250, 21, 161, 172, 66, 121, 217, 238, 128, 198, 163, 39, 139, 60, 225, 81, 240, 244, 45, 206, 212, 72, 89, 239, 219, 104, 139, 237, 7, 228, 164, 149, 29, 120, 246, 199, 234, 219, 48, 62, 2, 188, 51, 213, 205, 140, 210, 180, 208, 151, 220, 181, 72, 99, 164, 115, 141, 226, 145, 21, 17, 47, 122, 79, 213, 53, 185, 189, 102, 214, 189, 185, 231, 61, 133, 67, 157, 122, 1, 156, 152, 10, 226, 108, 7, 72, 87, 122, 215, 28, 86, 51, 167, 60, 238, 179, 194, 222, 100, 230, 191, 195, 145, 87, 51, 136, 126, 29, 107, 13, 115, 214, 145 } });
        }
    }
}
