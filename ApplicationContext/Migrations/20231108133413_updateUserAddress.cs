using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUserAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 13, 34, 12, 850, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 11, 9, 13, 34, 12, 850, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "Address", "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { "tran quoc toan", 10, new byte[] { 219, 78, 69, 146, 130, 35, 112, 98, 173, 93, 70, 120, 182, 76, 5, 240, 170, 147, 128, 4, 99, 153, 255, 85, 209, 101, 156, 127, 86, 10, 128, 131, 44, 34, 64, 223, 42, 77, 155, 136, 182, 172, 192, 224, 54, 97, 243, 200, 144, 67, 51, 61, 37, 62, 146, 192, 213, 147, 140, 48, 92, 141, 5, 198 }, new byte[] { 109, 145, 44, 25, 213, 201, 190, 77, 171, 17, 138, 191, 48, 117, 46, 98, 106, 109, 235, 205, 5, 157, 84, 144, 147, 112, 78, 249, 57, 238, 82, 7, 97, 126, 70, 167, 94, 203, 176, 126, 97, 106, 221, 208, 200, 236, 98, 101, 203, 197, 145, 167, 109, 102, 114, 77, 210, 36, 109, 3, 169, 224, 75, 83, 81, 178, 209, 171, 55, 122, 214, 184, 169, 36, 22, 105, 12, 136, 105, 85, 49, 60, 30, 188, 123, 94, 144, 197, 16, 92, 103, 43, 131, 200, 136, 117, 147, 84, 45, 117, 51, 124, 200, 140, 231, 45, 195, 249, 77, 190, 63, 241, 41, 145, 121, 208, 158, 186, 226, 130, 133, 129, 180, 110, 114, 104, 49, 229 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "Address", "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Tran quoc toan", 10, new byte[] { 97, 190, 107, 23, 166, 45, 176, 18, 232, 188, 174, 143, 240, 184, 29, 107, 155, 193, 96, 50, 136, 245, 112, 175, 167, 92, 0, 104, 7, 135, 3, 217, 160, 235, 9, 66, 214, 183, 212, 141, 62, 40, 180, 48, 5, 79, 175, 141, 56, 141, 165, 200, 226, 84, 49, 208, 198, 151, 251, 146, 52, 213, 198, 19 }, new byte[] { 47, 241, 114, 179, 10, 251, 90, 120, 44, 16, 167, 25, 187, 33, 198, 68, 69, 6, 8, 29, 7, 179, 131, 32, 43, 164, 11, 166, 2, 68, 141, 34, 61, 124, 178, 241, 115, 7, 54, 248, 154, 76, 96, 5, 225, 105, 162, 64, 118, 113, 11, 190, 146, 197, 88, 46, 184, 166, 25, 54, 233, 131, 243, 109, 74, 249, 86, 59, 154, 211, 124, 134, 56, 251, 91, 218, 93, 74, 142, 247, 139, 122, 10, 160, 203, 171, 163, 183, 22, 22, 103, 39, 37, 127, 103, 153, 107, 176, 152, 152, 103, 158, 16, 172, 65, 201, 126, 229, 125, 134, 241, 89, 201, 151, 113, 235, 198, 2, 25, 99, 182, 15, 118, 50, 186, 231, 46, 43 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 8, 4, 47, 184, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 11, 9, 8, 4, 47, 184, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 206, 183, 202, 23, 4, 96, 58, 22, 210, 98, 245, 115, 190, 26, 77, 55, 112, 45, 220, 146, 238, 220, 147, 72, 120, 65, 216, 209, 127, 119, 81, 85, 227, 80, 64, 6, 254, 31, 228, 207, 117, 203, 182, 162, 118, 7, 57, 57, 187, 223, 202, 49, 176, 95, 109, 93, 41, 42, 21, 206, 129, 77, 25, 147 }, new byte[] { 236, 164, 195, 118, 28, 198, 244, 188, 246, 14, 22, 186, 176, 247, 24, 128, 116, 55, 163, 136, 24, 193, 106, 9, 131, 28, 23, 118, 209, 246, 185, 64, 92, 9, 51, 25, 81, 153, 95, 33, 92, 177, 174, 55, 89, 231, 55, 219, 61, 48, 101, 230, 193, 114, 22, 3, 119, 175, 66, 1, 75, 209, 255, 46, 70, 249, 241, 127, 97, 223, 61, 251, 124, 44, 138, 88, 150, 41, 27, 65, 6, 170, 8, 149, 6, 57, 123, 29, 6, 67, 105, 52, 35, 119, 175, 189, 108, 221, 192, 54, 114, 128, 224, 53, 93, 223, 226, 153, 196, 21, 243, 118, 134, 44, 184, 108, 120, 168, 44, 246, 195, 79, 157, 208, 83, 137, 112, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 253, 68, 239, 224, 6, 121, 157, 200, 217, 142, 79, 76, 51, 39, 153, 216, 173, 117, 181, 62, 250, 121, 95, 59, 71, 42, 158, 180, 158, 11, 228, 215, 158, 146, 88, 15, 204, 77, 214, 123, 218, 237, 234, 78, 76, 48, 204, 122, 62, 143, 37, 57, 191, 17, 199, 125, 118, 56, 228, 74, 81, 194, 153, 84 }, new byte[] { 237, 134, 16, 127, 55, 14, 203, 153, 44, 23, 30, 173, 110, 6, 199, 135, 32, 213, 57, 103, 225, 244, 108, 188, 110, 240, 179, 171, 2, 154, 212, 195, 202, 168, 36, 149, 89, 75, 127, 200, 58, 132, 150, 228, 61, 175, 155, 82, 178, 84, 190, 204, 143, 135, 218, 84, 66, 249, 43, 203, 90, 228, 161, 188, 37, 133, 211, 165, 181, 166, 228, 149, 100, 93, 219, 92, 75, 130, 34, 72, 241, 180, 90, 210, 193, 5, 214, 136, 15, 198, 138, 3, 252, 128, 230, 137, 218, 163, 65, 55, 59, 29, 197, 220, 244, 111, 154, 106, 241, 127, 58, 12, 74, 161, 47, 41, 92, 161, 9, 1, 61, 115, 215, 69, 18, 232, 43, 98 } });
        }
    }
}
