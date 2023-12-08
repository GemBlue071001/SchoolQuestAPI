using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class major3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Major",
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
                values: new object[] { new DateTime(2023, 12, 8, 2, 8, 47, 575, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 12, 9, 2, 8, 47, 575, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "Id", "Code", "CreatedBy", "DepartmentId", "Description", "IsDeleted", "MajorName", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0035306f-de5e-4c60-9e55-4f2282e7dda9"), "NNA", null, new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), "Ngành học đào tạo kỹ năng về ngôn ngữ Anh", false, "Ngôn ngữ Anh", null, null },
                    { new Guid("0273f179-b2ae-434d-835f-6035e8b6ae52"), "DVKDATH", null, new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), "Ngành học đào tạo kỹ năng về diễn viên kịch, điện ảnh - truyền hình", false, "Diễn viên kịch, điện ảnh - truyền hình", null, null },
                    { new Guid("07951ef0-d8df-47a3-82c2-c16dd3a16a3f"), "TTQT", null, new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), "Ngành học đào tạo kỹ năng về truyền thông quốc tế", false, "Truyền thông quốc tế", null, null },
                    { new Guid("0ab02d77-61fb-46ea-8340-7236296c4022"), "NNN", null, new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), "Ngành học đào tạo kỹ năng về ngôn ngữ Nhật", false, "Ngôn ngữ Nhật", null, null },
                    { new Guid("0af0e064-0927-45b7-b9cc-8e8a49996c1c"), "HH", null, new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), "Ngành học đào tạo kỹ năng về lĩnh vực hội họa", false, "Hội họa", null, null },
                    { new Guid("0c7c4a30-d3d1-48ea-9526-1b31fe4c0103"), "CNDM", null, new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), "Ngành học đào tạo kỹ năng về công nghệ dệt,may", false, "Công nghệ dệt,may", null, null },
                    { new Guid("0d036fb3-5ff7-4b63-86db-4342a62f886e"), "CNCTM", null, new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ chế tạo máy", false, "Công nghệ chế tạo máy", null, null },
                    { new Guid("0e9599e3-0279-4ac6-8af5-eb14b3f1e584"), "KTXD", null, new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật xây dựng", false, "Kỹ thuật xây dựng", null, null },
                    { new Guid("1569cd2c-deef-4d74-bdcd-f785f52b465d"), "TCDN", null, new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), "Ngành học đào tạo kỹ năng về tài chính doanh nghiệp", false, "Tài chính doanh nghiệp", null, null },
                    { new Guid("17d5462c-3a8a-4e93-b5e6-69d36186577e"), "DK", null, new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "Đào tạo nghệ thuật điêu khắc", false, "Điêu khắc", null, null },
                    { new Guid("19d935fe-5772-48a6-98bd-782450be775a"), "QHCC", null, new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), "Ngành học đào tạo kỹ năng về lĩnh vực quan hệ công chúng", false, "Quan hệ công chúng", null, null },
                    { new Guid("1a111b2a-1eac-4132-92ef-90b985ae0101"), "YK", null, new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "Ngành học về chẩn đoán, điều trị bệnh và nâng cao sức khỏe", false, "Y khoa", null, null },
                    { new Guid("1b320b9a-3eac-4336-92ef-90b985aec101"), "QTKD", null, new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "Ngành học về quản lý và điều hành các hoạt động trong doanh nghiệp", false, "Quản trị kinh doanh", null, null },
                    { new Guid("1dcd3794-f8d5-4d4e-9788-74a3b9426421"), "SPNV", null, new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "Đào tạo giáo viên ngữ văn", false, "Sư phạm ngữ văn", null, null },
                    { new Guid("2332343e-e798-496b-9ea5-841bdc10552a"), "KHTV", null, new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), "Ngành học đào tạo kỹ năng về lĩnh vực khoa học thư viện", false, "Khoa học thư viện", null, null },
                    { new Guid("2445d565-594a-419b-ab0a-bcd87c2b9a2a"), "LGS", null, new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), "Ngành học đào tạo kỹ năng về lĩnh vực logistics", false, "Logistics", null, null },
                    { new Guid("2793f8f1-98fb-4b13-b5e1-04085ae78762"), "DLĐC", null, new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), "Ngành học đào tạo kỹ năng về lĩnh vực du lịch địa chất", false, "Du lịch địa chất", null, null },
                    { new Guid("282b4ad3-d00d-4275-97ae-7480635636e8"), "ĐLTN", null, new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), "Ngành học đào tạo kỹ năng về lĩnh vực địa lý tự nhiên", false, "Địa lý tự nhiên", null, null },
                    { new Guid("2b222b3a-2eac-4233-93ef-80b985ae0202"), "DH", null, new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "Ngành học về nghiên cứu, phát triển và sản xuất thuốc", false, "Dược học", null, null },
                    { new Guid("2b49fa02-7c48-45ab-9f81-4605ff991bd4"), "QLCCU", null, new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), "Ngành học đào tạo kỹ năng về lĩnh vực quản lý chuỗi cung ứng", false, "Quản lý chuỗi cung ứng", null, null },
                    { new Guid("2b72f32c-5d96-4b5d-ae68-597bbeead505"), "ATTT", null, new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "Nghiên cứu và bảo mật hệ thống thông tin", false, "An toàn thông tin", null, null },
                    { new Guid("2c430b7a-5eac-4536-93ef-80b985aec202"), "TMĐT", null, new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "Ngành học về kinh doanh trực tuyến sử dụng nền tảng công nghệ thông tin với sự hỗ trợ của Internet để thực hiện các giao dịch mua bán, trao đổi, thanh toán trực tuyến.", false, "Thương mại điện tử", null, null },
                    { new Guid("2fa7fc82-948a-45bb-a33e-b37a98579b05"), "QP", null, new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), "Ngành học đào tạo kỹ năng về quay phim", false, "Quay phim", null, null },
                    { new Guid("317f2de4-b76e-4d4b-8b0a-94166493623e"), "VHVN", null, new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), "Ngành học đào tạo kỹ năng về tiếng Việt và văn hóa Việt Nam", false, "Tiếng Việt và văn hóa Việt Nam", null, null },
                    { new Guid("31b92a5b-8354-450f-a023-6e7d74349ab4"), "LHP", null, new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), "Ngành học đào tạo kỹ năng về luật Hiến pháp và luật hành chính", false, "Luật Hiến pháp và luật hành chính", null, null },
                    { new Guid("335f8cf8-94b0-47bd-ba70-eb2aaf0c07b1"), "TN", null, new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thanh nhạc", false, "Thanh nhạc", null, null },
                    { new Guid("348cdef7-2ec8-4814-883b-c41218128a3c"), "TVH", null, new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), "Ngành học đào tạo kỹ năng về thủy văn học", false, "Thủy văn học", null, null },
                    { new Guid("387c472b-1f7d-4655-838c-80982b8f9e24"), "TKĐH", null, new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "Thiết kế các sản phẩm truyền thông đồ họa", false, "Thiết kế đồ họa", null, null },
                    { new Guid("3c25899c-f1a5-48d0-9276-03ef9fd60a24"), "LDS", null, new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), "Ngành học đào tạo kỹ năng về luật dân sự và tố tụng dân sự", false, "Luật dân sự và tố tụng dân sự", null, null },
                    { new Guid("3c333b4a-3eac-4333-94ef-70b985ae0303"), "DD", null, new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "Ngành học về chăm sóc người bệnh tại các cơ sở y tế", false, "Điều dưỡng", null, null },
                    { new Guid("3d550b8a-6eac-4636-92ef-70b985aec303"), "KDQT", null, new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "Ngành học về kinh doanh và thương mại giữa các quốc gia", false, "Kinh doanh quốc tế", null, null },
                    { new Guid("42308b7d-8d80-4077-a960-433b4eb6ec7a"), "QLVH", null, new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), "Ngành học đào tạo kỹ năng về lĩnh vực quản lý văn hóa", false, "Quản lý văn hóa", null, null },
                    { new Guid("44929c3d-dd91-4405-9d4e-f4be315b7fbb"), "TKNT", null, new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "Thiết kế các sản phẩm nội thất", false, "Thiết kế nội thất", null, null },
                    { new Guid("4989ef16-62cd-4aa1-850f-ef6a8e2b3b2c"), "KTVT", null, new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế vận tải", false, "Kinh tế vận tải", null, null },
                    { new Guid("4c97f72e-0560-449e-a32d-7fac374b5bbf"), "QLNN", null, new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"), "Ngành học đào tạo kỹ năng về lĩnh vực quản lý nhà nước", false, "Quản lý nhà nước", null, null },
                    { new Guid("4d444b5a-4eac-4434-95ef-60b985ae0404"), "RHM", null, new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "Ngành học về phục hình, nha khoa và chỉnh nha", false, "Răng-Hàm-Mặt", null, null },
                    { new Guid("4e661b9a-7eac-4736-92ef-60b985aec404"), "KT", null, new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "Ngành học về công tác ghi chép, phân tích và kiểm tra các nghiệp vụ tài chính", false, "Kế toán", null, null },
                    { new Guid("524954ba-d75f-4cd7-a2af-acf23d383a05"), "CNVL", null, new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), "Ngành học đào tạo kỹ năng về công nghệ vật liệu dệt, may", false, "Công nghệ vật liệu dệt, may", null, null },
                    { new Guid("56306665-f58b-4188-8613-578b0fe470ed"), "KT", null, new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), "Ngành học đào tạo kỹ năng về lĩnh vực kiến trúc", false, "Kiến trúc", null, null },
                    { new Guid("5c1310fb-b35b-4529-beb1-79664cc85fc6"), "QLVH", null, new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), "Ngành học đào tạo kỹ năng về quản lý văn hóa", false, "Quản lý văn hóa", null, null },
                    { new Guid("5e555b6a-5eac-4535-96ef-50b985ae0505"), "YHCT", null, new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "Ngành học về phương pháp chữa bệnh bằng y học cổ truyền", false, "Y học cổ truyền", null, null },
                    { new Guid("5ee2fae8-eae3-495a-95b6-303307cb596c"), "KTTNTN", null, new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế tài nguyên thiên nhiên", false, "Kinh tế tài nguyên thiên nhiên", null, null },
                    { new Guid("5f246722-c823-466e-a024-254ba25d1750"), "HDH", null, new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), "Ngành học đào tạo kỹ năng về hải dương học", false, "Hải dương học", null, null },
                    { new Guid("6090009b-8534-4200-a83b-f544d9be8732"), "QSCS", null, new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), "Ngành học đào tạo kỹ năng về lĩnh vực quân sự cơ sở", false, "Quân sự cơ sở", null, null },
                    { new Guid("63da08f2-e70f-488d-8d5a-eb24063697e5"), "KHMT", null, new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "Nghiên cứu lý thuyết và thuật toán máy tính", false, "Khoa học máy tính", null, null },
                    { new Guid("667330de-e435-45d1-ab72-4d6504cbba14"), "KTHN", null, new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật hạt nhân", false, "Kỹ thuật hạt nhân", null, null },
                    { new Guid("66e52181-c48e-4fcc-a68e-421a02a9443e"), "TM", null, new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), "Ngành học đào tạo kỹ năng về lĩnh vực thương mại", false, "Thương mại", null, null },
                    { new Guid("6b9f2a3b-e60e-45ef-b5ec-056b362cf874"), "KHHH", null, new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), "Ngành học đào tạo kỹ năng về lĩnh vực khoa học hàng hải", false, "Khoa học hàng hải", null, null },
                    { new Guid("6d3f0b5b-f3f1-444b-a642-e83b527d7c3a"), "KHMT", null, new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), "Ngành học đào tạo kỹ năng về lĩnh vực khoa học môi trường", false, "Khoa học môi trường", null, null },
                    { new Guid("71bbd6ba-141b-4990-b2fa-28d59e026c75"), "LHS", null, new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), "Ngành học đào tạo kỹ năng về luật dân sự và tố tụng dân sự", false, "Luật hình sự và tố tụng hình sự", null, null },
                    { new Guid("74757d60-d6c9-4cf3-a657-8f01bf8c42c7"), "QLTNMT", null, new Guid("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"), "Ngành học đào tạo kỹ năng về lĩnh vực quản lý tài nguyên và môi trường", false, "Quản lý tài nguyên và môi trường", null, null },
                    { new Guid("748bbfcd-20b9-4be4-8ec5-522afcc5caf4"), "QLB", null, new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), "Ngành học đào tạo kỹ năng về quản lý biển", false, "Quản lý biển", null, null },
                    { new Guid("7e623947-4413-48ab-a0e1-c797405f5f10"), "CTXH", null, new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"), "Ngành học đào tạo kỹ năng về lĩnh vực công tác xã hội", false, "Công tác xã hội", null, null },
                    { new Guid("7ea9448b-e686-49e2-a0df-c425bd44f3ea"), "QLGD", null, new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "Đào tạo quản lý ngành giáo dục", false, "Quản lý giáo dục", null, null },
                    { new Guid("8136a6cf-c815-4d9e-9888-399d76d7c8e1"), "KTHK", null, new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật hàng không", false, "Kỹ thuật hàng không", null, null },
                    { new Guid("820d7547-37d2-480a-84bf-a3cae888b55c"), "THQ", null, new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), "Ngành học đào tạo kỹ năng về thuế - Hải quan", false, "Thuế - Hải quan", null, null },
                    { new Guid("825d82f4-470c-4eb5-bf4f-6106b682260e"), "TK", null, new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), "Ngành học đào tạo kỹ năng về thống kê", false, "Thống kê", null, null },
                    { new Guid("86ac7343-b4cd-4dbb-946f-81db8c117f87"), "ĐTH", null, new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), "Ngành học đào tạo kỹ năng về lĩnh vực đô thị học", false, "Đô thị học", null, null },
                    { new Guid("8a085ad7-3a1e-4cfd-8be9-c1bac0c36517"), "ĐTTS", null, new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), "Ngành học đào tạo kỹ năng về lĩnh vực điều tra trinh sát", false, "Điều tra trinh sát", null, null },
                    { new Guid("8ae7996c-505b-4343-9df7-caebf86c9e60"), "TH", null, new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), "Ngành học đào tạo kỹ năng về toán học", false, "Toán học", null, null },
                    { new Guid("8c2d3663-1012-4a24-809d-bb12e6ed5d23"), "SPAN", null, new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), "Ngành học đào tạo kỹ năng về lĩnh vực sư phạm âm nhạc", false, "Sư phạm âm nhạc", null, null },
                    { new Guid("8ff0d04b-da37-4345-853c-71b66a2d94eb"), "CNSTH", null, new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ sau thu hoạch", false, "Công nghệ sau thu hoạch", null, null },
                    { new Guid("9186a969-d349-4cc8-866b-352a5056418c"), "BTH", null, new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), "Ngành học đào tạo kỹ năng về lĩnh vực bảo tàng học", false, "Bảo tàng học", null, null },
                    { new Guid("91f89343-44ab-47a9-964b-15437a9678a1"), "ĐTHS", null, new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), "Ngành học đào tạo kỹ năng về lĩnh vực điều tra hình sự", false, "Điều tra hình sự", null, null },
                    { new Guid("92913faa-9607-43da-b4aa-b6269cad9d12"), "CNDG", null, new Guid("d2322472-e7af-47e7-ab8f-eba6e8e7baad"), "Ngành học đào tạo kỹ năng về công nghệ da giày", false, "Công nghệ da giày", null, null },
                    { new Guid("97c46aeb-da40-47de-9a6f-52254c3f5eb8"), "QTKS", null, new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), "Ngành học đào tạo kỹ năng về lĩnh vực quản trị khách sạn", false, "Quản trị khách sạn", null, null },
                    { new Guid("995cb552-a1a7-40c9-9032-d374f11f3ed4"), "QTDVDL", null, new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), "Ngành học đào tạo kỹ năng về lĩnh vực quản trị dịch vụ du lịch và lữ hành", false, "Quản trị dịch vụ du lịch và lữ hành", null, null },
                    { new Guid("99c6c608-54b0-44b5-b018-65b506bb5398"), "TCC", null, new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), "Ngành học đào tạo kỹ năng về tài chính công", false, "Tài chính công", null, null },
                    { new Guid("9e39d8ed-8447-45e6-aa07-9aa76e5c6c49"), "TT", null, new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), "Ngành học đào tạo kỹ năng về toán-tin", false, "Toán-tin", null, null },
                    { new Guid("9e518c87-c522-4fa7-abe1-a318ceec4e09"), "KTH", null, new Guid("03a02645-69be-46a7-ad93-cf48b8c2961d"), "Ngành học đào tạo kỹ năng về khí tượng học", false, "Khí tượng học", null, null },
                    { new Guid("9f9cdb58-040c-472e-9f6a-576a9ee87fb4"), "DLST", null, new Guid("d7ab840a-0e06-4785-aa71-f82bef075ff9"), "Ngành học đào tạo kỹ năng về lĩnh vực du lịch sinh thái", false, "Du lịch sinh thái", null, null },
                    { new Guid("9fff7eda-6093-4ce8-b467-f102b0f09430"), "VHĐT", null, new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), "Ngành học đào tạo kỹ năng về văn hóa đô thị", false, "Văn hóa đô thị", null, null },
                    { new Guid("a52a3b15-3a21-44cd-8d74-b4c6751e2963"), "SPTH", null, new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "Đào tạo giáo viên toán học", false, "Sư phạm toán học", null, null },
                    { new Guid("a767ae08-1162-4d9d-a6f0-e74123c4e055"), "KTVT", null, new Guid("bf4524c1-1150-48f6-8c57-d922d925426f"), "Ngành học đào tạo kỹ năng về lĩnh vực khai thác vận tải", false, "Khai thác vận tải", null, null },
                    { new Guid("ac30fa55-823c-4f49-aa01-98a15822af37"), "KTCN", null, new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật công nghiệp", false, "Kỹ thuật công nghiệp", null, null },
                    { new Guid("ad437f7f-3242-4270-997f-a0a6f8a0c9b2"), "QLTT", null, new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), "Ngành học đào tạo kỹ năng về lĩnh vực quản lý thông tin", false, "Quản lý thông tin", null, null },
                    { new Guid("ad84e105-1ca7-401e-abd7-fdc5d2e40999"), "QTDN", null, new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), "Ngành học đào tạo kỹ năng về lĩnh vực quản trị doanh nghiệp", false, "Quản trị doanh nghiệp", null, null },
                    { new Guid("b0377a76-981e-4af2-a0d8-d7ae1f723e7b"), "BDCN", null, new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), "Ngành học đào tạo kỹ năng về lĩnh vực bảo dưỡng công nghiệp", false, "Bảo dưỡng công nghiệp", null, null },
                    { new Guid("b430ab31-8762-4f35-906f-989f981f61b7"), "QTH", null, new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"), "Ngành học đào tạo kỹ năng về lĩnh vực quốc tế học", false, "Quốc tế học", null, null },
                    { new Guid("b49b3229-b46c-4821-a0f9-2ead482c2bf1"), "ĐDĐATH", null, new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), "Ngành học đào tạo kỹ năng về đạo diễn điện ảnh, truyền hình", false, "Đạo diễn điện ảnh, truyền hình", null, null },
                    { new Guid("b629fa64-5dea-4129-9d59-f48c265bca62"), "TKTT", null, new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "Thiết kế các sản phẩm thời trang", false, "Thiết kế thời trang", null, null },
                    { new Guid("bc19438f-ee7e-4e59-ad83-e7879c0a54e5"), "CHTMĐC", null, new Guid("575e2a34-3e4e-40b3-be97-37310e59085a"), "Ngành học đào tạo kỹ năng về lĩnh vực chỉ huy tham mưu đặc công", false, "Chỉ huy tham mưu đặc công", null, null },
                    { new Guid("bc1e9f85-8404-46eb-a6e6-bab6f898566a"), "KTĐ", null, new Guid("cbeac466-d627-466c-8300-6ee4d5505a20"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật điện", false, "Kỹ thuật điện", null, null },
                    { new Guid("bc73983d-1bb7-447b-be96-c4fc7b653e5c"), "NH", null, new Guid("adb460f7-aa33-4efd-8346-9f3b76a0484b"), "Ngành học đào tạo kỹ năng về ngân hàng", false, "Ngân hàng", null, null },
                    { new Guid("bfe5f392-c582-4915-9360-3d90134295d5"), "CNTP", null, new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ thực phẩm", false, "Công nghệ thực phẩm", null, null },
                    { new Guid("c0d46118-35a4-4a25-982b-584781b45ca8"), "BC", null, new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), "Ngành học đào tạo kỹ năng về lĩnh vực báo chí", false, "Báo chí", null, null },
                    { new Guid("c2a1d4aa-eb5a-4850-84c2-2b4cd2db77e0"), "TUD", null, new Guid("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"), "Ngành học đào tạo kỹ năng về toán ứng dụng", false, "Toán ứng dụng", null, null },
                    { new Guid("c731c3f5-a1d2-4b8f-bd7f-2d57fa0acb0f"), "KTPM", null, new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "Học về thiết kế phần mềm", false, "Kỹ thuật phần mềm", null, null },
                    { new Guid("c74e4f33-a078-4219-8f69-7398435aff4d"), "LKT", null, new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), "Ngành học đào tạo kỹ năng về luật kinh tế", false, "Luật kinh tế", null, null },
                    { new Guid("ca49e2d3-f880-4a4f-9e60-04c57660d730"), "QTCL", null, new Guid("934b3542-92d5-431c-9271-f39dedcac50f"), "Ngành học đào tạo kỹ năng về lĩnh vực quản trị chất lượng", false, "Quản trị chất lượng", null, null },
                    { new Guid("ce320b5a-4eac-4436-92ef-90b985aec10f"), "MKT", null, new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "Makerting", false, "Makerting", null, null },
                    { new Guid("cf3913ca-fa92-4f90-a55b-93725cae4b32"), "SPTA", null, new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "Đào tạo giáo viên tiếng Anh", false, "Sư phạm tiếng Anh", null, null },
                    { new Guid("d05498a2-0502-4a9d-a535-d548db92000a"), "CNVL", null, new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ vật liệu", false, "Công nghệ vật liệu", null, null },
                    { new Guid("d6f2b6ab-0f91-4ffc-ade1-65b934718b68"), "SPMT", null, new Guid("3a8a3b94-db19-44cb-91ae-a895fe50c498"), "Ngành học đào tạo kỹ năng về lĩnh vực sư phạm mỹ thuật", false, "Sư phạm mỹ thuật", null, null },
                    { new Guid("d8393091-0dbd-4ab8-b18c-50ae38579ce8"), "VHAT", null, new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), "Ngành học đào tạo kỹ năng về văn hóa ẩm thực", false, "Văn hóa ẩm thực", null, null },
                    { new Guid("da699b0b-c55d-417f-93d8-e9571e712189"), "CNCBTS", null, new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ chế biến thủy sản", false, "Công nghệ chế biến thủy sản", null, null },
                    { new Guid("dc05a4d6-7019-424c-bc3b-118c7aa1272b"), "TTĐPT", null, new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), "Ngành học đào tạo kỹ năng về lĩnh vực truyền thông đa phương tiện", false, "Truyền thông đa phương tiện", null, null },
                    { new Guid("dc482730-bf16-4558-b1b6-8a7f1b8b855d"), "KTCK", null, new Guid("38449231-c9b9-46b9-9ee1-83ebaea156f1"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật cơ khí", false, "Kỹ thuật cơ khí", null, null },
                    { new Guid("dd5be2ec-dd31-41ad-8674-d870f7b13ee8"), "KNTXD", null, new Guid("47243cb9-ad17-4590-bf72-bef8ca382fa9"), "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế xây dựng", false, "Kinh tế xây dựng", null, null },
                    { new Guid("e026cfb6-343f-4af1-a15d-c840165a09b4"), "KTTP", null, new Guid("37ac6580-0e40-465f-b9f6-aa7e803487b2"), "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật thực phẩm", false, "Kỹ thuật thực phẩm", null, null },
                    { new Guid("e10926c7-63e0-48e0-947c-060ba13d0a8e"), "ĐDSK", null, new Guid("07563189-01d5-4ec1-80a6-f9c7ced12408"), "Ngành học đào tạo kỹ năng về đạo diễn sân khấu", false, "Đạo diễn sân khấu", null, null },
                    { new Guid("e812ac28-8fa5-4c08-8d45-e40b6018056f"), "TTTV", null, new Guid("e63527a5-2326-4d15-afb5-8244fd0fa441"), "Ngành học đào tạo kỹ năng về lĩnh vực thông tin - thư viện", false, "Thông tin - thư viện", null, null },
                    { new Guid("f5e68a91-1e8e-4ef7-9f0d-6da923dc5611"), "TTNT", null, new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "Nghiên cứu và ứng dụng trí tuệ nhân tạo", false, "Trí tuệ nhân tạo", null, null },
                    { new Guid("fa88d41b-f627-4e5e-af66-19ead35fb082"), "XDĐ", null, new Guid("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"), "Ngành học đào tạo kỹ năng về xây dựng Đảng và chính quyền nhà nước", false, "Xây dựng Đảng và chính quyền nhà nước", null, null },
                    { new Guid("fcab8031-99a2-40cb-921c-f76e7f250ab6"), "VHNB", null, new Guid("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"), "Ngành học đào tạo kỹ năng về văn hóa Nam bộ", false, "Văn hóa Nam bộ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 177, 182, 147, 27, 96, 163, 9, 8, 63, 161, 150, 79, 103, 166, 242, 147, 186, 125, 37, 216, 152, 223, 72, 38, 209, 93, 95, 238, 131, 107, 201, 180, 98, 27, 190, 189, 213, 8, 76, 30, 126, 17, 113, 225, 80, 79, 83, 20, 69, 121, 72, 14, 151, 85, 105, 158, 171, 122, 250, 52, 188, 40, 208 }, new byte[] { 198, 214, 214, 222, 229, 84, 249, 97, 184, 194, 14, 51, 128, 201, 89, 58, 254, 124, 254, 253, 142, 235, 188, 9, 242, 56, 2, 252, 106, 77, 26, 104, 191, 5, 193, 5, 241, 225, 58, 31, 2, 75, 19, 222, 11, 246, 34, 22, 158, 47, 131, 84, 208, 22, 150, 184, 241, 75, 248, 120, 45, 246, 43, 143, 216, 238, 97, 157, 194, 29, 182, 65, 106, 206, 91, 118, 221, 221, 158, 178, 116, 96, 234, 205, 17, 146, 122, 190, 213, 202, 79, 12, 13, 124, 22, 234, 202, 174, 59, 246, 202, 161, 125, 206, 135, 168, 90, 71, 16, 79, 165, 223, 105, 176, 245, 143, 178, 167, 67, 92, 101, 39, 188, 139, 22, 123, 187, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 167, 68, 246, 101, 184, 151, 140, 31, 154, 112, 115, 81, 216, 117, 228, 106, 29, 89, 76, 237, 218, 245, 33, 186, 153, 122, 51, 40, 71, 12, 230, 207, 173, 87, 89, 101, 85, 39, 181, 206, 110, 16, 118, 78, 253, 141, 165, 72, 85, 249, 57, 63, 201, 58, 246, 20, 43, 119, 29, 46, 146, 92, 18 }, new byte[] { 108, 69, 117, 140, 176, 95, 5, 41, 179, 9, 18, 105, 242, 204, 57, 62, 157, 80, 99, 116, 53, 183, 61, 116, 233, 10, 223, 59, 178, 193, 63, 165, 143, 19, 224, 218, 182, 69, 246, 143, 174, 41, 39, 213, 138, 140, 76, 246, 134, 201, 92, 126, 171, 112, 172, 0, 27, 64, 61, 222, 226, 119, 174, 251, 227, 250, 247, 99, 92, 151, 252, 253, 169, 19, 157, 214, 180, 89, 171, 191, 140, 182, 100, 93, 100, 147, 10, 142, 160, 49, 208, 7, 207, 177, 93, 33, 51, 61, 75, 186, 112, 47, 109, 84, 104, 107, 192, 158, 146, 172, 227, 94, 18, 167, 175, 167, 69, 38, 165, 195, 77, 174, 145, 147, 54, 227, 88, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 170, 164, 46, 147, 225, 16, 222, 219, 109, 217, 133, 195, 208, 24, 255, 223, 102, 190, 36, 51, 17, 193, 121, 66, 213, 138, 249, 34, 57, 247, 203, 215, 95, 30, 174, 39, 84, 110, 250, 79, 111, 184, 116, 20, 251, 134, 76, 182, 91, 30, 128, 31, 22, 65, 223, 252, 33, 210, 123, 131, 83, 157, 255 }, new byte[] { 34, 93, 16, 138, 19, 209, 45, 34, 14, 134, 179, 206, 89, 122, 164, 224, 71, 140, 224, 97, 111, 226, 31, 190, 24, 74, 184, 220, 226, 107, 80, 54, 34, 158, 32, 67, 121, 206, 58, 139, 148, 215, 252, 231, 31, 32, 159, 219, 236, 42, 52, 218, 144, 117, 140, 29, 210, 68, 177, 138, 228, 254, 3, 117, 192, 98, 208, 50, 221, 75, 178, 100, 167, 13, 1, 194, 80, 82, 46, 228, 99, 250, 138, 179, 159, 50, 200, 144, 94, 118, 6, 186, 235, 196, 193, 176, 12, 103, 219, 172, 30, 113, 78, 185, 200, 52, 115, 135, 170, 196, 113, 59, 48, 23, 244, 243, 243, 161, 42, 92, 105, 93, 138, 163, 56, 57, 211, 103 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 48, 186, 122, 21, 197, 121, 69, 0, 63, 57, 190, 222, 161, 64, 175, 173, 117, 60, 197, 199, 255, 129, 181, 49, 174, 23, 1, 28, 165, 228, 31, 196, 144, 207, 174, 81, 73, 146, 198, 168, 96, 227, 153, 158, 46, 225, 95, 228, 119, 189, 87, 121, 182, 27, 69, 175, 215, 109, 201, 71, 209, 111, 137 }, new byte[] { 180, 171, 109, 187, 249, 39, 132, 174, 64, 20, 6, 35, 125, 226, 219, 247, 20, 36, 146, 169, 27, 237, 54, 88, 159, 151, 127, 176, 16, 136, 170, 227, 83, 16, 88, 90, 167, 172, 109, 253, 140, 105, 67, 3, 153, 142, 183, 153, 57, 103, 150, 220, 19, 195, 201, 122, 173, 9, 111, 8, 240, 12, 225, 9, 247, 72, 45, 199, 206, 143, 208, 216, 101, 156, 210, 11, 26, 67, 91, 242, 159, 204, 19, 159, 168, 39, 168, 192, 175, 108, 184, 75, 8, 213, 52, 117, 59, 63, 22, 243, 20, 192, 88, 205, 105, 153, 234, 209, 150, 171, 114, 62, 32, 4, 242, 242, 2, 161, 65, 23, 26, 66, 246, 200, 231, 129, 82, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 128, 151, 251, 85, 71, 155, 32, 58, 219, 104, 104, 247, 249, 113, 23, 159, 171, 145, 224, 58, 42, 188, 37, 210, 19, 125, 202, 240, 176, 251, 166, 206, 141, 234, 131, 180, 41, 64, 3, 204, 40, 140, 56, 7, 252, 75, 243, 108, 11, 98, 115, 118, 221, 202, 62, 6, 184, 135, 35, 39, 221, 232, 203 }, new byte[] { 211, 240, 0, 114, 88, 236, 58, 4, 169, 24, 176, 38, 121, 3, 173, 180, 94, 5, 50, 8, 242, 242, 47, 60, 239, 24, 156, 88, 61, 101, 214, 19, 153, 115, 245, 210, 118, 228, 14, 219, 50, 172, 197, 62, 61, 205, 170, 62, 113, 4, 69, 218, 40, 246, 191, 26, 12, 71, 193, 21, 74, 145, 0, 210, 129, 111, 252, 46, 65, 82, 7, 120, 179, 182, 188, 33, 41, 219, 163, 18, 111, 236, 253, 107, 93, 191, 17, 63, 57, 184, 174, 19, 31, 40, 252, 1, 88, 9, 100, 166, 109, 60, 81, 5, 80, 58, 1, 69, 23, 159, 169, 26, 190, 227, 209, 109, 20, 21, 0, 90, 50, 55, 46, 129, 201, 189, 63, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 92, 164, 24, 18, 144, 200, 144, 200, 141, 3, 171, 93, 149, 228, 59, 96, 100, 204, 3, 8, 13, 98, 185, 200, 243, 134, 17, 211, 224, 102, 196, 44, 27, 20, 46, 100, 216, 202, 174, 218, 80, 52, 64, 11, 152, 17, 18, 165, 103, 173, 42, 62, 46, 127, 250, 177, 202, 149, 233, 73, 104, 134, 235 }, new byte[] { 54, 226, 144, 216, 44, 148, 210, 223, 154, 65, 208, 7, 81, 141, 108, 9, 207, 83, 57, 206, 8, 135, 86, 247, 44, 32, 105, 14, 98, 52, 231, 92, 92, 93, 26, 50, 106, 4, 16, 254, 117, 227, 37, 82, 92, 131, 209, 38, 11, 61, 14, 76, 180, 54, 48, 144, 89, 244, 26, 48, 151, 176, 51, 22, 90, 10, 182, 6, 148, 243, 11, 50, 159, 16, 226, 119, 23, 44, 63, 52, 222, 201, 200, 160, 235, 49, 234, 95, 247, 235, 58, 63, 0, 39, 19, 13, 220, 47, 28, 184, 19, 102, 225, 116, 15, 48, 50, 39, 11, 117, 129, 43, 183, 26, 242, 14, 180, 183, 196, 189, 54, 110, 110, 191, 1, 167, 72, 20 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 91, 169, 7, 232, 143, 239, 1, 229, 195, 158, 168, 74, 146, 83, 17, 162, 11, 57, 214, 189, 54, 106, 129, 229, 184, 37, 69, 16, 32, 215, 173, 69, 176, 51, 115, 50, 121, 198, 82, 204, 15, 27, 223, 175, 162, 126, 166, 10, 151, 92, 161, 98, 94, 18, 166, 17, 19, 12, 114, 69, 97, 191, 54 }, new byte[] { 242, 237, 25, 250, 214, 172, 134, 62, 34, 115, 137, 52, 101, 1, 228, 107, 220, 11, 134, 162, 215, 46, 233, 138, 158, 13, 210, 2, 160, 86, 152, 252, 62, 46, 180, 67, 197, 246, 119, 125, 248, 57, 2, 253, 136, 165, 193, 34, 22, 98, 247, 220, 211, 15, 126, 192, 13, 75, 171, 88, 229, 225, 119, 20, 127, 122, 10, 35, 7, 34, 67, 89, 192, 232, 132, 158, 14, 110, 190, 158, 166, 241, 250, 235, 173, 97, 189, 254, 227, 234, 221, 66, 109, 147, 105, 76, 66, 218, 129, 14, 60, 21, 58, 240, 244, 68, 227, 54, 7, 230, 231, 222, 212, 105, 112, 201, 67, 3, 209, 249, 167, 96, 25, 101, 232, 88, 93, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 241, 111, 237, 160, 86, 207, 124, 86, 88, 213, 178, 55, 111, 84, 16, 99, 211, 112, 138, 82, 71, 110, 153, 51, 63, 60, 221, 152, 180, 138, 63, 114, 5, 170, 43, 19, 145, 85, 193, 17, 72, 249, 87, 15, 4, 102, 176, 196, 230, 12, 207, 42, 65, 222, 183, 231, 225, 183, 135, 170, 63, 174, 40 }, new byte[] { 5, 162, 238, 251, 47, 252, 249, 172, 230, 125, 13, 93, 216, 104, 116, 211, 31, 194, 185, 193, 175, 199, 205, 245, 94, 144, 245, 78, 237, 183, 13, 71, 158, 123, 202, 22, 207, 76, 56, 36, 168, 78, 244, 198, 193, 124, 216, 113, 150, 148, 244, 104, 72, 239, 59, 167, 109, 96, 122, 235, 1, 164, 136, 209, 136, 84, 179, 61, 79, 11, 84, 205, 245, 34, 226, 65, 151, 207, 53, 45, 222, 36, 199, 11, 159, 206, 179, 123, 114, 129, 103, 176, 121, 28, 205, 203, 206, 14, 198, 244, 245, 236, 230, 98, 62, 252, 236, 204, 216, 88, 184, 2, 109, 103, 190, 227, 204, 175, 101, 163, 255, 202, 82, 196, 218, 28, 143, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 111, 137, 8, 195, 240, 180, 159, 49, 108, 241, 235, 208, 117, 102, 200, 130, 241, 251, 174, 97, 157, 189, 205, 70, 227, 57, 124, 228, 77, 88, 34, 213, 175, 16, 56, 128, 230, 127, 42, 212, 175, 15, 142, 214, 190, 119, 163, 49, 48, 235, 204, 142, 233, 240, 73, 94, 201, 6, 249, 126, 162, 194, 9 }, new byte[] { 47, 156, 27, 92, 190, 190, 198, 137, 90, 247, 165, 72, 229, 15, 118, 42, 48, 92, 71, 100, 186, 81, 251, 227, 212, 154, 187, 197, 34, 144, 120, 115, 145, 215, 77, 40, 88, 143, 146, 49, 123, 131, 91, 128, 177, 96, 219, 128, 230, 253, 94, 135, 253, 5, 149, 102, 250, 211, 180, 8, 166, 201, 218, 23, 191, 96, 61, 216, 160, 247, 145, 233, 21, 243, 94, 127, 146, 9, 83, 90, 125, 202, 64, 54, 136, 246, 240, 239, 143, 113, 16, 76, 49, 219, 155, 194, 109, 225, 5, 153, 25, 3, 72, 224, 38, 112, 3, 151, 121, 59, 8, 70, 214, 205, 7, 245, 67, 149, 39, 49, 146, 238, 26, 101, 160, 93, 181, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 143, 183, 26, 95, 198, 102, 195, 64, 231, 81, 206, 53, 209, 170, 198, 49, 250, 223, 94, 254, 9, 115, 46, 161, 154, 32, 149, 170, 196, 104, 3, 30, 97, 39, 164, 85, 168, 41, 201, 185, 107, 190, 28, 192, 59, 6, 55, 201, 36, 9, 48, 198, 117, 143, 68, 189, 55, 14, 192, 150, 121, 128, 186, 108 }, new byte[] { 186, 106, 213, 64, 37, 101, 2, 45, 213, 118, 133, 139, 32, 248, 114, 20, 81, 114, 187, 108, 27, 72, 172, 240, 42, 243, 143, 32, 140, 72, 120, 104, 247, 184, 174, 82, 145, 129, 241, 49, 2, 227, 62, 27, 34, 75, 139, 252, 76, 133, 50, 81, 69, 147, 153, 84, 128, 144, 9, 1, 202, 252, 9, 1, 194, 211, 170, 220, 83, 96, 2, 77, 67, 255, 141, 40, 39, 28, 174, 1, 95, 222, 212, 148, 171, 252, 163, 164, 97, 23, 54, 58, 250, 249, 66, 232, 71, 251, 124, 219, 246, 66, 29, 169, 28, 197, 9, 42, 115, 240, 87, 95, 192, 23, 143, 147, 93, 54, 7, 157, 8, 222, 213, 140, 192, 119, 115, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 166, 88, 16, 102, 78, 231, 18, 141, 183, 155, 204, 109, 235, 29, 100, 180, 218, 131, 77, 246, 64, 154, 247, 193, 111, 70, 75, 138, 159, 228, 239, 7, 79, 62, 176, 78, 244, 159, 133, 110, 62, 213, 53, 87, 138, 94, 166, 232, 121, 165, 133, 54, 180, 170, 76, 156, 2, 139, 151, 230, 194, 92, 61, 123 }, new byte[] { 149, 120, 192, 40, 161, 205, 232, 59, 21, 203, 10, 62, 201, 233, 178, 18, 38, 191, 149, 133, 122, 136, 242, 12, 34, 124, 20, 251, 198, 252, 96, 48, 196, 235, 248, 150, 74, 150, 25, 70, 34, 189, 96, 250, 116, 112, 206, 145, 176, 70, 89, 196, 100, 206, 69, 42, 246, 203, 168, 58, 52, 150, 103, 44, 213, 136, 113, 185, 18, 139, 18, 41, 27, 104, 207, 103, 17, 108, 90, 176, 108, 74, 156, 232, 82, 32, 21, 105, 23, 53, 101, 110, 117, 89, 133, 61, 179, 233, 202, 118, 196, 62, 227, 246, 68, 114, 242, 240, 249, 230, 80, 69, 202, 144, 133, 19, 177, 113, 144, 211, 119, 219, 221, 14, 228, 94, 22, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 254, 107, 196, 183, 139, 169, 12, 2, 199, 148, 76, 187, 93, 123, 168, 159, 111, 196, 35, 59, 218, 43, 81, 33, 42, 232, 61, 242, 244, 116, 193, 31, 109, 103, 227, 49, 231, 123, 68, 36, 170, 28, 85, 164, 203, 252, 100, 239, 72, 12, 158, 118, 21, 223, 6, 106, 179, 194, 164, 235, 99, 4, 52, 181 }, new byte[] { 35, 164, 146, 219, 217, 180, 183, 195, 181, 113, 195, 68, 19, 251, 10, 230, 15, 143, 226, 129, 142, 82, 130, 238, 105, 28, 242, 28, 116, 0, 52, 31, 208, 157, 238, 131, 10, 38, 181, 214, 102, 26, 82, 142, 132, 117, 171, 235, 2, 228, 107, 53, 202, 120, 84, 219, 20, 189, 237, 72, 249, 22, 47, 107, 155, 239, 101, 209, 68, 139, 50, 59, 167, 5, 23, 151, 217, 192, 27, 143, 149, 49, 69, 221, 0, 111, 110, 254, 70, 178, 197, 66, 196, 24, 193, 226, 110, 161, 118, 125, 20, 214, 69, 55, 222, 244, 228, 5, 194, 175, 156, 209, 210, 207, 224, 73, 74, 40, 94, 45, 181, 235, 161, 80, 175, 131, 241, 17 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 203, 219, 22, 107, 159, 10, 152, 12, 110, 122, 185, 123, 160, 122, 18, 68, 95, 40, 161, 52, 232, 84, 162, 208, 192, 149, 98, 16, 128, 91, 79, 182, 194, 245, 172, 179, 221, 234, 130, 135, 78, 27, 142, 194, 229, 53, 34, 87, 89, 82, 92, 126, 221, 89, 13, 85, 86, 70, 33, 84, 23, 123, 100, 230 }, new byte[] { 198, 101, 74, 252, 78, 60, 106, 71, 36, 72, 226, 198, 216, 62, 85, 162, 250, 160, 26, 205, 25, 161, 100, 46, 243, 239, 149, 11, 39, 108, 66, 225, 217, 89, 170, 138, 198, 135, 91, 209, 141, 139, 79, 119, 225, 195, 59, 92, 10, 149, 169, 184, 105, 23, 208, 251, 77, 228, 163, 62, 123, 24, 97, 192, 70, 148, 144, 134, 5, 245, 168, 188, 24, 1, 180, 63, 83, 148, 188, 251, 244, 34, 176, 134, 132, 89, 59, 63, 14, 87, 43, 68, 202, 242, 154, 254, 107, 127, 77, 102, 19, 228, 80, 244, 165, 166, 106, 153, 165, 86, 200, 181, 67, 251, 87, 23, 67, 85, 149, 137, 24, 217, 18, 190, 96, 155, 88, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 236, 194, 250, 252, 186, 68, 174, 228, 205, 162, 12, 172, 115, 85, 125, 114, 117, 146, 82, 30, 50, 22, 114, 136, 204, 145, 116, 65, 177, 101, 158, 116, 196, 187, 119, 212, 23, 96, 19, 99, 30, 8, 23, 117, 82, 179, 160, 155, 131, 178, 97, 248, 173, 12, 124, 33, 202, 82, 139, 88, 171, 92, 180 }, new byte[] { 46, 67, 174, 58, 104, 108, 3, 216, 136, 206, 137, 167, 41, 220, 76, 174, 206, 82, 60, 184, 56, 239, 132, 61, 94, 4, 133, 158, 118, 18, 83, 249, 209, 0, 223, 135, 29, 194, 90, 242, 133, 221, 63, 255, 13, 146, 100, 167, 222, 138, 91, 216, 60, 157, 22, 66, 45, 231, 41, 5, 227, 133, 227, 232, 190, 231, 190, 5, 231, 240, 142, 167, 231, 71, 29, 226, 117, 28, 142, 145, 210, 171, 123, 156, 86, 7, 98, 15, 51, 198, 255, 187, 227, 69, 21, 113, 231, 162, 187, 34, 2, 202, 29, 67, 163, 193, 144, 65, 40, 81, 23, 160, 247, 114, 254, 166, 112, 199, 223, 54, 190, 233, 119, 81, 134, 58, 16, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 198, 26, 200, 38, 114, 137, 92, 2, 166, 245, 10, 15, 96, 189, 75, 4, 59, 205, 42, 145, 95, 156, 228, 37, 233, 213, 201, 68, 180, 92, 72, 163, 63, 55, 76, 199, 251, 121, 198, 204, 88, 122, 122, 173, 57, 233, 20, 139, 75, 11, 59, 30, 53, 200, 208, 181, 173, 104, 14, 191, 83, 134, 21, 123 }, new byte[] { 223, 224, 168, 14, 179, 15, 118, 111, 178, 64, 54, 54, 107, 148, 30, 103, 194, 253, 136, 184, 93, 19, 60, 200, 19, 135, 234, 101, 232, 223, 178, 177, 208, 86, 42, 66, 253, 64, 37, 91, 128, 94, 144, 169, 192, 152, 179, 55, 62, 146, 223, 195, 51, 103, 72, 28, 11, 24, 42, 213, 74, 205, 99, 25, 89, 233, 153, 166, 124, 83, 147, 71, 164, 48, 214, 253, 117, 158, 217, 238, 109, 116, 171, 72, 220, 63, 129, 153, 141, 212, 127, 103, 77, 145, 53, 44, 213, 247, 203, 220, 10, 167, 82, 213, 209, 196, 150, 233, 64, 255, 0, 195, 9, 14, 124, 92, 31, 144, 99, 48, 167, 112, 76, 90, 15, 191, 102, 27 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 53, 246, 162, 146, 10, 52, 102, 143, 106, 148, 53, 115, 232, 29, 13, 145, 221, 109, 251, 254, 8, 56, 156, 250, 22, 244, 65, 176, 62, 151, 133, 114, 70, 254, 144, 0, 149, 22, 86, 249, 53, 228, 63, 177, 133, 91, 182, 247, 120, 162, 248, 36, 5, 81, 102, 150, 73, 214, 190, 153, 242, 185, 206, 160 }, new byte[] { 230, 236, 187, 164, 165, 196, 170, 73, 140, 27, 144, 132, 178, 218, 94, 220, 234, 72, 59, 21, 237, 161, 85, 78, 159, 104, 40, 195, 40, 172, 249, 101, 86, 192, 43, 253, 135, 100, 78, 21, 143, 120, 199, 255, 183, 193, 49, 181, 102, 0, 149, 103, 97, 3, 65, 206, 42, 108, 132, 69, 104, 177, 104, 163, 83, 68, 196, 167, 221, 140, 49, 144, 52, 149, 163, 185, 30, 180, 169, 39, 184, 135, 121, 181, 250, 238, 29, 133, 212, 200, 145, 77, 235, 109, 223, 238, 107, 232, 88, 49, 128, 16, 253, 47, 90, 133, 156, 207, 68, 110, 226, 70, 161, 36, 63, 19, 146, 146, 230, 5, 146, 159, 28, 232, 119, 131, 45, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 83, 4, 142, 122, 218, 124, 165, 52, 77, 253, 156, 189, 108, 25, 29, 149, 172, 32, 223, 93, 107, 234, 224, 24, 160, 135, 116, 151, 3, 40, 112, 75, 41, 104, 0, 209, 208, 11, 57, 73, 140, 49, 211, 214, 117, 150, 53, 37, 1, 116, 168, 152, 139, 106, 253, 158, 8, 139, 42, 213, 5, 166, 243 }, new byte[] { 7, 159, 40, 127, 45, 128, 147, 93, 110, 22, 178, 169, 37, 204, 208, 235, 125, 219, 146, 222, 16, 165, 195, 179, 123, 177, 169, 250, 113, 31, 201, 160, 186, 227, 47, 21, 22, 142, 112, 83, 6, 246, 66, 134, 180, 229, 12, 81, 231, 2, 224, 204, 63, 119, 197, 25, 48, 26, 90, 246, 38, 61, 112, 69, 48, 230, 118, 146, 149, 88, 232, 158, 80, 240, 87, 220, 137, 200, 21, 153, 168, 136, 204, 46, 35, 35, 84, 244, 44, 199, 162, 89, 58, 112, 43, 189, 29, 205, 193, 73, 97, 204, 192, 77, 132, 84, 99, 218, 129, 77, 42, 117, 232, 104, 76, 178, 226, 174, 132, 20, 83, 223, 143, 36, 141, 224, 180, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 207, 109, 224, 21, 115, 221, 188, 186, 27, 76, 237, 176, 148, 124, 175, 248, 37, 41, 254, 206, 207, 24, 104, 34, 70, 47, 32, 158, 92, 179, 119, 134, 97, 218, 214, 161, 28, 119, 126, 173, 211, 189, 158, 149, 235, 136, 49, 25, 64, 90, 180, 109, 73, 6, 175, 196, 28, 27, 153, 232, 9, 205, 148 }, new byte[] { 185, 20, 109, 120, 10, 144, 51, 100, 250, 131, 222, 255, 30, 60, 17, 143, 175, 133, 104, 167, 74, 195, 139, 254, 63, 128, 186, 61, 200, 228, 8, 254, 53, 248, 140, 194, 254, 161, 38, 109, 180, 20, 168, 203, 231, 236, 122, 38, 207, 72, 191, 250, 110, 31, 26, 134, 198, 233, 225, 141, 186, 25, 50, 199, 235, 126, 64, 227, 206, 65, 191, 116, 241, 190, 237, 49, 40, 208, 58, 120, 198, 249, 36, 8, 41, 179, 6, 254, 61, 18, 3, 214, 176, 32, 237, 165, 132, 137, 125, 156, 143, 215, 57, 149, 151, 109, 172, 159, 180, 99, 239, 138, 18, 249, 103, 207, 171, 92, 12, 95, 189, 166, 50, 213, 162, 196, 162, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 153, 145, 0, 12, 21, 172, 125, 209, 151, 89, 18, 94, 108, 231, 231, 203, 191, 36, 232, 69, 161, 67, 173, 186, 228, 219, 207, 52, 96, 176, 174, 61, 52, 27, 191, 145, 1, 222, 42, 67, 235, 232, 155, 32, 132, 140, 94, 78, 224, 80, 173, 124, 240, 197, 73, 88, 85, 212, 119, 252, 177, 201, 252 }, new byte[] { 49, 48, 98, 198, 110, 206, 167, 238, 216, 64, 129, 243, 55, 31, 76, 193, 85, 213, 192, 146, 166, 216, 63, 13, 56, 61, 138, 217, 156, 117, 45, 20, 75, 69, 84, 181, 169, 26, 100, 220, 36, 137, 164, 162, 242, 231, 204, 176, 150, 148, 150, 93, 112, 132, 207, 190, 236, 52, 250, 234, 177, 54, 146, 171, 188, 36, 216, 14, 168, 226, 119, 103, 248, 20, 102, 89, 223, 95, 238, 36, 156, 180, 28, 57, 138, 248, 222, 34, 249, 63, 52, 251, 246, 49, 13, 79, 147, 143, 20, 190, 100, 63, 185, 102, 140, 95, 158, 252, 179, 7, 156, 221, 157, 56, 49, 200, 4, 78, 213, 192, 35, 43, 245, 151, 64, 169, 161, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 128, 204, 222, 72, 149, 130, 29, 224, 243, 78, 142, 197, 11, 63, 13, 211, 147, 102, 61, 112, 247, 70, 238, 58, 12, 95, 84, 179, 214, 188, 43, 197, 23, 252, 114, 44, 249, 101, 223, 158, 12, 10, 250, 23, 245, 67, 126, 77, 67, 228, 87, 113, 60, 185, 83, 85, 224, 252, 156, 51, 195, 17, 39, 220 }, new byte[] { 2, 169, 159, 156, 102, 185, 228, 249, 115, 70, 85, 41, 217, 11, 90, 99, 1, 183, 149, 94, 194, 232, 219, 200, 164, 6, 159, 169, 162, 215, 205, 49, 65, 118, 139, 255, 45, 247, 12, 27, 223, 237, 163, 117, 8, 164, 49, 163, 249, 240, 39, 208, 218, 45, 126, 142, 163, 153, 111, 109, 211, 23, 37, 26, 35, 71, 131, 115, 90, 222, 213, 162, 175, 123, 162, 234, 57, 250, 250, 136, 100, 75, 99, 184, 43, 31, 236, 232, 166, 71, 83, 61, 239, 243, 227, 140, 171, 58, 216, 45, 123, 69, 142, 55, 196, 193, 92, 63, 254, 56, 59, 117, 183, 128, 48, 119, 232, 237, 205, 36, 84, 71, 49, 229, 96, 124, 65, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 122, 75, 127, 131, 83, 23, 169, 165, 206, 61, 15, 213, 5, 154, 194, 143, 42, 24, 94, 130, 94, 46, 59, 173, 160, 86, 162, 18, 254, 73, 115, 112, 245, 33, 135, 187, 133, 228, 175, 227, 91, 98, 143, 187, 226, 155, 120, 238, 152, 250, 123, 188, 24, 252, 52, 115, 64, 115, 65, 55, 77, 118, 34 }, new byte[] { 114, 63, 253, 247, 96, 193, 6, 69, 206, 197, 146, 44, 197, 210, 228, 171, 151, 201, 206, 50, 6, 48, 128, 98, 155, 135, 167, 97, 116, 75, 226, 178, 112, 79, 27, 22, 60, 229, 53, 197, 125, 211, 172, 237, 26, 240, 138, 12, 87, 105, 80, 101, 168, 71, 226, 209, 130, 81, 61, 89, 43, 250, 19, 234, 229, 196, 148, 118, 218, 105, 114, 202, 33, 241, 13, 80, 180, 249, 61, 241, 151, 101, 237, 32, 36, 238, 104, 102, 253, 153, 247, 5, 224, 200, 169, 40, 51, 33, 72, 188, 127, 112, 157, 11, 207, 110, 128, 1, 181, 250, 43, 143, 122, 145, 95, 181, 89, 10, 133, 6, 230, 79, 139, 90, 140, 212, 168, 50 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 140, 87, 202, 62, 182, 134, 198, 24, 17, 240, 250, 186, 75, 104, 55, 79, 228, 95, 144, 239, 238, 67, 121, 168, 48, 132, 61, 150, 125, 239, 117, 241, 242, 14, 188, 232, 240, 179, 89, 240, 52, 190, 17, 234, 102, 76, 55, 246, 157, 21, 108, 119, 20, 141, 87, 47, 96, 72, 78, 174, 92, 217, 68 }, new byte[] { 177, 105, 208, 253, 81, 247, 39, 249, 120, 206, 143, 62, 86, 180, 48, 124, 59, 74, 244, 232, 211, 16, 121, 175, 30, 170, 189, 78, 58, 26, 202, 81, 255, 85, 90, 20, 26, 85, 239, 223, 114, 56, 225, 132, 231, 171, 39, 15, 77, 18, 72, 219, 110, 100, 18, 15, 207, 115, 137, 32, 29, 55, 208, 44, 169, 144, 139, 234, 142, 236, 163, 195, 231, 121, 63, 80, 138, 51, 45, 87, 162, 39, 81, 89, 201, 86, 58, 63, 244, 136, 107, 205, 119, 250, 82, 215, 90, 34, 80, 216, 19, 189, 88, 44, 182, 20, 46, 225, 9, 8, 237, 225, 180, 70, 248, 61, 14, 76, 175, 154, 196, 97, 6, 123, 9, 102, 248, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 76, 138, 16, 230, 161, 115, 167, 254, 150, 253, 79, 106, 234, 251, 200, 235, 16, 161, 173, 223, 136, 68, 247, 56, 69, 162, 124, 239, 230, 117, 90, 131, 163, 108, 203, 131, 212, 94, 49, 97, 191, 40, 47, 234, 1, 184, 11, 43, 73, 199, 128, 128, 14, 4, 224, 161, 177, 73, 63, 168, 76, 181, 29 }, new byte[] { 130, 28, 79, 115, 79, 19, 156, 150, 198, 159, 91, 220, 162, 133, 95, 241, 152, 152, 42, 28, 208, 35, 170, 228, 103, 194, 215, 215, 48, 12, 80, 45, 76, 200, 211, 27, 61, 42, 234, 62, 93, 109, 118, 200, 231, 173, 185, 160, 1, 207, 142, 35, 167, 26, 43, 248, 17, 35, 96, 51, 129, 155, 132, 182, 46, 101, 183, 222, 243, 221, 111, 71, 74, 20, 184, 116, 177, 200, 24, 241, 232, 102, 38, 22, 25, 92, 41, 21, 234, 37, 51, 25, 19, 39, 36, 140, 103, 237, 180, 178, 234, 190, 171, 203, 51, 4, 55, 214, 4, 14, 96, 42, 117, 250, 229, 139, 111, 175, 42, 61, 188, 121, 238, 195, 40, 40, 27, 54 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0035306f-de5e-4c60-9e55-4f2282e7dda9"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0273f179-b2ae-434d-835f-6035e8b6ae52"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("07951ef0-d8df-47a3-82c2-c16dd3a16a3f"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0ab02d77-61fb-46ea-8340-7236296c4022"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0af0e064-0927-45b7-b9cc-8e8a49996c1c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0c7c4a30-d3d1-48ea-9526-1b31fe4c0103"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0d036fb3-5ff7-4b63-86db-4342a62f886e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("0e9599e3-0279-4ac6-8af5-eb14b3f1e584"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("1569cd2c-deef-4d74-bdcd-f785f52b465d"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("17d5462c-3a8a-4e93-b5e6-69d36186577e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("19d935fe-5772-48a6-98bd-782450be775a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("1a111b2a-1eac-4132-92ef-90b985ae0101"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("1b320b9a-3eac-4336-92ef-90b985aec101"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("1dcd3794-f8d5-4d4e-9788-74a3b9426421"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2332343e-e798-496b-9ea5-841bdc10552a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2445d565-594a-419b-ab0a-bcd87c2b9a2a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2793f8f1-98fb-4b13-b5e1-04085ae78762"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("282b4ad3-d00d-4275-97ae-7480635636e8"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2b222b3a-2eac-4233-93ef-80b985ae0202"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2b49fa02-7c48-45ab-9f81-4605ff991bd4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2b72f32c-5d96-4b5d-ae68-597bbeead505"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2c430b7a-5eac-4536-93ef-80b985aec202"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("2fa7fc82-948a-45bb-a33e-b37a98579b05"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("317f2de4-b76e-4d4b-8b0a-94166493623e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("31b92a5b-8354-450f-a023-6e7d74349ab4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("335f8cf8-94b0-47bd-ba70-eb2aaf0c07b1"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("348cdef7-2ec8-4814-883b-c41218128a3c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("387c472b-1f7d-4655-838c-80982b8f9e24"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("3c25899c-f1a5-48d0-9276-03ef9fd60a24"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("3c333b4a-3eac-4333-94ef-70b985ae0303"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("3d550b8a-6eac-4636-92ef-70b985aec303"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("42308b7d-8d80-4077-a960-433b4eb6ec7a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("44929c3d-dd91-4405-9d4e-f4be315b7fbb"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("4989ef16-62cd-4aa1-850f-ef6a8e2b3b2c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("4c97f72e-0560-449e-a32d-7fac374b5bbf"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("4d444b5a-4eac-4434-95ef-60b985ae0404"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("4e661b9a-7eac-4736-92ef-60b985aec404"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("524954ba-d75f-4cd7-a2af-acf23d383a05"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("56306665-f58b-4188-8613-578b0fe470ed"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("5c1310fb-b35b-4529-beb1-79664cc85fc6"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("5e555b6a-5eac-4535-96ef-50b985ae0505"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("5ee2fae8-eae3-495a-95b6-303307cb596c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("5f246722-c823-466e-a024-254ba25d1750"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("6090009b-8534-4200-a83b-f544d9be8732"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("63da08f2-e70f-488d-8d5a-eb24063697e5"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("667330de-e435-45d1-ab72-4d6504cbba14"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("66e52181-c48e-4fcc-a68e-421a02a9443e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("6b9f2a3b-e60e-45ef-b5ec-056b362cf874"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("6d3f0b5b-f3f1-444b-a642-e83b527d7c3a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("71bbd6ba-141b-4990-b2fa-28d59e026c75"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("74757d60-d6c9-4cf3-a657-8f01bf8c42c7"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("748bbfcd-20b9-4be4-8ec5-522afcc5caf4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("7e623947-4413-48ab-a0e1-c797405f5f10"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("7ea9448b-e686-49e2-a0df-c425bd44f3ea"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("8136a6cf-c815-4d9e-9888-399d76d7c8e1"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("820d7547-37d2-480a-84bf-a3cae888b55c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("825d82f4-470c-4eb5-bf4f-6106b682260e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("86ac7343-b4cd-4dbb-946f-81db8c117f87"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("8a085ad7-3a1e-4cfd-8be9-c1bac0c36517"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("8ae7996c-505b-4343-9df7-caebf86c9e60"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("8c2d3663-1012-4a24-809d-bb12e6ed5d23"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("8ff0d04b-da37-4345-853c-71b66a2d94eb"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("9186a969-d349-4cc8-866b-352a5056418c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("91f89343-44ab-47a9-964b-15437a9678a1"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("92913faa-9607-43da-b4aa-b6269cad9d12"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("97c46aeb-da40-47de-9a6f-52254c3f5eb8"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("995cb552-a1a7-40c9-9032-d374f11f3ed4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("99c6c608-54b0-44b5-b018-65b506bb5398"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("9e39d8ed-8447-45e6-aa07-9aa76e5c6c49"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("9e518c87-c522-4fa7-abe1-a318ceec4e09"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("9f9cdb58-040c-472e-9f6a-576a9ee87fb4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("9fff7eda-6093-4ce8-b467-f102b0f09430"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("a52a3b15-3a21-44cd-8d74-b4c6751e2963"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("a767ae08-1162-4d9d-a6f0-e74123c4e055"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("ac30fa55-823c-4f49-aa01-98a15822af37"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("ad437f7f-3242-4270-997f-a0a6f8a0c9b2"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("ad84e105-1ca7-401e-abd7-fdc5d2e40999"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("b0377a76-981e-4af2-a0d8-d7ae1f723e7b"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("b430ab31-8762-4f35-906f-989f981f61b7"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("b49b3229-b46c-4821-a0f9-2ead482c2bf1"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("b629fa64-5dea-4129-9d59-f48c265bca62"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("bc19438f-ee7e-4e59-ad83-e7879c0a54e5"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("bc1e9f85-8404-46eb-a6e6-bab6f898566a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("bc73983d-1bb7-447b-be96-c4fc7b653e5c"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("bfe5f392-c582-4915-9360-3d90134295d5"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("c0d46118-35a4-4a25-982b-584781b45ca8"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("c2a1d4aa-eb5a-4850-84c2-2b4cd2db77e0"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("c731c3f5-a1d2-4b8f-bd7f-2d57fa0acb0f"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("c74e4f33-a078-4219-8f69-7398435aff4d"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("ca49e2d3-f880-4a4f-9e60-04c57660d730"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("ce320b5a-4eac-4436-92ef-90b985aec10f"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("cf3913ca-fa92-4f90-a55b-93725cae4b32"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("d05498a2-0502-4a9d-a535-d548db92000a"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("d6f2b6ab-0f91-4ffc-ade1-65b934718b68"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("d8393091-0dbd-4ab8-b18c-50ae38579ce8"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("da699b0b-c55d-417f-93d8-e9571e712189"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("dc05a4d6-7019-424c-bc3b-118c7aa1272b"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("dc482730-bf16-4558-b1b6-8a7f1b8b855d"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("dd5be2ec-dd31-41ad-8674-d870f7b13ee8"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("e026cfb6-343f-4af1-a15d-c840165a09b4"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("e10926c7-63e0-48e0-947c-060ba13d0a8e"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("e812ac28-8fa5-4c08-8d45-e40b6018056f"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("f5e68a91-1e8e-4ef7-9f0d-6da923dc5611"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("fa88d41b-f627-4e5e-af66-19ead35fb082"));

            migrationBuilder.DeleteData(
                table: "Major",
                keyColumn: "Id",
                keyValue: new Guid("fcab8031-99a2-40cb-921c-f76e7f250ab6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Major",
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
                values: new object[] { new DateTime(2023, 12, 8, 2, 7, 13, 571, DateTimeKind.Utc).AddTicks(9836), new DateTime(2023, 12, 9, 2, 7, 13, 571, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 45, 97, 211, 8, 92, 42, 237, 127, 106, 41, 209, 140, 71, 100, 42, 245, 93, 123, 161, 187, 132, 67, 212, 255, 130, 229, 61, 39, 105, 238, 60, 112, 79, 109, 79, 53, 139, 205, 29, 240, 225, 13, 209, 184, 229, 26, 109, 194, 82, 251, 117, 87, 122, 216, 224, 253, 163, 105, 222, 80, 156, 62, 45, 102 }, new byte[] { 176, 217, 210, 103, 186, 50, 90, 140, 207, 229, 46, 6, 102, 30, 116, 254, 116, 227, 235, 108, 25, 136, 251, 39, 142, 240, 152, 83, 106, 74, 60, 178, 158, 183, 18, 117, 104, 136, 196, 34, 31, 131, 159, 176, 114, 85, 149, 89, 169, 93, 158, 129, 77, 51, 248, 130, 183, 61, 207, 134, 144, 101, 64, 97, 106, 239, 96, 200, 108, 241, 81, 162, 241, 87, 192, 86, 39, 154, 205, 43, 253, 54, 127, 197, 28, 101, 44, 23, 141, 79, 184, 133, 93, 99, 60, 244, 170, 112, 142, 31, 41, 48, 186, 198, 149, 148, 74, 167, 199, 22, 97, 118, 142, 243, 78, 62, 10, 113, 188, 105, 240, 133, 236, 35, 116, 186, 135, 168 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 12, 108, 27, 249, 57, 238, 72, 86, 87, 159, 229, 125, 117, 241, 66, 249, 229, 37, 94, 254, 162, 163, 212, 79, 255, 62, 143, 83, 140, 94, 98, 194, 144, 40, 193, 79, 250, 23, 84, 1, 63, 226, 27, 61, 135, 189, 15, 135, 11, 88, 94, 14, 121, 124, 93, 18, 105, 101, 193, 156, 189, 225, 118 }, new byte[] { 144, 166, 254, 175, 220, 128, 75, 141, 88, 210, 139, 183, 9, 118, 152, 144, 198, 177, 178, 104, 36, 161, 48, 120, 232, 217, 133, 191, 128, 115, 148, 46, 33, 168, 77, 253, 18, 166, 252, 128, 146, 15, 105, 32, 139, 44, 20, 230, 225, 9, 65, 218, 9, 143, 124, 156, 139, 151, 200, 162, 101, 27, 247, 143, 80, 1, 154, 60, 87, 103, 156, 125, 131, 218, 91, 191, 9, 182, 235, 4, 58, 177, 66, 161, 210, 123, 41, 254, 209, 44, 79, 160, 128, 195, 147, 43, 137, 105, 2, 119, 245, 117, 155, 65, 255, 116, 72, 26, 145, 118, 165, 112, 66, 14, 153, 220, 64, 90, 89, 118, 136, 42, 120, 17, 219, 213, 40, 232 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 3, 170, 2, 165, 228, 202, 100, 193, 201, 28, 174, 245, 167, 147, 214, 219, 127, 122, 68, 211, 162, 166, 19, 47, 51, 231, 136, 229, 5, 53, 19, 121, 41, 179, 46, 132, 37, 128, 203, 253, 188, 207, 88, 62, 32, 122, 229, 137, 234, 150, 162, 161, 6, 212, 234, 248, 9, 201, 9, 141, 29, 170, 65 }, new byte[] { 215, 186, 119, 203, 127, 54, 116, 52, 174, 235, 134, 158, 152, 78, 73, 172, 85, 162, 41, 130, 219, 1, 72, 45, 243, 154, 41, 49, 112, 17, 79, 132, 237, 40, 170, 57, 187, 175, 73, 61, 62, 251, 3, 169, 221, 65, 89, 90, 45, 63, 39, 32, 148, 220, 210, 139, 149, 84, 149, 227, 132, 111, 12, 96, 225, 64, 152, 102, 181, 161, 177, 129, 250, 228, 168, 126, 2, 42, 13, 194, 216, 233, 28, 254, 72, 106, 202, 253, 57, 4, 226, 36, 151, 31, 232, 194, 199, 159, 168, 128, 88, 46, 118, 158, 135, 238, 179, 210, 177, 124, 234, 241, 61, 45, 23, 221, 25, 228, 225, 213, 203, 206, 249, 109, 131, 163, 235, 171 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 29, 155, 94, 220, 161, 2, 49, 176, 66, 125, 217, 120, 15, 67, 199, 8, 242, 144, 180, 30, 158, 121, 250, 248, 236, 34, 46, 13, 137, 156, 108, 143, 210, 18, 217, 140, 246, 22, 2, 140, 18, 46, 100, 3, 223, 72, 3, 182, 51, 189, 227, 164, 35, 51, 133, 6, 109, 196, 81, 98, 119, 48, 153, 104 }, new byte[] { 61, 72, 57, 194, 123, 201, 193, 221, 1, 165, 167, 28, 177, 58, 223, 99, 154, 241, 167, 19, 121, 134, 107, 148, 43, 98, 88, 113, 142, 248, 138, 201, 72, 183, 147, 202, 241, 228, 17, 106, 42, 188, 171, 89, 138, 92, 211, 156, 133, 165, 14, 211, 153, 14, 220, 201, 180, 188, 137, 95, 70, 218, 60, 180, 131, 16, 62, 171, 200, 23, 27, 122, 197, 50, 58, 146, 223, 115, 230, 127, 158, 125, 208, 240, 69, 97, 64, 254, 75, 184, 129, 164, 244, 201, 218, 124, 23, 189, 224, 20, 49, 101, 238, 27, 194, 44, 5, 171, 235, 237, 229, 209, 199, 140, 250, 123, 59, 185, 150, 239, 121, 102, 160, 241, 207, 9, 129, 210 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 89, 212, 166, 238, 6, 5, 66, 169, 186, 203, 169, 66, 74, 42, 226, 247, 209, 25, 220, 188, 222, 203, 98, 3, 135, 240, 68, 79, 99, 230, 157, 118, 1, 24, 219, 86, 250, 123, 97, 61, 104, 213, 17, 227, 154, 224, 237, 129, 14, 30, 194, 214, 111, 7, 246, 173, 64, 132, 192, 237, 138, 205, 152 }, new byte[] { 239, 51, 77, 90, 144, 110, 210, 245, 207, 133, 174, 44, 201, 22, 74, 164, 112, 179, 126, 78, 86, 125, 233, 190, 139, 188, 9, 151, 12, 122, 124, 117, 110, 135, 117, 84, 72, 92, 25, 130, 0, 99, 145, 151, 146, 22, 234, 207, 47, 8, 220, 165, 63, 97, 204, 99, 49, 12, 77, 198, 71, 115, 97, 55, 241, 170, 247, 115, 239, 145, 54, 174, 103, 162, 66, 34, 45, 196, 29, 180, 230, 233, 5, 100, 164, 74, 70, 78, 16, 225, 0, 78, 13, 42, 84, 209, 228, 109, 23, 42, 145, 54, 122, 41, 115, 105, 127, 33, 200, 80, 108, 76, 7, 92, 126, 189, 37, 227, 29, 156, 252, 140, 110, 84, 55, 18, 40, 17 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 86, 113, 49, 125, 212, 97, 21, 93, 164, 155, 244, 221, 62, 157, 13, 92, 247, 227, 247, 96, 15, 154, 110, 46, 107, 113, 247, 37, 172, 234, 132, 17, 36, 117, 118, 75, 41, 27, 214, 95, 24, 143, 162, 213, 238, 71, 226, 150, 9, 254, 133, 176, 173, 112, 6, 113, 167, 151, 225, 152, 59, 101, 186 }, new byte[] { 172, 203, 97, 239, 110, 252, 192, 77, 86, 92, 79, 5, 183, 97, 154, 202, 229, 187, 69, 33, 121, 93, 91, 77, 112, 74, 130, 19, 126, 167, 136, 52, 166, 95, 121, 7, 40, 192, 116, 152, 87, 89, 217, 120, 50, 158, 215, 233, 122, 241, 156, 136, 118, 128, 13, 184, 227, 184, 148, 60, 141, 47, 136, 111, 195, 128, 105, 80, 240, 175, 178, 83, 71, 102, 54, 226, 4, 35, 8, 191, 90, 126, 166, 125, 7, 237, 247, 221, 87, 187, 78, 105, 34, 167, 168, 125, 13, 69, 225, 17, 186, 4, 179, 212, 146, 247, 171, 2, 124, 112, 206, 146, 240, 130, 203, 147, 202, 50, 224, 254, 190, 99, 208, 168, 165, 109, 244, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 121, 95, 221, 35, 145, 68, 24, 199, 15, 65, 157, 62, 39, 245, 80, 173, 64, 70, 42, 111, 165, 135, 106, 148, 236, 24, 10, 71, 80, 215, 87, 205, 220, 211, 39, 127, 14, 247, 84, 78, 130, 33, 123, 195, 11, 193, 59, 107, 26, 155, 160, 5, 55, 84, 127, 12, 47, 241, 35, 3, 114, 252, 56, 64 }, new byte[] { 226, 178, 151, 180, 165, 28, 63, 237, 4, 133, 35, 57, 254, 62, 203, 237, 224, 136, 113, 71, 74, 42, 43, 175, 230, 244, 196, 176, 228, 37, 148, 1, 121, 136, 160, 127, 112, 114, 241, 45, 51, 100, 52, 233, 170, 120, 162, 176, 227, 190, 223, 6, 237, 59, 233, 150, 233, 208, 213, 253, 173, 129, 224, 211, 1, 205, 200, 195, 0, 252, 120, 113, 52, 135, 158, 254, 185, 95, 117, 29, 91, 83, 198, 108, 211, 177, 42, 66, 52, 86, 1, 240, 202, 139, 21, 36, 139, 146, 107, 87, 163, 25, 178, 183, 165, 241, 61, 42, 62, 5, 251, 39, 174, 34, 33, 55, 149, 155, 23, 49, 168, 134, 62, 117, 216, 201, 36, 179 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 149, 155, 101, 28, 57, 224, 97, 234, 99, 50, 189, 187, 225, 25, 188, 97, 241, 248, 67, 102, 172, 25, 214, 183, 61, 30, 93, 103, 225, 233, 112, 174, 55, 11, 47, 37, 59, 30, 240, 52, 153, 58, 19, 178, 8, 125, 50, 79, 100, 88, 167, 69, 46, 139, 245, 233, 118, 221, 50, 47, 204, 72, 143, 113 }, new byte[] { 222, 175, 2, 136, 133, 165, 130, 178, 55, 129, 50, 72, 79, 240, 111, 0, 62, 246, 236, 174, 36, 145, 5, 11, 112, 25, 59, 66, 32, 176, 115, 58, 35, 116, 1, 216, 14, 33, 224, 75, 161, 211, 232, 49, 177, 62, 138, 69, 49, 88, 96, 152, 210, 237, 202, 71, 42, 40, 85, 163, 221, 57, 2, 14, 46, 120, 224, 196, 208, 48, 56, 239, 252, 179, 190, 142, 31, 41, 84, 133, 250, 7, 37, 231, 139, 189, 39, 25, 146, 194, 140, 230, 206, 114, 30, 19, 22, 58, 27, 230, 75, 21, 232, 221, 125, 179, 191, 43, 124, 40, 204, 163, 162, 108, 215, 215, 1, 111, 177, 121, 148, 222, 118, 199, 74, 58, 251, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 59, 205, 114, 129, 89, 47, 229, 238, 134, 122, 10, 66, 157, 198, 102, 127, 194, 116, 248, 208, 220, 189, 89, 22, 220, 247, 240, 237, 88, 87, 73, 116, 166, 185, 37, 15, 222, 118, 41, 6, 176, 58, 24, 219, 49, 26, 131, 120, 119, 8, 232, 147, 123, 216, 212, 24, 9, 25, 166, 238, 94, 126, 123 }, new byte[] { 51, 92, 61, 67, 210, 248, 47, 27, 118, 222, 175, 185, 54, 73, 134, 131, 11, 116, 114, 56, 87, 219, 231, 211, 142, 96, 7, 31, 16, 140, 186, 231, 62, 167, 109, 73, 168, 19, 32, 247, 222, 154, 208, 21, 243, 51, 173, 20, 204, 158, 157, 198, 84, 57, 26, 164, 72, 188, 121, 217, 110, 105, 20, 117, 249, 102, 182, 101, 195, 196, 168, 213, 14, 183, 120, 210, 34, 68, 57, 155, 56, 212, 107, 254, 38, 175, 42, 126, 35, 100, 195, 215, 146, 6, 58, 199, 250, 240, 185, 6, 76, 156, 16, 6, 239, 122, 131, 134, 97, 147, 93, 24, 178, 212, 219, 11, 137, 83, 14, 131, 158, 133, 255, 193, 3, 106, 68, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 37, 4, 14, 72, 163, 4, 110, 128, 116, 1, 185, 51, 200, 218, 48, 223, 22, 203, 23, 156, 120, 100, 88, 237, 95, 107, 133, 1, 57, 80, 128, 86, 187, 204, 224, 72, 111, 239, 36, 225, 148, 104, 66, 12, 22, 202, 190, 228, 170, 242, 204, 209, 221, 170, 130, 232, 151, 45, 16, 83, 22, 223, 81 }, new byte[] { 195, 2, 55, 131, 125, 250, 96, 237, 175, 99, 152, 39, 48, 71, 184, 197, 237, 133, 182, 202, 59, 180, 204, 217, 136, 112, 155, 65, 62, 237, 153, 123, 35, 186, 97, 65, 107, 87, 66, 81, 106, 17, 96, 72, 135, 111, 158, 242, 67, 64, 195, 204, 138, 166, 80, 101, 216, 6, 113, 170, 17, 254, 237, 207, 181, 22, 113, 129, 2, 198, 95, 118, 113, 119, 54, 136, 81, 89, 108, 159, 210, 80, 65, 154, 181, 41, 250, 131, 24, 185, 190, 191, 185, 77, 55, 71, 134, 158, 11, 131, 67, 192, 195, 217, 114, 227, 225, 24, 88, 184, 157, 136, 47, 164, 100, 12, 37, 235, 18, 164, 181, 186, 193, 73, 174, 217, 43, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 16, 177, 130, 248, 147, 199, 3, 232, 1, 52, 76, 157, 79, 87, 27, 87, 123, 13, 176, 56, 37, 1, 244, 29, 195, 133, 166, 222, 201, 57, 129, 159, 61, 225, 229, 169, 111, 219, 61, 97, 17, 222, 225, 229, 147, 186, 124, 8, 213, 71, 241, 125, 200, 182, 85, 171, 87, 154, 216, 68, 104, 72, 169 }, new byte[] { 182, 80, 226, 207, 31, 183, 68, 45, 68, 169, 121, 102, 203, 253, 120, 230, 20, 15, 36, 103, 29, 105, 244, 16, 112, 240, 113, 36, 181, 122, 230, 161, 249, 122, 14, 26, 50, 128, 37, 249, 68, 38, 67, 111, 46, 188, 43, 46, 61, 190, 32, 238, 231, 204, 92, 194, 165, 46, 29, 79, 242, 206, 92, 126, 0, 83, 12, 117, 214, 25, 245, 143, 226, 195, 44, 33, 113, 93, 112, 188, 220, 226, 138, 150, 70, 6, 214, 237, 165, 152, 225, 145, 245, 206, 95, 55, 46, 49, 120, 255, 40, 113, 93, 195, 176, 188, 126, 20, 196, 241, 155, 159, 172, 141, 224, 155, 248, 45, 86, 206, 54, 78, 200, 188, 106, 15, 79, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 141, 157, 79, 89, 55, 148, 190, 123, 225, 144, 182, 94, 198, 127, 23, 80, 233, 152, 221, 60, 16, 0, 147, 238, 110, 130, 14, 247, 55, 175, 130, 106, 196, 31, 127, 30, 83, 170, 120, 182, 22, 100, 47, 170, 204, 217, 82, 63, 153, 166, 128, 88, 109, 121, 170, 237, 77, 59, 99, 21, 133, 183, 223 }, new byte[] { 106, 151, 110, 22, 248, 219, 156, 251, 115, 241, 105, 198, 196, 243, 121, 193, 60, 128, 235, 209, 70, 238, 25, 164, 166, 53, 15, 59, 172, 186, 143, 224, 109, 163, 16, 47, 59, 77, 234, 141, 51, 169, 73, 144, 73, 199, 215, 196, 145, 153, 34, 136, 156, 176, 114, 151, 230, 33, 218, 100, 153, 254, 137, 80, 159, 107, 110, 70, 177, 73, 229, 34, 158, 188, 27, 22, 32, 20, 111, 220, 248, 230, 121, 156, 135, 144, 108, 68, 126, 193, 146, 204, 217, 20, 129, 222, 220, 112, 153, 52, 120, 45, 69, 179, 83, 233, 55, 190, 37, 69, 181, 147, 210, 37, 21, 155, 164, 178, 193, 150, 227, 174, 199, 156, 102, 93, 248, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 161, 123, 255, 51, 3, 180, 220, 66, 99, 170, 82, 158, 37, 191, 159, 203, 71, 239, 248, 21, 130, 255, 16, 37, 42, 110, 14, 234, 118, 87, 130, 164, 156, 255, 72, 188, 179, 33, 2, 99, 32, 123, 190, 82, 224, 219, 19, 95, 124, 102, 152, 88, 58, 86, 98, 135, 155, 174, 221, 113, 252, 172, 222 }, new byte[] { 53, 49, 72, 61, 109, 246, 87, 121, 104, 202, 86, 205, 23, 201, 125, 103, 11, 137, 29, 12, 207, 219, 219, 187, 57, 108, 137, 62, 135, 140, 55, 26, 48, 65, 82, 228, 152, 41, 216, 252, 28, 195, 198, 142, 153, 32, 124, 82, 193, 77, 110, 238, 9, 200, 114, 67, 38, 118, 172, 234, 77, 244, 161, 244, 84, 17, 165, 154, 170, 183, 56, 157, 57, 200, 116, 53, 98, 226, 50, 89, 22, 64, 80, 128, 106, 85, 147, 43, 122, 232, 172, 235, 107, 214, 10, 214, 114, 48, 174, 176, 18, 253, 186, 57, 161, 119, 37, 102, 13, 236, 139, 224, 6, 211, 184, 26, 191, 233, 197, 209, 174, 13, 55, 214, 168, 172, 43, 148 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 53, 35, 4, 77, 199, 28, 4, 3, 136, 183, 218, 208, 223, 180, 1, 149, 40, 144, 7, 162, 131, 164, 5, 235, 232, 25, 197, 96, 18, 20, 152, 47, 106, 114, 138, 162, 15, 128, 186, 248, 78, 174, 15, 149, 28, 20, 137, 55, 186, 83, 56, 255, 163, 214, 206, 16, 50, 227, 105, 134, 63, 248, 190, 226 }, new byte[] { 6, 115, 137, 56, 172, 184, 19, 146, 244, 232, 223, 68, 11, 175, 41, 25, 50, 244, 131, 219, 174, 220, 151, 180, 10, 130, 166, 148, 42, 25, 158, 207, 26, 179, 69, 47, 173, 88, 234, 195, 213, 26, 187, 217, 158, 37, 102, 228, 124, 46, 35, 246, 38, 165, 140, 131, 118, 105, 245, 35, 163, 170, 245, 167, 170, 0, 145, 57, 200, 116, 214, 75, 112, 124, 96, 64, 60, 96, 77, 129, 212, 187, 223, 156, 102, 224, 174, 188, 7, 228, 184, 30, 55, 225, 210, 55, 69, 27, 251, 254, 167, 59, 242, 206, 128, 10, 124, 138, 35, 128, 33, 113, 156, 145, 156, 8, 57, 61, 253, 63, 152, 77, 244, 8, 135, 128, 13, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 191, 103, 34, 85, 97, 102, 42, 1, 78, 201, 221, 224, 121, 15, 175, 20, 32, 165, 124, 69, 196, 168, 16, 10, 81, 137, 149, 55, 105, 200, 164, 139, 19, 200, 120, 58, 100, 225, 255, 158, 114, 42, 174, 234, 97, 9, 53, 139, 139, 69, 163, 58, 18, 96, 137, 22, 78, 192, 136, 218, 3, 208, 63 }, new byte[] { 98, 249, 21, 149, 83, 73, 135, 104, 92, 173, 199, 3, 197, 43, 51, 49, 239, 34, 105, 96, 2, 130, 227, 254, 200, 244, 139, 8, 254, 148, 233, 44, 76, 71, 145, 239, 9, 15, 122, 116, 121, 147, 111, 93, 219, 206, 96, 87, 80, 252, 34, 246, 90, 89, 104, 189, 176, 122, 49, 225, 150, 226, 29, 132, 156, 232, 113, 175, 44, 9, 172, 136, 15, 45, 92, 181, 80, 136, 8, 97, 31, 241, 192, 192, 105, 36, 217, 111, 146, 56, 40, 50, 195, 149, 152, 208, 208, 112, 157, 136, 192, 19, 242, 140, 68, 40, 146, 114, 11, 61, 119, 225, 66, 226, 155, 156, 98, 160, 242, 140, 237, 142, 119, 74, 239, 116, 113, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 73, 128, 170, 25, 96, 6, 73, 9, 249, 12, 52, 149, 84, 255, 137, 138, 111, 156, 242, 198, 92, 40, 71, 25, 38, 11, 25, 98, 175, 117, 99, 16, 72, 237, 10, 191, 47, 136, 171, 29, 163, 184, 66, 186, 145, 108, 122, 108, 199, 90, 89, 88, 245, 104, 157, 131, 93, 46, 74, 214, 64, 115, 145 }, new byte[] { 246, 211, 213, 119, 21, 163, 119, 96, 85, 38, 185, 33, 139, 100, 14, 191, 51, 34, 135, 100, 72, 82, 60, 132, 68, 67, 75, 28, 183, 102, 203, 23, 0, 219, 85, 105, 134, 31, 72, 99, 19, 226, 16, 168, 201, 144, 19, 160, 47, 65, 172, 209, 189, 207, 30, 22, 195, 118, 253, 86, 87, 86, 231, 187, 130, 148, 142, 124, 220, 251, 127, 134, 133, 128, 48, 145, 123, 114, 70, 190, 152, 248, 101, 245, 28, 78, 211, 10, 105, 84, 133, 71, 90, 143, 210, 124, 40, 158, 179, 166, 118, 177, 64, 86, 89, 134, 233, 232, 253, 92, 68, 55, 31, 22, 73, 168, 86, 201, 170, 52, 161, 80, 70, 97, 140, 235, 247, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 160, 85, 242, 213, 33, 53, 161, 149, 31, 72, 94, 197, 100, 210, 182, 102, 0, 54, 231, 134, 180, 77, 172, 101, 189, 167, 173, 23, 196, 58, 35, 89, 17, 176, 176, 68, 46, 125, 182, 198, 144, 98, 195, 251, 27, 14, 233, 75, 36, 238, 211, 183, 156, 174, 0, 11, 78, 173, 209, 83, 215, 42, 40, 179 }, new byte[] { 253, 21, 52, 81, 100, 142, 245, 89, 15, 93, 201, 89, 146, 26, 100, 111, 115, 191, 202, 224, 30, 21, 65, 97, 145, 183, 58, 192, 105, 234, 189, 114, 152, 77, 174, 96, 94, 125, 84, 230, 223, 49, 31, 154, 149, 128, 15, 45, 98, 28, 6, 149, 125, 82, 133, 21, 43, 106, 115, 120, 127, 224, 95, 165, 15, 164, 159, 230, 62, 58, 100, 249, 68, 156, 61, 58, 120, 191, 155, 159, 80, 143, 3, 18, 44, 55, 134, 175, 176, 97, 180, 201, 98, 171, 92, 130, 152, 116, 153, 210, 57, 221, 58, 192, 206, 148, 231, 230, 31, 195, 19, 253, 83, 250, 55, 168, 19, 87, 199, 201, 20, 7, 136, 7, 3, 249, 20, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 178, 26, 247, 78, 234, 90, 60, 255, 230, 178, 196, 2, 233, 42, 150, 181, 146, 172, 205, 252, 64, 250, 135, 20, 137, 70, 204, 181, 55, 50, 240, 149, 227, 35, 59, 25, 27, 72, 177, 202, 159, 2, 108, 83, 9, 36, 118, 138, 80, 244, 100, 91, 214, 204, 209, 72, 12, 6, 223, 47, 171, 88, 204 }, new byte[] { 144, 191, 29, 95, 104, 62, 141, 235, 122, 104, 159, 235, 226, 241, 48, 162, 135, 166, 219, 106, 167, 81, 214, 66, 215, 84, 247, 11, 208, 25, 216, 39, 78, 249, 162, 203, 156, 149, 48, 233, 23, 162, 80, 213, 11, 163, 9, 220, 240, 3, 92, 173, 192, 141, 86, 208, 153, 248, 9, 61, 241, 148, 86, 7, 22, 120, 201, 246, 44, 117, 156, 49, 215, 210, 211, 201, 80, 215, 238, 9, 148, 44, 26, 200, 198, 212, 95, 243, 212, 99, 106, 84, 113, 244, 198, 80, 191, 51, 81, 40, 22, 72, 8, 154, 153, 38, 15, 203, 31, 241, 128, 180, 63, 26, 91, 4, 200, 14, 240, 98, 177, 77, 221, 205, 152, 71, 186, 51 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 255, 39, 125, 201, 83, 211, 49, 104, 96, 203, 172, 77, 5, 25, 87, 243, 121, 124, 134, 102, 4, 206, 172, 237, 111, 217, 254, 27, 214, 51, 17, 136, 143, 177, 190, 124, 46, 8, 229, 43, 151, 167, 67, 181, 4, 72, 45, 211, 148, 73, 82, 195, 121, 46, 254, 110, 6, 119, 34, 102, 217, 196, 199 }, new byte[] { 57, 27, 220, 49, 48, 142, 31, 177, 202, 16, 206, 103, 173, 66, 13, 35, 5, 135, 230, 13, 201, 82, 188, 229, 179, 61, 52, 150, 190, 187, 195, 207, 112, 120, 24, 59, 29, 197, 72, 205, 137, 196, 251, 62, 121, 233, 118, 7, 41, 204, 220, 111, 200, 203, 105, 248, 103, 222, 162, 216, 174, 2, 39, 41, 37, 37, 36, 76, 228, 93, 15, 88, 190, 98, 40, 155, 248, 23, 186, 249, 167, 199, 42, 122, 74, 111, 111, 95, 104, 107, 217, 117, 60, 68, 1, 194, 166, 218, 149, 138, 3, 253, 210, 42, 17, 33, 2, 82, 230, 150, 255, 195, 92, 254, 41, 123, 213, 204, 61, 6, 172, 146, 127, 55, 201, 236, 90, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 89, 71, 159, 214, 18, 66, 10, 246, 204, 206, 23, 187, 245, 182, 150, 42, 198, 118, 199, 231, 75, 137, 3, 24, 97, 120, 155, 222, 170, 100, 57, 223, 64, 49, 199, 45, 115, 97, 82, 195, 9, 203, 219, 73, 50, 32, 8, 254, 179, 41, 235, 143, 118, 167, 139, 25, 241, 104, 140, 30, 176, 225, 180 }, new byte[] { 123, 214, 197, 0, 75, 49, 33, 121, 102, 54, 122, 95, 97, 123, 73, 69, 232, 219, 84, 110, 143, 34, 41, 61, 6, 121, 117, 87, 43, 148, 179, 93, 126, 203, 11, 66, 66, 187, 18, 64, 251, 104, 219, 36, 54, 228, 108, 201, 202, 36, 195, 191, 236, 24, 177, 74, 50, 220, 46, 10, 76, 135, 53, 170, 13, 81, 198, 138, 123, 39, 224, 178, 180, 6, 1, 138, 20, 121, 166, 72, 182, 243, 120, 195, 119, 68, 171, 124, 126, 61, 254, 172, 233, 212, 95, 155, 21, 155, 126, 93, 187, 79, 188, 125, 123, 204, 148, 86, 132, 158, 198, 87, 100, 170, 165, 44, 11, 29, 31, 223, 138, 6, 76, 69, 94, 119, 157, 125 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 21, 177, 169, 246, 158, 88, 213, 90, 15, 188, 205, 52, 251, 166, 87, 36, 147, 7, 86, 41, 237, 82, 70, 148, 19, 51, 54, 85, 48, 222, 143, 7, 194, 28, 219, 152, 158, 159, 106, 138, 243, 212, 42, 143, 158, 74, 169, 118, 146, 10, 106, 209, 73, 27, 131, 70, 49, 200, 147, 222, 36, 133, 26, 93 }, new byte[] { 121, 236, 30, 24, 149, 142, 235, 69, 204, 180, 70, 102, 48, 116, 228, 1, 108, 190, 221, 55, 132, 91, 63, 101, 234, 96, 38, 219, 166, 180, 203, 211, 24, 68, 213, 2, 41, 53, 67, 141, 215, 165, 175, 86, 252, 49, 124, 161, 16, 158, 247, 150, 87, 25, 51, 223, 86, 26, 158, 95, 15, 72, 204, 152, 166, 26, 152, 102, 84, 167, 194, 60, 105, 42, 131, 132, 26, 66, 197, 94, 166, 76, 11, 43, 169, 94, 55, 172, 203, 41, 225, 99, 231, 21, 123, 239, 67, 6, 168, 139, 186, 231, 103, 206, 194, 254, 72, 203, 115, 89, 236, 96, 30, 250, 193, 180, 66, 3, 160, 167, 31, 160, 135, 112, 36, 10, 131, 230 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 58, 130, 74, 41, 114, 191, 215, 4, 112, 183, 42, 144, 170, 179, 177, 61, 161, 155, 197, 243, 216, 137, 179, 119, 29, 154, 107, 132, 102, 95, 217, 142, 192, 174, 11, 75, 164, 17, 189, 29, 82, 83, 221, 139, 81, 129, 92, 30, 3, 60, 27, 218, 235, 239, 45, 210, 69, 192, 97, 193, 248, 80, 79 }, new byte[] { 214, 69, 19, 83, 129, 231, 234, 229, 20, 156, 247, 237, 76, 64, 17, 220, 28, 223, 95, 7, 61, 115, 166, 158, 166, 36, 80, 92, 14, 147, 33, 133, 43, 146, 189, 125, 137, 67, 214, 56, 20, 231, 63, 97, 5, 133, 162, 191, 190, 134, 125, 200, 208, 216, 241, 180, 18, 118, 204, 35, 78, 73, 92, 50, 219, 219, 198, 215, 224, 176, 117, 184, 246, 108, 64, 106, 95, 115, 125, 25, 148, 225, 224, 44, 164, 51, 238, 231, 228, 168, 169, 166, 171, 151, 151, 55, 25, 61, 202, 104, 76, 25, 124, 26, 109, 93, 41, 151, 4, 33, 112, 125, 53, 27, 246, 78, 20, 189, 94, 31, 244, 219, 82, 172, 17, 58, 91, 168 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 236, 150, 190, 83, 111, 114, 254, 237, 231, 130, 87, 234, 55, 123, 83, 253, 96, 74, 101, 150, 83, 131, 136, 191, 38, 207, 107, 237, 184, 230, 207, 110, 225, 66, 25, 222, 35, 166, 70, 207, 235, 75, 84, 217, 4, 220, 170, 125, 237, 5, 24, 216, 61, 245, 96, 112, 157, 243, 156, 58, 143, 126, 247 }, new byte[] { 145, 99, 113, 205, 226, 81, 78, 161, 33, 172, 46, 94, 116, 63, 194, 82, 119, 232, 126, 100, 37, 96, 23, 162, 73, 237, 199, 100, 253, 117, 174, 86, 98, 101, 63, 196, 223, 229, 40, 191, 225, 165, 178, 135, 231, 173, 80, 216, 103, 52, 230, 169, 134, 127, 238, 134, 138, 230, 247, 138, 136, 192, 162, 143, 182, 50, 162, 73, 123, 228, 10, 62, 14, 23, 163, 62, 151, 96, 106, 163, 70, 57, 177, 196, 100, 151, 254, 48, 1, 120, 64, 243, 102, 122, 206, 29, 130, 10, 220, 38, 31, 211, 179, 170, 180, 75, 4, 226, 203, 39, 100, 132, 50, 165, 120, 151, 130, 172, 50, 207, 74, 107, 218, 55, 212, 130, 57, 40 } });
        }
    }
}
