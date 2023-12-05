using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class university : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "University",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "NOW()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 5, 3, 4, 21, 677, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 12, 6, 3, 4, 21, 677, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                column: "Description",
                value: "Các ngành sư phạm-giáo dục");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), "HD", null, "Các ngành về hải dương học", false, null, null, "Hải dương", 21f },
                    { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), "TP", null, "Các ngành về thực phẩm", false, null, null, "Thực phẩm", 20f },
                    { new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), "CK", null, "Các ngành về cơ khí", false, null, null, "Cơ khí", 23f },
                    { new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), "NK", null, "Các ngành về năng khiếu", false, null, null, "Năng Khiếu", 27f },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), "XD", null, "Các ngành về xây dựng-kiến trúc", false, null, null, "Xây Dựng", 20f },
                    { new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), "CA", null, "Các ngành về công an- quân đội", false, null, null, "Công an- quân đội", 20f },
                    { new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"), "CT", null, "Các ngành về chính trị", false, null, null, "Chính trị", 30f },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), "KD", null, "Các ngành về kinh doanh-marketing", false, null, null, "Kinh doanh", 22f },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), "TC", null, "Các ngành về tài chính-ngân hàng", false, null, null, "Tài chính", 26f },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), "LG", null, "Các ngành về logistics", false, null, null, "Logistics", 27f },
                    { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), "TH", null, "Các ngành về toán học", false, null, null, "Toán học", 25f },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), "KT", null, "Các ngành về kỹ thuật", false, null, null, "Kỹ Thuật", 26f },
                    { new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), "DM", null, "Các ngành về dệt may", false, null, null, "Dệt May", 20f },
                    { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), "DL", null, "Các ngành về du lịch", false, null, null, "Du lịch", 25f },
                    { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), "QL", null, "Các ngành về quản lý-lưu trữ thông tin", false, null, null, "Quản lý-Lưu trữ thông tin", 25f },
                    { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), "MT", null, "Các ngành về môi trường", false, null, null, "Môi trường", 26f }
                });

            migrationBuilder.InsertData(
                table: "University",
                columns: new[] { "Id", "Code", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("059779f5-c84c-455a-85d0-798ca039ba72"), "VINUNI", null, "Trường đại học tư thục phi lợi nhuận được thành lập bởi Tập đoàn Vingroup – tập đoàn tư nhân lớn nhất Việt Nam", false, null, null, "Trường Đại học VinUni" },
                    { new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"), "HUB", null, "Trường đại học công lập trực thuộc Ngân hàng Nhà nước Việt Nam được thành lập từ ngày 16/12/1976.", false, null, null, "Trường Đại học Ngân hàng TP.HCM" },
                    { new Guid("166d0a24-7e52-45af-a795-d8e082d3749a"), "UFM", null, "Trường đại học công lập chuyên ngành về nhóm ngành tài chính và quản lý tại miền Nam Việt Nam", false, null, null, "Trường Đại học Tài chính – Marketing" },
                    { new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8"), "HUS", null, "trường đại học với mô hình kết hợp giữa đào tạo và huấn luyện", false, null, null, "Trường Đại học Thể dục Thể thao TP. HCM" },
                    { new Guid("253fca55-c797-4f1d-8c83-a66d81342921"), "IUH", null, "Trường đại học định hướng ứng dụng và thực hành, chuyên đào tạo nhóm ngành kinh tế công nghiệp và kỹ thuật công nghiệp", false, null, null, "Trường Đại học Công nghiệp TP.HCM" },
                    { new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"), "HCMCOU", null, "có nhiệm vụ đào tạo đại học và sau đại học, với các hình thức đào tạo chính quy và giáo dục thường xuyên, đào tạo các điểm vệ tinh", false, null, null, "Trường Đại học Mở" },
                    { new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), "HCMIU", null, "Trường đại học công lập đa ngành đầu tiên tại Việt Nam giảng dạy hoàn toàn tiếng Anh", false, null, null, "Trường Đại học Quốc tế" },
                    { new Guid("314a233c-a95f-4026-992a-75a708d07838"), "UEL", null, "Trường đại học đào tạo và nghiên cứu khối ngành kinh tế, kinh doanh quản lý và luật hàng đầu Việt Nam", false, null, null, "Trường Đại học Kinh tế – Luật TP.HCM" },
                    { new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"), "VGU", null, "Trường đại học công lập của Việt Nam được xây dựng trên cơ sở quan hệ đối tác chặt chẽ với CHLB Đức", false, null, null, "Trường Đại học Việt Đức" },
                    { new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"), "HUIT", null, "Trường đại học đạt chuẩn kiểm định chất lượng giáo dục với chương trình đào tạo đa ngành,đa lĩnh vực, có thế mạnh trong lĩnh vực công nghiệp và thương mại.", false, null, null, "Trường Đại học Công Thương" },
                    { new Guid("3fdd5b92-3e52-4434-8f21-176732be0cc1"), "PPU", null, "trường đại học công lập trực thuộc Bộ Công an tại Việt Nam đào tạo trình độ và phẩm chất cán bộ Cảnh sát nhân dân ở bậc đại học và sau đại học", false, null, null, "Trường Đại học Cảnh sát Nhân dân" },
                    { new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"), "HCMUS", null, "Trường đại học đầu ngành về đào tạo, nghiên cứu khoa học cơ bản, khoa học công nghệ và ứng dụng ở miền Nam Việt Nam.", false, null, null, "Trường Đại học Khoa học Tự nhiên TPHCM" },
                    { new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"), "TLUS", null, "Trường đại học số 1 trong việc đào tạo lĩnh vực thủy lợi, môi trường, phòng chống và giảm nhẹ thiên tai.", false, null, null, "Trường Đại học Thủy Lợi TP.HCM" },
                    { new Guid("778c4103-05d3-4dab-9019-7196f6772dc8"), "SKDAHCM", null, "Trường đại học chuyên đào tạo nhóm ngành sân khấu, điện ảnh và nghệ thuật tại Thành phố Hồ Chí Minh.", false, null, null, "Trường Đại học Sân khấu – Điện ảnh TP.HCM" },
                    { new Guid("7d8960c2-ee10-4813-9522-106512a9b802"), "UPES", null, "Trường đại học đào tạo về giáo dục thể chất và đào tạo chuẩn hóa giáo viên thể dục theo định chuẩn của Bộ Giáo dục và Đào tạo Việt Nam.", false, null, null, "Trường Đại học Sư phạm Thể dục Thể thao" },
                    { new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), "HCMUT", null, "Trường đại học đầu ngành về lĩnh vực kỹ thuật ở miền Nam Việt Nam", false, null, null, "Trường Đại học Bách Khoa TP.Hồ Chí Minh" },
                    { new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80"), "HCMUFA", null, " Trường đại học chuyên ngành về đào tạo nhóm ngành mỹ thuật tại Việt Nam.", false, null, null, "Trường Đại học Mỹ thuật TP.HCM" },
                    { new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"), "ULSA2", null, "Trường đại học đào tạo các khối ngành kinh tế, xã hội; nghiên cứu và ứng dụng khoa học phục vụ giáo dục, đào tạo và phát triển kinh tế - xã hội", false, null, null, "Trường Đại học Lao động – Xã hội cơ sở 2" },
                    { new Guid("abf76dc2-7086-4836-badb-a520e720caaa"), "HCMUNRE", null, "Trường đại học đào tạo các chuyên ngành kinh tế, kỹ thuật, môi trường, khí hậu, biển - hải đảo, trắc địa - bản đồ, đất đai, địa chất, khí tượng, thủy văn,...", false, null, null, "Trường Đại học Tài nguyên – Môi trường TPHCM" },
                    { new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f"), "TDNU", null, "Trường đại học kỹ thuật được thành lập ngày 12 tháng 05 năm 1975 trên cơ sở nâng cấp Trường Sĩ quan Kỹ thuật quân sự.", false, null, null, "Trường Đại học Trần Đại Nghĩa" },
                    { new Guid("b8620337-894a-4339-926e-dff2cd9f09ba"), "HCMUC", null, "Trường đại học đào tạo và nghiên cứu khoa học các lĩnh vực: văn hóa, nghệ thuật, thông tin và du lịch.", false, null, null, "Trường Đại học Văn hóa TP.HCM" },
                    { new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), "HCMUSSH", null, "Trường là trung tâm nghiên cứu, đào tạo trong lĩnh vực khoa học xã hội và nhân văn lớn nhất miền Nam.", false, null, null, "Trường Đại học Khoa học Xã hội và Nhân văn TP.HCM" },
                    { new Guid("b9647f7b-e9a0-4636-80f9-45364c8b04a9"), "UIT", null, "Trường đại học công lập đào tạo về công nghệ thông tin và truyền thông", false, null, null, "Trường Đại học Công nghệ Thông tin TP.HCM" },
                    { new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"), "HCMUTE", null, "Trường đại học đa ngành tại Việt Nam, với thế mạnh về đào tạo kỹ thuật", false, null, null, "Trường Đại học Sư phạm - Kỹ thuật TP.HCM" },
                    { new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"), "TDTU", null, "Trường đại học công lập đầu tiên tại Việt Nam có cơ sở vật chất và điều kiện giảng dạy được xếp hạng quốc tế", false, null, null, "Trường Đại học Tôn Đức Thắng" },
                    { new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"), "UTH", null, "Trường đại học đa ngành thuộc lĩnh vực giao thông vận tải lớn nhất phía Nam Việt Nam.", false, null, null, "Trường Đại học Giao thông Vận tải TP.HCM" }
                });

            migrationBuilder.InsertData(
                table: "UniversityDepartments",
                columns: new[] { "DepartmentId", "UniversityId", "CreatedBy", "CreatedDate", "Id", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"), null, null, new Guid("6c552337-a58e-493d-90f4-ff6299dfbd0a"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"), null, null, new Guid("0fbe70bd-b478-419b-88ff-af343c7845ac"), false, null, null },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"), null, null, new Guid("93527c9b-71fa-4cb9-9286-a0fe534a7608"), false, null, null },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("947274a7-eb7b-4b23-aad3-db2072eb3a75"), false, null, null },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("fe7b7c28-eadc-4313-81a8-eca850f6a64f"), false, null, null },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("e864f3ea-4d1c-49ad-9e09-8b4a30530b5a"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("d77354a4-913c-4a11-97e3-4ca47c0f5424"), false, null, null },
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62"), null, null, new Guid("c01ede3f-21a6-4925-ac48-2e922094ba83"), false, null, null },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), null, null, new Guid("46233795-1b64-448a-a629-21c12c40c804"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), null, null, new Guid("57f0e5e0-e41f-4d51-813a-ef55550902d7"), false, null, null },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), null, null, new Guid("8c3ee2a4-a9f1-4ff4-b09a-9242f7cf6bc6"), false, null, null }
                });

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

            migrationBuilder.InsertData(
                table: "UniversityDepartments",
                columns: new[] { "DepartmentId", "UniversityId", "CreatedBy", "CreatedDate", "Id", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("3480333c-c628-4cd3-af80-53872212f1a3"), false, null, null },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("9de361f7-863f-4d47-9cf4-2807752ca358"), false, null, null },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("75ec74b5-2ddf-48be-a62d-4c5eab61b701"), false, null, null },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("ff27b635-bd80-4ee4-ba0f-cfb6318a03e2"), false, null, null },
                    { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("e169a6d4-b586-499d-b199-8aee1b8b0d54"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"), null, null, new Guid("6896fad6-879e-4583-ba11-7893aefcc4a9"), false, null, null },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("314a233c-a95f-4026-992a-75a708d07838"), null, null, new Guid("ed88daa5-98b5-4788-9974-bde351adb4b8"), false, null, null },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("314a233c-a95f-4026-992a-75a708d07838"), null, null, new Guid("7b048c7d-d707-4fc5-b2e1-a4d220a05ab3"), false, null, null },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("314a233c-a95f-4026-992a-75a708d07838"), null, null, new Guid("9f7d7dfe-35ca-496a-8685-c33f490a7778"), false, null, null },
                    { new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"), null, null, new Guid("8ff923b2-9857-419e-b6ce-f46a02a3fd0f"), false, null, null },
                    { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"), null, null, new Guid("afcfae3f-de36-44d4-b62e-e9f4016bdf98"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"), null, null, new Guid("3c82ef12-2e05-4fba-804b-142411e06608"), false, null, null },
                    { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"), null, null, new Guid("b1c7db3c-5adc-45eb-94b4-c05b15dc7dc1"), false, null, null },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("d42f497b-9196-4a29-9b23-3cbb9f2a9ccf"), false, null, null },
                    { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("a41470c0-9762-4441-9a8a-cc3510b372f7"), false, null, null },
                    { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), null, null, new Guid("aa55a474-c4b8-4a7c-8020-4639863d2009"), false, null, null },
                    { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), null, null, new Guid("2e17c493-2af0-4b21-9ec3-f53348865341"), false, null, null },
                    { new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), null, null, new Guid("c35a6c55-f88b-400f-9b1b-812e78e7b871"), false, null, null },
                    { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), null, null, new Guid("0e755d4f-1cdb-4b91-a371-f2db5e9e9dc2"), false, null, null },
                    { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), null, null, new Guid("ccac8532-50f8-4eb9-a4ff-f77a61532875"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"), null, null, new Guid("f4c4958c-9e2b-4131-9a02-452543deee11"), false, null, null },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), null, null, new Guid("eac04805-6163-49b7-96f2-83116100f3e4"), false, null, null },
                    { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), null, null, new Guid("4b6d3441-73c4-4c43-9210-7f5b02d0c408"), false, null, null },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), null, null, new Guid("5182c122-8173-46cf-8ff4-0f2abe45b2e2"), false, null, null },
                    { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), null, null, new Guid("5b718b0e-33a5-455b-9023-350ec9ba15d6"), false, null, null },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"), null, null, new Guid("a64675d4-f7f3-4fa0-8cf4-f9c416494f84"), false, null, null },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("b9647f7b-e9a0-4636-80f9-45364c8b04a9"), null, null, new Guid("1b5409e3-c83d-4456-9a97-3a7bfc0ea1da"), false, null, null },
                    { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), null, null, new Guid("5d18842d-3612-46a4-a0a8-bc6f633c0a27"), false, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("059779f5-c84c-455a-85d0-798ca039ba72"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("0de6a90f-780c-41a4-9920-3dc6a86e3f11"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("166d0a24-7e52-45af-a795-d8e082d3749a"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("1d5312be-a745-4a4a-b1df-41abd3dc01e8"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("253fca55-c797-4f1d-8c83-a66d81342921"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("2721d2b3-c6e1-4253-8823-cf73744e0190"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("3d6888a4-17b8-4173-9f12-7ce55983d1cc"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("3fdd5b92-3e52-4434-8f21-176732be0cc1"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("6d35b512-5dcc-49af-9f26-29eddd7f475c"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("778c4103-05d3-4dab-9019-7196f6772dc8"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("7d8960c2-ee10-4813-9522-106512a9b802"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("8ae6dc6f-c859-4fb9-b038-366470876d80"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("98f712a7-3847-46f7-90cc-2e3cb2348123"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("abf76dc2-7086-4836-badb-a520e720caaa"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("b83746d5-641b-40ef-9804-a8fb7ae9fb4f"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("b8620337-894a-4339-926e-dff2cd9f09ba"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("d1ee778a-2d89-402f-aa5e-c914315dbc3f"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("ddb202ca-e224-48d6-a463-6b32ed962693"));

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("0e7c3b01-d954-4986-9d9d-f48127433211") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("314a233c-a95f-4026-992a-75a708d07838") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("314a233c-a95f-4026-992a-75a708d07838") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("314a233c-a95f-4026-992a-75a708d07838") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("b9647f7b-e9a0-4636-80f9-45364c8b04a9") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") });

            migrationBuilder.DeleteData(
                table: "UniversityDepartments",
                keyColumns: new[] { "DepartmentId", "UniversityId" },
                keyValues: new object[] { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072") });

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("934b3542-92d5-431c-9271-f39dedcac50f"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("2a5d2d04-9d41-4279-9337-5b0039ee1b23"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("314a233c-a95f-4026-992a-75a708d07838"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("83e4e060-f70a-4fb3-b828-e8f1443d3f46"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("b8ec3722-2649-4738-8316-38ffd56ed04d"));

            migrationBuilder.DeleteData(
                table: "University",
                keyColumn: "Id",
                keyValue: new Guid("b9647f7b-e9a0-4636-80f9-45364c8b04a9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "University",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValueSql: "NOW()");

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 3, 11, 2, 25, 971, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 12, 4, 11, 2, 25, 971, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                column: "Description",
                value: "Các ngành sư phạm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 242, 166, 224, 173, 215, 243, 114, 1, 46, 112, 234, 15, 128, 42, 236, 236, 35, 216, 198, 124, 55, 15, 159, 252, 172, 5, 34, 48, 230, 213, 172, 12, 253, 247, 219, 1, 51, 8, 165, 253, 160, 150, 43, 109, 105, 207, 53, 68, 104, 40, 154, 198, 97, 62, 246, 141, 175, 248, 227, 42, 95, 147, 122 }, new byte[] { 111, 2, 210, 8, 7, 200, 185, 132, 223, 39, 235, 128, 219, 165, 33, 16, 33, 12, 118, 87, 121, 221, 251, 96, 7, 214, 127, 81, 131, 124, 1, 80, 141, 242, 28, 157, 192, 32, 51, 13, 105, 22, 177, 123, 109, 55, 87, 140, 62, 231, 230, 75, 236, 19, 74, 206, 40, 193, 112, 134, 135, 133, 51, 140, 33, 63, 208, 59, 169, 188, 245, 157, 66, 73, 36, 30, 61, 68, 159, 57, 37, 116, 51, 85, 226, 187, 181, 68, 36, 38, 41, 151, 8, 255, 195, 212, 80, 239, 208, 37, 97, 177, 206, 113, 78, 131, 37, 227, 132, 152, 173, 103, 238, 182, 192, 228, 97, 254, 114, 254, 229, 4, 179, 158, 48, 94, 72, 232 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 228, 103, 36, 36, 119, 97, 30, 237, 33, 6, 184, 181, 234, 237, 188, 245, 88, 128, 236, 1, 56, 206, 231, 21, 42, 13, 156, 70, 214, 143, 10, 188, 86, 24, 110, 187, 218, 86, 94, 224, 105, 109, 121, 151, 176, 83, 95, 3, 62, 172, 183, 77, 13, 58, 232, 149, 50, 219, 201, 63, 32, 154, 28, 43 }, new byte[] { 213, 177, 140, 71, 25, 51, 202, 61, 231, 40, 170, 35, 95, 233, 176, 18, 84, 94, 133, 219, 236, 223, 5, 97, 151, 110, 221, 82, 137, 147, 19, 141, 220, 81, 179, 255, 26, 92, 202, 185, 128, 123, 203, 0, 51, 92, 98, 73, 194, 119, 77, 2, 147, 203, 80, 211, 145, 179, 43, 10, 62, 83, 129, 162, 213, 95, 160, 252, 84, 79, 136, 80, 67, 215, 44, 18, 199, 200, 145, 95, 213, 208, 120, 187, 11, 171, 183, 172, 0, 167, 247, 192, 150, 100, 196, 251, 25, 207, 64, 140, 253, 148, 12, 148, 231, 215, 38, 119, 9, 240, 130, 115, 11, 171, 134, 127, 110, 201, 55, 82, 166, 160, 77, 8, 149, 50, 61, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 59, 127, 1, 114, 88, 214, 46, 16, 251, 249, 119, 124, 95, 244, 112, 6, 241, 221, 34, 141, 189, 177, 24, 155, 105, 151, 74, 138, 25, 4, 137, 46, 170, 3, 91, 138, 34, 235, 34, 39, 188, 158, 23, 105, 126, 238, 156, 68, 223, 226, 202, 225, 94, 232, 74, 137, 200, 188, 9, 198, 152, 194, 18 }, new byte[] { 32, 107, 139, 129, 231, 9, 97, 163, 16, 46, 200, 24, 132, 246, 21, 63, 229, 50, 175, 4, 232, 48, 228, 42, 245, 251, 129, 1, 106, 110, 136, 107, 194, 95, 253, 73, 51, 124, 158, 68, 197, 101, 72, 8, 9, 148, 109, 22, 162, 70, 202, 149, 181, 13, 162, 14, 211, 176, 16, 24, 179, 203, 156, 235, 161, 243, 231, 172, 85, 64, 139, 36, 137, 222, 147, 10, 202, 36, 156, 200, 164, 204, 2, 186, 143, 99, 11, 171, 242, 67, 252, 114, 70, 101, 77, 11, 145, 133, 38, 54, 153, 36, 203, 248, 125, 186, 192, 255, 189, 141, 68, 170, 64, 194, 163, 128, 33, 3, 51, 121, 16, 110, 37, 152, 204, 100, 72, 135 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 187, 90, 190, 4, 34, 106, 69, 174, 71, 208, 191, 147, 14, 234, 42, 244, 239, 0, 155, 20, 47, 98, 11, 57, 185, 4, 145, 218, 253, 220, 55, 55, 243, 134, 56, 43, 198, 175, 30, 218, 104, 27, 121, 81, 185, 48, 172, 151, 136, 212, 60, 248, 179, 237, 184, 178, 77, 12, 216, 26, 58, 40, 214, 74 }, new byte[] { 164, 97, 68, 115, 162, 134, 203, 35, 43, 61, 129, 194, 76, 78, 49, 178, 239, 165, 17, 70, 249, 100, 248, 223, 143, 213, 67, 162, 20, 176, 152, 127, 20, 137, 46, 172, 32, 20, 228, 241, 97, 83, 151, 184, 82, 179, 134, 216, 99, 205, 4, 37, 109, 148, 32, 214, 98, 129, 146, 8, 210, 81, 212, 88, 236, 96, 30, 81, 12, 138, 5, 199, 247, 61, 30, 46, 213, 44, 161, 145, 210, 6, 143, 153, 17, 55, 255, 117, 59, 72, 145, 238, 61, 51, 253, 24, 230, 86, 78, 140, 116, 72, 245, 43, 23, 47, 216, 83, 196, 217, 108, 218, 100, 194, 32, 195, 185, 52, 191, 52, 133, 224, 148, 118, 31, 133, 144, 89 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 143, 223, 197, 113, 198, 143, 241, 153, 80, 34, 87, 64, 88, 126, 213, 226, 131, 248, 227, 1, 196, 199, 230, 167, 123, 158, 85, 243, 131, 224, 236, 193, 246, 142, 98, 243, 68, 200, 126, 65, 72, 28, 123, 140, 18, 243, 48, 124, 173, 178, 237, 226, 161, 22, 41, 43, 155, 90, 194, 26, 32, 233, 209 }, new byte[] { 168, 13, 250, 86, 64, 179, 26, 245, 19, 146, 218, 224, 31, 229, 197, 103, 38, 201, 71, 67, 7, 43, 83, 240, 211, 103, 75, 142, 75, 210, 54, 209, 152, 147, 232, 217, 137, 244, 235, 185, 23, 32, 235, 24, 168, 186, 25, 0, 49, 213, 192, 133, 200, 140, 123, 236, 100, 224, 222, 2, 147, 165, 253, 134, 60, 172, 216, 82, 242, 65, 89, 221, 193, 117, 39, 144, 50, 202, 207, 49, 121, 162, 152, 118, 104, 7, 10, 30, 0, 223, 217, 37, 225, 19, 107, 228, 93, 214, 170, 43, 157, 137, 254, 145, 185, 164, 176, 193, 238, 247, 19, 241, 40, 173, 132, 56, 219, 212, 48, 181, 39, 92, 248, 97, 88, 232, 173, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 151, 170, 145, 150, 212, 240, 241, 15, 168, 3, 203, 146, 164, 146, 23, 129, 186, 127, 165, 222, 158, 193, 199, 79, 90, 7, 138, 69, 127, 174, 3, 249, 253, 226, 216, 102, 77, 91, 161, 156, 214, 29, 199, 40, 241, 6, 104, 52, 117, 180, 169, 174, 82, 111, 122, 169, 129, 249, 5, 245, 225, 123, 123, 39 }, new byte[] { 144, 113, 109, 70, 119, 185, 200, 113, 58, 127, 81, 128, 140, 64, 5, 198, 187, 250, 67, 81, 160, 123, 93, 102, 82, 90, 48, 33, 84, 79, 253, 95, 181, 130, 47, 248, 115, 85, 43, 171, 27, 190, 26, 99, 231, 137, 219, 85, 81, 93, 14, 37, 220, 239, 21, 139, 43, 153, 38, 101, 43, 169, 8, 136, 19, 190, 172, 245, 251, 214, 209, 115, 131, 135, 216, 211, 170, 170, 180, 156, 89, 87, 181, 216, 139, 188, 186, 194, 188, 162, 72, 22, 29, 143, 235, 21, 132, 10, 48, 221, 77, 85, 172, 68, 243, 47, 159, 41, 252, 233, 7, 175, 154, 138, 9, 224, 135, 187, 137, 12, 118, 167, 177, 213, 229, 195, 48, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 148, 77, 227, 60, 177, 215, 99, 233, 143, 47, 8, 13, 10, 186, 224, 188, 251, 148, 74, 231, 94, 133, 150, 163, 230, 116, 140, 242, 3, 112, 9, 104, 139, 72, 24, 114, 62, 1, 171, 6, 7, 246, 122, 249, 134, 98, 75, 90, 237, 204, 132, 162, 191, 246, 212, 141, 2, 174, 117, 85, 238, 46, 109 }, new byte[] { 49, 107, 180, 203, 53, 192, 163, 42, 191, 23, 39, 169, 108, 124, 130, 173, 36, 227, 46, 170, 46, 187, 222, 45, 184, 51, 247, 156, 213, 128, 251, 77, 7, 238, 244, 174, 106, 138, 182, 178, 174, 37, 58, 46, 35, 40, 118, 10, 245, 125, 32, 11, 116, 126, 114, 169, 16, 245, 226, 130, 127, 226, 117, 199, 206, 86, 231, 226, 27, 120, 228, 1, 195, 208, 252, 87, 129, 112, 36, 97, 209, 34, 81, 225, 174, 195, 96, 225, 90, 87, 22, 219, 240, 7, 3, 114, 35, 152, 108, 37, 17, 11, 150, 26, 134, 47, 29, 123, 138, 118, 46, 234, 193, 203, 48, 234, 27, 154, 218, 151, 216, 188, 156, 92, 8, 14, 142, 32 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 85, 251, 75, 205, 132, 79, 186, 15, 100, 163, 232, 237, 145, 71, 93, 95, 90, 244, 57, 131, 87, 218, 119, 204, 230, 159, 211, 82, 196, 42, 126, 82, 221, 185, 216, 33, 157, 130, 7, 170, 244, 225, 202, 194, 19, 191, 247, 209, 58, 75, 177, 19, 154, 74, 245, 70, 209, 166, 38, 232, 222, 94, 251, 85 }, new byte[] { 0, 190, 176, 2, 132, 66, 254, 62, 188, 22, 0, 48, 88, 13, 30, 197, 165, 69, 249, 202, 177, 211, 231, 150, 20, 122, 35, 160, 67, 241, 193, 175, 23, 149, 191, 218, 42, 77, 156, 62, 94, 5, 86, 28, 18, 201, 180, 185, 181, 13, 36, 23, 19, 200, 212, 37, 34, 105, 85, 176, 32, 241, 194, 100, 223, 195, 80, 42, 174, 149, 115, 121, 120, 79, 189, 35, 249, 69, 37, 43, 146, 190, 104, 50, 204, 27, 232, 243, 124, 165, 21, 65, 199, 233, 0, 67, 21, 68, 240, 150, 8, 136, 99, 213, 66, 173, 24, 236, 169, 29, 176, 82, 180, 67, 41, 101, 69, 36, 145, 47, 152, 228, 115, 36, 224, 34, 198, 23 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 113, 166, 46, 202, 132, 45, 219, 35, 123, 170, 44, 152, 149, 41, 183, 151, 174, 166, 177, 14, 58, 117, 212, 166, 115, 146, 66, 183, 207, 88, 45, 189, 201, 67, 174, 179, 113, 82, 58, 111, 77, 224, 236, 148, 224, 221, 26, 233, 107, 106, 215, 221, 28, 108, 71, 163, 135, 115, 7, 88, 62, 174, 104 }, new byte[] { 179, 113, 31, 26, 229, 45, 62, 235, 45, 32, 183, 231, 56, 170, 64, 206, 74, 131, 98, 129, 234, 108, 139, 81, 228, 243, 174, 94, 249, 75, 9, 11, 87, 181, 60, 228, 15, 189, 207, 215, 116, 150, 118, 128, 7, 2, 91, 173, 71, 195, 32, 163, 56, 179, 183, 21, 137, 111, 13, 105, 138, 231, 247, 136, 67, 171, 11, 82, 182, 54, 12, 58, 173, 7, 242, 147, 168, 8, 137, 37, 161, 24, 40, 253, 170, 26, 159, 159, 112, 252, 29, 239, 115, 139, 196, 252, 82, 252, 194, 25, 165, 77, 90, 5, 244, 6, 251, 151, 128, 32, 50, 9, 215, 128, 78, 18, 68, 234, 1, 82, 78, 10, 188, 22, 249, 220, 130, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 162, 122, 23, 168, 164, 122, 104, 244, 248, 149, 58, 221, 166, 46, 24, 68, 117, 65, 135, 204, 172, 234, 17, 241, 137, 165, 125, 122, 239, 75, 191, 231, 165, 50, 15, 131, 181, 81, 244, 202, 69, 58, 223, 4, 135, 227, 223, 148, 141, 235, 67, 47, 94, 229, 243, 92, 64, 226, 134, 52, 153, 140, 150, 23 }, new byte[] { 91, 97, 185, 190, 130, 114, 81, 170, 28, 194, 83, 30, 246, 90, 102, 186, 111, 231, 97, 43, 103, 93, 62, 33, 103, 160, 74, 136, 32, 55, 233, 230, 169, 234, 248, 140, 125, 213, 239, 77, 131, 232, 235, 26, 29, 60, 117, 18, 149, 211, 187, 116, 42, 211, 202, 240, 117, 45, 222, 112, 196, 126, 174, 69, 234, 99, 74, 42, 105, 170, 255, 42, 49, 66, 252, 65, 52, 250, 182, 244, 122, 6, 4, 23, 210, 35, 30, 110, 82, 2, 189, 171, 3, 27, 98, 223, 105, 228, 58, 125, 135, 223, 24, 228, 244, 46, 192, 116, 53, 84, 144, 166, 233, 194, 187, 196, 126, 42, 145, 11, 165, 20, 95, 71, 67, 179, 249, 23 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 101, 181, 231, 16, 180, 248, 233, 38, 250, 158, 3, 106, 246, 14, 170, 99, 144, 164, 37, 81, 255, 225, 48, 29, 77, 27, 50, 234, 15, 102, 137, 20, 121, 1, 48, 170, 196, 130, 143, 252, 51, 70, 79, 30, 34, 168, 186, 240, 8, 138, 46, 146, 28, 67, 69, 64, 200, 79, 123, 129, 213, 5, 138, 88 }, new byte[] { 192, 109, 8, 84, 123, 209, 125, 235, 185, 220, 67, 173, 75, 196, 155, 39, 102, 163, 63, 44, 175, 211, 157, 72, 191, 250, 145, 66, 153, 27, 241, 173, 172, 27, 173, 179, 145, 21, 213, 60, 93, 164, 46, 210, 88, 93, 158, 20, 152, 34, 245, 163, 96, 52, 177, 169, 241, 250, 109, 245, 5, 209, 192, 245, 150, 24, 83, 175, 163, 221, 205, 151, 10, 21, 50, 130, 139, 110, 240, 252, 141, 58, 99, 236, 166, 188, 50, 31, 105, 37, 172, 216, 41, 94, 116, 15, 185, 170, 60, 9, 198, 194, 51, 172, 68, 103, 153, 139, 250, 90, 179, 223, 140, 115, 204, 11, 8, 132, 239, 16, 195, 145, 30, 34, 38, 2, 56, 210 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 12, 62, 0, 145, 184, 35, 118, 128, 248, 46, 246, 66, 243, 37, 2, 51, 251, 154, 45, 130, 132, 137, 76, 132, 179, 252, 220, 254, 129, 81, 94, 33, 185, 172, 0, 170, 118, 65, 165, 148, 39, 240, 1, 158, 77, 157, 216, 155, 78, 63, 44, 84, 1, 57, 155, 131, 6, 172, 40, 5, 173, 114, 82, 106 }, new byte[] { 94, 154, 87, 202, 119, 101, 33, 51, 193, 208, 126, 8, 141, 223, 166, 39, 140, 100, 226, 121, 139, 59, 244, 195, 209, 8, 6, 192, 75, 78, 217, 31, 14, 207, 236, 190, 101, 92, 35, 47, 191, 73, 243, 80, 40, 192, 49, 152, 115, 40, 14, 243, 106, 90, 12, 242, 148, 182, 191, 130, 155, 22, 131, 29, 223, 43, 19, 168, 188, 136, 9, 112, 58, 123, 27, 138, 58, 42, 38, 70, 117, 121, 63, 83, 170, 118, 156, 200, 26, 89, 230, 146, 219, 188, 151, 219, 237, 146, 224, 43, 38, 22, 97, 98, 181, 4, 198, 36, 203, 69, 123, 207, 85, 115, 228, 182, 160, 209, 10, 239, 58, 71, 171, 96, 173, 42, 110, 172 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 181, 223, 225, 255, 187, 195, 134, 235, 20, 123, 26, 0, 69, 72, 134, 182, 25, 25, 11, 135, 122, 128, 13, 58, 228, 197, 191, 50, 7, 241, 97, 31, 166, 13, 133, 154, 88, 158, 163, 104, 49, 140, 21, 152, 98, 7, 194, 34, 124, 6, 198, 45, 43, 84, 5, 203, 231, 107, 240, 184, 76, 204, 19, 114 }, new byte[] { 220, 168, 218, 197, 35, 5, 160, 126, 166, 146, 51, 82, 70, 78, 6, 7, 45, 52, 240, 23, 90, 215, 121, 68, 127, 21, 150, 232, 209, 126, 45, 98, 212, 146, 34, 144, 206, 101, 37, 35, 81, 114, 87, 118, 215, 124, 186, 193, 60, 91, 52, 58, 45, 18, 0, 159, 183, 114, 154, 45, 61, 66, 19, 149, 77, 122, 221, 3, 56, 241, 164, 227, 84, 33, 205, 50, 255, 254, 158, 45, 157, 90, 71, 139, 147, 86, 133, 241, 214, 186, 201, 111, 43, 211, 141, 63, 70, 171, 82, 212, 125, 245, 156, 165, 11, 216, 17, 77, 195, 84, 187, 114, 97, 165, 95, 43, 228, 80, 254, 20, 201, 67, 104, 80, 111, 134, 15, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 101, 111, 96, 101, 102, 49, 138, 4, 106, 67, 172, 111, 238, 196, 151, 25, 137, 199, 24, 71, 119, 80, 14, 84, 225, 228, 222, 170, 81, 253, 6, 67, 218, 231, 222, 131, 106, 111, 29, 227, 214, 111, 34, 187, 147, 219, 232, 8, 241, 226, 217, 215, 13, 223, 228, 225, 63, 174, 71, 187, 11, 224, 25, 160 }, new byte[] { 168, 55, 49, 187, 11, 109, 151, 115, 215, 86, 62, 180, 218, 199, 62, 40, 143, 57, 28, 192, 178, 139, 12, 181, 30, 111, 112, 22, 8, 235, 68, 197, 245, 175, 241, 227, 195, 233, 71, 42, 57, 101, 124, 63, 19, 124, 97, 170, 68, 254, 133, 136, 171, 203, 92, 68, 27, 197, 105, 145, 4, 211, 13, 65, 238, 57, 4, 20, 181, 172, 34, 199, 166, 210, 37, 170, 164, 216, 40, 226, 93, 10, 36, 120, 163, 155, 222, 213, 165, 59, 1, 60, 124, 134, 137, 223, 243, 57, 3, 176, 100, 79, 172, 129, 218, 108, 31, 77, 106, 67, 120, 86, 69, 93, 19, 163, 245, 99, 14, 192, 146, 212, 79, 148, 63, 67, 43, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 253, 11, 121, 220, 140, 148, 165, 199, 209, 21, 52, 85, 43, 191, 185, 161, 212, 76, 114, 128, 195, 180, 226, 155, 168, 94, 15, 184, 138, 9, 68, 191, 119, 21, 21, 176, 71, 45, 17, 94, 85, 104, 27, 220, 165, 125, 133, 58, 12, 25, 245, 84, 116, 0, 189, 48, 169, 182, 226, 203, 37, 191, 38 }, new byte[] { 58, 247, 179, 32, 84, 24, 96, 75, 110, 142, 65, 255, 230, 147, 82, 98, 63, 47, 145, 234, 184, 201, 43, 126, 106, 81, 196, 246, 231, 255, 202, 169, 88, 29, 212, 79, 193, 111, 142, 96, 180, 157, 133, 167, 75, 181, 67, 112, 52, 112, 145, 223, 100, 199, 130, 19, 12, 25, 225, 145, 145, 175, 203, 41, 245, 246, 48, 75, 239, 133, 217, 191, 38, 113, 99, 91, 134, 12, 84, 0, 99, 162, 254, 40, 254, 222, 80, 218, 238, 124, 77, 164, 207, 34, 207, 17, 32, 220, 51, 247, 38, 89, 126, 104, 34, 106, 42, 66, 211, 4, 34, 35, 21, 60, 103, 91, 13, 227, 19, 176, 181, 212, 15, 252, 26, 184, 54, 209 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 124, 237, 251, 112, 225, 35, 244, 245, 122, 55, 233, 183, 29, 132, 40, 190, 31, 1, 99, 129, 130, 95, 190, 178, 191, 198, 27, 99, 14, 69, 170, 73, 187, 117, 8, 212, 163, 64, 208, 196, 226, 135, 48, 45, 151, 6, 56, 7, 86, 4, 75, 7, 111, 224, 195, 209, 24, 195, 129, 176, 96, 157, 255 }, new byte[] { 30, 82, 96, 33, 105, 157, 127, 140, 163, 132, 152, 135, 33, 203, 188, 114, 149, 52, 40, 89, 54, 137, 174, 80, 18, 91, 171, 214, 168, 2, 86, 8, 232, 200, 212, 251, 191, 81, 201, 156, 130, 201, 157, 160, 144, 127, 68, 223, 218, 131, 170, 46, 66, 241, 241, 119, 53, 46, 97, 190, 17, 100, 214, 218, 206, 125, 246, 12, 255, 203, 87, 226, 188, 189, 210, 191, 114, 48, 133, 201, 128, 52, 83, 114, 141, 107, 222, 255, 161, 155, 199, 40, 115, 74, 52, 95, 72, 89, 89, 108, 166, 80, 206, 81, 32, 188, 8, 103, 4, 199, 243, 82, 206, 138, 61, 171, 137, 156, 197, 184, 238, 201, 103, 41, 58, 130, 205, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 242, 150, 147, 59, 156, 0, 88, 221, 238, 47, 59, 26, 159, 188, 105, 99, 101, 58, 19, 142, 125, 38, 215, 135, 0, 81, 221, 20, 187, 4, 201, 83, 33, 53, 74, 127, 57, 129, 29, 224, 135, 88, 114, 53, 238, 217, 108, 0, 225, 148, 113, 196, 124, 27, 85, 221, 206, 81, 228, 28, 216, 142, 27 }, new byte[] { 109, 113, 164, 229, 47, 65, 176, 251, 251, 100, 20, 215, 60, 142, 101, 77, 170, 182, 171, 88, 219, 73, 103, 146, 214, 84, 55, 115, 169, 234, 224, 240, 41, 78, 196, 78, 13, 26, 83, 28, 161, 13, 202, 56, 212, 200, 25, 39, 238, 231, 254, 5, 186, 161, 197, 142, 54, 56, 32, 203, 73, 97, 101, 127, 235, 171, 172, 3, 242, 177, 47, 53, 48, 9, 135, 110, 195, 171, 5, 71, 54, 74, 183, 22, 188, 197, 118, 215, 217, 14, 45, 37, 114, 223, 44, 74, 207, 105, 6, 217, 186, 82, 105, 201, 15, 157, 183, 62, 120, 179, 193, 123, 100, 110, 223, 88, 31, 178, 170, 180, 43, 16, 51, 186, 128, 246, 136, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 157, 120, 184, 250, 6, 27, 122, 246, 53, 100, 28, 229, 238, 24, 220, 64, 3, 254, 79, 40, 19, 115, 195, 103, 48, 181, 138, 68, 6, 75, 120, 191, 8, 220, 176, 15, 197, 128, 49, 203, 27, 102, 136, 16, 206, 73, 71, 208, 109, 37, 90, 157, 105, 68, 129, 4, 50, 249, 180, 6, 4, 205, 226 }, new byte[] { 149, 64, 42, 69, 197, 37, 154, 175, 36, 85, 156, 180, 22, 190, 79, 137, 103, 188, 53, 89, 101, 9, 83, 137, 93, 31, 152, 194, 184, 5, 199, 5, 215, 215, 87, 35, 120, 206, 68, 87, 200, 182, 34, 186, 138, 228, 214, 100, 3, 109, 30, 114, 233, 47, 188, 189, 1, 8, 147, 210, 153, 39, 79, 98, 79, 143, 96, 11, 44, 89, 158, 103, 207, 16, 29, 57, 56, 71, 142, 180, 168, 140, 218, 211, 196, 156, 5, 59, 120, 194, 238, 44, 195, 66, 24, 124, 158, 21, 195, 193, 17, 110, 89, 213, 235, 171, 37, 65, 203, 7, 147, 65, 26, 203, 156, 199, 185, 144, 235, 76, 13, 25, 151, 253, 23, 96, 119, 51 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 68, 134, 208, 174, 200, 50, 225, 38, 56, 197, 219, 241, 224, 233, 159, 107, 189, 0, 178, 255, 70, 208, 251, 241, 78, 88, 64, 194, 140, 88, 236, 55, 42, 71, 16, 30, 152, 185, 91, 138, 184, 215, 234, 252, 62, 38, 52, 192, 61, 135, 105, 46, 175, 23, 95, 118, 132, 192, 58, 11, 129, 174, 191 }, new byte[] { 66, 45, 36, 202, 139, 151, 164, 23, 201, 3, 242, 201, 255, 135, 33, 194, 7, 145, 25, 150, 231, 224, 9, 247, 47, 104, 172, 224, 30, 52, 117, 171, 116, 196, 238, 125, 200, 218, 67, 13, 87, 162, 219, 148, 194, 232, 86, 113, 42, 206, 199, 46, 179, 121, 99, 49, 58, 242, 28, 22, 204, 209, 230, 49, 156, 166, 111, 1, 17, 13, 156, 99, 234, 90, 37, 213, 131, 218, 230, 8, 64, 152, 140, 241, 57, 76, 66, 220, 12, 2, 161, 19, 56, 5, 174, 213, 193, 15, 134, 33, 210, 179, 207, 92, 25, 154, 144, 20, 15, 248, 46, 42, 28, 146, 102, 162, 222, 238, 216, 7, 244, 15, 11, 27, 169, 233, 64, 183 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 10, 170, 109, 150, 176, 79, 65, 183, 190, 39, 183, 92, 26, 97, 59, 241, 166, 90, 102, 213, 46, 104, 170, 244, 30, 99, 155, 78, 219, 197, 53, 107, 231, 134, 72, 39, 224, 120, 76, 86, 41, 219, 50, 53, 202, 135, 163, 180, 198, 175, 121, 35, 200, 60, 191, 162, 106, 14, 58, 84, 66, 183, 229 }, new byte[] { 134, 49, 59, 39, 89, 250, 89, 154, 172, 196, 112, 237, 218, 249, 52, 39, 183, 65, 120, 99, 17, 54, 142, 234, 33, 190, 9, 21, 215, 88, 14, 121, 235, 183, 165, 0, 73, 88, 95, 189, 47, 53, 50, 154, 84, 32, 187, 175, 197, 64, 49, 240, 3, 16, 66, 36, 89, 5, 180, 244, 32, 189, 209, 48, 208, 148, 162, 157, 180, 99, 156, 27, 195, 249, 58, 60, 76, 130, 250, 9, 142, 164, 165, 230, 0, 92, 194, 64, 120, 197, 171, 205, 212, 108, 165, 48, 114, 66, 58, 210, 85, 138, 121, 143, 199, 173, 142, 44, 35, 187, 198, 59, 29, 231, 245, 104, 187, 106, 255, 55, 141, 49, 165, 208, 203, 9, 92, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 250, 17, 63, 170, 216, 253, 84, 127, 227, 173, 247, 173, 80, 95, 194, 51, 58, 156, 192, 218, 182, 200, 97, 252, 87, 46, 189, 53, 1, 40, 13, 16, 49, 180, 158, 181, 104, 169, 126, 218, 251, 46, 127, 70, 141, 90, 99, 193, 218, 46, 130, 210, 214, 33, 55, 189, 162, 36, 127, 76, 113, 81, 186, 100 }, new byte[] { 214, 225, 80, 150, 1, 236, 245, 201, 213, 107, 163, 181, 132, 87, 62, 244, 117, 37, 161, 97, 105, 247, 229, 222, 221, 17, 128, 34, 104, 120, 184, 60, 204, 142, 188, 25, 207, 197, 143, 235, 93, 38, 180, 46, 37, 193, 40, 190, 202, 218, 172, 238, 96, 252, 142, 179, 180, 201, 74, 169, 85, 127, 216, 11, 7, 245, 177, 209, 76, 222, 97, 164, 140, 202, 161, 96, 69, 69, 253, 103, 127, 17, 104, 133, 26, 207, 12, 90, 163, 85, 234, 94, 122, 53, 192, 162, 146, 242, 228, 109, 233, 176, 38, 21, 253, 187, 7, 61, 139, 1, 107, 185, 123, 62, 206, 188, 95, 12, 160, 27, 146, 1, 241, 86, 240, 120, 169, 254 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 134, 244, 127, 102, 181, 84, 114, 129, 35, 45, 149, 163, 112, 163, 233, 204, 200, 54, 189, 187, 194, 11, 143, 196, 24, 96, 152, 213, 83, 111, 133, 195, 49, 75, 34, 2, 239, 129, 0, 205, 31, 180, 193, 115, 61, 171, 239, 118, 28, 26, 164, 239, 82, 212, 174, 111, 140, 76, 184, 15, 30, 87, 175 }, new byte[] { 96, 112, 202, 147, 41, 77, 142, 57, 244, 141, 161, 3, 87, 46, 127, 35, 91, 237, 47, 79, 14, 30, 121, 227, 78, 123, 222, 35, 95, 49, 242, 37, 205, 3, 42, 99, 10, 166, 64, 135, 145, 196, 18, 170, 188, 163, 131, 99, 113, 243, 11, 203, 214, 179, 110, 175, 57, 247, 60, 104, 31, 111, 79, 20, 168, 147, 219, 20, 78, 227, 34, 150, 222, 187, 88, 18, 13, 30, 244, 134, 133, 148, 91, 220, 41, 61, 232, 213, 185, 233, 46, 213, 132, 218, 62, 93, 242, 123, 155, 167, 210, 147, 97, 68, 49, 127, 8, 168, 31, 133, 249, 151, 7, 177, 112, 164, 142, 218, 37, 205, 142, 99, 183, 98, 36, 226, 116, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 26, 140, 88, 112, 88, 178, 201, 211, 165, 56, 248, 143, 135, 72, 171, 206, 178, 196, 255, 44, 80, 95, 148, 206, 36, 183, 79, 94, 208, 68, 101, 221, 42, 211, 252, 235, 1, 90, 79, 122, 152, 167, 44, 110, 221, 20, 101, 151, 0, 223, 52, 204, 239, 41, 247, 24, 127, 234, 196, 212, 108, 182, 217, 189 }, new byte[] { 144, 77, 72, 30, 86, 70, 117, 143, 10, 222, 48, 106, 10, 142, 251, 202, 150, 204, 223, 125, 164, 107, 222, 6, 149, 114, 242, 153, 35, 225, 1, 61, 210, 26, 134, 85, 45, 225, 140, 108, 97, 196, 247, 17, 86, 94, 28, 98, 160, 42, 51, 150, 170, 49, 168, 172, 182, 116, 163, 120, 154, 148, 56, 234, 56, 128, 77, 36, 175, 25, 85, 10, 66, 34, 35, 226, 28, 94, 153, 73, 105, 19, 149, 227, 192, 122, 208, 15, 241, 218, 38, 38, 46, 69, 121, 18, 114, 134, 143, 8, 70, 77, 61, 169, 197, 157, 67, 143, 65, 25, 181, 175, 50, 84, 122, 233, 77, 103, 201, 92, 203, 162, 104, 66, 147, 108, 137, 127 } });
        }
    }
}
