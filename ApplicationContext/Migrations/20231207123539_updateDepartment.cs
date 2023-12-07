using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredScore",
                table: "Department");

            migrationBuilder.AddColumn<float>(
                name: "RequiredScore",
                table: "UniversityDepartments",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 7, 12, 35, 38, 922, DateTimeKind.Utc).AddTicks(4072), new DateTime(2023, 12, 8, 12, 35, 38, 922, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), "DA", null, "Các ngành về điện ảnh-sân khấu", false, null, null, "Điện ảnh" },
                    { new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), "VH", null, "Các ngành về văn hóa", false, null, null, "Văn hóa" }
                });

            migrationBuilder.UpdateData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8"),
                column: "Code",
                value: "USH");

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("314a233c-a95f-4026-992a-75a708d07838") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("314a233c-a95f-4026-992a-75a708d07838") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("314a233c-a95f-4026-992a-75a708d07838") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("b9647f7b-e9a0-4636-80f9-45364c8b04a9") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") },
                column: "RequiredScore",
                value: 0f);

            migrationBuilder.InsertData(
                table: "UniversityDepartments",
                columns: new[] { "DepartmentId", "UniversityId", "CreatedBy", "CreatedDate", "Id", "IsDeleted", "ModifiedBy", "ModifiedDate", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72"), null, null, new Guid("65ee4308-6e91-4772-8009-be274a6ecced"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72"), null, null, new Guid("a943a4e3-7633-4990-9ecd-431d93bf2b71"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72"), null, null, new Guid("ce8bd0dc-c001-4586-bceb-7ee83abde2b3"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), null, null, new Guid("d41fdfa1-8429-46cf-9941-de8fae4281b2"), false, null, null, 0f },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), null, null, new Guid("3cfdd28f-1d05-4fe1-b934-3837fbe2eec9"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), null, null, new Guid("b4e33b7e-eadc-411b-97fb-46366844f73d"), false, null, null, 0f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), null, null, new Guid("2d4e9205-6c66-47d1-aa4d-2c7365e27b4c"), false, null, null, 0f },
                    { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), null, null, new Guid("fe9af913-73d2-4d3a-a189-e81ccea8c82e"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a"), null, null, new Guid("32470d5f-84cb-4b60-a744-ce6303b9b948"), false, null, null, 0f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a"), null, null, new Guid("3e3340a9-1416-41b4-8ee6-ee6023a78a7c"), false, null, null, 0f },
                    { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a"), null, null, new Guid("b5c79e2b-3b5f-4fdd-926c-8bef0e208811"), false, null, null, 0f },
                    { new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8"), null, null, new Guid("395ee7e1-c73b-432b-8ef2-011e98655c3d"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), null, null, new Guid("5b37cfac-ef3a-4862-9200-63a9b84d5a84"), false, null, null, 0f },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), null, null, new Guid("16009e9f-b6a5-48fd-850e-c4cd633b1e3f"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), null, null, new Guid("d6f7ed4c-57d1-4680-80a2-a42de8d4c16d"), false, null, null, 0f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), null, null, new Guid("f0b547f6-2f60-446f-a3cb-ad312af4fd55"), false, null, null, 0f },
                    { new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), null, null, new Guid("1e5e5710-cbe3-4ad7-91cb-5b9e1ff6a495"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("cd585229-73d4-4048-aac0-9dde7259fa5e"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("bb2d1988-7500-48ca-9ab5-aee3fca24deb"), false, null, null, 0f },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("17e0e068-e177-4c6b-9ce3-8e2913f534d4"), false, null, null, 0f },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("2ec0d13f-068f-4aa8-8022-c1c0ec394b07"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("c58937df-64bd-4f63-b998-27e5ba347b3c"), false, null, null, 0f },
                    { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), null, null, new Guid("a2398a84-25e4-4766-bade-27d1da1178ac"), false, null, null, 0f },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"), null, null, new Guid("ade3c37a-030e-4f43-810b-10688b7512a2"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"), null, null, new Guid("77263dce-bbcb-44ae-8b6d-adff278fe00b"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"), null, null, new Guid("a896dca0-76e5-4a96-8858-838a8b8114ab"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"), null, null, new Guid("f38136d0-5602-49a2-b8fd-da73e0a65c16"), false, null, null, 0f },
                    { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), null, null, new Guid("3bd0e623-e6d7-4792-a697-a6b8c6ca6797"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), null, null, new Guid("5ea0df8b-390c-47f5-92a4-75e2c66e0f2b"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), null, null, new Guid("aa7add7f-d344-4d73-bc0a-5e6ea6f42aa2"), false, null, null, 0f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), null, null, new Guid("5ac24503-c23b-4905-bf2c-6fb68c53e877"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), null, null, new Guid("66c58733-d8f0-4900-afd7-70a54246f773"), false, null, null, 0f },
                    { new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), new Guid("3fdd5b92-3e52-4434-8f21-176732be0cc1"), null, null, new Guid("065e10eb-73c1-4279-9082-2cad7c132c68"), false, null, null, 0f },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"), null, null, new Guid("a8f151e5-5c82-45ab-81a6-fd407298145f"), false, null, null, 0f },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"), null, null, new Guid("5c33610f-8629-484a-a1ba-2f7ed31e61ab"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"), null, null, new Guid("e6ca6917-c81e-4b05-b1f6-a4bc81d25a20"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"), null, null, new Guid("254b48e7-a1d9-47a3-b2da-e237c4f85244"), false, null, null, 0f },
                    { new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), new Guid("7d8960c2-ee10-4813-9522-106512a9b802"), null, null, new Guid("dcf16f10-8db3-4f2e-9625-de864300b443"), false, null, null, 0f },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("7d8960c2-ee10-4813-9522-106512a9b802"), null, null, new Guid("d483a375-8e79-4042-8724-68ff7cc9c33c"), false, null, null, 0f },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80"), null, null, new Guid("47896fae-da8b-41c3-a554-8a2405659199"), false, null, null, 0f },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80"), null, null, new Guid("9ba9d579-afc3-4123-8047-c981a145ff37"), false, null, null, 0f },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"), null, null, new Guid("94b6acfa-7225-4df2-bb2d-eb99e203e7a7"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"), null, null, new Guid("dd268132-4b4c-4d4f-b599-8b4ff5ac91a9"), false, null, null, 0f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"), null, null, new Guid("252df49b-dd26-4a31-aa0a-1a0bbf90cc6f"), false, null, null, 0f },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"), null, null, new Guid("611ba8a9-3e62-4f93-814c-34887d31174d"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa"), null, null, new Guid("e8e3d5f7-dd13-4ac1-acb3-e26e0be0009f"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa"), null, null, new Guid("806293ab-12c3-429c-8155-72740bc38d23"), false, null, null, 0f },
                    { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa"), null, null, new Guid("dd7d6a2a-285f-4f43-bd3e-eb6b117310c5"), false, null, null, 0f },
                    { new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f"), null, null, new Guid("852c8bf8-960c-4215-ab98-29077f50c08a"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f"), null, null, new Guid("1e93a09e-1d42-40c4-ae6e-a8971ef5f663"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f"), null, null, new Guid("a2f6ef18-44b0-476c-86f4-06a19fff80e1"), false, null, null, 0f },
                    { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), new Guid("b8620337-894a-4339-926e-dff2cd9f09ba"), null, null, new Guid("4a077579-638c-4bb5-b991-330d2972a5b5"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"), null, null, new Guid("c7070cd0-fe91-497c-8865-7bb6a104ba47"), false, null, null, 0f },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"), null, null, new Guid("071cfad3-f6a1-4bf3-8632-692f5e48e706"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"), null, null, new Guid("9db07138-e420-4be8-b9bf-3cdd043ca55f"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"), null, null, new Guid("8fa757e4-ef5b-4ad4-8162-b8c75e6ed1ba"), false, null, null, 0f },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"), null, null, new Guid("298ccff7-9a81-437c-8473-5a0333e8cae2"), false, null, null, 0f },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"), null, null, new Guid("fe787b7f-254f-4ed3-ae20-8f3c376d0efd"), false, null, null, 0f },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), null, null, new Guid("9b797f4c-6b7f-470a-bdcc-f3c7e6599985"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), null, null, new Guid("1bf38b36-9663-4368-8d61-e33d8606bd62"), false, null, null, 0f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), null, null, new Guid("da0dfcbb-e846-45a2-baf9-7ec9e8f52f3d"), false, null, null, 0f },
                    { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), null, null, new Guid("32c9fe4e-66f9-4d7b-847d-efa87a4642a3"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), null, null, new Guid("699ecb87-e496-4781-945d-8aeb5455cae1"), false, null, null, 0f },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), null, null, new Guid("b7a246b7-b1ec-418b-8d09-3049363a6104"), false, null, null, 0f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), null, null, new Guid("b34ccc66-d9c3-438b-b989-b9af063cca86"), false, null, null, 0f },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), null, null, new Guid("ea30506f-3ee8-438f-8f98-e5b73837e64d"), false, null, null, 0f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), null, null, new Guid("4e6e422f-3d85-45a0-891d-898a3b96e23b"), false, null, null, 0f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), null, null, new Guid("0f04c625-6886-4755-b7e4-8339df3a9a12"), false, null, null, 0f }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 84, 121, 7, 32, 176, 186, 146, 82, 44, 93, 139, 94, 21, 15, 220, 1, 43, 100, 74, 151, 196, 212, 229, 184, 232, 10, 151, 118, 66, 79, 223, 45, 66, 244, 93, 211, 114, 145, 235, 146, 7, 123, 9, 247, 134, 221, 71, 4, 91, 95, 111, 0, 6, 20, 139, 229, 55, 123, 172, 143, 161, 243, 144 }, new byte[] { 128, 20, 34, 211, 125, 141, 80, 149, 172, 189, 106, 209, 123, 190, 29, 143, 86, 238, 166, 230, 158, 18, 161, 182, 4, 43, 207, 42, 239, 235, 86, 73, 68, 55, 25, 211, 178, 215, 168, 146, 0, 32, 100, 251, 81, 163, 173, 203, 191, 86, 156, 164, 184, 170, 235, 37, 245, 212, 162, 214, 159, 131, 253, 138, 8, 142, 217, 83, 148, 7, 155, 53, 174, 83, 21, 105, 71, 64, 175, 125, 14, 148, 124, 83, 34, 9, 248, 165, 28, 17, 100, 9, 194, 11, 83, 216, 10, 68, 29, 190, 242, 141, 115, 131, 172, 137, 157, 177, 131, 177, 110, 156, 76, 65, 31, 192, 50, 119, 36, 227, 146, 100, 56, 18, 217, 1, 227, 200 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 154, 52, 201, 166, 143, 15, 183, 222, 25, 115, 62, 17, 191, 92, 112, 184, 17, 240, 74, 108, 202, 34, 149, 138, 89, 119, 52, 192, 52, 13, 126, 147, 18, 19, 85, 79, 162, 236, 210, 32, 127, 114, 40, 232, 199, 196, 134, 57, 165, 218, 225, 207, 60, 181, 147, 207, 15, 145, 21, 106, 62, 64, 77 }, new byte[] { 70, 32, 191, 133, 213, 121, 223, 30, 5, 230, 0, 159, 177, 223, 236, 167, 191, 204, 30, 75, 74, 126, 9, 39, 113, 62, 112, 162, 78, 254, 52, 252, 182, 169, 148, 63, 181, 179, 164, 147, 201, 102, 227, 171, 213, 124, 185, 208, 239, 246, 145, 166, 52, 37, 135, 68, 41, 124, 173, 145, 183, 230, 131, 169, 14, 151, 34, 59, 136, 111, 6, 107, 137, 66, 227, 10, 86, 77, 150, 104, 169, 63, 113, 21, 78, 236, 23, 61, 230, 142, 45, 17, 173, 142, 206, 107, 84, 85, 82, 176, 233, 82, 0, 64, 91, 208, 111, 34, 232, 101, 247, 57, 18, 127, 80, 103, 194, 107, 210, 231, 250, 173, 149, 42, 96, 250, 58, 84 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 61, 119, 43, 233, 98, 187, 182, 4, 182, 168, 163, 167, 122, 110, 7, 237, 165, 182, 48, 41, 176, 42, 250, 251, 139, 138, 119, 236, 252, 0, 127, 182, 134, 201, 196, 139, 236, 54, 136, 69, 174, 29, 94, 231, 194, 190, 196, 66, 210, 85, 128, 162, 128, 61, 226, 153, 57, 138, 37, 184, 5, 96, 252 }, new byte[] { 87, 32, 239, 139, 185, 100, 184, 208, 180, 162, 15, 1, 130, 78, 20, 107, 204, 46, 122, 33, 168, 17, 163, 105, 211, 8, 79, 124, 125, 178, 217, 74, 234, 10, 123, 186, 133, 234, 34, 134, 227, 96, 65, 137, 15, 119, 98, 139, 134, 239, 239, 240, 153, 243, 124, 7, 253, 29, 100, 73, 142, 203, 132, 162, 191, 72, 19, 101, 4, 11, 235, 233, 240, 131, 67, 250, 187, 130, 193, 199, 222, 3, 0, 30, 233, 106, 44, 56, 74, 87, 85, 133, 77, 160, 104, 215, 141, 18, 71, 20, 216, 82, 111, 141, 81, 227, 181, 83, 235, 239, 174, 130, 193, 216, 153, 44, 98, 245, 69, 175, 227, 149, 1, 215, 86, 182, 71, 210 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 15, 175, 115, 33, 21, 38, 101, 130, 23, 136, 31, 37, 146, 149, 100, 214, 120, 157, 148, 120, 11, 44, 180, 200, 142, 18, 176, 171, 79, 150, 137, 96, 2, 132, 109, 213, 109, 224, 55, 165, 188, 45, 122, 147, 55, 43, 40, 65, 111, 177, 136, 215, 147, 236, 203, 158, 230, 195, 32, 166, 71, 8, 9 }, new byte[] { 143, 177, 13, 146, 162, 230, 156, 40, 165, 95, 133, 199, 52, 255, 126, 158, 128, 234, 176, 43, 5, 143, 144, 235, 79, 245, 106, 225, 87, 34, 1, 198, 113, 185, 197, 190, 42, 23, 119, 176, 235, 28, 75, 0, 182, 245, 118, 44, 31, 253, 236, 183, 160, 56, 193, 82, 113, 188, 22, 123, 179, 29, 44, 163, 214, 8, 112, 243, 162, 6, 204, 130, 70, 40, 214, 146, 133, 59, 128, 5, 199, 141, 24, 178, 99, 251, 221, 113, 203, 149, 125, 81, 119, 238, 238, 67, 130, 216, 156, 178, 73, 105, 62, 44, 67, 201, 87, 22, 83, 101, 116, 8, 225, 228, 78, 146, 197, 232, 198, 111, 100, 42, 26, 254, 133, 179, 46, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 0, 63, 83, 103, 239, 134, 67, 227, 209, 113, 199, 105, 15, 145, 21, 87, 156, 238, 2, 100, 69, 243, 196, 0, 49, 20, 177, 179, 149, 60, 216, 169, 74, 216, 229, 78, 56, 255, 215, 2, 79, 140, 247, 43, 56, 39, 247, 180, 18, 203, 66, 93, 87, 230, 11, 196, 181, 161, 150, 102, 34, 29, 148, 101 }, new byte[] { 118, 161, 157, 95, 73, 15, 20, 134, 185, 234, 9, 109, 34, 128, 237, 248, 165, 245, 121, 54, 61, 229, 47, 23, 252, 239, 127, 55, 161, 224, 123, 250, 255, 125, 193, 10, 59, 185, 146, 31, 21, 189, 183, 251, 81, 134, 73, 184, 83, 150, 87, 218, 130, 193, 247, 159, 59, 245, 45, 202, 115, 85, 180, 165, 165, 225, 17, 124, 161, 193, 154, 154, 247, 108, 198, 183, 105, 31, 243, 169, 58, 82, 163, 144, 88, 231, 192, 125, 235, 227, 113, 226, 180, 252, 156, 96, 88, 87, 111, 251, 203, 79, 143, 138, 233, 45, 120, 10, 41, 200, 181, 90, 84, 159, 237, 40, 63, 57, 225, 135, 80, 235, 3, 25, 194, 190, 133, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 83, 100, 194, 175, 98, 124, 221, 21, 220, 250, 151, 204, 155, 180, 159, 141, 142, 45, 210, 132, 89, 254, 229, 145, 194, 101, 33, 58, 70, 106, 118, 128, 92, 47, 244, 208, 29, 138, 203, 182, 214, 27, 22, 233, 3, 141, 89, 248, 3, 163, 189, 82, 133, 163, 91, 51, 103, 19, 25, 172, 219, 1, 130 }, new byte[] { 16, 242, 84, 87, 66, 156, 225, 120, 234, 100, 152, 149, 138, 158, 25, 223, 27, 165, 233, 94, 116, 0, 124, 254, 178, 75, 218, 2, 10, 168, 152, 115, 175, 149, 69, 178, 74, 214, 146, 99, 12, 51, 104, 75, 152, 78, 180, 139, 109, 108, 148, 70, 51, 103, 130, 57, 153, 95, 122, 122, 0, 25, 41, 16, 96, 63, 123, 63, 151, 56, 31, 206, 222, 4, 73, 82, 127, 184, 38, 174, 88, 4, 165, 127, 12, 255, 100, 48, 46, 190, 41, 126, 183, 159, 19, 59, 115, 246, 29, 100, 118, 68, 117, 171, 2, 214, 227, 35, 101, 35, 29, 146, 204, 204, 30, 229, 246, 194, 3, 251, 168, 84, 72, 183, 104, 99, 76, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 85, 156, 133, 182, 252, 118, 110, 235, 3, 81, 112, 36, 27, 48, 74, 49, 5, 65, 255, 66, 125, 205, 85, 171, 224, 96, 22, 234, 61, 111, 140, 223, 47, 225, 152, 84, 133, 165, 101, 69, 147, 102, 24, 166, 231, 92, 169, 121, 160, 163, 35, 147, 200, 114, 244, 95, 207, 91, 64, 174, 117, 176, 205, 1 }, new byte[] { 224, 186, 248, 31, 171, 155, 222, 252, 55, 193, 8, 245, 187, 248, 146, 220, 64, 139, 137, 54, 185, 128, 207, 250, 188, 40, 18, 182, 134, 32, 203, 136, 193, 165, 98, 229, 156, 222, 189, 171, 32, 77, 199, 71, 131, 97, 248, 155, 58, 203, 46, 69, 188, 83, 214, 197, 65, 240, 102, 231, 17, 193, 14, 241, 133, 234, 229, 217, 32, 250, 62, 12, 250, 119, 99, 136, 213, 27, 186, 250, 58, 153, 52, 33, 165, 254, 198, 111, 200, 237, 233, 42, 130, 190, 208, 202, 40, 119, 244, 175, 100, 4, 178, 224, 4, 103, 46, 151, 227, 40, 83, 31, 67, 190, 203, 140, 119, 245, 254, 63, 201, 62, 203, 24, 204, 158, 11, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 33, 24, 161, 62, 156, 10, 48, 159, 229, 181, 103, 196, 238, 77, 251, 55, 181, 35, 53, 73, 19, 181, 12, 51, 46, 176, 8, 184, 24, 79, 63, 73, 124, 164, 36, 125, 128, 59, 143, 82, 229, 93, 158, 173, 156, 79, 85, 149, 117, 162, 13, 173, 226, 107, 100, 229, 163, 21, 249, 59, 210, 161, 79 }, new byte[] { 13, 168, 191, 13, 232, 46, 240, 81, 67, 52, 83, 52, 9, 27, 131, 114, 137, 13, 238, 12, 204, 230, 229, 160, 8, 170, 251, 91, 218, 188, 231, 218, 14, 205, 185, 145, 242, 95, 14, 180, 34, 117, 151, 195, 174, 106, 36, 161, 91, 229, 221, 173, 124, 12, 165, 47, 205, 57, 140, 133, 121, 234, 126, 249, 59, 255, 227, 93, 82, 211, 230, 153, 118, 113, 101, 177, 69, 250, 33, 63, 95, 168, 118, 133, 35, 9, 242, 97, 137, 107, 98, 220, 232, 122, 205, 113, 153, 253, 18, 191, 164, 119, 189, 254, 93, 82, 0, 107, 30, 153, 236, 239, 134, 96, 183, 209, 13, 130, 238, 235, 118, 114, 14, 152, 198, 254, 238, 99 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 253, 182, 229, 176, 140, 92, 18, 102, 97, 32, 140, 2, 193, 106, 107, 210, 74, 69, 81, 56, 14, 147, 176, 217, 255, 200, 99, 76, 61, 153, 194, 95, 25, 122, 232, 83, 60, 40, 197, 196, 254, 120, 226, 181, 161, 250, 157, 73, 210, 149, 165, 9, 92, 85, 21, 226, 195, 195, 144, 42, 4, 87, 93 }, new byte[] { 236, 172, 92, 169, 103, 138, 202, 44, 88, 24, 102, 99, 125, 188, 243, 182, 185, 201, 60, 150, 142, 171, 168, 192, 197, 172, 22, 187, 58, 177, 183, 177, 227, 60, 255, 196, 27, 212, 90, 240, 73, 115, 55, 156, 212, 154, 81, 183, 82, 85, 117, 97, 58, 95, 110, 170, 153, 199, 27, 54, 98, 40, 22, 136, 245, 61, 176, 125, 107, 55, 255, 33, 91, 52, 141, 201, 112, 58, 132, 101, 187, 24, 170, 75, 119, 197, 168, 78, 168, 175, 172, 225, 210, 44, 24, 103, 188, 62, 29, 169, 23, 0, 0, 67, 62, 52, 171, 249, 19, 138, 22, 251, 127, 244, 14, 81, 49, 80, 61, 224, 25, 176, 92, 155, 85, 113, 121, 69 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 102, 138, 136, 22, 249, 126, 196, 172, 33, 163, 37, 235, 30, 56, 101, 120, 44, 141, 8, 71, 107, 214, 131, 242, 194, 64, 11, 95, 127, 175, 149, 252, 26, 117, 233, 78, 63, 52, 160, 101, 128, 70, 154, 186, 172, 104, 141, 68, 69, 122, 231, 9, 113, 157, 82, 151, 27, 88, 237, 102, 247, 109, 133, 165 }, new byte[] { 184, 72, 74, 62, 179, 51, 125, 103, 64, 213, 159, 65, 249, 128, 142, 175, 96, 86, 27, 103, 67, 196, 22, 13, 224, 209, 82, 112, 118, 6, 171, 204, 12, 65, 180, 89, 15, 128, 4, 187, 186, 192, 148, 72, 166, 153, 200, 190, 50, 54, 97, 3, 27, 167, 101, 17, 121, 34, 169, 181, 142, 182, 36, 9, 127, 28, 107, 194, 171, 233, 114, 116, 242, 163, 191, 172, 65, 17, 22, 32, 228, 112, 25, 111, 122, 14, 149, 69, 59, 52, 90, 16, 15, 249, 96, 63, 13, 197, 159, 97, 245, 248, 134, 204, 89, 177, 254, 159, 66, 36, 167, 131, 162, 196, 204, 225, 245, 185, 53, 188, 214, 103, 93, 167, 43, 178, 53, 138 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 53, 21, 241, 169, 244, 247, 250, 175, 120, 170, 26, 101, 187, 147, 53, 193, 113, 170, 27, 164, 221, 52, 80, 50, 26, 178, 202, 233, 235, 168, 217, 21, 124, 57, 238, 214, 104, 9, 159, 10, 141, 14, 225, 227, 128, 72, 45, 21, 24, 4, 91, 5, 27, 174, 120, 24, 55, 242, 114, 213, 65, 75, 126, 50 }, new byte[] { 97, 126, 189, 34, 227, 239, 162, 89, 8, 135, 161, 217, 27, 208, 251, 190, 149, 230, 92, 51, 112, 151, 47, 21, 16, 145, 75, 240, 213, 236, 109, 144, 171, 4, 132, 173, 138, 73, 89, 197, 250, 140, 125, 49, 115, 47, 213, 75, 2, 91, 219, 134, 244, 252, 232, 94, 201, 114, 100, 90, 141, 105, 181, 177, 5, 90, 95, 83, 55, 83, 52, 242, 251, 199, 190, 124, 138, 231, 87, 95, 124, 13, 157, 141, 9, 207, 57, 54, 37, 132, 109, 123, 112, 55, 66, 231, 34, 1, 242, 29, 50, 204, 131, 5, 123, 124, 129, 203, 33, 233, 251, 110, 58, 146, 50, 217, 48, 252, 200, 33, 78, 88, 122, 229, 70, 215, 189, 220 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 143, 195, 31, 125, 38, 8, 123, 158, 26, 148, 68, 11, 23, 184, 25, 75, 234, 220, 18, 74, 130, 242, 122, 57, 152, 214, 171, 252, 163, 72, 184, 131, 5, 125, 56, 78, 135, 53, 19, 248, 153, 239, 29, 201, 192, 185, 30, 116, 1, 47, 167, 91, 173, 140, 44, 32, 36, 4, 83, 203, 10, 179, 180, 44 }, new byte[] { 66, 110, 6, 181, 74, 197, 113, 228, 242, 217, 169, 127, 177, 154, 234, 113, 179, 50, 108, 150, 212, 213, 43, 214, 88, 10, 22, 175, 60, 30, 151, 210, 67, 234, 213, 153, 71, 197, 71, 97, 22, 65, 245, 160, 226, 91, 129, 36, 24, 157, 3, 196, 226, 210, 67, 82, 241, 45, 113, 121, 163, 63, 167, 132, 130, 142, 78, 146, 143, 46, 237, 58, 162, 205, 220, 131, 169, 75, 219, 92, 28, 84, 28, 216, 4, 118, 5, 192, 139, 219, 122, 17, 138, 134, 90, 56, 218, 142, 91, 125, 97, 151, 189, 5, 156, 106, 49, 2, 164, 112, 50, 251, 190, 214, 86, 69, 179, 94, 191, 73, 238, 156, 137, 9, 48, 56, 91, 97 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 139, 157, 153, 170, 2, 14, 25, 65, 168, 230, 252, 73, 230, 30, 160, 205, 36, 36, 179, 209, 52, 254, 60, 241, 222, 5, 51, 143, 255, 143, 40, 246, 144, 230, 137, 148, 21, 199, 190, 46, 91, 177, 4, 91, 90, 41, 113, 6, 73, 155, 102, 4, 185, 11, 247, 157, 109, 189, 80, 94, 214, 182, 234 }, new byte[] { 182, 138, 10, 43, 57, 43, 110, 7, 13, 107, 78, 244, 235, 213, 123, 73, 6, 232, 91, 46, 250, 252, 176, 191, 88, 247, 120, 241, 24, 161, 41, 65, 2, 121, 93, 68, 183, 239, 245, 241, 30, 61, 221, 75, 144, 65, 252, 149, 86, 21, 75, 253, 129, 211, 143, 176, 251, 39, 34, 104, 241, 44, 145, 1, 226, 103, 203, 97, 215, 105, 50, 219, 102, 250, 232, 211, 99, 69, 112, 152, 94, 169, 70, 183, 29, 156, 3, 233, 234, 59, 130, 166, 106, 63, 118, 39, 154, 18, 127, 102, 211, 64, 4, 93, 200, 137, 224, 217, 239, 197, 75, 170, 73, 72, 33, 72, 136, 134, 89, 139, 228, 82, 143, 125, 190, 170, 207, 16 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 253, 200, 132, 251, 228, 171, 121, 139, 104, 137, 73, 185, 84, 220, 69, 93, 203, 205, 1, 158, 140, 153, 248, 176, 47, 2, 251, 200, 5, 182, 177, 148, 118, 254, 223, 106, 64, 20, 128, 120, 221, 44, 199, 249, 49, 195, 193, 111, 186, 46, 191, 106, 184, 249, 31, 141, 19, 14, 160, 231, 164, 27, 16 }, new byte[] { 51, 122, 115, 210, 177, 143, 133, 168, 248, 244, 17, 132, 139, 19, 186, 68, 29, 83, 240, 209, 201, 65, 173, 36, 178, 204, 177, 7, 242, 106, 174, 209, 3, 51, 121, 85, 154, 125, 62, 189, 49, 155, 234, 194, 41, 194, 85, 176, 218, 8, 101, 76, 38, 71, 22, 177, 236, 198, 125, 157, 46, 77, 172, 83, 47, 176, 34, 223, 178, 229, 27, 108, 1, 238, 75, 225, 204, 189, 8, 218, 226, 206, 253, 83, 59, 44, 90, 224, 194, 133, 99, 249, 202, 130, 112, 59, 162, 163, 152, 184, 197, 215, 33, 189, 92, 32, 143, 122, 171, 126, 33, 141, 192, 78, 153, 190, 180, 194, 178, 79, 204, 167, 176, 188, 121, 18, 44, 43 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 217, 64, 184, 88, 12, 168, 93, 35, 222, 221, 230, 173, 203, 176, 219, 165, 221, 253, 131, 64, 101, 246, 140, 136, 67, 32, 0, 140, 43, 203, 59, 42, 67, 160, 5, 231, 242, 93, 116, 1, 170, 171, 189, 219, 199, 16, 2, 141, 160, 165, 117, 239, 114, 152, 80, 39, 54, 143, 225, 207, 149, 52, 251 }, new byte[] { 77, 137, 121, 6, 192, 15, 214, 250, 240, 58, 66, 163, 33, 195, 127, 85, 67, 229, 153, 7, 143, 205, 52, 197, 87, 52, 205, 126, 68, 240, 75, 185, 216, 133, 89, 41, 188, 93, 190, 247, 228, 175, 241, 0, 51, 45, 5, 196, 169, 113, 60, 109, 249, 85, 253, 4, 239, 219, 43, 229, 115, 81, 247, 202, 18, 174, 20, 13, 254, 107, 6, 210, 126, 248, 35, 239, 123, 18, 11, 117, 153, 108, 36, 14, 187, 215, 110, 201, 38, 29, 228, 110, 153, 190, 30, 58, 192, 174, 235, 46, 66, 179, 249, 255, 36, 47, 187, 234, 18, 210, 171, 254, 161, 92, 249, 5, 117, 66, 122, 198, 12, 49, 13, 221, 6, 99, 222, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 26, 158, 100, 113, 109, 77, 216, 89, 220, 248, 241, 58, 223, 234, 78, 186, 230, 66, 245, 147, 206, 222, 129, 161, 228, 112, 56, 54, 31, 64, 29, 215, 210, 125, 97, 119, 67, 160, 1, 167, 136, 147, 87, 27, 33, 197, 231, 198, 146, 170, 183, 178, 96, 21, 16, 59, 96, 110, 195, 138, 52, 143, 118, 205 }, new byte[] { 56, 242, 189, 56, 0, 30, 116, 93, 43, 30, 210, 172, 136, 200, 162, 94, 121, 153, 154, 148, 70, 79, 124, 160, 209, 156, 252, 86, 41, 177, 202, 74, 28, 226, 41, 158, 27, 119, 124, 218, 245, 226, 247, 137, 139, 119, 82, 86, 70, 211, 112, 56, 81, 141, 78, 250, 119, 8, 251, 246, 88, 56, 46, 254, 123, 125, 55, 104, 115, 49, 227, 146, 48, 26, 72, 66, 16, 93, 164, 135, 82, 148, 145, 44, 183, 182, 204, 22, 126, 58, 7, 197, 94, 109, 3, 94, 20, 124, 246, 10, 58, 213, 148, 143, 216, 85, 183, 224, 42, 163, 209, 33, 252, 17, 107, 224, 236, 3, 155, 214, 60, 194, 0, 23, 165, 227, 53, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 170, 101, 20, 118, 19, 254, 140, 172, 51, 0, 58, 48, 188, 183, 12, 161, 249, 217, 233, 162, 243, 215, 91, 86, 7, 68, 55, 233, 246, 175, 157, 93, 62, 159, 191, 38, 208, 2, 57, 32, 1, 248, 155, 104, 53, 51, 140, 126, 2, 33, 12, 140, 28, 32, 142, 80, 196, 103, 128, 228, 152, 15, 67 }, new byte[] { 104, 236, 184, 165, 94, 171, 172, 146, 193, 42, 56, 0, 118, 255, 59, 236, 24, 42, 242, 119, 115, 9, 42, 113, 31, 145, 232, 129, 171, 183, 212, 183, 196, 88, 151, 104, 155, 238, 164, 236, 14, 112, 40, 166, 144, 21, 227, 40, 110, 15, 203, 95, 66, 201, 33, 22, 82, 236, 212, 23, 106, 35, 208, 0, 129, 131, 172, 198, 83, 38, 80, 201, 79, 66, 193, 181, 159, 25, 63, 202, 231, 26, 173, 140, 252, 191, 201, 160, 130, 120, 94, 127, 233, 70, 251, 206, 74, 47, 114, 167, 70, 233, 181, 228, 139, 62, 188, 238, 195, 228, 39, 194, 5, 54, 63, 84, 65, 220, 211, 197, 154, 171, 194, 59, 128, 188, 251, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 220, 224, 9, 188, 154, 173, 238, 212, 175, 67, 35, 220, 252, 76, 170, 126, 45, 155, 5, 144, 174, 241, 80, 218, 159, 219, 20, 194, 248, 238, 220, 21, 240, 144, 244, 13, 140, 80, 47, 213, 138, 129, 88, 224, 90, 72, 132, 2, 204, 31, 113, 152, 0, 88, 222, 201, 121, 47, 200, 38, 133, 128, 44, 76 }, new byte[] { 40, 161, 254, 182, 48, 37, 152, 170, 17, 11, 218, 163, 101, 107, 112, 138, 130, 180, 146, 0, 236, 123, 184, 186, 122, 143, 224, 85, 127, 73, 254, 141, 107, 103, 201, 166, 42, 245, 76, 166, 241, 168, 231, 199, 68, 134, 39, 121, 92, 120, 118, 30, 8, 111, 43, 30, 59, 85, 214, 66, 12, 58, 241, 187, 227, 165, 64, 127, 183, 251, 20, 5, 16, 72, 52, 219, 66, 24, 167, 29, 159, 160, 97, 87, 11, 38, 208, 173, 18, 52, 27, 69, 123, 125, 229, 213, 110, 206, 97, 66, 6, 98, 216, 135, 87, 143, 161, 6, 204, 199, 59, 178, 167, 164, 4, 124, 170, 6, 122, 155, 241, 151, 223, 156, 8, 64, 65, 237 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 122, 60, 5, 139, 47, 229, 52, 100, 111, 3, 129, 106, 206, 136, 68, 110, 21, 121, 18, 216, 150, 247, 193, 134, 106, 110, 158, 255, 88, 175, 29, 228, 22, 6, 83, 143, 133, 3, 6, 127, 14, 236, 144, 162, 58, 153, 135, 19, 31, 130, 61, 4, 202, 252, 179, 185, 213, 199, 220, 192, 189, 155, 21 }, new byte[] { 78, 140, 93, 223, 66, 96, 28, 96, 89, 7, 126, 149, 66, 190, 179, 244, 4, 63, 241, 212, 22, 8, 70, 181, 104, 125, 194, 230, 230, 241, 54, 115, 52, 67, 114, 224, 74, 20, 51, 253, 147, 207, 94, 153, 226, 32, 16, 254, 20, 51, 118, 165, 115, 13, 190, 55, 29, 43, 254, 255, 93, 65, 27, 178, 18, 205, 230, 171, 255, 39, 145, 134, 8, 163, 202, 170, 39, 227, 220, 141, 97, 154, 88, 44, 83, 118, 39, 248, 232, 13, 247, 185, 76, 168, 253, 21, 91, 186, 82, 114, 71, 241, 247, 112, 69, 161, 7, 240, 37, 149, 20, 121, 122, 62, 133, 135, 44, 254, 188, 1, 50, 133, 16, 107, 232, 226, 73, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 27, 6, 67, 89, 178, 196, 21, 7, 69, 194, 145, 143, 58, 148, 32, 211, 79, 169, 135, 239, 27, 231, 202, 64, 132, 140, 168, 12, 186, 111, 181, 78, 242, 237, 11, 174, 121, 214, 149, 26, 175, 3, 78, 211, 125, 114, 234, 224, 150, 237, 72, 12, 58, 193, 113, 20, 16, 130, 36, 19, 205, 54, 249, 17 }, new byte[] { 117, 225, 225, 246, 80, 103, 226, 16, 80, 40, 170, 226, 177, 5, 190, 60, 194, 197, 166, 186, 255, 201, 198, 171, 163, 139, 100, 98, 66, 192, 210, 162, 11, 102, 215, 7, 134, 169, 57, 65, 193, 153, 38, 168, 140, 73, 225, 109, 55, 192, 222, 127, 63, 220, 114, 151, 49, 86, 156, 40, 232, 72, 19, 3, 24, 122, 232, 135, 21, 250, 153, 153, 72, 179, 40, 1, 77, 246, 235, 200, 45, 18, 22, 128, 124, 202, 107, 136, 100, 69, 210, 34, 203, 133, 148, 110, 109, 42, 99, 52, 138, 127, 233, 103, 229, 181, 50, 188, 107, 27, 247, 162, 242, 251, 219, 50, 92, 144, 219, 151, 93, 71, 168, 27, 77, 141, 39, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 0, 229, 215, 59, 54, 98, 136, 234, 32, 160, 249, 126, 97, 179, 202, 129, 45, 170, 2, 117, 166, 107, 106, 72, 192, 231, 97, 144, 96, 146, 205, 127, 232, 20, 34, 41, 97, 134, 232, 232, 136, 161, 110, 185, 110, 130, 150, 88, 245, 237, 43, 100, 223, 74, 179, 137, 245, 170, 2, 31, 143, 96, 104, 157 }, new byte[] { 8, 73, 158, 13, 193, 203, 162, 167, 133, 0, 52, 179, 99, 162, 236, 108, 175, 208, 211, 74, 8, 70, 46, 86, 26, 15, 112, 203, 127, 54, 87, 64, 229, 176, 118, 130, 168, 193, 200, 176, 32, 3, 98, 96, 196, 103, 226, 176, 227, 120, 96, 53, 82, 199, 207, 196, 44, 235, 7, 159, 67, 229, 35, 157, 187, 15, 116, 181, 41, 53, 201, 184, 116, 130, 125, 45, 79, 108, 226, 89, 187, 44, 185, 26, 127, 206, 95, 0, 102, 114, 38, 66, 134, 140, 151, 26, 237, 255, 132, 35, 35, 202, 165, 58, 35, 99, 211, 186, 208, 106, 23, 159, 188, 187, 248, 13, 193, 159, 31, 77, 230, 202, 184, 70, 94, 154, 112, 89 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 161, 67, 50, 196, 155, 183, 103, 101, 53, 179, 99, 120, 22, 252, 192, 78, 94, 110, 119, 22, 248, 82, 15, 118, 123, 152, 117, 147, 180, 158, 88, 43, 57, 125, 242, 159, 49, 58, 119, 44, 6, 186, 213, 78, 236, 246, 146, 43, 191, 45, 127, 253, 9, 141, 204, 6, 23, 9, 110, 23, 121, 79, 183 }, new byte[] { 114, 45, 204, 95, 141, 238, 152, 152, 167, 228, 107, 95, 4, 144, 250, 241, 197, 8, 239, 146, 90, 223, 229, 197, 235, 26, 34, 143, 169, 89, 80, 58, 207, 162, 34, 121, 18, 135, 170, 174, 28, 207, 197, 181, 105, 122, 229, 105, 41, 216, 58, 149, 95, 55, 154, 80, 171, 254, 57, 171, 81, 200, 38, 144, 169, 251, 240, 86, 133, 42, 243, 210, 15, 171, 248, 132, 223, 105, 210, 216, 98, 171, 131, 122, 108, 212, 83, 215, 105, 254, 134, 233, 94, 230, 164, 35, 135, 51, 4, 173, 37, 219, 168, 96, 34, 16, 217, 89, 60, 10, 190, 176, 237, 86, 116, 227, 92, 156, 125, 228, 184, 32, 30, 221, 219, 129, 16, 42 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 185, 100, 106, 229, 74, 84, 176, 65, 172, 232, 78, 80, 83, 241, 51, 95, 227, 201, 14, 132, 239, 68, 16, 129, 233, 173, 219, 124, 238, 239, 22, 144, 96, 189, 203, 180, 215, 73, 234, 127, 51, 84, 64, 129, 79, 14, 70, 102, 20, 37, 255, 62, 155, 36, 8, 249, 39, 245, 168, 168, 22, 18, 176, 250 }, new byte[] { 2, 236, 1, 33, 210, 160, 174, 188, 140, 191, 108, 6, 1, 238, 130, 202, 53, 86, 66, 140, 113, 80, 249, 145, 72, 44, 92, 36, 229, 28, 165, 193, 246, 207, 42, 133, 162, 38, 195, 199, 247, 148, 150, 41, 26, 209, 194, 62, 161, 128, 216, 65, 152, 226, 231, 242, 36, 105, 227, 12, 200, 255, 243, 17, 178, 164, 241, 155, 183, 24, 55, 9, 114, 236, 19, 27, 108, 248, 169, 60, 235, 243, 46, 5, 76, 213, 86, 47, 9, 183, 201, 130, 247, 60, 174, 39, 26, 97, 154, 223, 126, 239, 49, 197, 90, 98, 112, 172, 108, 72, 226, 55, 32, 238, 33, 228, 197, 218, 212, 48, 99, 208, 232, 113, 40, 185, 223, 71 } });

            migrationBuilder.InsertData(
                table: "UniversityDepartments",
                columns: new[] { "DepartmentId", "UniversityId", "CreatedBy", "CreatedDate", "Id", "IsDeleted", "ModifiedBy", "ModifiedDate", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), new Guid("778c4103-05d3-4dab-9019-7196f6772dc8"), null, null, new Guid("7152be3b-19dc-47fa-b74c-3fe92044789d"), false, null, null, 0f },
                    { new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), new Guid("b8620337-894a-4339-926e-dff2cd9f09ba"), null, null, new Guid("0776c065-b631-4331-80bd-c87e7ca881db"), false, null, null, 0f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("059779f5-c84c-455a-85d0-798ca039ba72") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("166d0a24-7e52-45af-a795-d8e082d3749a") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), new Guid("253fca55-c797-4f1d-8c83-a66d81342921") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), new Guid("3fdd5b92-3e52-4434-8f21-176732be0cc1") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), new Guid("778c4103-05d3-4dab-9019-7196f6772dc8") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), new Guid("7d8960c2-ee10-4813-9522-106512a9b802") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("7d8960c2-ee10-4813-9522-106512a9b802") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), new Guid("abf76dc2-7086-4836-badb-a520e720caaa") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), new Guid("b8620337-894a-4339-926e-dff2cd9f09ba") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), new Guid("b8620337-894a-4339-926e-dff2cd9f09ba") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("ddb202ca-e224-48d6-a463-6b32ed962693") });

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"));

            migrationBuilder.DropColumn(
                name: "RequiredScore",
                table: "UniversityDepartments");

            migrationBuilder.AddColumn<float>(
                name: "RequiredScore",
                table: "Department",
                type: "real",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 5, 3, 4, 21, 677, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 12, 6, 3, 4, 21, 677, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"),
                column: "RequiredScore",
                value: 21f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"),
                column: "RequiredScore",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"),
                column: "RequiredScore",
                value: 23f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"),
                column: "RequiredScore",
                value: 27f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                column: "RequiredScore",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                column: "RequiredScore",
                value: 27f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"),
                column: "RequiredScore",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"),
                column: "RequiredScore",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                column: "RequiredScore",
                value: 23f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"),
                column: "RequiredScore",
                value: 30f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("934b3542-92d5-431c-9271-f39dedcac50f"),
                column: "RequiredScore",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                column: "RequiredScore",
                value: 26f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                column: "RequiredScore",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                column: "RequiredScore",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"),
                column: "RequiredScore",
                value: 27f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"),
                column: "RequiredScore",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"),
                column: "RequiredScore",
                value: 26f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"),
                column: "RequiredScore",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"),
                column: "RequiredScore",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"),
                column: "RequiredScore",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                column: "RequiredScore",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                column: "RequiredScore",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"),
                column: "RequiredScore",
                value: 26f);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                column: "RequiredScore",
                value: 24f);

            migrationBuilder.UpdateData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8"),
                column: "Code",
                value: "HUS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 192, 221, 131, 137, 193, 13, 58, 200, 171, 248, 166, 23, 185, 183, 126, 63, 144, 33, 139, 134, 160, 47, 148, 65, 68, 51, 7, 170, 223, 120, 120, 148, 252, 244, 229, 121, 115, 9, 197, 80, 121, 116, 12, 103, 37, 106, 58, 58, 127, 181, 182, 242, 2, 119, 215, 76, 66, 182, 12, 220, 49, 218, 38 }, new byte[] { 85, 24, 255, 93, 74, 90, 155, 70, 194, 186, 44, 123, 59, 162, 238, 151, 158, 230, 28, 150, 182, 107, 102, 17, 26, 209, 119, 43, 1, 110, 211, 141, 160, 130, 211, 46, 161, 99, 1, 27, 95, 46, 179, 117, 55, 208, 243, 206, 163, 104, 145, 153, 181, 229, 215, 19, 156, 239, 53, 50, 159, 29, 106, 79, 131, 111, 149, 40, 11, 21, 188, 97, 23, 42, 103, 252, 223, 219, 154, 210, 38, 48, 92, 108, 40, 30, 117, 171, 172, 176, 250, 119, 143, 246, 78, 98, 13, 111, 61, 199, 180, 78, 233, 23, 213, 46, 24, 241, 128, 155, 102, 229, 37, 215, 43, 33, 93, 94, 100, 6, 25, 241, 164, 145, 137, 239, 48, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 23, 73, 247, 21, 167, 7, 104, 197, 197, 239, 188, 21, 97, 131, 126, 11, 8, 51, 87, 51, 56, 74, 248, 238, 42, 14, 233, 103, 31, 55, 216, 21, 55, 53, 153, 186, 176, 28, 241, 1, 197, 90, 24, 210, 42, 203, 245, 156, 245, 108, 185, 201, 68, 214, 170, 54, 234, 205, 193, 88, 233, 205, 191 }, new byte[] { 77, 225, 165, 214, 30, 146, 69, 229, 132, 34, 127, 212, 158, 99, 187, 166, 77, 54, 9, 31, 122, 70, 62, 248, 150, 236, 177, 49, 156, 88, 19, 65, 43, 209, 111, 18, 212, 216, 156, 53, 54, 168, 225, 185, 57, 135, 102, 67, 86, 102, 218, 97, 177, 253, 38, 83, 178, 69, 153, 204, 65, 4, 175, 87, 196, 104, 23, 13, 191, 205, 20, 79, 147, 152, 77, 232, 81, 67, 124, 159, 23, 190, 38, 127, 29, 140, 50, 165, 211, 18, 18, 33, 102, 6, 70, 194, 42, 1, 7, 163, 7, 53, 35, 123, 152, 33, 42, 3, 94, 5, 101, 149, 115, 26, 239, 63, 227, 118, 135, 81, 7, 104, 230, 97, 5, 177, 134, 157 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 56, 115, 38, 103, 229, 228, 61, 189, 115, 46, 55, 184, 103, 255, 52, 5, 27, 166, 37, 43, 189, 236, 163, 146, 250, 42, 140, 79, 125, 193, 48, 242, 96, 32, 47, 135, 190, 49, 169, 245, 41, 27, 105, 164, 58, 190, 39, 59, 157, 57, 130, 0, 51, 90, 225, 226, 162, 192, 141, 67, 80, 97, 178 }, new byte[] { 127, 37, 29, 215, 48, 192, 195, 153, 31, 75, 179, 202, 163, 44, 157, 118, 50, 4, 56, 134, 156, 7, 163, 168, 92, 184, 211, 37, 167, 69, 230, 5, 238, 71, 60, 48, 237, 98, 50, 35, 150, 127, 195, 172, 172, 185, 158, 149, 14, 205, 245, 22, 146, 204, 213, 60, 24, 249, 163, 163, 4, 179, 162, 210, 230, 36, 179, 154, 22, 38, 73, 85, 150, 77, 102, 39, 251, 120, 58, 117, 177, 174, 201, 220, 149, 110, 108, 40, 131, 132, 153, 144, 117, 249, 11, 212, 59, 183, 77, 234, 217, 111, 149, 70, 24, 13, 73, 143, 83, 222, 188, 83, 195, 82, 52, 58, 172, 112, 156, 203, 118, 168, 248, 17, 195, 214, 130, 105 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 21, 238, 36, 46, 214, 235, 184, 158, 220, 158, 110, 61, 73, 227, 127, 246, 187, 111, 32, 108, 211, 149, 27, 245, 61, 13, 162, 132, 241, 213, 218, 219, 24, 159, 30, 145, 250, 74, 45, 233, 104, 199, 143, 54, 172, 43, 118, 29, 150, 203, 13, 72, 105, 121, 231, 253, 211, 63, 106, 34, 251, 92, 238, 51 }, new byte[] { 95, 119, 79, 183, 203, 144, 50, 28, 37, 58, 65, 142, 211, 102, 191, 93, 34, 163, 250, 210, 222, 150, 11, 135, 143, 152, 225, 75, 66, 94, 161, 35, 42, 153, 248, 103, 185, 240, 42, 85, 165, 65, 113, 60, 212, 93, 78, 92, 242, 198, 219, 7, 17, 198, 220, 168, 99, 147, 245, 8, 34, 139, 163, 85, 97, 18, 208, 52, 135, 47, 51, 80, 179, 69, 74, 43, 44, 204, 116, 132, 242, 225, 4, 181, 147, 225, 22, 142, 54, 15, 247, 231, 11, 159, 74, 177, 22, 244, 73, 152, 209, 59, 163, 97, 89, 140, 126, 93, 23, 190, 156, 22, 54, 28, 36, 156, 163, 137, 156, 49, 97, 53, 251, 176, 210, 221, 77, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 182, 110, 17, 139, 241, 106, 170, 198, 198, 188, 202, 121, 235, 28, 216, 234, 31, 252, 138, 72, 49, 124, 17, 101, 5, 216, 33, 171, 239, 246, 19, 83, 254, 120, 147, 15, 193, 49, 156, 24, 234, 28, 18, 252, 179, 60, 102, 226, 168, 60, 25, 150, 150, 8, 190, 7, 154, 226, 171, 100, 138, 163, 149, 156 }, new byte[] { 73, 231, 182, 74, 38, 156, 20, 244, 188, 93, 65, 161, 160, 19, 206, 172, 180, 189, 242, 184, 159, 228, 17, 174, 209, 177, 24, 146, 22, 140, 179, 66, 94, 163, 168, 225, 175, 114, 220, 14, 162, 72, 81, 57, 73, 240, 61, 40, 245, 41, 33, 62, 216, 11, 186, 218, 253, 228, 108, 221, 163, 53, 206, 231, 57, 214, 52, 11, 99, 168, 56, 36, 90, 90, 74, 178, 33, 104, 169, 246, 16, 132, 46, 107, 171, 225, 141, 33, 9, 59, 179, 116, 220, 108, 198, 44, 110, 243, 166, 150, 96, 215, 53, 87, 249, 204, 15, 190, 26, 175, 240, 2, 226, 177, 75, 17, 56, 70, 213, 121, 80, 185, 73, 243, 97, 166, 142, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 221, 217, 15, 250, 223, 241, 182, 192, 175, 168, 69, 157, 73, 100, 107, 120, 36, 222, 88, 73, 91, 34, 243, 127, 81, 35, 157, 99, 47, 111, 139, 143, 134, 154, 130, 131, 218, 69, 66, 156, 21, 108, 143, 150, 211, 158, 110, 74, 22, 70, 171, 149, 70, 61, 212, 134, 128, 222, 131, 239, 214, 79, 210 }, new byte[] { 123, 45, 109, 255, 130, 219, 83, 122, 117, 232, 5, 67, 9, 119, 248, 236, 62, 48, 79, 115, 75, 88, 135, 193, 148, 199, 160, 198, 166, 221, 184, 150, 122, 7, 212, 24, 57, 176, 147, 163, 95, 216, 120, 11, 224, 43, 116, 11, 214, 221, 147, 37, 138, 158, 43, 240, 247, 219, 59, 62, 62, 243, 123, 156, 208, 172, 157, 11, 46, 114, 12, 184, 187, 41, 221, 121, 127, 70, 247, 219, 78, 124, 131, 75, 75, 66, 113, 204, 197, 239, 236, 151, 253, 7, 229, 107, 22, 201, 218, 78, 201, 50, 146, 117, 226, 57, 21, 210, 237, 119, 50, 34, 244, 191, 95, 237, 48, 25, 93, 192, 224, 173, 69, 31, 51, 184, 165, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 89, 109, 131, 53, 71, 84, 153, 39, 247, 135, 228, 177, 114, 95, 107, 214, 131, 152, 148, 126, 227, 155, 74, 136, 31, 247, 122, 11, 220, 184, 152, 50, 74, 163, 49, 204, 254, 229, 45, 4, 192, 215, 231, 33, 203, 209, 27, 157, 4, 148, 165, 178, 142, 170, 82, 191, 103, 13, 63, 156, 248, 239, 34 }, new byte[] { 24, 189, 102, 157, 182, 188, 21, 227, 171, 32, 67, 249, 178, 231, 61, 91, 246, 249, 73, 215, 158, 241, 237, 230, 100, 16, 128, 95, 199, 4, 112, 38, 137, 223, 96, 18, 51, 211, 15, 145, 41, 195, 116, 195, 197, 245, 90, 79, 228, 237, 74, 191, 34, 209, 57, 84, 138, 84, 42, 229, 4, 245, 123, 162, 73, 41, 102, 145, 215, 210, 80, 55, 217, 212, 52, 234, 241, 101, 7, 66, 181, 224, 245, 200, 153, 48, 100, 95, 51, 51, 76, 137, 199, 182, 204, 236, 206, 23, 164, 237, 130, 72, 47, 15, 35, 17, 98, 89, 92, 133, 216, 34, 32, 190, 175, 193, 248, 143, 140, 234, 147, 94, 63, 151, 64, 6, 202, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 201, 136, 91, 60, 232, 34, 41, 147, 25, 155, 67, 17, 205, 47, 243, 147, 154, 194, 249, 221, 51, 158, 81, 69, 220, 7, 95, 217, 183, 178, 238, 235, 230, 200, 7, 170, 120, 163, 224, 150, 144, 249, 224, 1, 188, 224, 123, 191, 135, 203, 41, 178, 83, 190, 160, 38, 6, 87, 158, 226, 58, 78, 109, 103 }, new byte[] { 82, 145, 84, 118, 9, 188, 116, 130, 7, 180, 101, 125, 128, 31, 108, 24, 134, 169, 199, 161, 169, 141, 126, 217, 210, 39, 32, 241, 122, 167, 127, 116, 132, 105, 156, 117, 245, 228, 181, 129, 235, 59, 54, 124, 147, 33, 22, 85, 57, 7, 211, 80, 31, 54, 189, 173, 199, 181, 48, 154, 194, 131, 80, 112, 79, 193, 210, 170, 86, 118, 211, 88, 119, 108, 219, 196, 13, 203, 157, 79, 23, 8, 207, 237, 231, 46, 43, 221, 130, 238, 233, 198, 240, 88, 239, 20, 150, 69, 139, 157, 188, 156, 254, 91, 38, 182, 131, 187, 15, 185, 123, 232, 219, 224, 215, 56, 87, 124, 109, 182, 230, 250, 143, 133, 34, 99, 248, 112 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 158, 253, 164, 253, 133, 146, 186, 219, 150, 73, 98, 196, 30, 70, 1, 147, 114, 43, 181, 107, 131, 65, 33, 79, 204, 214, 182, 248, 131, 148, 88, 229, 191, 73, 176, 48, 36, 224, 12, 148, 234, 168, 194, 58, 232, 255, 252, 35, 58, 64, 49, 26, 33, 45, 199, 236, 232, 182, 196, 46, 34, 240, 215 }, new byte[] { 248, 38, 191, 208, 56, 140, 59, 68, 171, 196, 172, 53, 169, 207, 3, 78, 188, 148, 171, 4, 4, 185, 24, 159, 160, 3, 107, 207, 50, 232, 58, 34, 68, 124, 20, 57, 254, 16, 166, 66, 120, 135, 20, 70, 86, 67, 180, 169, 234, 38, 159, 161, 15, 65, 66, 247, 179, 16, 255, 201, 27, 52, 143, 107, 229, 231, 45, 222, 101, 50, 222, 153, 164, 14, 169, 182, 210, 175, 173, 188, 225, 230, 54, 18, 126, 215, 20, 119, 120, 220, 43, 59, 250, 177, 68, 87, 38, 153, 199, 215, 213, 173, 112, 134, 37, 221, 26, 153, 190, 0, 116, 236, 136, 127, 179, 95, 62, 2, 12, 110, 154, 248, 55, 108, 236, 11, 103, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 248, 92, 112, 207, 120, 29, 113, 177, 46, 244, 13, 181, 124, 82, 148, 126, 198, 17, 89, 51, 46, 246, 29, 187, 111, 68, 197, 251, 230, 57, 196, 191, 99, 123, 21, 143, 105, 240, 96, 119, 64, 76, 247, 123, 246, 206, 148, 77, 85, 199, 244, 43, 149, 196, 120, 40, 200, 111, 93, 36, 77, 158, 157 }, new byte[] { 159, 75, 33, 137, 101, 76, 27, 26, 20, 3, 134, 66, 228, 129, 144, 73, 138, 181, 60, 108, 77, 180, 219, 210, 186, 254, 63, 146, 159, 233, 117, 55, 241, 134, 169, 33, 163, 239, 45, 202, 92, 243, 76, 146, 24, 151, 196, 49, 131, 50, 30, 220, 209, 250, 94, 82, 235, 116, 135, 95, 149, 241, 53, 84, 187, 142, 10, 5, 48, 27, 156, 25, 80, 129, 49, 98, 213, 81, 180, 124, 132, 58, 93, 44, 145, 83, 20, 27, 85, 63, 13, 127, 157, 151, 151, 254, 23, 202, 239, 104, 3, 97, 97, 181, 154, 111, 46, 42, 199, 143, 236, 54, 174, 196, 25, 11, 15, 65, 193, 102, 149, 74, 183, 155, 9, 149, 181, 213 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 220, 212, 204, 111, 192, 144, 239, 135, 253, 180, 81, 190, 131, 120, 149, 216, 26, 62, 190, 203, 30, 164, 164, 73, 33, 121, 43, 1, 135, 0, 149, 36, 77, 72, 117, 183, 200, 59, 212, 20, 172, 16, 157, 130, 80, 193, 3, 241, 54, 5, 55, 122, 141, 203, 90, 82, 67, 108, 51, 29, 106, 160, 255 }, new byte[] { 203, 42, 188, 25, 46, 247, 200, 75, 114, 8, 238, 66, 165, 26, 109, 186, 134, 211, 76, 120, 212, 37, 131, 248, 197, 210, 209, 2, 220, 189, 147, 13, 169, 201, 13, 53, 188, 187, 190, 80, 24, 99, 3, 206, 10, 154, 137, 225, 170, 31, 28, 60, 124, 19, 56, 149, 227, 201, 1, 243, 134, 11, 84, 44, 24, 58, 193, 227, 168, 23, 105, 133, 50, 113, 8, 132, 34, 180, 1, 144, 107, 61, 11, 87, 101, 226, 93, 69, 45, 40, 231, 161, 142, 123, 212, 162, 248, 77, 174, 95, 154, 146, 91, 49, 108, 53, 203, 123, 56, 7, 43, 236, 62, 183, 64, 226, 157, 78, 76, 165, 31, 215, 96, 194, 204, 235, 49, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 233, 64, 81, 161, 183, 159, 103, 189, 119, 219, 246, 71, 92, 251, 118, 82, 216, 228, 172, 213, 184, 146, 96, 128, 70, 135, 217, 117, 116, 130, 144, 245, 92, 35, 231, 123, 45, 165, 97, 42, 245, 119, 215, 13, 163, 242, 172, 216, 3, 12, 154, 174, 178, 30, 54, 218, 42, 2, 22, 209, 101, 12, 155 }, new byte[] { 210, 231, 96, 66, 194, 205, 217, 77, 205, 103, 110, 79, 238, 86, 90, 190, 12, 210, 0, 98, 47, 249, 245, 171, 175, 28, 139, 155, 96, 72, 164, 44, 27, 74, 170, 5, 142, 28, 113, 107, 127, 75, 38, 71, 184, 168, 103, 238, 109, 9, 137, 204, 219, 87, 190, 90, 64, 204, 165, 169, 1, 114, 147, 195, 250, 213, 38, 46, 236, 95, 83, 205, 237, 188, 201, 25, 51, 127, 219, 21, 210, 46, 12, 16, 173, 252, 195, 1, 244, 20, 79, 172, 102, 133, 17, 198, 134, 77, 16, 249, 72, 79, 241, 68, 136, 198, 142, 104, 72, 233, 142, 188, 192, 123, 155, 2, 163, 172, 56, 214, 8, 114, 52, 34, 253, 194, 229, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 79, 210, 81, 83, 51, 66, 239, 230, 204, 57, 133, 211, 237, 9, 38, 159, 154, 205, 190, 129, 113, 220, 200, 40, 17, 244, 233, 73, 204, 99, 56, 1, 107, 253, 141, 117, 23, 231, 99, 208, 189, 154, 138, 208, 119, 1, 120, 58, 213, 164, 218, 159, 228, 158, 24, 41, 250, 12, 119, 65, 29, 140, 141 }, new byte[] { 115, 18, 189, 200, 167, 218, 150, 158, 84, 220, 182, 116, 134, 87, 123, 12, 199, 192, 243, 59, 215, 113, 206, 4, 47, 209, 211, 62, 17, 219, 118, 219, 88, 104, 151, 68, 228, 241, 170, 65, 179, 170, 227, 99, 208, 151, 255, 229, 170, 71, 0, 138, 53, 214, 105, 137, 203, 45, 241, 45, 161, 132, 254, 69, 197, 11, 51, 247, 4, 147, 195, 161, 37, 20, 85, 62, 216, 131, 25, 163, 98, 252, 145, 212, 200, 236, 67, 97, 177, 190, 39, 96, 246, 163, 213, 84, 23, 74, 50, 2, 18, 126, 36, 90, 154, 189, 14, 198, 249, 37, 116, 51, 224, 80, 46, 71, 1, 72, 39, 30, 1, 177, 1, 172, 108, 255, 195, 239 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 27, 234, 128, 203, 75, 29, 166, 201, 145, 148, 166, 18, 52, 50, 156, 182, 212, 95, 106, 149, 108, 182, 97, 112, 155, 249, 249, 93, 117, 223, 183, 181, 205, 134, 54, 253, 121, 152, 122, 217, 184, 20, 139, 2, 113, 211, 96, 250, 187, 76, 147, 63, 65, 201, 223, 59, 37, 229, 253, 99, 73, 187, 179 }, new byte[] { 121, 122, 169, 255, 177, 32, 95, 34, 166, 233, 188, 131, 92, 51, 78, 160, 117, 141, 156, 133, 175, 162, 132, 135, 30, 253, 101, 93, 190, 37, 208, 30, 195, 146, 159, 151, 112, 47, 60, 223, 126, 197, 7, 245, 29, 126, 247, 173, 144, 142, 213, 221, 94, 100, 251, 15, 44, 46, 234, 244, 219, 221, 222, 51, 217, 8, 199, 221, 102, 239, 229, 50, 205, 156, 46, 245, 25, 70, 6, 66, 79, 118, 159, 135, 182, 93, 218, 198, 28, 19, 162, 186, 152, 249, 110, 56, 113, 133, 108, 153, 62, 154, 28, 193, 62, 115, 62, 225, 240, 208, 46, 66, 173, 199, 176, 238, 15, 251, 143, 70, 143, 128, 39, 74, 101, 15, 31, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 251, 129, 24, 239, 240, 246, 51, 126, 239, 201, 66, 112, 46, 242, 154, 51, 254, 120, 82, 226, 207, 97, 42, 243, 200, 125, 125, 51, 228, 190, 65, 79, 103, 251, 4, 124, 196, 243, 28, 149, 96, 204, 115, 162, 251, 123, 182, 51, 117, 199, 98, 36, 65, 230, 172, 87, 123, 123, 149, 230, 197, 80, 201 }, new byte[] { 81, 90, 200, 48, 103, 143, 212, 0, 195, 2, 164, 70, 71, 101, 134, 38, 72, 26, 203, 33, 2, 106, 12, 208, 103, 186, 94, 179, 166, 92, 173, 239, 1, 61, 13, 237, 196, 38, 90, 195, 149, 189, 91, 137, 120, 124, 71, 62, 122, 66, 60, 154, 6, 83, 3, 135, 233, 179, 13, 242, 66, 146, 232, 232, 210, 129, 230, 142, 250, 229, 26, 137, 34, 241, 176, 143, 235, 42, 25, 197, 35, 198, 121, 32, 88, 116, 228, 142, 99, 206, 102, 168, 119, 105, 179, 253, 99, 146, 122, 125, 210, 240, 61, 161, 103, 255, 244, 9, 2, 178, 250, 207, 56, 242, 142, 24, 191, 8, 175, 133, 204, 91, 61, 28, 221, 235, 48, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 20, 80, 138, 70, 239, 186, 195, 93, 3, 117, 68, 13, 45, 32, 235, 97, 30, 58, 163, 139, 202, 167, 45, 135, 10, 248, 158, 124, 40, 250, 38, 50, 120, 1, 153, 166, 181, 191, 67, 217, 212, 143, 84, 139, 12, 204, 52, 31, 213, 173, 237, 36, 66, 175, 173, 119, 197, 151, 5, 148, 0, 123, 34 }, new byte[] { 158, 102, 190, 14, 138, 12, 183, 61, 133, 34, 225, 74, 114, 98, 132, 247, 243, 72, 129, 60, 189, 232, 131, 252, 208, 15, 28, 218, 68, 5, 200, 216, 10, 57, 41, 116, 187, 64, 141, 119, 143, 65, 124, 54, 236, 98, 250, 183, 37, 59, 184, 11, 88, 210, 179, 77, 176, 55, 252, 242, 45, 41, 146, 151, 79, 83, 200, 236, 198, 172, 13, 156, 137, 219, 92, 255, 67, 195, 109, 22, 52, 78, 30, 162, 243, 115, 32, 214, 218, 180, 108, 66, 211, 122, 136, 134, 86, 143, 226, 63, 33, 115, 72, 245, 174, 164, 124, 241, 32, 29, 246, 17, 241, 226, 205, 9, 100, 91, 89, 104, 228, 171, 111, 164, 255, 248, 108, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 66, 203, 149, 191, 164, 68, 206, 156, 228, 96, 250, 249, 217, 44, 224, 143, 105, 143, 166, 50, 139, 1, 88, 213, 188, 76, 209, 137, 116, 243, 45, 220, 141, 136, 78, 52, 238, 188, 115, 96, 38, 170, 18, 211, 184, 88, 78, 240, 203, 175, 68, 235, 112, 93, 45, 101, 108, 221, 195, 228, 231, 23, 72 }, new byte[] { 66, 151, 199, 227, 3, 203, 130, 104, 176, 166, 107, 62, 120, 122, 2, 190, 92, 212, 231, 223, 210, 212, 137, 119, 251, 160, 199, 76, 34, 7, 58, 169, 93, 29, 79, 6, 231, 116, 183, 11, 192, 253, 188, 123, 200, 68, 159, 247, 196, 67, 158, 249, 139, 225, 42, 67, 134, 114, 160, 25, 222, 191, 142, 215, 77, 32, 255, 3, 106, 162, 242, 252, 202, 106, 189, 35, 128, 76, 208, 139, 211, 204, 233, 168, 114, 140, 251, 181, 0, 225, 239, 230, 246, 78, 28, 87, 11, 91, 30, 176, 99, 92, 132, 184, 236, 160, 8, 252, 13, 89, 141, 94, 200, 191, 138, 164, 189, 121, 53, 204, 167, 139, 30, 117, 59, 63, 144, 32 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 151, 148, 224, 185, 46, 5, 229, 220, 237, 81, 218, 149, 15, 1, 237, 35, 203, 3, 149, 181, 194, 144, 70, 92, 185, 130, 209, 46, 77, 108, 8, 142, 117, 91, 61, 94, 233, 55, 53, 248, 199, 203, 53, 139, 17, 129, 55, 249, 211, 94, 166, 92, 79, 60, 67, 3, 90, 219, 50, 113, 70, 75, 137, 195 }, new byte[] { 151, 212, 223, 106, 105, 241, 118, 2, 17, 102, 105, 97, 187, 244, 101, 112, 7, 188, 88, 62, 219, 76, 191, 149, 209, 151, 202, 221, 239, 252, 68, 214, 109, 111, 219, 207, 146, 227, 119, 181, 249, 63, 209, 148, 100, 59, 246, 87, 26, 0, 33, 74, 246, 61, 245, 105, 236, 233, 215, 16, 193, 143, 144, 240, 104, 217, 196, 64, 12, 57, 182, 27, 234, 65, 225, 65, 123, 75, 233, 1, 20, 116, 97, 135, 208, 108, 181, 75, 148, 64, 79, 214, 165, 142, 171, 145, 5, 214, 254, 147, 72, 155, 248, 172, 231, 220, 211, 147, 168, 244, 49, 202, 186, 52, 46, 170, 80, 45, 165, 191, 113, 71, 196, 132, 56, 204, 5, 150 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 113, 212, 58, 27, 25, 80, 20, 89, 219, 210, 71, 187, 237, 148, 129, 221, 240, 157, 141, 65, 169, 87, 156, 56, 183, 140, 240, 53, 242, 155, 99, 18, 5, 155, 132, 74, 242, 146, 22, 133, 99, 150, 165, 219, 238, 57, 211, 62, 83, 103, 104, 97, 95, 204, 15, 232, 93, 78, 150, 205, 29, 68, 59 }, new byte[] { 56, 221, 183, 92, 198, 146, 219, 47, 122, 140, 206, 142, 214, 49, 49, 201, 0, 4, 225, 198, 161, 109, 104, 73, 254, 146, 56, 72, 76, 100, 82, 88, 230, 10, 81, 131, 146, 238, 58, 242, 156, 108, 152, 162, 67, 156, 143, 43, 32, 158, 44, 149, 156, 151, 254, 244, 208, 62, 82, 38, 54, 87, 10, 29, 55, 73, 31, 3, 237, 46, 200, 122, 3, 67, 210, 220, 44, 247, 150, 97, 80, 159, 171, 115, 235, 6, 221, 146, 150, 19, 237, 206, 56, 96, 1, 206, 96, 106, 84, 74, 230, 122, 82, 20, 159, 229, 18, 164, 64, 97, 90, 99, 59, 100, 18, 34, 161, 27, 65, 81, 253, 111, 137, 153, 101, 244, 251, 4 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 185, 41, 239, 12, 69, 118, 52, 236, 37, 134, 142, 147, 167, 6, 159, 235, 85, 222, 198, 28, 131, 67, 215, 176, 120, 125, 57, 237, 166, 67, 247, 164, 80, 229, 53, 246, 32, 159, 175, 71, 114, 73, 102, 124, 170, 189, 118, 119, 238, 166, 67, 239, 117, 204, 195, 215, 10, 139, 207, 189, 42, 96, 46, 176 }, new byte[] { 151, 127, 27, 20, 33, 154, 172, 65, 39, 237, 62, 89, 151, 117, 88, 114, 132, 154, 95, 181, 140, 215, 201, 249, 68, 113, 60, 128, 2, 230, 36, 55, 233, 10, 128, 124, 137, 105, 64, 214, 96, 127, 200, 32, 86, 255, 160, 71, 221, 157, 81, 141, 218, 37, 11, 129, 254, 6, 65, 99, 251, 88, 146, 165, 141, 67, 8, 46, 220, 247, 41, 45, 79, 57, 174, 39, 25, 232, 98, 23, 239, 241, 231, 241, 107, 219, 117, 175, 16, 188, 146, 20, 54, 227, 43, 223, 135, 70, 132, 95, 4, 130, 13, 232, 128, 45, 68, 193, 184, 23, 133, 38, 180, 155, 26, 27, 177, 0, 153, 240, 129, 248, 182, 72, 58, 153, 68, 22 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 207, 237, 118, 73, 87, 162, 37, 162, 90, 160, 161, 17, 95, 66, 15, 111, 34, 215, 214, 81, 57, 189, 219, 229, 234, 248, 247, 179, 75, 28, 202, 240, 176, 195, 138, 240, 73, 108, 209, 47, 157, 137, 241, 230, 194, 201, 169, 58, 228, 67, 20, 138, 152, 183, 37, 214, 100, 216, 84, 224, 176, 13, 117 }, new byte[] { 158, 139, 77, 136, 167, 29, 223, 207, 62, 15, 214, 108, 191, 202, 123, 219, 66, 192, 205, 18, 47, 198, 222, 180, 237, 49, 211, 123, 60, 27, 184, 44, 155, 6, 230, 152, 224, 181, 72, 18, 180, 3, 238, 59, 234, 15, 213, 22, 45, 200, 32, 230, 91, 198, 109, 194, 74, 54, 13, 14, 221, 28, 6, 172, 111, 182, 208, 173, 44, 5, 209, 97, 50, 146, 123, 30, 96, 211, 19, 254, 42, 236, 251, 22, 142, 24, 189, 76, 153, 206, 5, 216, 67, 151, 63, 69, 95, 39, 217, 237, 101, 224, 164, 172, 53, 108, 27, 79, 191, 172, 94, 239, 157, 187, 140, 249, 53, 25, 227, 22, 231, 193, 0, 145, 10, 11, 243, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 84, 103, 132, 144, 4, 75, 156, 57, 150, 221, 241, 72, 73, 163, 121, 137, 34, 212, 178, 51, 30, 133, 59, 192, 23, 93, 48, 96, 116, 83, 3, 6, 235, 173, 199, 64, 139, 248, 12, 113, 153, 30, 60, 66, 17, 181, 99, 110, 31, 214, 116, 188, 164, 210, 152, 229, 129, 220, 62, 149, 6, 70, 32 }, new byte[] { 5, 190, 248, 182, 205, 38, 229, 101, 27, 41, 111, 119, 101, 34, 24, 246, 2, 74, 6, 35, 128, 145, 112, 231, 98, 222, 10, 52, 56, 13, 153, 210, 36, 119, 25, 254, 91, 52, 241, 178, 237, 117, 39, 114, 161, 71, 37, 18, 158, 35, 186, 109, 184, 80, 141, 191, 69, 161, 224, 200, 26, 134, 243, 32, 88, 196, 201, 214, 77, 247, 15, 124, 233, 1, 22, 67, 135, 19, 207, 36, 237, 92, 28, 19, 168, 226, 154, 112, 249, 199, 145, 230, 6, 64, 198, 177, 205, 170, 224, 110, 87, 34, 223, 8, 166, 17, 223, 100, 250, 164, 150, 22, 183, 244, 92, 175, 25, 37, 249, 196, 205, 37, 39, 114, 141, 105, 84, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 145, 217, 183, 120, 6, 19, 183, 109, 134, 16, 11, 111, 130, 28, 87, 249, 106, 164, 127, 245, 65, 14, 157, 239, 101, 224, 143, 138, 144, 181, 202, 46, 200, 181, 111, 18, 142, 84, 35, 93, 72, 126, 168, 236, 115, 167, 130, 70, 65, 226, 58, 84, 232, 243, 10, 34, 193, 91, 89, 153, 139, 37, 194 }, new byte[] { 161, 79, 4, 248, 49, 3, 100, 182, 55, 164, 79, 87, 24, 174, 99, 232, 112, 225, 126, 243, 3, 210, 70, 68, 86, 192, 102, 139, 60, 64, 115, 29, 146, 145, 228, 183, 31, 136, 194, 72, 27, 63, 201, 51, 79, 28, 212, 105, 227, 252, 177, 100, 10, 213, 87, 77, 187, 51, 41, 70, 182, 68, 197, 100, 194, 138, 155, 205, 61, 73, 146, 82, 170, 209, 52, 88, 108, 162, 176, 6, 251, 37, 145, 201, 51, 105, 62, 122, 176, 166, 101, 189, 11, 175, 32, 166, 181, 241, 177, 175, 98, 120, 122, 150, 49, 203, 121, 114, 15, 247, 137, 243, 77, 79, 48, 154, 148, 4, 2, 223, 219, 117, 102, 125, 81, 210, 149, 192 } });
        }
    }
}
