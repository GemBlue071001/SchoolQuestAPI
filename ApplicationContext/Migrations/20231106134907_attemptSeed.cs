using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class attemptSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"), null, "student@gmail.com", "Nguyen", false, "Vu", null, null, new byte[] { 9, 3, 111, 145, 72, 11, 57, 171, 133, 59, 247, 141, 175, 27, 13, 70, 124, 222, 144, 78, 17, 6, 4, 25, 20, 174, 182, 242, 251, 210, 48, 158, 145, 232, 57, 132, 104, 177, 196, 8, 108, 124, 228, 213, 244, 206, 21, 144, 246, 182, 185, 105, 23, 191, 49, 151, 212, 254, 30, 210, 66, 173, 190, 220 }, new byte[] { 39, 162, 234, 103, 228, 112, 214, 53, 253, 200, 154, 227, 70, 25, 141, 13, 113, 154, 75, 67, 65, 41, 94, 247, 206, 246, 125, 217, 214, 64, 237, 160, 56, 198, 241, 24, 45, 169, 35, 54, 194, 176, 22, 73, 5, 155, 3, 63, 171, 240, 150, 133, 251, 246, 168, 251, 77, 146, 165, 249, 63, 215, 75, 103, 81, 239, 151, 128, 131, 195, 60, 62, 201, 173, 8, 168, 183, 38, 99, 53, 64, 24, 103, 126, 85, 65, 197, 58, 166, 246, 129, 106, 188, 31, 193, 58, 51, 5, 215, 213, 223, 11, 229, 188, 131, 19, 53, 77, 102, 35, 136, 152, 88, 245, 209, 104, 88, 84, 95, 11, 165, 171, 183, 92, 113, 125, 201, 22 }, "1234567890", 1, "student1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"));
        }
    }
}
