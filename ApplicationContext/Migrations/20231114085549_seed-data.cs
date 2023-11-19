﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 14, 8, 55, 49, 148, DateTimeKind.Utc).AddTicks(8847), new DateTime(2023, 11, 15, 8, 55, 49, 148, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 26, 5, 250, 231, 186, 186, 217, 149, 131, 165, 159, 120, 5, 115, 168, 159, 83, 163, 69, 1, 115, 84, 201, 114, 46, 78, 128, 157, 87, 104, 172, 98, 4, 56, 212, 38, 13, 212, 236, 29, 154, 100, 177, 148, 196, 4, 14, 54, 127, 188, 198, 34, 34, 223, 221, 200, 166, 211, 71, 40, 68, 140, 119, 168 }, new byte[] { 152, 70, 6, 180, 159, 127, 131, 181, 76, 139, 54, 185, 78, 48, 200, 75, 66, 172, 93, 239, 213, 177, 38, 44, 231, 60, 220, 133, 0, 238, 31, 33, 247, 205, 65, 42, 174, 235, 34, 3, 11, 195, 174, 116, 29, 123, 235, 119, 251, 124, 17, 201, 187, 79, 60, 172, 99, 28, 52, 77, 40, 61, 187, 13, 131, 109, 184, 49, 88, 175, 2, 89, 153, 26, 200, 218, 188, 15, 84, 203, 225, 103, 236, 37, 69, 249, 11, 249, 224, 33, 180, 228, 80, 209, 161, 134, 80, 96, 59, 53, 147, 162, 227, 180, 92, 180, 194, 169, 147, 217, 201, 219, 19, 133, 183, 147, 203, 125, 35, 76, 57, 17, 74, 171, 10, 154, 127, 47 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 182, 26, 109, 116, 26, 57, 114, 217, 206, 106, 207, 231, 203, 142, 191, 124, 139, 135, 204, 191, 1, 214, 157, 130, 129, 191, 105, 213, 67, 165, 98, 238, 245, 191, 235, 80, 42, 159, 116, 157, 63, 119, 247, 127, 2, 238, 91, 60, 16, 82, 3, 96, 98, 128, 1, 7, 109, 14, 19, 13, 17, 82, 28 }, new byte[] { 137, 180, 229, 47, 39, 46, 201, 212, 162, 91, 169, 218, 117, 48, 139, 224, 223, 220, 217, 91, 233, 145, 20, 32, 0, 11, 140, 210, 138, 127, 84, 177, 212, 157, 213, 198, 154, 212, 171, 58, 116, 101, 126, 211, 81, 51, 189, 22, 114, 214, 31, 26, 94, 40, 48, 47, 49, 150, 217, 161, 160, 26, 154, 233, 161, 215, 242, 26, 167, 212, 41, 231, 37, 0, 162, 40, 6, 233, 29, 176, 180, 95, 167, 159, 67, 68, 62, 201, 109, 41, 155, 93, 183, 142, 223, 174, 132, 89, 81, 179, 180, 240, 71, 82, 202, 154, 143, 220, 82, 244, 106, 254, 146, 176, 189, 52, 183, 124, 9, 98, 66, 112, 98, 40, 207, 235, 232, 185 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedBy", "Email", "FirstName", "HighestScore", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"), "Tran quoc toan", null, "student2@gmail.com", "Minh", 9, false, "Vu", null, null, new byte[] { 238, 197, 215, 134, 110, 246, 175, 204, 87, 224, 90, 123, 234, 159, 212, 37, 183, 128, 240, 180, 236, 159, 239, 154, 128, 210, 103, 37, 71, 224, 218, 49, 217, 56, 64, 118, 97, 133, 163, 187, 112, 55, 209, 83, 183, 75, 199, 91, 138, 246, 132, 247, 84, 149, 232, 96, 176, 194, 203, 222, 78, 95, 85, 41 }, new byte[] { 180, 98, 98, 137, 120, 1, 130, 139, 86, 195, 198, 195, 147, 29, 147, 7, 89, 182, 25, 55, 243, 130, 246, 148, 76, 57, 37, 100, 12, 145, 227, 33, 99, 236, 55, 236, 7, 221, 58, 13, 24, 166, 181, 91, 219, 141, 231, 11, 50, 233, 115, 165, 51, 6, 231, 186, 23, 89, 107, 24, 212, 164, 223, 149, 64, 98, 82, 28, 140, 9, 20, 107, 39, 209, 100, 176, 108, 178, 202, 151, 88, 242, 154, 231, 206, 205, 242, 74, 124, 240, 46, 174, 240, 43, 240, 97, 132, 52, 65, 229, 171, 169, 87, 207, 79, 78, 46, 31, 198, 157, 222, 85, 235, 238, 36, 31, 193, 210, 116, 97, 8, 22, 15, 25, 6, 121, 163, 218 }, "1234567890", 1, "student2" },
                    { new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"), "Tran quoc toan", null, "student4@gmail.com", "Minh", 6, false, "Tam", null, null, new byte[] { 211, 90, 145, 207, 71, 39, 94, 185, 131, 68, 230, 112, 34, 155, 232, 54, 49, 4, 73, 92, 114, 47, 116, 84, 216, 78, 90, 78, 98, 39, 167, 178, 14, 70, 212, 164, 238, 29, 181, 149, 113, 252, 236, 116, 40, 65, 173, 104, 201, 66, 18, 237, 182, 201, 94, 129, 45, 214, 137, 234, 97, 45, 169, 93 }, new byte[] { 243, 133, 58, 178, 136, 231, 190, 152, 92, 150, 84, 195, 4, 153, 53, 253, 228, 28, 54, 114, 194, 221, 16, 57, 228, 60, 56, 36, 39, 224, 102, 55, 110, 76, 77, 179, 79, 131, 1, 209, 254, 106, 56, 136, 131, 20, 250, 174, 225, 87, 74, 40, 69, 69, 250, 209, 250, 152, 252, 172, 41, 15, 67, 204, 245, 244, 28, 67, 62, 184, 164, 2, 203, 220, 231, 164, 60, 87, 174, 144, 65, 220, 220, 5, 23, 171, 126, 13, 167, 114, 40, 212, 196, 153, 207, 252, 134, 20, 217, 162, 16, 154, 222, 16, 62, 22, 227, 146, 252, 155, 163, 111, 102, 52, 144, 192, 78, 68, 34, 55, 196, 231, 176, 77, 44, 152, 96, 82 }, "1234567890", 1, "student4" },
                    { new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"), "Tran quoc toan", null, "student15@gmail.com", "Trinh", 1, false, "Quan", null, null, new byte[] { 138, 123, 232, 79, 183, 59, 206, 216, 192, 56, 187, 174, 185, 219, 7, 99, 131, 4, 35, 181, 187, 114, 35, 194, 30, 76, 28, 140, 154, 144, 116, 152, 195, 54, 237, 229, 68, 208, 125, 117, 5, 53, 101, 7, 113, 243, 86, 57, 255, 1, 126, 85, 21, 199, 29, 154, 191, 230, 104, 157, 146, 158, 184, 86 }, new byte[] { 137, 243, 217, 190, 179, 104, 115, 142, 254, 102, 141, 253, 165, 125, 105, 82, 6, 132, 146, 130, 165, 190, 148, 246, 55, 48, 17, 114, 61, 169, 221, 150, 94, 162, 80, 125, 212, 152, 228, 34, 32, 225, 196, 247, 26, 204, 36, 60, 113, 207, 114, 37, 171, 110, 213, 186, 192, 18, 238, 254, 10, 177, 60, 166, 156, 127, 154, 236, 70, 113, 137, 210, 234, 188, 63, 108, 211, 130, 134, 124, 214, 8, 17, 224, 213, 124, 214, 69, 24, 110, 69, 65, 21, 222, 149, 251, 145, 11, 87, 235, 123, 219, 94, 143, 65, 193, 92, 209, 24, 211, 232, 197, 88, 203, 11, 84, 33, 233, 171, 82, 47, 20, 249, 228, 24, 147, 254, 129 }, "1234567890", 1, "student15" },
                    { new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"), "Tran quoc toan", null, "student14@gmail.com", "Cook", 1, false, "Lee", null, null, new byte[] { 141, 129, 16, 51, 109, 164, 59, 101, 254, 137, 180, 175, 154, 179, 63, 137, 245, 246, 115, 75, 24, 216, 68, 206, 73, 179, 130, 213, 182, 69, 88, 206, 66, 78, 70, 27, 248, 83, 128, 132, 240, 103, 236, 32, 35, 114, 42, 222, 217, 155, 220, 63, 138, 222, 163, 42, 88, 162, 81, 108, 44, 12, 18, 4 }, new byte[] { 245, 210, 227, 11, 191, 23, 89, 153, 142, 134, 255, 206, 242, 73, 18, 72, 72, 14, 18, 2, 138, 15, 148, 85, 4, 67, 224, 217, 77, 74, 4, 28, 107, 222, 17, 231, 106, 237, 222, 73, 164, 215, 148, 6, 252, 127, 105, 58, 250, 220, 12, 248, 63, 33, 56, 215, 68, 2, 167, 126, 217, 180, 110, 32, 53, 174, 156, 130, 210, 60, 50, 117, 25, 188, 252, 75, 158, 148, 229, 61, 205, 146, 73, 174, 42, 159, 194, 123, 120, 167, 245, 133, 23, 205, 110, 170, 248, 180, 96, 193, 98, 20, 165, 40, 42, 58, 122, 141, 145, 3, 67, 172, 43, 252, 76, 214, 239, 142, 96, 83, 57, 251, 78, 56, 117, 120, 23, 196 }, "1234567890", 1, "student14" },
                    { new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"), "Tran quoc toan", null, "student8@gmail.com", "Ly", 2, false, "Hung", null, null, new byte[] { 157, 218, 212, 140, 69, 124, 214, 14, 218, 213, 1, 42, 89, 160, 127, 81, 2, 131, 19, 96, 1, 244, 104, 135, 227, 102, 122, 73, 2, 27, 51, 143, 195, 67, 62, 104, 42, 118, 74, 104, 161, 80, 196, 97, 215, 99, 7, 243, 208, 53, 71, 142, 255, 248, 170, 118, 181, 236, 92, 136, 44, 93, 255, 129 }, new byte[] { 253, 157, 9, 135, 47, 8, 74, 219, 246, 209, 42, 125, 155, 190, 150, 50, 181, 47, 56, 139, 58, 21, 118, 236, 123, 13, 194, 176, 104, 48, 103, 22, 124, 2, 155, 223, 16, 90, 113, 85, 37, 203, 107, 53, 193, 161, 177, 160, 11, 93, 107, 105, 92, 49, 173, 33, 23, 71, 143, 163, 159, 59, 127, 98, 46, 53, 55, 23, 114, 244, 91, 28, 20, 5, 47, 39, 20, 218, 18, 181, 102, 87, 246, 163, 132, 79, 39, 2, 1, 58, 143, 196, 35, 160, 43, 204, 128, 15, 106, 206, 110, 118, 103, 72, 213, 228, 230, 228, 83, 177, 230, 28, 132, 240, 94, 189, 93, 124, 240, 214, 120, 241, 134, 205, 213, 209, 159, 56 }, "1234567890", 1, "student8" },
                    { new Guid("324ed66e-e8de-4710-a139-18c50b442945"), "Tran quoc toan", null, "student6@gmail.com", "Van", 4, false, "Ba", null, null, new byte[] { 196, 98, 207, 114, 144, 146, 97, 90, 176, 146, 6, 227, 79, 144, 39, 174, 9, 80, 9, 52, 174, 70, 166, 36, 134, 149, 200, 82, 234, 110, 191, 183, 98, 143, 155, 99, 106, 144, 202, 30, 82, 61, 81, 39, 250, 165, 220, 210, 126, 160, 40, 240, 198, 66, 204, 105, 229, 124, 57, 210, 178, 55, 45, 60 }, new byte[] { 104, 218, 20, 111, 168, 139, 94, 108, 141, 48, 162, 101, 73, 45, 29, 198, 106, 27, 5, 173, 140, 210, 115, 28, 160, 135, 171, 47, 16, 114, 117, 193, 182, 85, 146, 186, 137, 107, 74, 2, 151, 112, 40, 41, 204, 140, 133, 103, 89, 132, 63, 36, 43, 124, 233, 131, 199, 6, 246, 38, 50, 87, 50, 206, 164, 88, 31, 35, 234, 17, 52, 76, 215, 16, 166, 26, 24, 125, 233, 179, 14, 214, 75, 157, 187, 138, 97, 186, 28, 24, 47, 81, 112, 19, 145, 91, 6, 62, 76, 96, 251, 251, 80, 56, 171, 126, 244, 5, 192, 214, 175, 122, 182, 73, 102, 64, 93, 0, 97, 0, 235, 250, 22, 162, 168, 251, 83, 17 }, "1234567890", 1, "student6" },
                    { new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"), "Tran quoc toan", null, "student5@gmail.com", "Trinh", 5, false, "Tam", null, null, new byte[] { 88, 157, 92, 192, 128, 89, 115, 174, 130, 217, 19, 84, 5, 204, 193, 172, 219, 115, 195, 197, 173, 48, 204, 175, 61, 16, 94, 224, 147, 43, 94, 8, 218, 42, 112, 229, 196, 180, 157, 68, 26, 224, 90, 50, 124, 82, 103, 176, 199, 98, 41, 217, 220, 97, 145, 58, 70, 91, 217, 5, 28, 217, 38, 36 }, new byte[] { 21, 185, 97, 47, 138, 226, 90, 197, 150, 62, 12, 8, 123, 172, 133, 0, 146, 84, 5, 19, 125, 142, 211, 42, 41, 133, 71, 34, 84, 61, 79, 136, 218, 155, 183, 42, 74, 101, 70, 108, 174, 117, 160, 45, 128, 205, 37, 125, 171, 158, 203, 248, 217, 140, 238, 188, 169, 172, 132, 115, 8, 149, 176, 114, 69, 153, 57, 69, 234, 79, 202, 159, 117, 208, 220, 97, 14, 37, 178, 53, 17, 249, 231, 227, 174, 52, 161, 223, 156, 131, 102, 142, 153, 72, 149, 123, 130, 68, 16, 90, 6, 217, 106, 84, 156, 190, 11, 73, 82, 101, 76, 101, 179, 245, 203, 251, 217, 44, 233, 124, 141, 244, 16, 184, 234, 69, 117, 146 }, "1234567890", 1, "student5" },
                    { new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"), "Tran quoc toan", null, "student17@gmail.com", "Kim", 1, false, "Trong", null, null, new byte[] { 203, 161, 75, 9, 137, 151, 9, 171, 190, 57, 26, 229, 71, 52, 163, 241, 44, 215, 119, 98, 158, 109, 152, 157, 184, 82, 14, 21, 244, 56, 235, 247, 60, 193, 0, 135, 151, 234, 1, 172, 123, 166, 30, 146, 239, 42, 173, 19, 216, 144, 198, 225, 133, 198, 64, 71, 254, 119, 89, 253, 63, 90, 221, 29 }, new byte[] { 130, 185, 26, 64, 113, 109, 103, 228, 190, 13, 233, 129, 107, 180, 52, 144, 220, 85, 195, 33, 11, 18, 59, 133, 16, 213, 232, 47, 59, 105, 248, 172, 250, 58, 76, 108, 140, 235, 91, 49, 185, 100, 117, 237, 148, 217, 139, 136, 133, 108, 111, 208, 23, 56, 226, 186, 170, 147, 222, 54, 168, 30, 187, 157, 245, 74, 148, 192, 243, 139, 27, 236, 70, 217, 189, 8, 27, 227, 120, 7, 167, 88, 159, 191, 143, 149, 169, 110, 76, 206, 197, 110, 77, 74, 45, 214, 142, 50, 69, 200, 237, 245, 184, 183, 171, 234, 53, 59, 166, 175, 125, 103, 66, 169, 157, 39, 178, 30, 238, 60, 27, 168, 194, 1, 3, 160, 0, 93 }, "1234567890", 1, "student17" },
                    { new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"), "Tran quoc toan", null, "student2@gmail.com", "Minh", 6, false, "Duc", null, null, new byte[] { 63, 59, 249, 36, 180, 98, 221, 6, 36, 1, 39, 242, 149, 62, 152, 70, 3, 136, 224, 208, 20, 77, 194, 145, 24, 77, 181, 71, 165, 71, 187, 239, 46, 235, 6, 137, 204, 165, 135, 94, 142, 235, 167, 68, 117, 106, 132, 39, 121, 240, 61, 52, 143, 152, 224, 173, 200, 196, 53, 188, 72, 163, 11, 102 }, new byte[] { 174, 71, 72, 17, 3, 130, 253, 73, 145, 56, 203, 214, 84, 78, 118, 110, 18, 40, 29, 144, 22, 146, 137, 103, 37, 64, 84, 237, 93, 67, 224, 117, 209, 54, 120, 52, 2, 180, 120, 183, 81, 31, 107, 211, 87, 231, 1, 194, 135, 98, 207, 110, 254, 123, 94, 74, 59, 84, 113, 210, 40, 83, 228, 252, 175, 70, 140, 71, 34, 81, 82, 183, 182, 50, 188, 98, 175, 34, 124, 240, 63, 176, 134, 15, 137, 195, 204, 30, 14, 89, 171, 189, 101, 112, 187, 60, 214, 240, 178, 231, 78, 70, 203, 37, 54, 57, 231, 36, 167, 230, 32, 231, 51, 221, 107, 64, 166, 169, 188, 20, 124, 167, 83, 49, 101, 214, 130, 69 }, "1234567890", 1, "student2" },
                    { new Guid("666bc14a-4078-4619-85f1-bc63033c556f"), "Tran quoc toan", null, "student19@gmail.com", "Cach", 2, false, "Ly", null, null, new byte[] { 185, 188, 247, 63, 213, 238, 78, 130, 101, 20, 177, 45, 233, 148, 78, 186, 78, 139, 163, 48, 181, 59, 185, 214, 229, 175, 15, 3, 165, 237, 14, 3, 209, 196, 147, 109, 103, 181, 15, 61, 111, 237, 149, 253, 78, 95, 113, 165, 191, 120, 7, 148, 253, 108, 14, 209, 215, 8, 117, 86, 166, 182, 141, 70 }, new byte[] { 216, 196, 14, 85, 78, 107, 115, 124, 229, 19, 147, 13, 253, 38, 202, 19, 17, 8, 145, 48, 234, 136, 197, 63, 37, 88, 188, 41, 211, 208, 4, 177, 113, 37, 131, 164, 96, 170, 183, 110, 173, 51, 226, 58, 41, 42, 190, 12, 83, 148, 45, 45, 30, 92, 62, 108, 252, 232, 59, 168, 165, 57, 152, 242, 6, 109, 135, 152, 131, 88, 123, 243, 34, 130, 221, 246, 201, 254, 116, 248, 202, 8, 121, 7, 204, 113, 160, 193, 177, 248, 4, 115, 92, 49, 10, 190, 59, 42, 159, 189, 69, 69, 169, 108, 228, 240, 140, 4, 34, 6, 144, 183, 185, 117, 136, 1, 51, 209, 49, 149, 201, 101, 62, 240, 143, 80, 149, 153 }, "1234567890", 1, "student19" },
                    { new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"), "Tran quoc toan", null, "student11@gmail.com", "Nhan", 10, false, "Hong", null, null, new byte[] { 14, 167, 205, 8, 111, 145, 29, 124, 76, 9, 75, 243, 84, 20, 76, 109, 193, 222, 10, 78, 133, 231, 58, 49, 155, 223, 169, 78, 23, 221, 46, 189, 55, 17, 186, 155, 225, 240, 194, 66, 118, 52, 80, 197, 204, 255, 147, 255, 103, 151, 72, 89, 81, 109, 174, 48, 179, 234, 97, 3, 203, 254, 51, 255 }, new byte[] { 253, 237, 106, 223, 82, 44, 18, 2, 42, 174, 89, 232, 109, 95, 3, 236, 248, 90, 98, 203, 252, 127, 229, 104, 31, 169, 66, 122, 3, 183, 56, 23, 46, 179, 127, 29, 119, 161, 50, 232, 79, 125, 188, 16, 221, 225, 246, 14, 165, 181, 204, 243, 120, 34, 221, 4, 29, 35, 11, 219, 84, 211, 107, 124, 11, 38, 147, 169, 142, 33, 99, 214, 63, 199, 250, 237, 100, 226, 161, 136, 178, 207, 86, 170, 106, 12, 209, 191, 212, 25, 40, 222, 118, 48, 189, 4, 70, 15, 127, 31, 73, 237, 122, 155, 107, 254, 14, 122, 24, 255, 200, 173, 82, 51, 110, 10, 58, 235, 44, 138, 129, 171, 8, 169, 125, 63, 86, 11 }, "1234567890", 1, "student11" },
                    { new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"), "Tran quoc toan", null, "student9@gmail.com", "Ly", 1, false, "Lac", null, null, new byte[] { 67, 177, 202, 42, 136, 90, 46, 246, 114, 1, 74, 28, 92, 117, 111, 233, 3, 97, 49, 103, 30, 164, 12, 223, 61, 126, 118, 175, 46, 212, 190, 157, 212, 252, 184, 80, 38, 55, 49, 39, 129, 200, 159, 71, 22, 193, 151, 227, 15, 224, 142, 209, 229, 168, 216, 51, 126, 32, 133, 250, 92, 198, 39, 5 }, new byte[] { 23, 129, 245, 194, 113, 186, 127, 0, 154, 239, 28, 150, 201, 141, 103, 50, 73, 116, 40, 52, 166, 121, 24, 218, 43, 126, 152, 253, 161, 174, 26, 11, 146, 168, 87, 236, 133, 35, 40, 24, 176, 149, 28, 169, 244, 164, 70, 232, 217, 191, 204, 49, 75, 75, 130, 219, 236, 85, 232, 134, 243, 7, 156, 184, 102, 33, 170, 80, 52, 17, 220, 204, 77, 15, 101, 194, 2, 220, 93, 110, 65, 104, 118, 21, 6, 216, 206, 77, 213, 49, 190, 66, 5, 221, 62, 151, 114, 88, 173, 69, 54, 160, 42, 75, 46, 142, 65, 157, 7, 61, 24, 182, 225, 169, 4, 245, 52, 24, 13, 88, 50, 139, 142, 126, 187, 34, 142, 113 }, "1234567890", 1, "student9" },
                    { new Guid("8f744e72-da12-4038-a54e-7512a0ada884"), "Tran quoc toan", null, "student13@gmail.com", "Huan", 8, false, "Hoe", null, null, new byte[] { 89, 114, 4, 232, 150, 18, 73, 119, 108, 148, 70, 27, 220, 174, 240, 62, 57, 209, 191, 149, 62, 192, 146, 136, 124, 252, 171, 29, 255, 65, 238, 111, 223, 32, 142, 108, 149, 87, 152, 129, 43, 99, 201, 28, 96, 210, 236, 26, 30, 109, 97, 42, 228, 243, 246, 133, 54, 115, 124, 213, 36, 254, 98, 31 }, new byte[] { 192, 150, 19, 234, 12, 165, 2, 223, 69, 124, 163, 231, 105, 180, 224, 141, 119, 8, 141, 56, 34, 172, 35, 27, 113, 83, 197, 130, 141, 65, 4, 105, 106, 92, 119, 10, 106, 98, 73, 253, 14, 133, 24, 219, 19, 3, 25, 119, 124, 242, 64, 44, 51, 60, 223, 140, 146, 161, 80, 111, 31, 232, 220, 124, 91, 224, 220, 16, 114, 164, 23, 158, 6, 178, 90, 122, 209, 172, 206, 192, 71, 177, 165, 110, 50, 188, 72, 218, 73, 118, 114, 166, 195, 5, 32, 207, 161, 93, 127, 175, 242, 175, 228, 170, 153, 160, 127, 185, 252, 170, 118, 46, 136, 121, 185, 236, 62, 224, 222, 6, 229, 20, 200, 187, 160, 139, 193, 69 }, "1234567890", 1, "student13" },
                    { new Guid("96e0097f-ce73-4950-8ee2-89b313581154"), "Tran quoc toan", null, "student20@gmail.com", "Biet", 3, false, "Ly", null, null, new byte[] { 51, 250, 59, 239, 81, 179, 255, 208, 160, 83, 154, 38, 244, 234, 204, 85, 22, 140, 14, 164, 92, 138, 2, 173, 9, 254, 171, 222, 139, 185, 163, 106, 240, 45, 33, 15, 198, 13, 161, 133, 81, 105, 0, 31, 87, 182, 246, 164, 209, 23, 140, 87, 172, 245, 185, 72, 77, 129, 142, 51, 60, 204, 122, 202 }, new byte[] { 233, 129, 56, 221, 71, 111, 220, 77, 163, 71, 190, 29, 214, 229, 104, 84, 181, 22, 87, 53, 235, 181, 243, 53, 5, 25, 194, 6, 11, 72, 126, 33, 133, 178, 192, 235, 234, 21, 213, 250, 213, 140, 214, 124, 227, 85, 117, 231, 151, 150, 197, 243, 99, 105, 69, 96, 105, 159, 174, 191, 87, 28, 185, 175, 138, 9, 34, 222, 219, 50, 65, 95, 247, 239, 160, 55, 64, 58, 234, 247, 39, 70, 49, 85, 40, 86, 69, 187, 104, 126, 81, 196, 70, 88, 141, 87, 216, 236, 246, 59, 250, 219, 250, 243, 55, 161, 204, 138, 54, 64, 92, 108, 207, 110, 124, 117, 251, 113, 188, 32, 101, 10, 48, 96, 253, 16, 24, 51 }, "1234567890", 1, "student20" },
                    { new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"), "Tran quoc toan", null, "student16@gmail.com", "Trinh", 5, false, "Trong", null, null, new byte[] { 89, 43, 137, 140, 111, 98, 68, 218, 238, 21, 170, 8, 71, 166, 111, 213, 34, 207, 251, 110, 14, 117, 38, 6, 204, 207, 70, 60, 248, 113, 100, 113, 253, 6, 94, 78, 235, 84, 218, 38, 65, 45, 115, 143, 67, 133, 169, 18, 224, 203, 159, 99, 203, 111, 146, 160, 51, 148, 75, 163, 201, 163, 79, 212 }, new byte[] { 209, 122, 67, 211, 174, 62, 182, 178, 86, 75, 79, 78, 88, 88, 41, 103, 90, 177, 16, 174, 170, 142, 173, 143, 142, 122, 223, 44, 140, 164, 232, 120, 162, 213, 142, 65, 133, 72, 183, 163, 81, 39, 55, 145, 5, 85, 208, 77, 254, 246, 200, 233, 151, 96, 114, 123, 47, 193, 236, 171, 201, 155, 250, 133, 65, 1, 204, 115, 206, 130, 13, 43, 244, 192, 120, 219, 213, 232, 239, 92, 82, 69, 89, 80, 198, 14, 178, 225, 0, 155, 139, 227, 51, 184, 190, 7, 78, 67, 49, 160, 10, 54, 191, 41, 227, 216, 121, 153, 80, 47, 47, 134, 31, 169, 197, 216, 218, 21, 185, 114, 12, 30, 85, 57, 49, 154, 148, 162 }, "1234567890", 1, "student16" },
                    { new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"), "Tran quoc toan", null, "student18@gmail.com", "Kim", 10, false, "Ly", null, null, new byte[] { 212, 227, 41, 128, 63, 244, 51, 12, 124, 138, 225, 91, 113, 216, 235, 239, 111, 13, 221, 64, 81, 190, 95, 66, 148, 188, 109, 116, 40, 140, 11, 6, 241, 255, 242, 31, 97, 148, 172, 186, 77, 116, 140, 189, 123, 201, 45, 36, 44, 85, 218, 13, 228, 105, 167, 144, 11, 96, 123, 96, 16, 250, 105, 233 }, new byte[] { 190, 75, 182, 102, 220, 157, 177, 76, 223, 111, 182, 206, 123, 91, 80, 89, 5, 43, 79, 145, 250, 238, 78, 123, 238, 77, 93, 66, 253, 107, 187, 188, 139, 242, 194, 203, 171, 43, 100, 80, 70, 57, 158, 82, 181, 220, 160, 92, 114, 132, 81, 153, 43, 218, 78, 90, 247, 188, 87, 69, 234, 241, 158, 226, 66, 20, 86, 198, 178, 183, 195, 130, 21, 254, 147, 156, 180, 221, 95, 237, 176, 61, 43, 91, 163, 253, 23, 127, 73, 215, 15, 183, 210, 74, 113, 155, 70, 182, 25, 255, 164, 189, 137, 210, 156, 232, 100, 107, 122, 47, 78, 107, 183, 200, 87, 238, 97, 128, 204, 50, 98, 34, 247, 246, 161, 177, 22, 70 }, "1234567890", 1, "student18" },
                    { new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"), "Tran quoc toan", null, "student21@gmail.com", "Bien", 4, false, "Ly", null, null, new byte[] { 171, 82, 160, 7, 187, 245, 40, 70, 201, 230, 241, 27, 167, 173, 185, 138, 144, 61, 70, 120, 103, 25, 19, 184, 201, 75, 118, 181, 31, 35, 160, 13, 129, 58, 5, 129, 216, 152, 50, 33, 14, 254, 106, 32, 221, 177, 174, 28, 240, 8, 191, 35, 160, 107, 187, 118, 195, 168, 188, 250, 152, 96, 174, 200 }, new byte[] { 192, 50, 35, 139, 168, 35, 163, 252, 76, 109, 25, 41, 11, 222, 51, 85, 91, 125, 181, 160, 141, 232, 62, 212, 242, 21, 37, 21, 235, 212, 161, 232, 184, 229, 176, 27, 93, 194, 159, 100, 41, 231, 188, 150, 130, 250, 19, 162, 63, 170, 35, 205, 82, 136, 45, 1, 204, 211, 87, 237, 47, 139, 142, 67, 5, 146, 112, 78, 192, 2, 148, 166, 162, 114, 47, 62, 100, 174, 242, 90, 198, 110, 12, 172, 255, 33, 56, 110, 205, 237, 158, 59, 41, 180, 141, 211, 143, 16, 219, 129, 28, 107, 5, 45, 142, 73, 173, 206, 54, 26, 31, 81, 246, 45, 114, 225, 48, 3, 245, 63, 161, 174, 132, 54, 74, 209, 35, 107 }, "1234567890", 1, "student21" },
                    { new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"), "Tran quoc toan", null, "student10@gmail.com", "Tran", 9, false, "Hong", null, null, new byte[] { 213, 162, 52, 50, 102, 5, 35, 118, 163, 196, 214, 40, 162, 121, 222, 211, 17, 186, 134, 176, 15, 20, 8, 17, 111, 239, 246, 176, 244, 188, 86, 153, 141, 17, 66, 2, 49, 5, 72, 47, 162, 134, 137, 52, 180, 133, 201, 145, 242, 145, 27, 166, 119, 199, 18, 111, 93, 200, 23, 117, 56, 66, 238, 5 }, new byte[] { 33, 91, 40, 7, 212, 163, 96, 115, 155, 113, 47, 135, 89, 228, 31, 240, 217, 195, 88, 249, 97, 168, 169, 248, 169, 255, 52, 162, 189, 149, 12, 147, 233, 223, 139, 153, 163, 116, 138, 200, 73, 75, 206, 113, 182, 33, 137, 60, 75, 25, 86, 139, 192, 220, 37, 217, 220, 227, 28, 19, 159, 117, 144, 43, 175, 131, 9, 18, 137, 219, 177, 28, 78, 9, 243, 193, 181, 117, 200, 241, 192, 24, 252, 186, 100, 79, 180, 108, 184, 85, 220, 63, 32, 153, 240, 100, 156, 244, 139, 212, 184, 33, 243, 175, 145, 149, 139, 175, 211, 177, 194, 135, 158, 136, 54, 203, 107, 252, 185, 87, 39, 130, 168, 46, 64, 71, 209, 155 }, "1234567890", 1, "student10" },
                    { new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"), "Tran quoc toan", null, "student7@gmail.com", "Van", 3, false, "Hung", null, null, new byte[] { 95, 238, 210, 40, 211, 36, 158, 213, 242, 62, 32, 147, 164, 205, 111, 112, 75, 104, 207, 0, 124, 227, 124, 96, 254, 42, 172, 176, 29, 109, 253, 212, 172, 32, 45, 40, 38, 27, 208, 69, 214, 145, 248, 204, 29, 237, 40, 110, 239, 155, 77, 253, 185, 19, 105, 91, 179, 125, 140, 132, 70, 234, 22, 188 }, new byte[] { 152, 126, 80, 52, 15, 232, 171, 154, 140, 105, 174, 78, 44, 107, 128, 120, 246, 32, 122, 21, 129, 32, 236, 194, 250, 16, 184, 159, 181, 80, 199, 99, 121, 217, 241, 178, 34, 163, 103, 218, 246, 10, 161, 209, 99, 205, 72, 209, 247, 252, 199, 223, 217, 233, 181, 26, 238, 78, 75, 47, 104, 96, 118, 48, 199, 163, 199, 101, 8, 241, 233, 85, 247, 70, 101, 35, 0, 190, 61, 207, 235, 171, 228, 217, 196, 57, 232, 242, 246, 132, 165, 183, 230, 34, 188, 14, 148, 247, 227, 20, 115, 208, 47, 195, 41, 48, 89, 116, 123, 3, 34, 252, 27, 110, 82, 208, 111, 125, 254, 65, 219, 51, 78, 177, 93, 224, 118, 158 }, "1234567890", 1, "student7" },
                    { new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"), "Tran quoc toan", null, "student12@gmail.com", "Nhan", 7, false, "Chia", null, null, new byte[] { 97, 175, 76, 151, 215, 220, 97, 60, 180, 53, 182, 165, 21, 155, 110, 167, 184, 248, 67, 166, 231, 213, 92, 230, 5, 33, 173, 83, 130, 14, 100, 138, 31, 137, 126, 217, 4, 233, 81, 81, 197, 23, 212, 120, 1, 9, 88, 155, 109, 27, 205, 124, 151, 128, 163, 81, 132, 138, 43, 219, 251, 171, 242, 39 }, new byte[] { 111, 230, 113, 104, 249, 38, 27, 77, 170, 136, 72, 114, 66, 83, 23, 14, 60, 143, 228, 193, 137, 59, 18, 4, 220, 112, 229, 6, 81, 8, 181, 205, 168, 29, 129, 179, 59, 90, 157, 147, 60, 87, 225, 39, 203, 201, 176, 188, 195, 96, 152, 62, 220, 208, 66, 80, 115, 10, 65, 70, 111, 181, 94, 204, 130, 21, 157, 13, 158, 229, 119, 54, 74, 252, 51, 155, 118, 18, 71, 45, 88, 123, 113, 189, 34, 69, 251, 92, 86, 57, 242, 59, 143, 239, 193, 70, 3, 242, 21, 237, 158, 76, 111, 159, 49, 201, 251, 221, 13, 225, 169, 4, 124, 113, 184, 89, 213, 152, 100, 251, 100, 3, 181, 176, 211, 211, 158, 103 }, "1234567890", 1, "student12" },
                    { new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"), "Tran quoc toan", null, "student3@gmail.com", "Minh", 7, false, "Quan", null, null, new byte[] { 95, 73, 53, 0, 22, 3, 64, 63, 42, 56, 198, 218, 238, 226, 139, 75, 24, 72, 69, 184, 63, 135, 98, 193, 60, 157, 224, 8, 50, 25, 5, 224, 34, 47, 246, 156, 113, 0, 21, 0, 177, 66, 14, 67, 124, 33, 99, 0, 16, 161, 246, 183, 20, 230, 233, 121, 232, 222, 249, 59, 133, 217, 155, 238 }, new byte[] { 184, 135, 83, 120, 157, 15, 88, 10, 137, 122, 88, 219, 176, 10, 175, 24, 25, 201, 139, 31, 193, 57, 128, 127, 228, 174, 52, 52, 14, 97, 108, 155, 58, 94, 87, 111, 208, 128, 14, 127, 46, 235, 16, 84, 223, 120, 20, 29, 126, 126, 167, 36, 33, 77, 157, 39, 247, 102, 94, 129, 87, 98, 66, 24, 215, 222, 45, 131, 211, 205, 246, 242, 111, 198, 195, 28, 76, 99, 20, 108, 17, 251, 4, 121, 2, 191, 226, 192, 119, 36, 189, 75, 47, 103, 40, 111, 131, 116, 12, 51, 115, 102, 220, 232, 46, 121, 116, 83, 0, 221, 122, 100, 183, 25, 114, 181, 136, 7, 146, 100, 218, 159, 18, 17, 189, 188, 137, 167 }, "1234567890", 1, "student3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"));

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 12, 14, 59, 40, 683, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 11, 13, 14, 59, 40, 683, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "HighestScore", "PasswordHash", "PasswordSalt" },
                values: new object[] { 10, new byte[] { 45, 197, 6, 3, 227, 30, 167, 235, 37, 75, 160, 55, 152, 149, 211, 122, 13, 47, 120, 114, 233, 133, 77, 156, 146, 214, 11, 137, 108, 34, 92, 18, 182, 226, 165, 141, 85, 138, 240, 101, 42, 26, 232, 72, 23, 147, 108, 81, 89, 91, 33, 104, 147, 181, 73, 161, 30, 237, 115, 99, 30, 3, 15, 99 }, new byte[] { 233, 188, 178, 217, 183, 240, 140, 148, 32, 162, 61, 235, 152, 237, 46, 96, 253, 88, 199, 149, 251, 126, 193, 199, 201, 28, 106, 106, 90, 21, 10, 222, 60, 97, 109, 232, 10, 36, 49, 30, 173, 8, 9, 244, 118, 184, 221, 154, 137, 230, 134, 206, 98, 5, 122, 189, 200, 234, 244, 161, 165, 71, 87, 79, 6, 136, 118, 93, 13, 116, 57, 145, 223, 227, 40, 95, 190, 75, 14, 181, 11, 54, 207, 203, 189, 234, 196, 95, 88, 174, 186, 28, 30, 170, 253, 191, 118, 218, 202, 152, 201, 43, 27, 92, 230, 33, 24, 99, 4, 152, 242, 68, 185, 208, 58, 205, 205, 202, 96, 39, 233, 208, 157, 4, 69, 255, 143, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 7, 4, 214, 145, 39, 145, 250, 194, 198, 231, 43, 69, 104, 249, 52, 108, 78, 130, 114, 241, 191, 199, 147, 144, 173, 129, 167, 162, 240, 230, 163, 144, 139, 178, 226, 249, 166, 0, 151, 2, 254, 198, 22, 174, 241, 247, 130, 25, 231, 0, 48, 250, 116, 185, 160, 215, 161, 26, 92, 70, 19, 46, 171 }, new byte[] { 62, 133, 6, 54, 135, 208, 141, 91, 35, 210, 131, 154, 211, 216, 243, 112, 233, 60, 81, 208, 48, 255, 247, 178, 126, 8, 212, 170, 111, 112, 40, 224, 68, 161, 81, 25, 98, 66, 235, 228, 208, 185, 27, 191, 55, 91, 153, 159, 60, 178, 182, 231, 70, 128, 58, 173, 241, 250, 121, 124, 147, 182, 60, 65, 5, 36, 235, 195, 100, 68, 183, 222, 124, 188, 97, 129, 41, 155, 30, 47, 107, 57, 218, 252, 76, 72, 137, 28, 248, 78, 178, 201, 129, 114, 113, 187, 245, 39, 220, 50, 182, 155, 80, 112, 221, 73, 226, 206, 244, 1, 57, 222, 41, 219, 100, 101, 155, 10, 109, 177, 159, 124, 219, 68, 144, 32, 167, 171 } });
        }
    }
}
