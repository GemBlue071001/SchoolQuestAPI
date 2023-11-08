using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 8, 4, 47, 184, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 11, 9, 8, 4, 47, 184, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 68, 239, 224, 6, 121, 157, 200, 217, 142, 79, 76, 51, 39, 153, 216, 173, 117, 181, 62, 250, 121, 95, 59, 71, 42, 158, 180, 158, 11, 228, 215, 158, 146, 88, 15, 204, 77, 214, 123, 218, 237, 234, 78, 76, 48, 204, 122, 62, 143, 37, 57, 191, 17, 199, 125, 118, 56, 228, 74, 81, 194, 153, 84 }, new byte[] { 237, 134, 16, 127, 55, 14, 203, 153, 44, 23, 30, 173, 110, 6, 199, 135, 32, 213, 57, 103, 225, 244, 108, 188, 110, 240, 179, 171, 2, 154, 212, 195, 202, 168, 36, 149, 89, 75, 127, 200, 58, 132, 150, 228, 61, 175, 155, 82, 178, 84, 190, 204, 143, 135, 218, 84, 66, 249, 43, 203, 90, 228, 161, 188, 37, 133, 211, 165, 181, 166, 228, 149, 100, 93, 219, 92, 75, 130, 34, 72, 241, 180, 90, 210, 193, 5, 214, 136, 15, 198, 138, 3, 252, 128, 230, 137, 218, 163, 65, 55, 59, 29, 197, 220, 244, 111, 154, 106, 241, 127, 58, 12, 74, 161, 47, 41, 92, 161, 9, 1, 61, 115, 215, 69, 18, 232, 43, 98 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "Email", "FirstName", "HighestScore", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), null, "admin@gmail.com", "admin", null, false, "admin", null, null, new byte[] { 206, 183, 202, 23, 4, 96, 58, 22, 210, 98, 245, 115, 190, 26, 77, 55, 112, 45, 220, 146, 238, 220, 147, 72, 120, 65, 216, 209, 127, 119, 81, 85, 227, 80, 64, 6, 254, 31, 228, 207, 117, 203, 182, 162, 118, 7, 57, 57, 187, 223, 202, 49, 176, 95, 109, 93, 41, 42, 21, 206, 129, 77, 25, 147 }, new byte[] { 236, 164, 195, 118, 28, 198, 244, 188, 246, 14, 22, 186, 176, 247, 24, 128, 116, 55, 163, 136, 24, 193, 106, 9, 131, 28, 23, 118, 209, 246, 185, 64, 92, 9, 51, 25, 81, 153, 95, 33, 92, 177, 174, 55, 89, 231, 55, 219, 61, 48, 101, 230, 193, 114, 22, 3, 119, 175, 66, 1, 75, 209, 255, 46, 70, 249, 241, 127, 97, 223, 61, 251, 124, 44, 138, 88, 150, 41, 27, 65, 6, 170, 8, 149, 6, 57, 123, 29, 6, 67, 105, 52, 35, 119, 175, 189, 108, 221, 192, 54, 114, 128, 224, 53, 93, 223, 226, 153, 196, 21, 243, 118, 134, 44, 184, 108, 120, 168, 44, 246, 195, 79, 157, 208, 83, 137, 112, 185 }, "1234567890", 0, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"));

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 7, 58, 24, 903, DateTimeKind.Utc).AddTicks(3949), new DateTime(2023, 11, 9, 7, 58, 24, 903, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 83, 219, 136, 105, 53, 54, 233, 106, 114, 173, 13, 39, 162, 252, 240, 37, 163, 102, 3, 195, 252, 91, 164, 94, 11, 205, 90, 226, 165, 195, 194, 74, 88, 150, 66, 212, 17, 222, 27, 160, 243, 103, 223, 229, 131, 240, 72, 176, 43, 142, 255, 127, 198, 188, 201, 119, 157, 234, 39, 13, 82, 175, 113 }, new byte[] { 181, 101, 88, 232, 52, 8, 222, 155, 97, 237, 200, 20, 234, 131, 4, 28, 132, 88, 239, 249, 207, 104, 22, 228, 192, 109, 140, 16, 159, 139, 94, 214, 182, 251, 59, 254, 62, 82, 84, 2, 145, 214, 225, 124, 75, 40, 200, 243, 174, 0, 35, 17, 193, 238, 216, 57, 224, 136, 244, 188, 24, 92, 140, 40, 104, 60, 136, 72, 86, 223, 206, 199, 177, 59, 245, 149, 146, 238, 74, 255, 83, 191, 200, 81, 160, 219, 149, 217, 206, 178, 188, 23, 62, 175, 172, 65, 7, 120, 145, 128, 113, 168, 131, 48, 14, 186, 14, 243, 125, 89, 122, 64, 124, 62, 71, 114, 42, 124, 117, 245, 42, 60, 199, 158, 86, 42, 250, 187 } });
        }
    }
}
