using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addDepartmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("5f68a389-ef79-4a8d-aa8e-1f6e944eb241"), "UI", null, null, "thiet ke giao dien web, mobile, game, content", false, null, null, "Do Hoa", 20f },
                    { new Guid("98b5de7d-6326-47ab-972e-9138c299f10e"), "SE", null, null, "lam ve may tinh", false, null, null, "Cong Nghe Thong Tin", 22f },
                    { new Guid("b120b5a0-5eac-4836-96ef-90b9834ea88a"), "GM", null, null, "lam ve game tren dien thoai", false, null, null, "Mobile Game", 23f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "SE", null, null, "lam ve may tinh", false, null, null, "Cong Nghe Thong Tin", 22f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("5f68a389-ef79-4a8d-aa8e-1f6e944eb241"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("98b5de7d-6326-47ab-972e-9138c299f10e"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("b120b5a0-5eac-4836-96ef-90b9834ea88a"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"));
        }
    }
}
