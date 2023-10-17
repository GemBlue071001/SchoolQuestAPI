using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class MBTIResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Attempts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Attempts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Attempts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "YH", null, null, "Các ngành y dược", false, null, null, "Y học", 27f },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "KT", null, null, "các ngành về kinh tế", false, null, null, "Kinh tế", 22f },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "TK", null, null, "Các ngành thiết kế/nghệ thuật", false, null, null, "Thiết kế", 22f },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "SP", null, null, "Các ngành sư phạm", false, null, null, "Sư phạm", 25f }
                });

            migrationBuilder.InsertData(
                table: "University",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"), "HCMUE", null, null, "Trường đại học công lập đào tạo sư phạm lớn nhất Việt Nam", false, null, null, "Đại học Sư phạm Thành phố Hồ Chí Minh" },
                    { new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), "UEH", null, null, "Trường đại học công lập đào tạo về kinh tế, tài chính, ngân hàng hàng đầu tại Việt Nam", false, null, null, "Đại học kinh tế TPHCM" },
                    { new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62"), "UMP", null, null, "Trường đại học công lập đào tạo về y dược lớn nhất Việt Nam", false, null, null, "Đại học Y Dược Thành phố Hồ Chí Minh" },
                    { new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"), "UAH", null, null, "Trường đại học công lập đào tạo về kiến trúc hàng đầu Việt Nam", false, null, null, "Đại học Kiến trúc Thành phố Hồ Chí Minh" },
                    { new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), "FPT", null, null, "Trường đại học tư thục hàng đầu Việt Nam về công nghệ thông tin và truyền thông.", false, null, null, "Đại học FPT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"));

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Attempts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Attempts");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Attempts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("5f68a389-ef79-4a8d-aa8e-1f6e944eb241"), "UI", null, null, "thiet ke giao dien web, mobile, game, content", false, null, null, "Do Hoa", 20f },
                    { new Guid("98b5de7d-6326-47ab-972e-9138c299f10e"), "SE", null, null, "lam ve may tinh", false, null, null, "Cong Nghe Thong Tin", 22f },
                    { new Guid("b120b5a0-5eac-4836-96ef-90b9834ea88a"), "GM", null, null, "lam ve game tren dien thoai", false, null, null, "Mobile Game", 23f }
                });
        }
    }
}
