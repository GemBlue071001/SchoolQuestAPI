using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateAttemptName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Attempts",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 8, 7, 58, 24, 903, DateTimeKind.Utc).AddTicks(3949), new DateTime(2023, 11, 9, 7, 58, 24, 903, DateTimeKind.Utc).AddTicks(3966), "bai kiem tra kien thuc xa hoi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 83, 219, 136, 105, 53, 54, 233, 106, 114, 173, 13, 39, 162, 252, 240, 37, 163, 102, 3, 195, 252, 91, 164, 94, 11, 205, 90, 226, 165, 195, 194, 74, 88, 150, 66, 212, 17, 222, 27, 160, 243, 103, 223, 229, 131, 240, 72, 176, 43, 142, 255, 127, 198, 188, 201, 119, 157, 234, 39, 13, 82, 175, 113 }, new byte[] { 181, 101, 88, 232, 52, 8, 222, 155, 97, 237, 200, 20, 234, 131, 4, 28, 132, 88, 239, 249, 207, 104, 22, 228, 192, 109, 140, 16, 159, 139, 94, 214, 182, 251, 59, 254, 62, 82, 84, 2, 145, 214, 225, 124, 75, 40, 200, 243, 174, 0, 35, 17, 193, 238, 216, 57, 224, 136, 244, 188, 24, 92, 140, 40, 104, 60, 136, 72, 86, 223, 206, 199, 177, 59, 245, 149, 146, 238, 74, 255, 83, 191, 200, 81, 160, 219, 149, 217, 206, 178, 188, 23, 62, 175, 172, 65, 7, 120, 145, 128, 113, 168, 131, 48, 14, 186, 14, 243, 125, 89, 122, 64, 124, 62, 71, 114, 42, 124, 117, 245, 42, 60, 199, 158, 86, 42, 250, 187 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Attempts");

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 16, 215, 94, 93, 222, 250, 194, 157, 119, 224, 216, 114, 127, 97, 57, 238, 242, 78, 61, 243, 62, 92, 220, 12, 117, 42, 202, 169, 116, 111, 135, 56, 137, 189, 235, 110, 5, 241, 10, 49, 244, 105, 244, 61, 240, 245, 243, 150, 170, 173, 126, 223, 127, 86, 103, 213, 120, 222, 249, 101, 102, 64, 222 }, new byte[] { 225, 136, 196, 118, 124, 196, 117, 151, 148, 222, 217, 114, 56, 148, 108, 1, 151, 129, 92, 241, 13, 59, 252, 227, 180, 191, 54, 28, 229, 120, 108, 7, 215, 93, 32, 138, 209, 57, 6, 1, 78, 191, 233, 23, 86, 191, 45, 46, 16, 211, 12, 213, 112, 112, 32, 54, 84, 132, 115, 129, 33, 62, 189, 182, 104, 212, 47, 99, 180, 222, 171, 239, 40, 115, 174, 161, 177, 112, 235, 85, 65, 37, 239, 157, 161, 26, 250, 138, 170, 69, 146, 39, 227, 83, 151, 201, 57, 180, 118, 69, 158, 154, 130, 59, 125, 83, 181, 115, 102, 213, 18, 23, 118, 121, 15, 133, 87, 121, 210, 237, 213, 49, 185, 82, 165, 72, 148, 198 } });
        }
    }
}
