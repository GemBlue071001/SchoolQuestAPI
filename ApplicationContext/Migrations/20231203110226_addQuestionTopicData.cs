using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addQuestionTopicData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("50051095-391a-4abf-94f2-ac3cf912f07b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("25b3ba1e-240a-4a3c-96b6-c0816b0a3975"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f722c143-412c-4721-bf5c-5b32a01d90da"));

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 12, 3, 11, 2, 25, 971, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 12, 4, 11, 2, 25, 971, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                column: "Name",
                value: "Tiếng Anh");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedBy", "Description", "Index", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("020841e0-c4da-4010-9556-e67ad0b7d816"), null, "Nội dung về đặc điểm, vấn đề phát triển của các khu vực kinh tế ở Việt Nam", 10, false, null, null, "Điạ Lý Các Vùng Kinh Tế", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("03699ee1-aa9b-4695-8593-8112a5b7145f"), null, "Giới thiệu sự phát sinh sự sống qua các giai đoạn tiến hóa hóa học và tiến hóa tiến sinh học, sự phát triển của sinh vật qua các đại địa chất và sự phát sinh loài người.", 7, false, null, null, "Sự phát sinh và phát triển của sự sống trên trái đất", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("0546ebd3-376e-4246-bdb3-9ae20e6f253c"), null, "thấy các đặc trưng di truyền của một quần thể như tần số alen, thành phần kiểu gen có xu hướng biến đổi ra sao qua các thế hệ, đồng thời cũng giới thiệu quy luật Hacđi – Vanbec về sự cân bằng của tần số alen và thành phần kiểu gen trong quần thể ngẫu phối.", 3, false, null, null, "Di truyền học quần thể", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("0bca65ca-2ce4-4923-a507-43e381130c9f"), null, "Nội dung về địa lý và lịch sử hình thành và phát triển lãnh thổ", 2, false, null, null, "Vị trí địa lí và lịch sử phát triển lãnh thổ", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("0c83b2dc-372d-4687-8a51-c35b5e51c991"), null, "Nội dung chuyển dịch cơ cấu ngành kinh tế, chuyển dịch cơ cấu thành phần  kinh tế, chuyển dịch cơ cấu lãnh thổ kinh tế", 6, false, null, null, "Địa Lý Kinh Tế", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("0faf3a0d-3e02-41f1-890c-51610de8e8cb"), null, "Tìm hiểu về các quyền dân chủ cơ bản của công dân: quyền bầu cử, ứng cử, quyền khiếu nại, tố cáo... ", 7, false, null, null, "Công dân với các quyền dân chủ", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("111aa302-4022-42e7-bf44-5546d2212240"), null, "Kim loại kiềm và hợp chất quan trọng kim loại kiềm, kim loại kiềm thổ và hợp chất quan trọng của chúng, nhôm và hợp chất của nhôm, luyện tập tính chất của kim loại kiềm, luyện tập tính chất của nhôm sau cùng là thực hành tính chất của natri, magie, nhôm và hợp chất của chúng", 6, false, null, null, "Kim Loại Kiềm, Kim Loại Kiềm Thổ, Nhôm", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("111d9344-66dd-4653-8cff-96bb9bc3863a"), null, "Este, lipit, khái niệm về Xà phòng và Chất giặt rửa tổng hợp sau cùng là luyện tập Este và Chất béo", 1, false, null, null, "Este – Lipit", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("1133b9a3-b5c1-4470-982a-22a5b5391d15"), null, "", 10, false, null, null, "Endangered Species - Những loài đang gặp nguy hiểm", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("1649f0c1-8557-4c2a-99a8-b4ffde8e7bbe"), null, "Nghiên cứu các kiến thức về Việt Nam giai đoạn từ 1954 đến 1975, qua đó, các em học sinh sẽ nắm được quá trình xây dựng CNXH ở miền Bắc và đấu tranh chống Đế quốc Mĩ ở Miền Nam và nguyên nhân thắng lợi ý nghĩa lịch sử đại thắng mùa xuân năm 1975 giải phóng hoàn toàn miền Nam", 10, false, null, null, "Việt Nam từ năm 1954 đến năm 1975", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("179ea3f8-4ed8-4151-b360-7dbe9f033e0c"), null, "Nghiên cứu các kiến thức về Việt Nam từ năm 1975 đến năm 2000. Qua đây, các em sẽ nắm được quá trình khắc phục hậu quả chiến tranh, đi lên XHCN, sự trở mình về kinh tế, văn hóa, xã hội ở Việt Nam", 11, false, null, null, "Việt Nam từ năm 1975 đến năm 2000", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"), null, "Tìm hiểu về các loại sóng trong cuộc sống chúng ta. Tìm hiểu về các khái niệm của sóng như: sóng cơ và sự truyền sóng cơ, giao thoa sóng là gì? khái niệm về sóng dừng và cuối cùng là đặc trưng vật lý của âm và đặc trưng sinh lý của âm", 2, false, null, null, "Sóng cơ và sóng âm", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("20dd53da-8d28-4f31-b2d6-7e722fbf1aea"), null, "Sắt, hợp chất của sắt, hợp kim của sắt, Crom và hợp chất của crom, đồng và hợp chất của đồng, Sơ lược về niken, kẽm, chì, thiếc, luyện tập Tính chất hóa học của sắt và hợp chất của sắt, luyện tập Tính chất hóa học của crom, đồng và hợp chất của chúng, thực hành Tính chất hóa học của sắt, đồng và hợp chất của sắt, crom", 7, false, null, null, "Sắt Và Một Số Kim Loại Quan Trọng", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("28bbe836-de18-4d85-9555-a47d95f85a5f"), null, "Nắm được khái niệm, bản chất của pháp luật, mối quan hệ giữa phát luật với đạo đức. Và hiểu được vai trò của pháp luật với đời sống của cá nhân, Nhà nước và xã hội", 1, false, null, null, "Pháp luật và đời sống", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("29322677-3508-4e9f-956d-38219393afe8"), null, " hiện tượng quang điện và thuyết lượng tử ánh sáng, hiện tượng quang điện trong, hiện tượng quang – phát quang và nguyên tử Bo và sơ lược Laze", 6, false, null, null, "Lượng tử ánh sáng", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("2addcd1a-4f32-42dc-bf9f-637fd7769c3c"), null, "", 2, false, null, null, "Cultural Diversity - Sự đa dạng văn hóa", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("33fcdca5-2b11-49cf-8824-f91d45c86dd2"), null, "", 1, false, null, null, "Home life - Đời sống gia đình", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("3501833e-e73b-4f30-8c73-36287d864c4b"), null, "Nội dung tìm hiểu địa lý tỉnh, thành phố qua đây sẽ giúp các em tìm hiểu kĩ hơn về địa lý hành chính, kinh tế, văn hóa xã hội, ở địa phương hoặc là tỉnh thành phố nơi mình đang sinh sống", 11, false, null, null, "Địa Lý Địa Phương", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("35399c19-5f66-4dfd-bdb7-f4744f6749aa"), null, "", 5, false, null, null, "Higher Education - Nền giáo dục bậc cao", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("356135ae-0bc9-4560-af03-191995168919"), null, "Giới thiệu các hệ sinh thái từ nhỏ đến lớn: các hệ sinh thái nhỏ → các khu sinh học → sinh quyển", 10, false, null, null, "Hệ sinh thái, sinh quyển và bảo vệ môi trường", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("370bb392-410b-46b5-9971-2df9a53e7670"), null, "Nội dung về dân cư và phát triển đô thi một cách hợp lý", 5, false, null, null, "Địa Lý Dân Cư", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("3f3502cf-68cb-4f91-846e-d8819dca38fd"), null, "", 16, false, null, null, "The Association of Southeast Asian Nations - Hiệp hội các quốc gia Đông Nam Á", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("451fa872-1960-4c03-a3df-374dbfc81c83"), null, "", 4, false, null, null, "School Education System - Hệ thống giáo dục", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("45b651e7-9e76-42d0-b996-aeb00ec00d3f"), null, "Nội dung về chọn giống vật nuôi và cây trồng dựa trên nguồn biến dị tổ hợp, Tạo giống bằng phương pháp gây đột biến và công nghệ tế bào, Tạo giống mới nhờ công nghệ gen", 4, false, null, null, "Ứng dụng di truyền học", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("468f1e58-d93b-46db-b4df-4a173513befb"), null, "Tìm hiểu thế nào về khái niệm mặt tròn xoay và tìm hiểu khái niệm mặt cầu là gì?", 6, false, null, null, "Mặt Nón, Mặt Trụ, Mặt Cầu", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("470c4063-38b5-437c-9820-2a29a470c708"), null, "", 11, false, null, null, "Books - Các loại sách", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("4881c89c-4995-4833-a00c-90bac688b8c4"), null, "Giới thiệu các đặc điểm và các phương pháp nghiên cứu di truyền ở người, đồng thời vạch ra nguyên nhân và cơ chế gây bệnh di truyền ở người, đồng thời chỉ ra loài người cung đang gánh chịu một gánh nặng di truyền và cần phải có biện pháp để giảm bớt các gánh nặng đó cũng như một số vấn đề xã hội của di truyền học", 5, false, null, null, "Di truyền học người", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("49d712a6-e7ca-4252-a430-308f954047ff"), null, "Khái niệm, đặc điểm của quần xã sinh vật", 9, false, null, null, "Quần xã sinh vật", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("4bf74338-43a1-495c-ba6a-8d4b4aa431ab"), null, "Nhận biết một số ion trong dung dịch, cách nhận biết một số chất khí, và sau cùng là luyện tập để nhận biết một số chất vô cơ", 8, false, null, null, "Phân Biệt Một Số Chất Vô Cơ", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("4f830591-4a73-4976-9a63-dcebb53ca4c2"), null, "", 7, false, null, null, "Economic Reforms - Sự cải cách kinh tế", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("5054a03a-17d9-4ba1-b33c-fef16aa2ffc0"), null, "Nghiên cứu các kiến thức về Mĩ, Tây Âu và Nhật Bản, qua đó nắm được tình hình kinh tế, văn hóa, xã hội của các nước này trong những năm 1945 đến 2000, sự hợp tác về mặt chính trị, quân sự và ngoại giao", 4, false, null, null, "Mĩ, Tây Âu, Nhật Bản (1945 – 2000)", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("533446a5-2f4c-4618-a441-f02bad78e322"), null, "Được thấy bản chất của hiện tượng di truyền và biến dị là sự vận động của các cấu trúc vật chất trong tế bào", 1, false, null, null, "Cơ chế di truyền và biến dị", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("55469d88-1e76-4678-ad62-e3d233602dfa"), null, "", 6, false, null, null, "Future Jobs - Nghề nghiệp tương lai", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("56057547-6172-4967-a8c3-e8e9afc494ac"), null, "Làm quen với nguyên hàm, tích phân và ứng dụng của chúng trong tính toán", 3, false, null, null, "Nguyên hàm. Tích phân và ứng dụng", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("596c886d-ae82-4b7e-9d88-7f185f57778e"), null, "Nghiên cứu các kiến thức về Việt Nam trong giai đoạn từ 1945 đến 1954, qua đó, các em học sinh sẽ nắm được cuộc hành trình 8 năm kháng chiến trường kì chống Pháp của dân tộc Việt Nam, những khó khăn và mất mát, nguyên nhân thắng lợi và ý nghĩa lịch sử", 9, false, null, null, "Việt Nam từ năm 1945 đến năm 1954", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("5a1a8691-497c-4ac4-b764-64b0984a7c49"), null, "làm quen với các loại ánh sáng như tán sắc ánh sáng, giao thoa ánh sáng sau đó là tìm hiểu về các loại quang phổ, bên cạnh đó là tìm hiểu về tia hồng ngoại và tia tử ngoại và tia X", 5, false, null, null, "Sóng ánh sáng", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("5b019dee-3d51-4b0c-af72-bc6b48d51a32"), null, "Nghiên cứu các kiến thức về cuộc cách mạng khoa học - công nghệ và xu thế toàn cầu hoá, qua đó nắm được những thành tựu khoa học cũng như những ảnh hưởng, tác động tích cực và tiêu cực của nó đến tình hình phát triển của xã hội", 6, false, null, null, "Cách mạng khoa học – Công nghệ và xu hướng toàn cầu hoá", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("64722757-eb15-4891-abbc-bd870caae9f1"), null, "", 3, false, null, null, "Ways of Socialising - Phương thức giao tiếp xã hội", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("670f0b14-435e-413f-ac27-7271ed1b87bb"), null, "Nghiên cứu các kiến thức về Việt Nam từ năm 1930-1945, qua đó nắm được nguyên nhân, diễn biến và ý nghĩa lịch sử của các cuộc cách mạng dân chủ, cách mạng tháng 8 và sự ra đời của nhà nước Việt Nam dân chủ cộng hòa", 8, false, null, null, "Việt Nam từ năm 1930 đến năm 1945", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("6880b25a-40ec-410e-b332-e6616982e206"), null, "Các hình thức cũng như quá trình thực hiện pháp luật. Bên cạnh đó hiểu được thế nào là vi phạm pháp luật và trách nhiệm pháp lí", 2, false, null, null, "Thực hiện pháp luật", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("6fc99327-e8b8-42ad-b3f0-641c2f81027d"), null, "Mạch dao động, điện từ trường, sóng điện từ và cuối cùng là nguyên tắc thông tin liên lạc bằng sóng vô tuyến. Được tìm hiểu về các khái niệm cũng như các ứng dụng trong thực tế", 4, false, null, null, "Dao động và Sóng điện từ", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("7294fa9f-78c5-49f3-a9fa-c99feb6d6a5c"), null, "", 9, false, null, null, "Deserts - Sa mạc", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("72c5c4ca-e8f8-4b02-97cd-4666ab7ccd44"), null, "Một đất nước phát triển bền vững là một đất nước có sự tăng trưởng liên tục và vững chắc về kinh tế, có sự bảo đảm ổn định và phát triển về văn hoá, xã hội, có môi trường được bảo vệ và cải thiện, có nền quốc phòng và an ninh vững chắc. Trong sự phát triển bền vững của đất nước, phát luật có vai trò rất quan trọng?", 9, false, null, null, "Pháp luật với sự phát triển bền vững của đất nước", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("74d64b16-20e1-4f3c-9f54-facf73dd9740"), null, "Làm Quen Với Mọi Khái Niệm Về Số Phức Phức Là Gì? Cộng Trừ Và Nhân Chia Số Phức Là Gì? Phép Chia Và Các Phép Toán Về Số Phức Và Tiếp Theo Đó Là Phương Trình Bậc Hai Với Hệ Số Thực", 4, false, null, null, "Số phức", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("7612387b-bd34-4ff2-bc52-535d32fe45ec"), null, "Khái niệm về khối đa diện, khối đa diện và khối đa diện đều là gì?", 5, false, null, null, "Khối đa diện", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("77963fa2-2bc8-4273-929b-835f0efd31f6"), null, "Sự đồng biến, nghịch biến của hàm số, cực trị của hàm số, tìm giá trị lớn nhất và giá trị nhỏ nhất của hàm số, đường tiệm cận là gì và cuối cùng là khảo sát sự biến thiên và vẽ đồ thị của hàm số.", 1, false, null, null, "Ứng dụng đạo hàm để khảo sát và vẽ đồ thị hàm số ", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("79d76295-efe3-4f84-a831-5ca9913b7ab6"), null, "Đại cương về dòng điện xoay chiều, cùng với đó là các mạch điện xoay chiều, tìm hiểu về các mạch R, L, C mắc nối tiếp, tính công suất điện tiêu thụ của mạch điện xoay chiều và Hệ số công suất tìm hiểu về truyền tải điện năng và máy biến áp, từ đó nghiên cứu máy phát điện xoay chiều, sau cùng là động cơ không đồng bộ ba pha và thực hành khảo sát đoạn mạch xoay chiều RLC.", 3, false, null, null, "Dòng điện xoay chiều", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("7b39b159-82aa-48a9-9dd1-6d0b435f50be"), null, "Hiểu về Pháp luật với sự phát triển của công dân là gì? Các quyền cơ bản để công dân phát triển đó là: học tập, sáng tạo,... ", 8, false, null, null, "Pháp luật với sự phát triển của công dân", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("838f30bd-d9cf-4ea6-8825-fe729c55e5af"), null, "", 13, false, null, null, "The 22nd Sea Game - Sea Game lần thứ 22", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("86f6ce80-f585-47d8-b3f0-c2f1d6cd084a"), null, "Tìm hiểu về vai trò của pháp luật đối với hòa bình và sự phát triển tiến bộ của nhân loại. Đồng thời tôn trọng pháp luật về các mặt phát triển của nhân loại", 10, false, null, null, "Pháp luật với hoà bình và sự phát triển tiến bộ của nhân loại", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("879bd2f5-8e49-4b94-b4cc-ed86c1f4b0da"), null, "Giới thiệu về vị trí địa lý, khí hậu cử từng vùng lãnh thổ trên đất nước Việt Nam", 3, false, null, null, "Đặc Điểm Chung Của Tự Nhiên", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("898a8245-bff3-4cbb-9ac4-8692cc84d2e1"), null, "Bình đẳng trước pháp luật là một trong những quyền cơ bản của công dân được quy định tại điều 52 Hiến pháp năm 1992 nước Cộng hòa xã hội chủ nghĩa Việt Nam: “Mọi công dân đều bình đẳng trước pháp luật”", 3, false, null, null, "Công dân bình đẳng trước pháp luật", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("9207680f-4c5e-4725-aec7-85d64102b0e9"), null, "Glucozơm Saccarozơ, Tinh bột và Xenlulozơ, Luyện tập Cấu tạo và tính chất của Cacbohiđrat", 2, false, null, null, "Cacbohiđrat", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("9654577c-a684-4ec7-ac30-fd49386482a7"), null, "Nghiên cứu các kiến thức về phong trào dân tộc, dân chủ ở Việt Nam trong hai gia đoạn từ 1919 - 1925 và từ 1925 - 1930, qua đó nắm được các chính sách khai thác thuộc địa của Pháp đối với Việt Nam, cũng như sự chuyển biến về mặt kinh tế, văn hóa, xã hội của đất nước", 7, false, null, null, "Việt Nam từ năm 1919 đến năm 1930", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("9a4f72df-ee78-4455-8b67-76b3a26ce507"), null, "", 12, false, null, null, "Water Sports - Những môn thể thao dưới nước", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("a54bae14-3251-48aa-b210-0c32b3b46a13"), null, "Giới thiệu về vị trí địa lý, khí hậu cử từng vùng lãnh thổ trên đất nước Việt Nam", 4, false, null, null, "Vấn Đề Sử Dụng Và Bảo Vệ Tự Nhiên", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("a9902cb8-b044-4e0e-8e22-9ec0337dea6b"), null, "Nội dung về đặc điểm về nền nông nghiệp ở nước ta", 7, false, null, null, "Một Số Vấn Đề Phát Triển Và Phân Bố Nông Nghiệp", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("adda106e-b8ba-4bfb-bdea-e2fcd916137c"), null, "Nội dung về ngành công nghiệp", 8, false, null, null, "Một Số Vấn Đề Phát Triển Và Phân Bố Công Nghiệp", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("b2a7a480-c0e9-424a-a3cf-e35ed4f7e794"), null, "Giới thiệu các loại bằng chứng tiến hóa bao gồm bằng chứng giải phẫu so sánh, phôi sinh học so sánh, tế bào học và sinh học phân từ, bằng chứng địa lý sinh vật học để chứng minh sự tồn tại của quá trình tiến hóa của các loài sinh vật trên trái đất.", 6, false, null, null, "Bằng chứng và cơ chế tiến hoá", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("b4f8ba38-e4f6-4fa9-a49a-18e74322e133"), null, "Nghiên cứu các kiến thức về Quan hệ Quốc tế sau chiến tranh lạnh, qua đó, các em học sinh sẽ nắm được tình hình thế giới trong giai đoạn này, sự mâu thuẫn, xung đột về lợi ích Đông - Tây, nội chiến kéo dài kèm theo đó là sự sụp đổ của XHCN", 5, false, null, null, "Quan hệ quốc tế (1945 – 2000)", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("b80adb23-18d3-4b5e-9fc0-2fa25d47dd49"), null, "Ngay từ khi mới ra đời đã xác định vấn đề dân tộc, tôn giáo là vấn đề chiến lược có tầm quan trọng đặc biệt. Đáp ứng đòi hỏi của sự nghiệp công nghiệp hóa, hiện đại hóa đất nước hiện nay, Đảng và Nhà nước ta đã có những chính sách như thế nào về vấn đề dân tộc và tôn giáo?", 5, false, null, null, "Quyền bình đẳng giữa các dân tộc, tôn giáo", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("ba088c8b-890e-4743-9a45-d49066c780a6"), null, "5 bài học liên quan đến hạt nhân nguyên tử như: tính chất và cấu tạo hạt nhân, năng lượng liên kết của hạt nhân và phản ứng hạt nhân, tìm hiểu phóng xạ, tiếp theo đó là tìm hiểu phản ứng phân hạch và phản ứng nhiệt hạch", 7, false, null, null, "Hạt nhân nguyên tử – Hiện tượng phóng xạ", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("bffb16de-cbfc-4a26-8e27-370225aa09aa"), null, "Nghiên cứu các kiến thức về Liên Xô và các nước Đông Âu, Liên bang Nga, qua đó nắm được tình hình kinh tế, văn hóa, xã hội của các nước này trong những năm 1945 đến 2000, sự hợp tác về mặt chính trị, quân sự và ngoại giao, sự hình thành chế độ XHCN ở Liên bang Nga.", 2, false, null, null, "Liên Xô và các nước Đông Âu (1945 – 1991). Liên bang Nga (1991 – 2000)", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("c20ee29b-c548-4a55-9f5c-2c78113b445e"), null, "Nghiên cứu các kiến thức về các nước Á, Phi và Mĩ Latinh giai đoạn từ năm 1945 đến 2000, qua đó nắm được tình hình kinh tế, văn hóa, xã hội của các nước cụ thể là ở Đông Bắc Á, Đông Nam Á, Ấn Độ, Châu Phi và Mĩ Latinh trong những năm 1945 đến 2000", 3, false, null, null, "Các nước Á, Phi, Mỹ Latinh (1945 – 2000)", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("c2b93d0f-1032-45c9-94bf-a53e2c5aa3be"), null, "Khái niệm, nội dung, ý nghĩa của các quyền tự do cơ bản của công dân: Quyền bất khả xâm phạm về thân thể. Quyền được pháp luật bảo hộ về tính mạng, sức khỏe, danh dự và nhân phẩm cũng như quyền bất khả xâm phạm về chỗ ở. Quyền bảo đảm an toàn và bí mật thư tín, điện thoại, điện tín và quyền tự do ngôn luận.", 6, false, null, null, "Công dân với các quyền tự do cơ bản", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("c444dd00-cde1-43b3-9761-ea0eca9553e9"), null, "Khái niệm và các đặc điểm của quần thể sinh vật", 8, false, null, null, "Cá thể và quần thể sinh vật", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("c484c892-8a60-4056-b0b4-223a4d382529"), null, "Giới thiệu khái quát về con dường hội nhập và phát triển của Việt Nam", 1, false, null, null, "Địa lý Việt Nam", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("c5470d64-b50b-447c-8d89-fc5b9bf338d3"), null, "Nghiên cứu các kiến thức về sự hình thành trật tự thế giới mới sau chiến tranh thể giới thứ hai từ năm 1945 đến 1949, qua đó, nắm được nguyên nhân hình thành trật tự thế giới mới mà đứng đầu là 3 cường quốc Anh, Mĩ và Liên Xô, cũng như sự ra đời của Liên hợp Quốc và sự phân chia thế giới thành hai phe đối lập.", 1, false, null, null, "Sự hình thành trật tự thế giới mới sau chiến tranh thế giới thứ hai (1945 – 1949)", new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de") },
                    { new Guid("cb01694c-ebac-478c-bbef-6845d723e501"), null, "Đại cương về polime, vật liệu polime, luyện tập Polime và vật liệu polime, thực hành Một số tính chất của protein và vật liệu polime", 4, false, null, null, "Polime Và Vật Liệu Polime", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("d1e7ee41-195a-462f-906a-c8b867371e4d"), null, " Dao động điều hòa, khái niệm về con lắc lò xo và con lắc đơn, dao động tắt dần và dao động cưỡng bức, sau cùng tổng hợp hai dao động điều hòa cùng phương, cùng tần số và Phương pháp Fre-Nen", 1, false, null, null, "Dao động cơ", new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4") },
                    { new Guid("db827133-7fbb-4b8e-bcdd-7f769e849505"), null, "Vị trí của kim loại trong bảng tuần hòa, sau đó là biết được tính chất của kim loại và dãy điện hóa, hợp kim, sự ăn mòn kim loại, điều chế kim loại, luyện tập tính chất của kim loại, luyện tập Điều chế kim loại và sự ăn mòn kim loại, thực hành Tính chất, điều chế kim loại, sự ăn mòn kim loại", 5, false, null, null, "Đại Cương Về Kim Loại", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("dd4944ee-e8c4-47dc-b864-afe597d047b3"), null, "Hóa học và vấn đề phát triển kinh tế, hóa học và vấn đề xã hội và sau cùng là hóa học và vấn đề môi trường", 9, false, null, null, "Hóa Học Và Vấn Đề Phát Triển Kinh Tế, Xã Hội, Môi Trường", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("dd4d8c18-5a33-4a61-a34b-e2cd10226ec8"), null, " Amin, sau đó đến Amino axit sau cùng là peptit và protein", 3, false, null, null, "Amin, Amino Axit Và Protein", new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8") },
                    { new Guid("de780968-915f-418e-845d-84c5810b5c92"), null, "", 15, false, null, null, "Women In Society - Người phụ nữ trong xã hội ", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("e83b8918-df70-4d49-8ddc-adcdac56a057"), null, "Tìm hiểu như thế nào là tọa độ trong không gian, sau đó sẽ được làm quen đến phương trình mặt phẳng và cuối cùng là sự kết hợp để tìm phương trình đường thẳng trong không gian.", 7, false, null, null, "Phương pháp toạ độ trong không gian", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("e992f53a-b7b0-4a1e-9b81-36ed3328c6e1"), null, "Nội dung về ngành thương mại du lịch và ngành giao thông vận tải", 9, false, null, null, "Một Số Vấn Đề Phát Triển Và Phân Bố Các Ngành Dịch Vụ", new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7") },
                    { new Guid("f0a45c6c-be92-4c73-829e-907591c7694a"), null, "sự di truyền của các tính trạng qua các thế hệ của loài diễn ra theo những xu thế tất yếu mà người ta đã phát hiện được bằng phương pháp thực nghiệm", 2, false, null, null, "Tính quy luật của hiện tượng di truyền", new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502") },
                    { new Guid("f6b3d23f-e2d4-4cc9-8cea-2d942f2e9092"), null, "", 8, false, null, null, "Life in the future - Cuộc sống trong tương lai", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") },
                    { new Guid("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e"), null, "Lũy thừa, hàm số lũy thừa, Lôgarit tiếp theo đó là hàm số mũ hàm số lôgarit, Phương trình mũ và phương trình lôgarit, cuối cùng là bất phương trình mũ và bất phương trình lôgarit", 2, false, null, null, "Hàm số lũy thừa, hàm số mũ và hàm số lôgarit", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("fa93b3f0-ed5f-4b84-af34-6cc4f5b3831c"), null, "Đề cập cụ thể tới quyền bình đẳng của công dân trong hôn nhân và gia đình, trong lao động và trong kinh doanh", 4, false, null, null, "Quyền bình đẳng của công dân trong một số lĩnh vực của đời sống xã hội", new Guid("00940497-7f82-493d-aac3-a56e9e92f390") },
                    { new Guid("fd5ee68e-5647-41ad-9ff1-2d98edd4aea2"), null, "", 14, false, null, null, "International Organizations - Những tổ chức quốc tế", new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c") }
                });

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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "IsDeleted", "ModifiedBy", "ModifiedDate", "TopicId" },
                values: new object[,]
                {
                    { new Guid("02f6bdd7-aca1-41c8-a7d1-07843aff2d10"), "{\"Question\":\"Trong th\\u00ED nghi\\u1EC7m Y\\u00E2ng v\\u1EC1 giao thoa c\\u1EE7a \\u00E1nh s\\u00E1ng \\u0111\\u01A1n s\\u1EAFc, hai khe h\\u1EB9p c\\u00E1ch nhau 1 mm, m\\u1EB7t ph\\u1EB3ng ch\\u1EE9a hai khe c\\u00E1ch m\\u00E0n quan s\\u00E1t 1,5 m. Kho\\u1EA3ng c\\u00E1ch gi\\u1EEFa 5 v\\u00E2n s\\u00E1ng li\\u00EAn ti\\u1EBFp l\\u00E0 3,6 mm. B\\u01B0\\u1EDBc s\\u00F3ng c\\u1EE7a \\u00E1nh s\\u00E1ng d\\u00F9ng trong th\\u00ED nghi\\u1EC7m n\\u00E0y b\\u1EB1ng:\",\"ListAnswer\":[{\"Value\":\"0,48 \\u00B5m.\",\"IsAnswer\":false},{\"Value\":\"0,40 \\u00B5m.\",\"IsAnswer\":false},{\"Value\":\"0,60 \\u00B5m\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("5a1a8691-497c-4ac4-b764-64b0984a7c49") },
                    { new Guid("19582b83-700e-43f7-9867-d86c71153b4b"), "{\"Question\":\"S\\u00F3ng \\u0111i\\u1EC7n t\\u1EEB c\\u00F3 t\\u1EA7n s\\u1ED1 f = 300 MHz thu\\u1ED9c lo\\u1EA1i\",\"ListAnswer\":[{\"Value\":\"s\\u00F3ng trung\",\"IsAnswer\":false},{\"Value\":\" s\\u00F3ng d\\u00E0i\",\"IsAnswer\":false},{\"Value\":\"s\\u00F3ng c\\u1EF1c ng\\u1EAFn\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("6fc99327-e8b8-42ad-b3f0-641c2f81027d") },
                    { new Guid("551e3712-3de1-402a-8df9-a35db36011d4"), "{\"Question\":\"M\\u1ED9t v\\u1EADt dao \\u0111\\u1ED9ng \\u0111i\\u1EC1u ho\\u00E0 v\\u1EDBi chu k\\u00EC T, bi\\u00EAn \\u0111\\u1ED9 b\\u1EB1ng 5 cm. Qu\\u00E3ng \\u0111\\u01B0\\u1EDDng v\\u1EADt \\u0111i \\u0111\\u01B0\\u1EE3c trong 2,5T l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"50 cm\",\"IsAnswer\":true},{\"Value\":\"45 cm\",\"IsAnswer\":false},{\"Value\":\"25 cm\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("d1e7ee41-195a-462f-906a-c8b867371e4d") },
                    { new Guid("8e7bbeff-72b3-4010-a716-9b31d5d20186"), "{\"Question\":\"Ph\\u00F3ng x\\u1EA1 l\\u00E0\",\"ListAnswer\":[{\"Value\":\"qu\\u00E1 tr\\u00ECnh h\\u1EA1t nh\\u00E2n nguy\\u00EAn t\\u1EED ph\\u00E1t c\\u00E1c tia kh\\u00F4ng nh\\u00ECn th\\u1EA5y\",\"IsAnswer\":false},{\"Value\":\"qu\\u00E1 tr\\u00ECnh ph\\u00E2n r\\u00E3 t\\u1EF1 ph\\u00E1t c\\u1EE7a m\\u1ED9t h\\u1EA1t nh\\u00E2n kh\\u00F4ng b\\u1EC1n v\\u1EEFng\",\"IsAnswer\":true},{\"Value\":\"qu\\u00E1 tr\\u00ECnh h\\u1EA1t nh\\u00E2n nguy\\u00EAn t\\u1EED n\\u1EB7ng b\\u1ECB ph\\u00E1 v\\u1EE1 th\\u00E0nh c\\u00E1c h\\u1EA1t nh\\u00E2n nh\\u1ECF h\\u01A1n.\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("ba088c8b-890e-4743-9a45-d49066c780a6") },
                    { new Guid("9d76c22d-553c-4fe3-ba6b-6c7b38b1e7a5"), "{\"Question\":\"Khi n\\u00F3i v\\u1EC1 dao \\u0111\\u1ED9ng c\\u01B0\\u1EE1ng b\\u1EE9c v\\u00E0 dao \\u0111\\u1ED9ng duy tr\\u00EC, ph\\u00E1t bi\\u1EC3u n\\u00E0o sau \\u0111\\u00E2y l\\u00E0 sai?\",\"ListAnswer\":[{\"Value\":\"Dao \\u0111\\u1ED9ng duy tr\\u00EC c\\u00F3 t\\u1EA7n s\\u1ED1 b\\u1EB1ng t\\u1EA7n s\\u1ED1 ri\\u00EAng c\\u1EE7a h\\u1EC7 dao \\u0111\\u1ED9ng.\",\"IsAnswer\":false},{\"Value\":\"Dao \\u0111\\u1ED9ng duy tr\\u00EC c\\u00F3 bi\\u00EAn \\u0111\\u1ED9 kh\\u00F4ng \\u0111\\u1ED5i.\",\"IsAnswer\":false},{\"Value\":\"Bi\\u00EAn \\u0111\\u1ED9 c\\u1EE7a dao \\u0111\\u1ED9ng c\\u01B0\\u1EE1ng b\\u1EE9c l\\u00E0 bi\\u00EAn \\u0111\\u1ED9 c\\u1EE7a l\\u1EF1c c\\u01B0\\u1EE1ng b\\u1EE9c.\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("d1e7ee41-195a-462f-906a-c8b867371e4d") },
                    { new Guid("a0752c7e-ac76-4a9c-82e4-92ddb89033b0"), "{\"Question\":\"S\\u1ED1 ch\\u1EC9 c\\u1EE7a ampe k\\u1EBF khi m\\u1EAFc n\\u1ED1i ti\\u1EBFp v\\u00E0o \\u0111o\\u1EA1n m\\u1EA1ch \\u0111i\\u1EC7n xoay chi\\u1EC1u cho ta bi\\u1EBFt gi\\u00E1 tr\\u1ECB c\\u01B0\\u1EDDng \\u0111\\u1ED9 d\\u00F2ng \\u0111i\\u1EC7n\",\"ListAnswer\":[{\"Value\":\"c\\u1EF1c \\u0111\\u1EA1i\",\"IsAnswer\":false},{\"Value\":\"hi\\u1EC7u d\\u1EE5ng\",\"IsAnswer\":true},{\"Value\":\"t\\u1EE9c th\\u1EDDi\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("79d76295-efe3-4f84-a831-5ca9913b7ab6") },
                    { new Guid("b423d3b0-ebc5-4164-ba8a-458e14f089c5"), "{\"Question\":\"Ng\\u01B0\\u1EDDi ta t\\u1EA1o s\\u00F3ng d\\u1EEBng tr\\u00EAn m\\u1ED9t s\\u1EE3i d\\u00E2y c\\u0103ng gi\\u1EEFa 2 \\u0111i\\u1EC3m c\\u1ED1 \\u0111\\u1ECBnh. Hai t\\u1EA7n s\\u1ED1 g\\u1EA7n nhau nh\\u1EA5t c\\u00F9ng t\\u1EA1o ra s\\u00F3ng d\\u1EEBng tr\\u00EAn d\\u00E2y l\\u00E0 525 Hz v\\u00E0 600 Hz. T\\u1EA7n s\\u1ED1 nh\\u1ECF nh\\u1EA5t t\\u1EA1o ra s\\u00F3ng d\\u1EEBng tr\\u00EAn d\\u00E2y \\u0111\\u00F3 l\\u00E0:\",\"ListAnswer\":[{\"Value\":\"75 Hz\",\"IsAnswer\":true},{\"Value\":\"125 Hz\",\"IsAnswer\":false},{\"Value\":\"100 Hz\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("17ba34ec-7b7c-47ce-9491-6a28d8f0f497") },
                    { new Guid("d9bde32b-01a3-409b-9991-de7f471add13"), "{\"Question\":\"Khi c\\u00F3 s\\u00F3ng d\\u1EEBng tr\\u00EAn d\\u00E2y kho\\u1EA3ng c\\u00E1ch gi\\u1EEFa hai n\\u00FAt s\\u00F3ng li\\u00EAn ti\\u1EBFp l\\u00E0\",\"ListAnswer\":[{\"Value\":\"m\\u1ED9t b\\u01B0\\u1EDBc s\\u00F3ng\",\"IsAnswer\":false},{\"Value\":\"m\\u1ED9t n\\u1EEDa b\\u01B0\\u1EDBc s\\u00F3ng\",\"IsAnswer\":true},{\"Value\":\"m\\u1ED9t ph\\u1EA7n t\\u01B0 b\\u01B0\\u1EDBc s\\u00F3ng\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("17ba34ec-7b7c-47ce-9491-6a28d8f0f497") },
                    { new Guid("f381da01-ca48-41b6-842d-6b9ff7e8deec"), "{\"Question\":\"Hai dao \\u0111\\u1ED9ng \\u0111i\\u1EC1u h\\u00F2a c\\u00F9ng ph\\u01B0\\u01A1ng, c\\u00F9ng t\\u1EA7n s\\u1ED1 c\\u00F3 bi\\u00EAn \\u0111\\u1ED9 l\\u1EA7n l\\u01B0\\u1EE3t l\\u00E0 A1 = 8 cm; A2 = 15 cm v\\u00E0 l\\u1EC7ch pha nhau 0,5\\u03C0. Dao \\u0111\\u1ED9ng t\\u1ED5ng h\\u1EE3p c\\u1EE7a hai dao \\u0111\\u1ED9ng n\\u00E0y c\\u00F3 bi\\u00EAn \\u0111\\u1ED9 b\\u1EB1ng:\",\"ListAnswer\":[{\"Value\":\"7cm\",\"IsAnswer\":false},{\"Value\":\"17cm\",\"IsAnswer\":true},{\"Value\":\"11cm\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("d1e7ee41-195a-462f-906a-c8b867371e4d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("02f6bdd7-aca1-41c8-a7d1-07843aff2d10"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("19582b83-700e-43f7-9867-d86c71153b4b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("551e3712-3de1-402a-8df9-a35db36011d4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8e7bbeff-72b3-4010-a716-9b31d5d20186"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9d76c22d-553c-4fe3-ba6b-6c7b38b1e7a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a0752c7e-ac76-4a9c-82e4-92ddb89033b0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b423d3b0-ebc5-4164-ba8a-458e14f089c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9bde32b-01a3-409b-9991-de7f471add13"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f381da01-ca48-41b6-842d-6b9ff7e8deec"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("020841e0-c4da-4010-9556-e67ad0b7d816"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("03699ee1-aa9b-4695-8593-8112a5b7145f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0546ebd3-376e-4246-bdb3-9ae20e6f253c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0bca65ca-2ce4-4923-a507-43e381130c9f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0c83b2dc-372d-4687-8a51-c35b5e51c991"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0faf3a0d-3e02-41f1-890c-51610de8e8cb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("111aa302-4022-42e7-bf44-5546d2212240"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("111d9344-66dd-4653-8cff-96bb9bc3863a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1133b9a3-b5c1-4470-982a-22a5b5391d15"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1649f0c1-8557-4c2a-99a8-b4ffde8e7bbe"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("179ea3f8-4ed8-4151-b360-7dbe9f033e0c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("20dd53da-8d28-4f31-b2d6-7e722fbf1aea"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("28bbe836-de18-4d85-9555-a47d95f85a5f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("29322677-3508-4e9f-956d-38219393afe8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2addcd1a-4f32-42dc-bf9f-637fd7769c3c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("33fcdca5-2b11-49cf-8824-f91d45c86dd2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3501833e-e73b-4f30-8c73-36287d864c4b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("35399c19-5f66-4dfd-bdb7-f4744f6749aa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("356135ae-0bc9-4560-af03-191995168919"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("370bb392-410b-46b5-9971-2df9a53e7670"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3f3502cf-68cb-4f91-846e-d8819dca38fd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("451fa872-1960-4c03-a3df-374dbfc81c83"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("45b651e7-9e76-42d0-b996-aeb00ec00d3f"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("468f1e58-d93b-46db-b4df-4a173513befb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("470c4063-38b5-437c-9820-2a29a470c708"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4881c89c-4995-4833-a00c-90bac688b8c4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("49d712a6-e7ca-4252-a430-308f954047ff"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4bf74338-43a1-495c-ba6a-8d4b4aa431ab"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4f830591-4a73-4976-9a63-dcebb53ca4c2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5054a03a-17d9-4ba1-b33c-fef16aa2ffc0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("533446a5-2f4c-4618-a441-f02bad78e322"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("55469d88-1e76-4678-ad62-e3d233602dfa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("56057547-6172-4967-a8c3-e8e9afc494ac"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("596c886d-ae82-4b7e-9d88-7f185f57778e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5b019dee-3d51-4b0c-af72-bc6b48d51a32"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("64722757-eb15-4891-abbc-bd870caae9f1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("670f0b14-435e-413f-ac27-7271ed1b87bb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6880b25a-40ec-410e-b332-e6616982e206"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7294fa9f-78c5-49f3-a9fa-c99feb6d6a5c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("72c5c4ca-e8f8-4b02-97cd-4666ab7ccd44"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("74d64b16-20e1-4f3c-9f54-facf73dd9740"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7612387b-bd34-4ff2-bc52-535d32fe45ec"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("77963fa2-2bc8-4273-929b-835f0efd31f6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7b39b159-82aa-48a9-9dd1-6d0b435f50be"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("838f30bd-d9cf-4ea6-8825-fe729c55e5af"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("86f6ce80-f585-47d8-b3f0-c2f1d6cd084a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("879bd2f5-8e49-4b94-b4cc-ed86c1f4b0da"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("898a8245-bff3-4cbb-9ac4-8692cc84d2e1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9207680f-4c5e-4725-aec7-85d64102b0e9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9654577c-a684-4ec7-ac30-fd49386482a7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9a4f72df-ee78-4455-8b67-76b3a26ce507"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a54bae14-3251-48aa-b210-0c32b3b46a13"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a9902cb8-b044-4e0e-8e22-9ec0337dea6b"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("adda106e-b8ba-4bfb-bdea-e2fcd916137c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b2a7a480-c0e9-424a-a3cf-e35ed4f7e794"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b4f8ba38-e4f6-4fa9-a49a-18e74322e133"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b80adb23-18d3-4b5e-9fc0-2fa25d47dd49"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bffb16de-cbfc-4a26-8e27-370225aa09aa"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c20ee29b-c548-4a55-9f5c-2c78113b445e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c2b93d0f-1032-45c9-94bf-a53e2c5aa3be"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c444dd00-cde1-43b3-9761-ea0eca9553e9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c484c892-8a60-4056-b0b4-223a4d382529"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("c5470d64-b50b-447c-8d89-fc5b9bf338d3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cb01694c-ebac-478c-bbef-6845d723e501"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("db827133-7fbb-4b8e-bcdd-7f769e849505"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dd4944ee-e8c4-47dc-b864-afe597d047b3"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("dd4d8c18-5a33-4a61-a34b-e2cd10226ec8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("de780968-915f-418e-845d-84c5810b5c92"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e83b8918-df70-4d49-8ddc-adcdac56a057"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e992f53a-b7b0-4a1e-9b81-36ed3328c6e1"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f0a45c6c-be92-4c73-829e-907591c7694a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f6b3d23f-e2d4-4cc9-8cea-2d942f2e9092"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fa93b3f0-ed5f-4b84-af34-6cc4f5b3831c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fd5ee68e-5647-41ad-9ff1-2d98edd4aea2"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5a1a8691-497c-4ac4-b764-64b0984a7c49"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("6fc99327-e8b8-42ad-b3f0-641c2f81027d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("79d76295-efe3-4f84-a831-5ca9913b7ab6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("ba088c8b-890e-4743-9a45-d49066c780a6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("d1e7ee41-195a-462f-906a-c8b867371e4d"));

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 29, 15, 4, 12, 870, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 11, 30, 15, 4, 12, 870, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                column: "Name",
                value: "Anh Văn");

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { new Guid("50051095-391a-4abf-94f2-ac3cf912f07b"), null, null, false, null, null, "Mỹ Thuật" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedBy", "Description", "Index", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("25b3ba1e-240a-4a3c-96b6-c0816b0a3975"), null, "Toan hinh", 2, false, null, null, "toan hinh", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("f722c143-412c-4721-bf5c-5b32a01d90da"), null, "toan dai cuong", 1, false, null, null, "toan dai cuong", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 232, 163, 226, 156, 238, 132, 243, 239, 156, 178, 197, 79, 217, 8, 54, 150, 81, 180, 192, 102, 27, 137, 202, 36, 147, 186, 89, 168, 250, 166, 232, 22, 21, 157, 40, 151, 11, 168, 149, 89, 185, 163, 77, 60, 80, 122, 250, 120, 111, 144, 73, 166, 75, 149, 19, 43, 22, 47, 193, 120, 87, 82, 122 }, new byte[] { 251, 126, 184, 215, 13, 148, 146, 16, 99, 91, 23, 58, 134, 213, 235, 114, 24, 148, 146, 181, 7, 194, 199, 3, 152, 49, 120, 31, 87, 179, 205, 151, 96, 61, 111, 238, 101, 211, 107, 89, 162, 224, 31, 185, 209, 179, 10, 51, 142, 30, 146, 86, 240, 17, 179, 72, 230, 137, 177, 250, 208, 145, 139, 227, 27, 72, 181, 190, 87, 196, 194, 162, 10, 153, 71, 88, 196, 46, 228, 126, 0, 198, 122, 147, 203, 189, 13, 83, 40, 242, 28, 92, 93, 244, 106, 233, 98, 73, 122, 147, 194, 249, 220, 250, 215, 97, 25, 112, 161, 47, 151, 31, 113, 137, 182, 97, 4, 31, 121, 199, 112, 243, 96, 18, 188, 202, 53, 47 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 7, 40, 19, 84, 24, 49, 155, 126, 216, 85, 17, 217, 116, 68, 44, 164, 150, 25, 102, 123, 102, 77, 56, 244, 107, 252, 32, 218, 33, 233, 249, 221, 186, 151, 55, 17, 107, 98, 180, 203, 171, 167, 73, 144, 215, 72, 50, 113, 114, 92, 218, 198, 93, 66, 97, 43, 157, 211, 146, 210, 127, 84, 141 }, new byte[] { 213, 187, 59, 67, 177, 252, 96, 35, 45, 251, 195, 21, 90, 24, 39, 92, 206, 41, 66, 14, 175, 222, 67, 27, 183, 24, 177, 220, 4, 190, 62, 29, 232, 8, 83, 141, 158, 200, 142, 53, 8, 251, 65, 194, 102, 157, 16, 15, 133, 158, 182, 32, 71, 41, 104, 193, 136, 33, 215, 68, 214, 128, 78, 228, 144, 238, 68, 146, 117, 208, 54, 190, 91, 54, 55, 157, 252, 0, 115, 73, 65, 98, 31, 12, 254, 171, 164, 211, 165, 176, 253, 69, 240, 156, 134, 97, 250, 117, 12, 153, 26, 3, 203, 185, 99, 23, 252, 49, 179, 255, 135, 211, 240, 152, 40, 219, 241, 98, 47, 83, 72, 184, 99, 175, 152, 173, 228, 171 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 162, 217, 221, 40, 109, 183, 136, 25, 250, 16, 188, 17, 40, 155, 128, 93, 255, 157, 150, 108, 232, 152, 244, 171, 182, 102, 182, 210, 8, 67, 231, 13, 207, 178, 197, 35, 195, 47, 91, 98, 68, 107, 55, 16, 103, 92, 11, 161, 27, 46, 64, 83, 179, 242, 199, 255, 220, 141, 216, 98, 75, 211, 60 }, new byte[] { 99, 164, 49, 216, 104, 166, 248, 65, 7, 17, 115, 246, 95, 187, 239, 217, 157, 222, 220, 170, 141, 243, 106, 177, 194, 213, 123, 161, 83, 167, 52, 70, 6, 52, 195, 231, 35, 104, 175, 78, 217, 28, 84, 118, 168, 11, 6, 44, 29, 199, 126, 215, 76, 85, 199, 235, 218, 144, 183, 166, 1, 209, 177, 75, 202, 68, 30, 168, 210, 68, 29, 189, 98, 254, 194, 130, 130, 26, 116, 37, 101, 205, 29, 172, 30, 183, 123, 252, 132, 250, 193, 147, 75, 247, 188, 71, 93, 89, 226, 182, 21, 72, 114, 96, 246, 48, 176, 124, 255, 219, 209, 226, 180, 253, 225, 45, 72, 103, 65, 25, 196, 213, 37, 56, 231, 217, 159, 120 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 233, 143, 201, 4, 118, 234, 166, 213, 204, 4, 14, 173, 185, 25, 29, 219, 86, 9, 93, 50, 110, 24, 185, 186, 188, 186, 225, 142, 49, 100, 191, 130, 131, 97, 135, 254, 165, 250, 144, 16, 105, 151, 47, 76, 3, 176, 168, 248, 85, 163, 145, 206, 165, 221, 84, 147, 44, 106, 216, 222, 171, 78, 67 }, new byte[] { 230, 201, 246, 26, 11, 227, 151, 121, 39, 203, 13, 115, 188, 117, 83, 248, 9, 224, 255, 194, 129, 170, 163, 253, 118, 39, 210, 191, 140, 26, 234, 26, 103, 210, 76, 25, 116, 201, 197, 188, 30, 67, 100, 5, 214, 128, 54, 25, 97, 226, 255, 20, 137, 109, 172, 49, 45, 159, 251, 1, 166, 232, 189, 219, 103, 157, 149, 103, 182, 52, 248, 179, 161, 220, 23, 50, 11, 114, 11, 131, 30, 147, 52, 176, 88, 232, 63, 64, 245, 79, 109, 150, 173, 47, 2, 245, 33, 233, 128, 38, 4, 61, 161, 231, 103, 27, 104, 92, 144, 128, 72, 157, 134, 29, 19, 251, 246, 42, 116, 226, 53, 213, 231, 134, 146, 161, 161, 20 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 218, 243, 194, 208, 90, 71, 251, 227, 83, 221, 41, 198, 254, 125, 172, 9, 187, 255, 121, 183, 175, 73, 243, 134, 27, 3, 144, 203, 221, 214, 134, 36, 15, 149, 182, 85, 110, 252, 104, 61, 201, 64, 200, 169, 155, 234, 66, 88, 99, 87, 255, 207, 98, 199, 12, 112, 95, 186, 121, 188, 155, 70, 183 }, new byte[] { 131, 130, 45, 38, 214, 195, 141, 30, 124, 164, 22, 99, 200, 177, 28, 121, 142, 150, 255, 106, 117, 111, 135, 50, 136, 167, 26, 53, 58, 222, 178, 74, 132, 105, 16, 62, 155, 187, 10, 206, 241, 48, 22, 44, 149, 190, 215, 189, 194, 200, 11, 61, 45, 16, 152, 242, 99, 141, 28, 245, 18, 78, 253, 94, 160, 252, 131, 152, 152, 107, 105, 174, 24, 211, 7, 228, 191, 129, 183, 185, 10, 23, 21, 128, 57, 132, 110, 220, 135, 212, 76, 172, 167, 9, 58, 191, 24, 202, 118, 198, 99, 122, 134, 235, 163, 23, 172, 246, 27, 231, 224, 182, 32, 86, 228, 119, 86, 16, 233, 24, 144, 54, 64, 21, 42, 26, 242, 15 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("324ed66e-e8de-4710-a139-18c50b442945"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 25, 167, 34, 223, 22, 208, 185, 108, 40, 59, 189, 112, 235, 2, 46, 49, 195, 229, 233, 11, 178, 247, 107, 65, 214, 250, 30, 85, 8, 247, 6, 2, 77, 246, 53, 206, 130, 196, 30, 191, 41, 216, 130, 53, 22, 99, 138, 243, 12, 74, 108, 173, 203, 0, 2, 91, 50, 40, 192, 198, 41, 71, 54 }, new byte[] { 164, 204, 49, 12, 234, 106, 238, 145, 228, 189, 231, 188, 4, 188, 51, 12, 164, 39, 70, 148, 36, 167, 110, 250, 89, 164, 21, 228, 14, 253, 110, 150, 80, 37, 112, 168, 195, 92, 98, 102, 183, 78, 26, 10, 112, 86, 154, 226, 76, 245, 201, 32, 101, 228, 231, 226, 127, 211, 240, 59, 152, 188, 150, 163, 7, 31, 100, 5, 176, 100, 237, 34, 7, 239, 29, 250, 79, 193, 129, 177, 121, 41, 52, 254, 144, 231, 190, 113, 213, 119, 99, 71, 19, 30, 74, 174, 97, 145, 180, 218, 210, 184, 61, 29, 226, 128, 251, 90, 65, 156, 132, 99, 113, 231, 118, 15, 115, 24, 212, 95, 144, 100, 19, 116, 65, 1, 76, 144 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 58, 83, 14, 163, 223, 172, 63, 110, 3, 243, 30, 61, 107, 230, 183, 157, 188, 251, 118, 228, 64, 218, 226, 8, 30, 73, 152, 34, 156, 135, 219, 88, 141, 54, 194, 15, 80, 182, 186, 235, 217, 7, 59, 226, 26, 253, 140, 15, 155, 84, 161, 223, 219, 78, 53, 132, 71, 19, 41, 158, 67, 183, 171, 151 }, new byte[] { 86, 86, 68, 206, 49, 40, 169, 88, 156, 200, 122, 111, 145, 26, 70, 39, 67, 137, 16, 69, 37, 147, 191, 26, 140, 103, 158, 218, 46, 196, 230, 125, 66, 18, 214, 112, 53, 62, 228, 243, 6, 1, 97, 24, 11, 48, 245, 131, 255, 205, 140, 122, 184, 181, 167, 139, 198, 255, 53, 216, 108, 197, 44, 92, 94, 54, 54, 29, 43, 201, 144, 114, 79, 245, 67, 244, 76, 22, 134, 244, 228, 244, 245, 235, 196, 54, 109, 193, 45, 138, 102, 7, 128, 167, 123, 217, 47, 142, 154, 201, 226, 55, 30, 157, 72, 144, 179, 222, 56, 43, 176, 145, 207, 37, 157, 66, 254, 107, 103, 43, 65, 241, 172, 185, 39, 109, 173, 253 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 228, 170, 103, 115, 27, 135, 148, 239, 87, 109, 127, 211, 246, 19, 60, 230, 234, 72, 255, 213, 12, 52, 122, 131, 91, 39, 18, 100, 19, 186, 68, 52, 80, 219, 1, 213, 179, 197, 106, 88, 43, 219, 17, 159, 12, 163, 110, 28, 87, 177, 59, 14, 204, 162, 179, 40, 64, 105, 192, 107, 87, 205, 206, 78 }, new byte[] { 207, 22, 201, 136, 85, 24, 64, 125, 213, 191, 216, 24, 39, 113, 204, 39, 133, 100, 218, 23, 125, 67, 3, 138, 45, 11, 227, 223, 110, 176, 4, 201, 58, 33, 157, 232, 114, 46, 97, 90, 186, 31, 131, 96, 227, 168, 198, 153, 140, 57, 110, 157, 233, 41, 78, 159, 6, 133, 191, 112, 116, 2, 139, 157, 190, 144, 89, 94, 209, 217, 143, 252, 69, 228, 125, 96, 165, 197, 249, 118, 232, 11, 187, 15, 74, 230, 38, 248, 249, 126, 194, 88, 169, 112, 151, 139, 54, 93, 66, 91, 219, 95, 138, 24, 214, 74, 212, 136, 83, 173, 173, 242, 147, 65, 232, 34, 157, 38, 14, 134, 150, 178, 23, 31, 171, 246, 226, 63 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 45, 214, 69, 73, 253, 35, 31, 102, 144, 204, 52, 142, 253, 29, 16, 102, 55, 160, 94, 247, 10, 147, 245, 12, 69, 252, 114, 214, 32, 165, 3, 36, 53, 153, 176, 142, 191, 5, 12, 47, 76, 129, 32, 235, 234, 241, 59, 82, 135, 167, 255, 228, 11, 141, 10, 45, 230, 103, 174, 91, 173, 203, 186 }, new byte[] { 23, 177, 15, 8, 189, 234, 108, 183, 112, 210, 136, 22, 0, 55, 114, 81, 121, 77, 247, 117, 169, 166, 105, 152, 68, 136, 228, 53, 132, 189, 146, 61, 101, 115, 189, 4, 105, 5, 169, 126, 91, 154, 216, 127, 198, 57, 203, 126, 204, 228, 213, 22, 30, 159, 203, 212, 32, 158, 243, 171, 25, 227, 167, 8, 241, 10, 203, 219, 11, 7, 95, 220, 252, 135, 254, 106, 45, 74, 88, 195, 155, 147, 206, 212, 106, 181, 29, 122, 145, 69, 239, 64, 131, 98, 106, 199, 169, 189, 141, 183, 118, 110, 116, 219, 30, 87, 0, 171, 145, 18, 6, 140, 51, 194, 205, 117, 180, 141, 250, 129, 222, 99, 142, 4, 100, 229, 183, 64 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666bc14a-4078-4619-85f1-bc63033c556f"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 124, 86, 141, 232, 193, 146, 201, 194, 34, 56, 61, 150, 162, 21, 186, 1, 220, 58, 89, 190, 81, 84, 189, 83, 205, 7, 83, 94, 254, 198, 250, 77, 205, 190, 104, 161, 171, 211, 66, 199, 33, 59, 143, 187, 156, 184, 181, 39, 190, 38, 103, 187, 114, 100, 188, 128, 75, 26, 243, 34, 139, 38, 98 }, new byte[] { 73, 95, 55, 75, 169, 220, 47, 172, 15, 175, 45, 99, 204, 38, 7, 216, 82, 197, 39, 67, 121, 40, 177, 69, 169, 43, 229, 139, 107, 13, 75, 120, 46, 255, 19, 15, 110, 2, 33, 254, 173, 53, 17, 128, 253, 135, 40, 187, 183, 31, 246, 8, 135, 118, 188, 166, 225, 253, 164, 198, 150, 100, 37, 125, 224, 53, 182, 46, 102, 69, 121, 244, 26, 12, 229, 80, 234, 185, 150, 65, 252, 245, 120, 108, 70, 209, 218, 67, 223, 76, 8, 241, 119, 175, 178, 230, 123, 4, 88, 167, 97, 20, 96, 214, 58, 126, 3, 17, 126, 217, 18, 22, 96, 159, 146, 214, 78, 31, 189, 61, 13, 67, 84, 33, 239, 76, 102, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 25, 45, 113, 145, 3, 239, 197, 135, 7, 61, 57, 223, 38, 116, 252, 95, 108, 108, 68, 173, 61, 158, 199, 221, 141, 25, 169, 19, 147, 116, 3, 165, 62, 68, 190, 196, 138, 193, 13, 184, 149, 81, 205, 200, 117, 51, 166, 196, 157, 89, 244, 249, 15, 136, 216, 126, 44, 3, 246, 190, 116, 162, 116 }, new byte[] { 177, 245, 248, 113, 55, 132, 121, 135, 77, 249, 41, 75, 26, 71, 110, 52, 69, 131, 205, 32, 121, 181, 103, 145, 25, 213, 161, 41, 12, 201, 240, 216, 231, 44, 117, 2, 235, 94, 206, 75, 15, 8, 197, 131, 121, 162, 33, 113, 147, 150, 183, 231, 93, 54, 186, 130, 196, 222, 91, 110, 10, 232, 233, 232, 176, 65, 15, 107, 4, 36, 94, 39, 11, 229, 124, 78, 192, 105, 37, 244, 111, 155, 229, 166, 102, 174, 25, 229, 107, 170, 49, 107, 198, 141, 111, 191, 170, 145, 157, 177, 108, 143, 47, 167, 22, 167, 114, 241, 52, 121, 113, 160, 225, 39, 190, 90, 187, 139, 255, 73, 235, 89, 120, 250, 129, 133, 210, 12 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 205, 195, 78, 130, 22, 40, 219, 96, 1, 196, 179, 147, 77, 48, 233, 212, 241, 208, 179, 121, 119, 106, 3, 175, 108, 101, 201, 251, 229, 48, 33, 65, 73, 198, 35, 12, 148, 90, 159, 186, 178, 222, 223, 153, 59, 224, 26, 10, 187, 106, 59, 199, 191, 255, 9, 212, 19, 246, 25, 116, 26, 145, 166, 145 }, new byte[] { 46, 82, 233, 128, 30, 99, 104, 30, 99, 13, 169, 93, 111, 60, 130, 208, 190, 156, 154, 203, 52, 127, 109, 71, 199, 103, 137, 137, 168, 132, 232, 240, 193, 237, 36, 30, 123, 24, 47, 106, 109, 172, 232, 10, 234, 45, 244, 37, 26, 200, 211, 4, 235, 229, 190, 172, 221, 9, 43, 217, 214, 109, 197, 125, 167, 0, 40, 208, 132, 155, 158, 186, 186, 131, 0, 21, 224, 169, 221, 199, 44, 35, 224, 71, 100, 100, 119, 111, 57, 172, 214, 95, 199, 251, 122, 207, 6, 50, 38, 171, 72, 21, 128, 175, 211, 220, 128, 2, 55, 226, 80, 27, 146, 245, 88, 6, 200, 78, 240, 120, 250, 16, 144, 242, 128, 19, 212, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f744e72-da12-4038-a54e-7512a0ada884"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 130, 151, 38, 164, 106, 255, 196, 174, 183, 42, 121, 220, 196, 1, 130, 172, 60, 64, 141, 226, 103, 141, 241, 113, 238, 131, 132, 201, 205, 181, 178, 78, 133, 15, 52, 210, 147, 252, 251, 156, 171, 77, 186, 206, 84, 59, 174, 115, 225, 249, 165, 11, 56, 50, 142, 39, 234, 103, 104, 161, 17, 141, 239 }, new byte[] { 142, 11, 93, 230, 114, 199, 113, 18, 244, 115, 0, 108, 251, 219, 193, 253, 89, 152, 208, 131, 176, 179, 1, 192, 143, 107, 226, 161, 167, 207, 10, 144, 16, 129, 226, 59, 141, 139, 241, 217, 28, 242, 2, 75, 97, 203, 230, 160, 137, 132, 144, 222, 60, 151, 86, 254, 142, 130, 151, 150, 1, 14, 231, 157, 59, 154, 35, 34, 82, 10, 47, 45, 42, 153, 197, 41, 173, 79, 126, 117, 128, 36, 178, 64, 42, 181, 36, 170, 43, 143, 140, 162, 172, 194, 103, 47, 65, 137, 100, 43, 88, 47, 167, 11, 168, 56, 227, 115, 190, 187, 82, 58, 3, 166, 221, 104, 223, 46, 247, 222, 141, 3, 228, 144, 203, 24, 5, 14 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e0097f-ce73-4950-8ee2-89b313581154"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 117, 236, 71, 136, 166, 172, 251, 144, 142, 85, 238, 214, 203, 91, 94, 185, 146, 9, 67, 143, 83, 90, 170, 137, 64, 211, 68, 100, 67, 66, 98, 233, 54, 173, 22, 83, 239, 156, 66, 31, 240, 237, 73, 249, 158, 82, 36, 122, 143, 196, 147, 172, 211, 47, 87, 121, 182, 232, 247, 28, 110, 81, 187 }, new byte[] { 28, 224, 203, 101, 60, 20, 112, 163, 224, 254, 36, 209, 146, 166, 162, 152, 127, 114, 101, 214, 94, 181, 197, 33, 171, 216, 117, 41, 210, 7, 145, 82, 239, 68, 239, 61, 179, 107, 251, 114, 3, 185, 204, 219, 83, 55, 228, 58, 56, 143, 24, 136, 157, 60, 108, 63, 214, 248, 206, 3, 238, 34, 109, 75, 218, 197, 234, 17, 208, 50, 159, 234, 156, 91, 218, 212, 181, 128, 140, 183, 84, 0, 229, 231, 154, 67, 155, 232, 156, 5, 83, 7, 0, 201, 81, 219, 154, 7, 23, 102, 156, 211, 146, 238, 101, 57, 85, 191, 42, 86, 144, 87, 118, 222, 213, 27, 51, 62, 42, 57, 126, 45, 40, 172, 10, 141, 182, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 19, 5, 71, 22, 36, 224, 165, 26, 175, 80, 113, 81, 127, 248, 46, 124, 54, 200, 123, 158, 61, 208, 22, 237, 136, 185, 18, 117, 25, 188, 63, 94, 7, 251, 46, 17, 183, 217, 189, 133, 192, 105, 22, 30, 218, 252, 57, 208, 167, 198, 37, 152, 220, 44, 5, 104, 34, 77, 107, 166, 70, 167, 181 }, new byte[] { 133, 224, 79, 220, 19, 11, 148, 218, 13, 102, 139, 39, 53, 199, 127, 251, 105, 25, 225, 108, 148, 91, 14, 4, 226, 26, 55, 198, 94, 242, 61, 103, 30, 227, 247, 39, 103, 115, 184, 160, 243, 108, 174, 201, 90, 54, 89, 159, 127, 37, 74, 217, 62, 10, 27, 14, 194, 112, 128, 14, 230, 71, 159, 181, 127, 23, 165, 170, 63, 177, 202, 52, 8, 169, 230, 31, 156, 155, 2, 146, 244, 112, 124, 132, 46, 62, 252, 36, 164, 216, 38, 254, 46, 250, 251, 176, 195, 244, 226, 230, 131, 66, 171, 22, 156, 229, 123, 93, 197, 198, 34, 111, 171, 118, 191, 53, 75, 221, 91, 243, 219, 177, 153, 49, 151, 255, 30, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 180, 66, 61, 83, 197, 81, 135, 240, 132, 230, 146, 87, 219, 217, 181, 40, 209, 210, 146, 36, 98, 188, 105, 109, 22, 221, 211, 221, 100, 68, 44, 53, 242, 221, 170, 158, 212, 190, 146, 218, 123, 222, 230, 99, 0, 57, 162, 104, 68, 152, 172, 102, 159, 199, 145, 189, 49, 182, 251, 125, 188, 254, 53, 8 }, new byte[] { 95, 132, 119, 189, 149, 149, 136, 153, 115, 59, 9, 184, 75, 214, 93, 19, 228, 212, 253, 106, 131, 170, 153, 61, 69, 206, 235, 124, 40, 189, 159, 248, 6, 224, 206, 155, 116, 154, 158, 206, 127, 93, 65, 49, 186, 42, 51, 142, 86, 204, 127, 254, 18, 172, 38, 227, 234, 236, 254, 42, 149, 5, 216, 17, 102, 55, 133, 130, 216, 254, 112, 210, 135, 131, 32, 144, 233, 42, 183, 39, 245, 66, 171, 93, 178, 45, 9, 208, 184, 67, 248, 239, 16, 182, 19, 69, 165, 110, 225, 30, 23, 53, 235, 184, 68, 46, 189, 82, 186, 35, 46, 70, 21, 215, 235, 167, 34, 205, 204, 42, 165, 164, 12, 148, 1, 207, 107, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 34, 169, 42, 136, 144, 245, 42, 63, 143, 47, 3, 205, 47, 96, 168, 28, 70, 66, 119, 217, 10, 104, 41, 55, 39, 142, 249, 176, 101, 155, 41, 239, 194, 235, 97, 6, 22, 209, 151, 10, 219, 116, 31, 164, 155, 219, 9, 172, 149, 1, 184, 183, 52, 0, 178, 217, 156, 134, 13, 96, 182, 92, 72 }, new byte[] { 157, 236, 252, 169, 253, 227, 224, 42, 13, 65, 194, 116, 161, 200, 112, 221, 82, 111, 61, 173, 129, 187, 181, 77, 200, 112, 220, 178, 30, 243, 58, 226, 79, 121, 104, 250, 118, 160, 111, 45, 137, 203, 74, 51, 28, 205, 202, 103, 100, 78, 218, 110, 4, 121, 91, 131, 158, 177, 64, 10, 176, 94, 42, 178, 89, 227, 39, 68, 152, 13, 140, 31, 19, 225, 191, 112, 177, 54, 149, 213, 81, 178, 179, 176, 171, 65, 159, 229, 112, 65, 207, 120, 219, 146, 144, 54, 205, 243, 193, 0, 29, 133, 128, 235, 152, 193, 157, 173, 42, 122, 155, 97, 104, 132, 104, 0, 247, 26, 14, 195, 206, 55, 70, 129, 215, 242, 207, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 11, 84, 151, 65, 22, 124, 247, 112, 2, 143, 91, 216, 214, 77, 98, 92, 51, 13, 192, 62, 54, 97, 234, 46, 250, 222, 169, 77, 52, 164, 100, 223, 170, 7, 212, 216, 24, 95, 86, 32, 191, 100, 135, 215, 150, 164, 178, 168, 97, 14, 204, 106, 242, 185, 203, 50, 138, 124, 14, 150, 86, 155, 59 }, new byte[] { 210, 249, 16, 159, 66, 12, 52, 122, 221, 69, 246, 13, 38, 73, 248, 227, 125, 24, 87, 246, 125, 40, 242, 8, 39, 1, 108, 56, 130, 198, 120, 88, 109, 32, 237, 184, 130, 68, 5, 125, 176, 179, 45, 236, 202, 247, 75, 162, 248, 255, 35, 4, 70, 195, 47, 103, 24, 118, 169, 158, 28, 122, 138, 87, 124, 80, 120, 78, 162, 17, 204, 170, 229, 42, 100, 82, 57, 248, 211, 181, 160, 2, 119, 207, 28, 107, 116, 23, 134, 196, 198, 25, 170, 129, 119, 35, 54, 172, 145, 231, 201, 250, 70, 178, 202, 221, 166, 235, 184, 140, 236, 60, 95, 186, 113, 14, 117, 158, 8, 111, 89, 243, 230, 32, 44, 100, 59, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 189, 110, 232, 7, 3, 67, 234, 240, 246, 41, 31, 160, 83, 158, 4, 115, 95, 207, 127, 128, 94, 1, 246, 192, 104, 214, 169, 3, 107, 95, 186, 165, 123, 240, 87, 62, 155, 50, 27, 129, 41, 241, 128, 29, 91, 185, 227, 118, 208, 176, 148, 131, 108, 160, 118, 151, 140, 211, 78, 7, 227, 147, 21, 30 }, new byte[] { 177, 212, 213, 40, 124, 59, 3, 235, 59, 153, 75, 78, 226, 250, 39, 149, 60, 160, 210, 206, 191, 191, 115, 136, 53, 164, 5, 133, 20, 139, 211, 93, 22, 202, 12, 27, 84, 237, 123, 190, 78, 125, 164, 193, 242, 235, 200, 18, 247, 132, 110, 164, 181, 50, 78, 76, 62, 105, 238, 60, 19, 19, 189, 244, 202, 70, 99, 224, 131, 108, 247, 33, 31, 78, 238, 212, 205, 203, 156, 166, 252, 137, 201, 186, 19, 117, 141, 232, 219, 60, 222, 166, 13, 227, 214, 182, 20, 194, 108, 7, 245, 30, 97, 7, 129, 163, 29, 75, 4, 44, 213, 203, 17, 234, 206, 191, 53, 100, 224, 5, 164, 9, 144, 239, 53, 98, 156, 121 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 240, 37, 240, 157, 168, 81, 152, 167, 11, 12, 230, 45, 192, 84, 203, 176, 232, 166, 232, 241, 28, 93, 8, 65, 226, 88, 41, 133, 54, 104, 19, 224, 114, 224, 14, 165, 129, 212, 73, 14, 199, 201, 87, 37, 10, 11, 147, 53, 16, 102, 203, 236, 13, 16, 137, 186, 223, 34, 202, 147, 1, 244, 181 }, new byte[] { 195, 66, 106, 194, 90, 168, 66, 44, 90, 254, 55, 145, 48, 152, 147, 253, 244, 154, 185, 200, 232, 49, 39, 251, 239, 81, 67, 117, 132, 186, 175, 65, 109, 140, 104, 98, 169, 7, 80, 21, 231, 28, 126, 207, 32, 252, 72, 175, 95, 146, 176, 38, 39, 217, 153, 121, 200, 15, 3, 114, 83, 230, 239, 60, 108, 44, 79, 121, 223, 210, 175, 45, 182, 15, 234, 151, 32, 161, 32, 79, 202, 57, 123, 157, 133, 188, 222, 251, 28, 253, 89, 150, 70, 102, 215, 138, 84, 17, 148, 250, 31, 71, 231, 72, 88, 178, 224, 171, 198, 65, 89, 108, 145, 21, 158, 153, 94, 237, 221, 147, 49, 101, 210, 210, 45, 244, 209, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 190, 228, 216, 181, 77, 165, 16, 16, 83, 112, 191, 75, 44, 40, 105, 28, 59, 174, 128, 16, 74, 150, 194, 55, 106, 176, 232, 82, 249, 110, 209, 234, 199, 15, 142, 201, 79, 101, 37, 56, 95, 87, 123, 59, 80, 203, 161, 33, 200, 146, 163, 49, 236, 252, 153, 71, 135, 131, 36, 147, 70, 228, 158 }, new byte[] { 49, 208, 175, 16, 178, 235, 74, 60, 200, 227, 13, 114, 243, 214, 138, 243, 57, 254, 135, 142, 130, 220, 139, 229, 3, 76, 51, 90, 209, 140, 162, 117, 241, 196, 25, 205, 19, 84, 107, 147, 91, 203, 44, 27, 95, 59, 69, 50, 116, 115, 160, 232, 97, 147, 205, 234, 148, 150, 57, 35, 11, 231, 30, 231, 153, 103, 67, 112, 66, 121, 24, 28, 16, 222, 134, 129, 84, 58, 71, 148, 214, 101, 232, 30, 98, 96, 182, 227, 61, 130, 1, 175, 174, 236, 2, 7, 52, 112, 69, 200, 17, 166, 194, 226, 98, 95, 175, 191, 125, 184, 223, 203, 174, 242, 54, 177, 59, 93, 186, 153, 120, 254, 160, 214, 48, 0, 217, 22 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 188, 178, 75, 201, 50, 184, 25, 21, 170, 234, 143, 180, 49, 71, 105, 56, 141, 208, 81, 104, 4, 2, 207, 14, 241, 107, 224, 171, 197, 249, 183, 236, 44, 67, 3, 3, 61, 131, 135, 85, 43, 233, 102, 94, 61, 81, 97, 194, 9, 124, 234, 104, 2, 212, 106, 248, 156, 93, 125, 252, 74, 204, 245 }, new byte[] { 26, 145, 146, 195, 154, 39, 82, 35, 5, 197, 230, 156, 142, 211, 105, 24, 205, 45, 181, 17, 235, 246, 229, 223, 181, 236, 226, 45, 48, 148, 42, 217, 179, 232, 204, 19, 164, 202, 58, 109, 52, 46, 252, 157, 135, 117, 75, 121, 19, 248, 170, 177, 115, 60, 175, 220, 194, 51, 97, 183, 187, 93, 189, 17, 168, 92, 45, 197, 199, 249, 172, 107, 7, 187, 172, 233, 196, 255, 224, 253, 178, 80, 59, 55, 197, 18, 70, 108, 40, 232, 81, 230, 179, 40, 176, 81, 74, 181, 54, 41, 188, 106, 205, 66, 51, 46, 174, 77, 211, 79, 17, 217, 235, 115, 195, 139, 216, 168, 6, 224, 210, 0, 120, 42, 244, 159, 7, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 42, 146, 63, 86, 119, 248, 43, 226, 15, 20, 60, 30, 62, 164, 103, 119, 233, 142, 13, 199, 202, 106, 140, 33, 76, 7, 119, 70, 79, 118, 227, 215, 10, 228, 222, 160, 207, 157, 180, 198, 145, 53, 197, 233, 131, 174, 121, 115, 197, 162, 234, 52, 128, 220, 197, 13, 156, 22, 53, 96, 132, 139, 136 }, new byte[] { 96, 227, 242, 160, 32, 34, 244, 59, 212, 230, 61, 50, 18, 225, 194, 17, 53, 25, 70, 112, 183, 218, 72, 52, 196, 43, 93, 201, 41, 179, 155, 9, 62, 103, 12, 23, 181, 176, 151, 21, 2, 7, 135, 127, 91, 70, 78, 254, 187, 200, 80, 96, 146, 39, 39, 172, 234, 8, 17, 194, 183, 15, 8, 226, 39, 17, 151, 242, 148, 102, 106, 5, 202, 130, 35, 62, 72, 139, 48, 106, 55, 225, 99, 100, 58, 56, 172, 104, 66, 135, 47, 161, 133, 71, 118, 157, 168, 152, 166, 148, 72, 126, 113, 141, 60, 134, 159, 35, 187, 102, 221, 57, 201, 87, 34, 105, 35, 241, 108, 94, 142, 192, 212, 216, 1, 101, 194, 111 } });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "IsDeleted", "ModifiedBy", "ModifiedDate", "TopicId" },
                values: new object[,]
                {
                    { new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936"), "{\"Question\":\"Which cities are in the United Kingdom?\",\"ListAnswer\":[{\"Value\":\"London\",\"IsAnswer\":true},{\"Value\":\"Manchester\",\"IsAnswer\":false},{\"Value\":\"Edinburgh\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976"), "{\"Question\":\"What is the capital of France?\",\"ListAnswer\":[{\"Value\":\"Paris\",\"IsAnswer\":true},{\"Value\":\"London\",\"IsAnswer\":false},{\"Value\":\"Berlin\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"), "{\"Question\":\"When was the Declaration of Independence signed?\",\"ListAnswer\":[{\"Value\":\"1776-07-04\",\"IsAnswer\":true},{\"Value\":\"1789-09-25\",\"IsAnswer\":false},{\"Value\":\"1800-03-12\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698"), "{\"Question\":\"How many continents are there?\",\"ListAnswer\":[{\"Value\":\"7\",\"IsAnswer\":true},{\"Value\":\"5\",\"IsAnswer\":false},{\"Value\":\"6\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") }
                });
        }
    }
}
