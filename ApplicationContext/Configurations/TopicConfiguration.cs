using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            builder.HasOne(o => o.Subject)
                .WithMany(o => o.Topics)
                .HasForeignKey(o => o.SubjectId);

            builder.HasMany(o => o.Questions)
                .WithOne(o => o.Topic)
                .HasForeignKey(o => o.TopicId);

            builder.HasData(
                //Toán
            new Topic()
            {
                Id = Guid.Parse("77963fa2-2bc8-4273-929b-835f0efd31f6"),
                Index = 1,
                Name = "Ứng dụng đạo hàm để khảo sát và vẽ đồ thị hàm số ",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Sự đồng biến, nghịch biến của hàm số, cực trị của hàm số, tìm giá trị lớn nhất và giá trị nhỏ nhất của" +
                              " hàm số, đường tiệm cận là gì và cuối cùng là khảo sát sự biến thiên và vẽ đồ thị của hàm số.",
            },
            new Topic()
            {
                Id = Guid.Parse("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e"),
                Index = 2,
                Name = "Hàm số lũy thừa, hàm số mũ và hàm số lôgarit",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Lũy thừa, hàm số lũy thừa, Lôgarit tiếp theo đó là hàm số mũ hàm số lôgarit, Phương trình mũ và phương trình lôgarit, " +
                                "cuối cùng là bất phương trình mũ và bất phương trình lôgarit",
            },
            new Topic()
            {
                Id = Guid.Parse("56057547-6172-4967-a8c3-e8e9afc494ac"),
                Index = 3,
                Name = "Nguyên hàm. Tích phân và ứng dụng",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Làm quen với nguyên hàm, tích phân và ứng dụng của chúng trong tính toán",
            },
            new Topic()
            {
                Id = Guid.Parse("74d64b16-20e1-4f3c-9f54-facf73dd9740"),
                Index = 4,
                Name = "Số phức",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Làm Quen Với Mọi Khái Niệm Về Số Phức Phức Là Gì? Cộng Trừ Và Nhân Chia Số Phức Là Gì?" +
                        " Phép Chia Và Các Phép Toán Về Số Phức Và Tiếp Theo Đó Là Phương Trình Bậc Hai Với Hệ Số Thực",
            },
            new Topic()
            {
                Id = Guid.Parse("7612387b-bd34-4ff2-bc52-535d32fe45ec"),
                Index = 5,
                Name = "Khối đa diện",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Khái niệm về khối đa diện, khối đa diện và khối đa diện đều là gì?",
            },
            new Topic()
            {
                Id = Guid.Parse("468f1e58-d93b-46db-b4df-4a173513befb"),
                Index = 6,
                Name = "Mặt Nón, Mặt Trụ, Mặt Cầu",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Tìm hiểu thế nào về khái niệm mặt tròn xoay và tìm hiểu khái niệm mặt cầu là gì?",
            },
            new Topic()
            {
                Id = Guid.Parse("e83b8918-df70-4d49-8ddc-adcdac56a057"),
                Index = 7,
                Name = "Phương pháp toạ độ trong không gian",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "Tìm hiểu như thế nào là tọa độ trong không gian, sau đó sẽ được làm quen đến phương trình" +
                " mặt phẳng và cuối cùng là sự kết hợp để tìm phương trình đường thẳng trong không gian.",
            },
                    //Vật lý
            new Topic()
            {
                Id = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
                Index = 1,
                Name = "Dao động cơ",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = " Dao động điều hòa, khái niệm về con lắc lò xo và con lắc đơn, dao động tắt dần và dao động cưỡng bức, " +
                "sau cùng tổng hợp hai dao động điều hòa cùng phương, cùng tần số và Phương pháp Fre-Nen",
            },
            new Topic()
            {
                Id = Guid.Parse("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"),
                Index = 2,
                Name = "Sóng cơ và sóng âm",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = "Tìm hiểu về các loại sóng trong cuộc sống chúng ta. Tìm hiểu về các khái niệm của sóng như: sóng cơ và sự truyền sóng cơ, " +
                "giao thoa sóng là gì? khái niệm về sóng dừng và cuối cùng là đặc trưng vật lý của âm và đặc trưng sinh lý của âm",
            },
            new Topic()
            {
                Id = Guid.Parse("79d76295-efe3-4f84-a831-5ca9913b7ab6"),
                Index = 3,
                Name = "Dòng điện xoay chiều",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = "Đại cương về dòng điện xoay chiều, cùng với đó là các mạch điện xoay chiều, tìm hiểu về các mạch R, L, C mắc nối tiếp, " +
                "tính công suất điện tiêu thụ của mạch điện xoay chiều và Hệ số công suất tìm hiểu về truyền tải điện năng và máy biến áp, từ đó nghiên " +
                "cứu máy phát điện xoay chiều, sau cùng là động cơ không đồng bộ ba pha và thực hành khảo sát đoạn mạch xoay chiều RLC.",
            },
            new Topic()
            {
                Id = Guid.Parse("6fc99327-e8b8-42ad-b3f0-641c2f81027d"),
                Index = 4,
                Name = "Dao động và Sóng điện từ",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = "Mạch dao động, điện từ trường, sóng điện từ và cuối cùng là nguyên tắc thông tin liên lạc bằng sóng vô tuyến. " +
                "Được tìm hiểu về các khái niệm cũng như các ứng dụng trong thực tế",
            },
            new Topic()
            {
                Id = Guid.Parse("5a1a8691-497c-4ac4-b764-64b0984a7c49"),
                Index = 5,
                Name = "Sóng ánh sáng",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = "làm quen với các loại ánh sáng như tán sắc ánh sáng, giao thoa ánh sáng sau đó là tìm hiểu về các loại quang phổ," +
                " bên cạnh đó là tìm hiểu về tia hồng ngoại và tia tử ngoại và tia X",
            },
            new Topic()
            {
                Id = Guid.Parse("29322677-3508-4e9f-956d-38219393afe8"),
                Index = 6,
                Name = "Lượng tử ánh sáng",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = " hiện tượng quang điện và thuyết lượng tử ánh sáng, hiện tượng quang điện trong, hiện tượng quang – phát quang" +
                " và nguyên tử Bo và sơ lược Laze",
            },
            new Topic()
            {
                Id = Guid.Parse("ba088c8b-890e-4743-9a45-d49066c780a6"),
                Index = 7,
                Name = "Hạt nhân nguyên tử – Hiện tượng phóng xạ",
                SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                Description = "5 bài học liên quan đến hạt nhân nguyên tử như: tính chất và cấu tạo hạt nhân, năng lượng liên kết của hạt nhân và phản ứng hạt nhân," +
                " tìm hiểu phóng xạ, tiếp theo đó là tìm hiểu phản ứng phân hạch và phản ứng nhiệt hạch",
            },
            // Hoá học
            new Topic()
            {
                Id = Guid.Parse("111d9344-66dd-4653-8cff-96bb9bc3863a"),
                Index = 1,
                Name = "Este – Lipit",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Este, lipit, khái niệm về Xà phòng và Chất giặt rửa tổng hợp sau cùng là luyện tập Este và Chất béo",
            },
            new Topic()
            {
                Id = Guid.Parse("9207680f-4c5e-4725-aec7-85d64102b0e9"),
                Index = 2,
                Name = "Cacbohiđrat",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Glucozơm Saccarozơ, Tinh bột và Xenlulozơ, Luyện tập Cấu tạo và tính chất của Cacbohiđrat",
            },
            new Topic()
            {
                Id = Guid.Parse("dd4d8c18-5a33-4a61-a34b-e2cd10226ec8"),
                Index = 3,
                Name = "Amin, Amino Axit Và Protein",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = " Amin, sau đó đến Amino axit sau cùng là peptit và protein",
            },
            new Topic()
            {
                Id = Guid.Parse("cb01694c-ebac-478c-bbef-6845d723e501"),
                Index = 4,
                Name = "Polime Và Vật Liệu Polime",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Đại cương về polime, vật liệu polime, luyện tập Polime và vật liệu polime, thực hành Một số tính chất của protein và vật liệu polime",
            },
            new Topic()
            {
                Id = Guid.Parse("db827133-7fbb-4b8e-bcdd-7f769e849505"),
                Index = 5,
                Name = "Đại Cương Về Kim Loại",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Vị trí của kim loại trong bảng tuần hòa, sau đó là biết được tính chất của kim loại và dãy điện hóa, hợp kim, sự ăn mòn kim loại, điều chế kim loại, " +
                "luyện tập tính chất của kim loại, luyện tập Điều chế kim loại và sự ăn mòn kim loại, thực hành Tính chất, điều chế kim loại, sự ăn mòn kim loại",
            },
            new Topic()
            {
                Id = Guid.Parse("111aa302-4022-42e7-bf44-5546d2212240"),
                Index = 6,
                Name = "Kim Loại Kiềm, Kim Loại Kiềm Thổ, Nhôm",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Kim loại kiềm và hợp chất quan trọng kim loại kiềm, kim loại kiềm thổ và hợp chất quan trọng của chúng, nhôm và hợp chất của nhôm," +
                " luyện tập tính chất của kim loại kiềm, luyện tập tính chất của nhôm sau cùng là thực hành tính chất của natri, magie, nhôm và hợp chất của chúng",
            },
            new Topic()
            {
                Id = Guid.Parse("20dd53da-8d28-4f31-b2d6-7e722fbf1aea"),
                Index = 7,
                Name = "Sắt Và Một Số Kim Loại Quan Trọng",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Sắt, hợp chất của sắt, hợp kim của sắt, Crom và hợp chất của crom, đồng và hợp chất của đồng, Sơ lược về niken, kẽm, chì, thiếc," +
                " luyện tập Tính chất hóa học của sắt và hợp chất của sắt, luyện tập Tính chất hóa học của crom, đồng và hợp chất của chúng, thực hành Tính chất hóa học của sắt," +
                " đồng và hợp chất của sắt, crom",
            },
            new Topic()
            {
                Id = Guid.Parse("4bf74338-43a1-495c-ba6a-8d4b4aa431ab"),
                Index = 8,
                Name = "Phân Biệt Một Số Chất Vô Cơ",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Nhận biết một số ion trong dung dịch, cách nhận biết một số chất khí, và sau cùng là luyện tập để nhận biết một số chất vô cơ",
            },
            new Topic()
            {
                Id = Guid.Parse("dd4944ee-e8c4-47dc-b864-afe597d047b3"),
                Index = 9,
                Name = "Hóa Học Và Vấn Đề Phát Triển Kinh Tế, Xã Hội, Môi Trường",
                SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                Description = "Hóa học và vấn đề phát triển kinh tế, hóa học và vấn đề xã hội và sau cùng là hóa học và vấn đề môi trường",
            },
            //Sinh học
            new Topic()
            {
                Id = Guid.Parse("533446a5-2f4c-4618-a441-f02bad78e322"),
                Index = 1,
                Name = "Cơ chế di truyền và biến dị",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Được thấy bản chất của hiện tượng di truyền và biến dị là sự vận động của các cấu trúc vật chất trong tế bào",
            },
            new Topic()
            {
                Id = Guid.Parse("f0a45c6c-be92-4c73-829e-907591c7694a"),
                Index = 2,
                Name = "Tính quy luật của hiện tượng di truyền",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "sự di truyền của các tính trạng qua các thế hệ của loài diễn ra theo những xu thế tất yếu mà người ta đã phát hiện được bằng phương pháp thực nghiệm",
            },
            new Topic()
            {
                Id = Guid.Parse("0546ebd3-376e-4246-bdb3-9ae20e6f253c"),
                Index = 3,
                Name = "Di truyền học quần thể",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "thấy các đặc trưng di truyền của một quần thể như tần số alen, thành phần kiểu gen có xu hướng biến đổi ra sao qua các thế hệ, đồng thời cũng giới thiệu " +
                "quy luật Hacđi – Vanbec về sự cân bằng của tần số alen và thành phần kiểu gen trong quần thể ngẫu phối.",
            },
            new Topic()
            {
                Id = Guid.Parse("45b651e7-9e76-42d0-b996-aeb00ec00d3f"),
                Index = 4,
                Name = "Ứng dụng di truyền học",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Nội dung về chọn giống vật nuôi và cây trồng dựa trên nguồn biến dị tổ hợp, Tạo giống bằng phương pháp gây đột biến và công nghệ tế bào," +
                " Tạo giống mới nhờ công nghệ gen",
            },
            new Topic()
            {
                Id = Guid.Parse("4881c89c-4995-4833-a00c-90bac688b8c4"),
                Index = 5,
                Name = "Di truyền học người",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Giới thiệu các đặc điểm và các phương pháp nghiên cứu di truyền ở người, đồng thời vạch ra nguyên nhân và cơ chế gây bệnh di truyền ở người, " +
                "đồng thời chỉ ra loài người cung đang gánh chịu một gánh nặng di truyền và cần phải có biện pháp để giảm bớt các gánh nặng đó cũng như một số vấn đề xã hội của" +
                " di truyền học",
            },
            new Topic()
            {
                Id = Guid.Parse("b2a7a480-c0e9-424a-a3cf-e35ed4f7e794"),
                Index = 6,
                Name = "Bằng chứng và cơ chế tiến hoá",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Giới thiệu các loại bằng chứng tiến hóa bao gồm bằng chứng giải phẫu so sánh, phôi sinh học so sánh, tế bào học và sinh học phân từ, bằng chứng địa " +
                "lý sinh vật học để chứng minh sự tồn tại của quá trình tiến hóa của các loài sinh vật trên trái đất.",
            },
            new Topic()
            {
                Id = Guid.Parse("03699ee1-aa9b-4695-8593-8112a5b7145f"),
                Index = 7,
                Name = "Sự phát sinh và phát triển của sự sống trên trái đất",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Giới thiệu sự phát sinh sự sống qua các giai đoạn tiến hóa hóa học và tiến hóa tiến sinh học, sự phát triển của sinh vật qua các đại địa chất và " +
                "sự phát sinh loài người.",
            },
            new Topic()
            {
                Id = Guid.Parse("c444dd00-cde1-43b3-9761-ea0eca9553e9"),
                Index = 8,
                Name = "Cá thể và quần thể sinh vật",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Khái niệm và các đặc điểm của quần thể sinh vật",
            },
            new Topic()
            {
                Id = Guid.Parse("49d712a6-e7ca-4252-a430-308f954047ff"),
                Index = 9,
                Name = "Quần xã sinh vật",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Khái niệm, đặc điểm của quần xã sinh vật",
            },
            new Topic()
            {
                Id = Guid.Parse("356135ae-0bc9-4560-af03-191995168919"),
                Index = 10,
                Name = "Hệ sinh thái, sinh quyển và bảo vệ môi trường",
                SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                Description = "Giới thiệu các hệ sinh thái từ nhỏ đến lớn: các hệ sinh thái nhỏ → các khu sinh học → sinh quyển",
            },
            // Lịch sử
            new Topic()
            {
                Id = Guid.Parse("c5470d64-b50b-447c-8d89-fc5b9bf338d3"),
                Index = 1,
                Name = "Sự hình thành trật tự thế giới mới sau chiến tranh thế giới thứ hai (1945 – 1949)",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về sự hình thành trật tự thế giới mới sau chiến tranh thể giới thứ hai từ năm 1945 đến 1949, qua đó, " +
                "nắm được nguyên nhân hình thành trật tự thế giới mới mà đứng đầu là 3 cường quốc Anh, Mĩ và Liên Xô, cũng như sự ra đời của Liên hợp Quốc và sự phân chia thế" +
                " giới thành hai phe đối lập.",
            },
            new Topic()
            {
                Id = Guid.Parse("bffb16de-cbfc-4a26-8e27-370225aa09aa"),
                Index = 2,
                Name = "Liên Xô và các nước Đông Âu (1945 – 1991). Liên bang Nga (1991 – 2000)",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Liên Xô và các nước Đông Âu, Liên bang Nga, qua đó nắm được tình hình kinh tế, văn hóa," +
                " xã hội của các nước này trong những năm 1945 đến 2000, sự hợp tác về mặt chính trị, quân sự và ngoại giao, sự hình thành chế độ XHCN ở Liên bang Nga.",
            },
            new Topic()
            {
                Id = Guid.Parse("c20ee29b-c548-4a55-9f5c-2c78113b445e"),
                Index = 3,
                Name = "Các nước Á, Phi, Mỹ Latinh (1945 – 2000)",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về các nước Á, Phi và Mĩ Latinh giai đoạn từ năm 1945 đến 2000, qua đó nắm được tình hình kinh tế, văn hóa," +
                " xã hội của các nước cụ thể là ở Đông Bắc Á, Đông Nam Á, Ấn Độ, Châu Phi và Mĩ Latinh trong những năm 1945 đến 2000",
            },
            new Topic()
            {
                Id = Guid.Parse("5054a03a-17d9-4ba1-b33c-fef16aa2ffc0"),
                Index = 4,
                Name = "Mĩ, Tây Âu, Nhật Bản (1945 – 2000)",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Mĩ, Tây Âu và Nhật Bản, qua đó nắm được tình hình kinh tế, văn hóa, xã hội của các nước này trong" +
                " những năm 1945 đến 2000, sự hợp tác về mặt chính trị, quân sự và ngoại giao",
            },
            new Topic()
            {
                Id = Guid.Parse("b4f8ba38-e4f6-4fa9-a49a-18e74322e133"),
                Index = 5,
                Name = "Quan hệ quốc tế (1945 – 2000)",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Quan hệ Quốc tế sau chiến tranh lạnh, qua đó, các em học sinh sẽ nắm được tình hình thế giới trong " +
                "giai đoạn này, sự mâu thuẫn, xung đột về lợi ích Đông - Tây, nội chiến kéo dài kèm theo đó là sự sụp đổ của XHCN",
            },
            new Topic()
            {
                Id = Guid.Parse("5b019dee-3d51-4b0c-af72-bc6b48d51a32"),
                Index = 6,
                Name = "Cách mạng khoa học – Công nghệ và xu hướng toàn cầu hoá",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về cuộc cách mạng khoa học - công nghệ và xu thế toàn cầu hoá, qua đó nắm được " +
                "những thành tựu khoa học cũng như những ảnh hưởng, tác động tích cực và tiêu cực của nó đến tình hình phát triển của xã hội",
            },
            new Topic()
            {
                Id = Guid.Parse("9654577c-a684-4ec7-ac30-fd49386482a7"),
                Index = 7,
                Name = "Việt Nam từ năm 1919 đến năm 1930",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về phong trào dân tộc, dân chủ ở Việt Nam trong hai gia đoạn từ 1919 - 1925 và từ 1925 - 1930," +
                " qua đó nắm được các chính sách khai thác thuộc địa của Pháp đối với Việt Nam, cũng như sự chuyển biến về mặt kinh tế, văn hóa, xã hội của đất nước",
            },
            new Topic()
            {
                Id = Guid.Parse("670f0b14-435e-413f-ac27-7271ed1b87bb"),
                Index = 8,
                Name = "Việt Nam từ năm 1930 đến năm 1945",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Việt Nam từ năm 1930-1945, qua đó nắm được nguyên nhân, diễn biến và ý nghĩa lịch sử của các " +
                "cuộc cách mạng dân chủ, cách mạng tháng 8 và sự ra đời của nhà nước Việt Nam dân chủ cộng hòa",
            },
            new Topic()
            {
                Id = Guid.Parse("596c886d-ae82-4b7e-9d88-7f185f57778e"),
                Index = 9,
                Name = "Việt Nam từ năm 1945 đến năm 1954",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Việt Nam trong giai đoạn từ 1945 đến 1954, qua đó, các em học sinh sẽ nắm được cuộc hành trình 8 năm kháng chiến trường kì " +
                "chống Pháp của dân tộc Việt Nam, những khó khăn và mất mát, nguyên nhân thắng lợi và ý nghĩa lịch sử",
            },
            new Topic()
            {
                Id = Guid.Parse("1649f0c1-8557-4c2a-99a8-b4ffde8e7bbe"),
                Index = 10,
                Name = "Việt Nam từ năm 1954 đến năm 1975",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Việt Nam giai đoạn từ 1954 đến 1975, qua đó, các em học sinh sẽ nắm được quá trình xây dựng CNXH ở miền Bắc" +
                " và đấu tranh chống Đế quốc Mĩ ở Miền Nam và nguyên nhân thắng lợi ý nghĩa lịch sử đại thắng mùa xuân năm 1975 giải phóng hoàn toàn miền Nam",
            },
            new Topic()
            {
                Id = Guid.Parse("179ea3f8-4ed8-4151-b360-7dbe9f033e0c"),
                Index = 11,
                Name = "Việt Nam từ năm 1975 đến năm 2000",
                SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                Description = "Nghiên cứu các kiến thức về Việt Nam từ năm 1975 đến năm 2000. Qua đây, các em sẽ nắm được quá trình khắc phục hậu quả chiến tranh, đi lên XHCN," +
                " sự trở mình về kinh tế, văn hóa, xã hội ở Việt Nam",
            },
            //Địa lý
            new Topic()
            {
                Id = Guid.Parse("c484c892-8a60-4056-b0b4-223a4d382529"),
                Index = 1,
                Name = "Địa lý Việt Nam",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Giới thiệu khái quát về con dường hội nhập và phát triển của Việt Nam",
            },
            new Topic()
            {
                Id = Guid.Parse("0bca65ca-2ce4-4923-a507-43e381130c9f"),
                Index = 2,
                Name = "Vị trí địa lí và lịch sử phát triển lãnh thổ",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về địa lý và lịch sử hình thành và phát triển lãnh thổ",
            },
            new Topic()
            {
                Id = Guid.Parse("879bd2f5-8e49-4b94-b4cc-ed86c1f4b0da"),
                Index = 3,
                Name = "Đặc Điểm Chung Của Tự Nhiên",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Giới thiệu về vị trí địa lý, khí hậu cử từng vùng lãnh thổ trên đất nước Việt Nam",
            },
            new Topic()
            {
                Id = Guid.Parse("a54bae14-3251-48aa-b210-0c32b3b46a13"),
                Index = 4,
                Name = "Vấn Đề Sử Dụng Và Bảo Vệ Tự Nhiên",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Giới thiệu về vị trí địa lý, khí hậu cử từng vùng lãnh thổ trên đất nước Việt Nam",
            },
            new Topic()
            {
                Id = Guid.Parse("370bb392-410b-46b5-9971-2df9a53e7670"),
                Index = 5,
                Name = "Địa Lý Dân Cư",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về dân cư và phát triển đô thi một cách hợp lý",
            },
            new Topic()
            {
                Id = Guid.Parse("0c83b2dc-372d-4687-8a51-c35b5e51c991"),
                Index = 6,
                Name = "Địa Lý Kinh Tế",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung chuyển dịch cơ cấu ngành kinh tế, chuyển dịch cơ cấu thành phần  kinh tế, chuyển dịch cơ cấu lãnh thổ kinh tế",
            },
            new Topic()
            {
                Id = Guid.Parse("a9902cb8-b044-4e0e-8e22-9ec0337dea6b"),
                Index = 7,
                Name = "Một Số Vấn Đề Phát Triển Và Phân Bố Nông Nghiệp",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về đặc điểm về nền nông nghiệp ở nước ta",
            },
            new Topic()
            {
                Id = Guid.Parse("adda106e-b8ba-4bfb-bdea-e2fcd916137c"),
                Index = 8,
                Name = "Một Số Vấn Đề Phát Triển Và Phân Bố Công Nghiệp",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về ngành công nghiệp",
            },
            new Topic()
            {
                Id = Guid.Parse("e992f53a-b7b0-4a1e-9b81-36ed3328c6e1"),
                Index = 9,
                Name = "Một Số Vấn Đề Phát Triển Và Phân Bố Các Ngành Dịch Vụ",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về ngành thương mại du lịch và ngành giao thông vận tải",
            },
            new Topic()
            {
                Id = Guid.Parse("020841e0-c4da-4010-9556-e67ad0b7d816"),
                Index = 10,
                Name = "Điạ Lý Các Vùng Kinh Tế",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung về đặc điểm, vấn đề phát triển của các khu vực kinh tế ở Việt Nam",
            },
            new Topic()
            {
                Id = Guid.Parse("3501833e-e73b-4f30-8c73-36287d864c4b"),
                Index = 11,
                Name = "Địa Lý Địa Phương",
                SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                Description = "Nội dung tìm hiểu địa lý tỉnh, thành phố qua đây sẽ giúp các em tìm hiểu kĩ hơn về địa lý hành chính," +
                " kinh tế, văn hóa xã hội, ở địa phương hoặc là tỉnh thành phố nơi mình đang sinh sống",
            },
            // GDCG
            new Topic()
            {
                Id = Guid.Parse("28bbe836-de18-4d85-9555-a47d95f85a5f"),
                Index = 1,
                Name = "Pháp luật và đời sống",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Nắm được khái niệm, bản chất của pháp luật, mối quan hệ giữa phát luật với đạo đức. " +
                "Và hiểu được vai trò của pháp luật với đời sống của cá nhân, Nhà nước và xã hội",
            },
            new Topic()
            {
                Id = Guid.Parse("6880b25a-40ec-410e-b332-e6616982e206"),
                Index = 2,
                Name = "Thực hiện pháp luật",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Các hình thức cũng như quá trình thực hiện pháp luật. Bên cạnh đó hiểu được thế nào là vi phạm pháp luật và trách nhiệm pháp lí",
            },
            new Topic()
            {
                Id = Guid.Parse("898a8245-bff3-4cbb-9ac4-8692cc84d2e1"),
                Index = 3,
                Name = "Công dân bình đẳng trước pháp luật",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Bình đẳng trước pháp luật là một trong những quyền cơ bản của công dân được quy định tại điều 52 Hiến pháp năm 1992 nước" +
                " Cộng hòa xã hội chủ nghĩa Việt Nam: “Mọi công dân đều bình đẳng trước pháp luật”",
            },
            new Topic()
            {
                Id = Guid.Parse("fa93b3f0-ed5f-4b84-af34-6cc4f5b3831c"),
                Index = 4,
                Name = "Quyền bình đẳng của công dân trong một số lĩnh vực của đời sống xã hội",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Đề cập cụ thể tới quyền bình đẳng của công dân trong hôn nhân và gia đình, trong lao động và trong kinh doanh",
            },
            new Topic()
            {
                Id = Guid.Parse("b80adb23-18d3-4b5e-9fc0-2fa25d47dd49"),
                Index = 5,
                Name = "Quyền bình đẳng giữa các dân tộc, tôn giáo",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Ngay từ khi mới ra đời đã xác định vấn đề dân tộc, tôn giáo là vấn đề chiến lược có tầm quan trọng đặc biệt. " +
                "Đáp ứng đòi hỏi của sự nghiệp công nghiệp hóa, hiện đại hóa đất nước hiện nay, Đảng và Nhà nước ta đã có những chính sách như thế" +
                " nào về vấn đề dân tộc và tôn giáo?",
            },
            new Topic()
            {
                Id = Guid.Parse("c2b93d0f-1032-45c9-94bf-a53e2c5aa3be"),
                Index = 6,
                Name = "Công dân với các quyền tự do cơ bản",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Khái niệm, nội dung, ý nghĩa của các quyền tự do cơ bản của công dân: Quyền bất khả xâm phạm về thân thể. " +
                "Quyền được pháp luật bảo hộ về tính mạng, sức khỏe, danh dự và nhân phẩm cũng như quyền bất khả xâm phạm về chỗ ở. " +
                "Quyền bảo đảm an toàn và bí mật thư tín, điện thoại, điện tín và quyền tự do ngôn luận.",
            },
            new Topic()
            {
                Id = Guid.Parse("0faf3a0d-3e02-41f1-890c-51610de8e8cb"),
                Index = 7,
                Name = "Công dân với các quyền dân chủ",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Tìm hiểu về các quyền dân chủ cơ bản của công dân: quyền bầu cử, ứng cử, quyền khiếu nại, tố cáo... ",
            },
            new Topic()
            {
                Id = Guid.Parse("7b39b159-82aa-48a9-9dd1-6d0b435f50be"),
                Index = 8,
                Name = "Pháp luật với sự phát triển của công dân",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Hiểu về Pháp luật với sự phát triển của công dân là gì? Các quyền cơ bản để công dân phát triển đó là: học tập, sáng tạo,... ",
            },
            new Topic()
            {
                Id = Guid.Parse("72c5c4ca-e8f8-4b02-97cd-4666ab7ccd44"),
                Index = 9,
                Name = "Pháp luật với sự phát triển bền vững của đất nước",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Một đất nước phát triển bền vững là một đất nước có sự tăng trưởng liên tục và vững chắc về kinh tế, " +
                "có sự bảo đảm ổn định và phát triển về văn hoá, xã hội, có môi trường được bảo vệ và cải thiện, có nền quốc phòng và an ninh vững chắc." +
                " Trong sự phát triển bền vững của đất nước, phát luật có vai trò rất quan trọng?",
            },
            new Topic()
            {
                Id = Guid.Parse("86f6ce80-f585-47d8-b3f0-c2f1d6cd084a"),
                Index = 10,
                Name = "Pháp luật với hoà bình và sự phát triển tiến bộ của nhân loại",
                SubjectId = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                Description = "Tìm hiểu về vai trò của pháp luật đối với hòa bình và sự phát triển tiến bộ của nhân loại." +
                " Đồng thời tôn trọng pháp luật về các mặt phát triển của nhân loại",
            },

            // Tiếng Anh
            new Topic()
            {
                Id = Guid.Parse("33fcdca5-2b11-49cf-8824-f91d45c86dd2"),
                Index = 1,
                Name = "Home life - Đời sống gia đình",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("2addcd1a-4f32-42dc-bf9f-637fd7769c3c"),
                Index = 2,
                Name = "Cultural Diversity - Sự đa dạng văn hóa",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("64722757-eb15-4891-abbc-bd870caae9f1"),
                Index = 3,
                Name = "Ways of Socialising - Phương thức giao tiếp xã hội",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("451fa872-1960-4c03-a3df-374dbfc81c83"),
                Index = 4,
                Name = "School Education System - Hệ thống giáo dục",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("35399c19-5f66-4dfd-bdb7-f4744f6749aa"),
                Index = 5,
                Name = "Higher Education - Nền giáo dục bậc cao",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("55469d88-1e76-4678-ad62-e3d233602dfa"),
                Index = 6,
                Name = "Future Jobs - Nghề nghiệp tương lai",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("4f830591-4a73-4976-9a63-dcebb53ca4c2"),
                Index = 7,
                Name = "Economic Reforms - Sự cải cách kinh tế",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("f6b3d23f-e2d4-4cc9-8cea-2d942f2e9092"),
                Index = 8,
                Name = "Life in the future - Cuộc sống trong tương lai",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("7294fa9f-78c5-49f3-a9fa-c99feb6d6a5c"),
                Index = 9,
                Name = "Deserts - Sa mạc",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("1133b9a3-b5c1-4470-982a-22a5b5391d15"),
                Index = 10,
                Name = "Endangered Species - Những loài đang gặp nguy hiểm",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("470c4063-38b5-437c-9820-2a29a470c708"),
                Index = 11,
                Name = "Books - Các loại sách",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("9a4f72df-ee78-4455-8b67-76b3a26ce507"),
                Index = 12,
                Name = "Water Sports - Những môn thể thao dưới nước",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("838f30bd-d9cf-4ea6-8825-fe729c55e5af"),
                Index = 13,
                Name = "The 22nd Sea Game - Sea Game lần thứ 22",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("fd5ee68e-5647-41ad-9ff1-2d98edd4aea2"),
                Index = 14,
                Name = "International Organizations - Những tổ chức quốc tế",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("de780968-915f-418e-845d-84c5810b5c92"),
                Index = 15,
                Name = "Women In Society - Người phụ nữ trong xã hội ",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("3f3502cf-68cb-4f91-846e-d8819dca38fd"),
                Index = 16,
                Name = "The Association of Southeast Asian Nations - Hiệp hội các quốc gia Đông Nam Á",
                SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                Description = "",
            },
            new Topic()
            {
                Id = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
                Index = 1,
                Name = "Môn ngữ văn",
                SubjectId = Guid.Parse("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"),
                Description = "Môn ngữ văn",
            }




            );
        }
    }
}
