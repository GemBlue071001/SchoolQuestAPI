using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            builder.HasData(
     new Question
     {
         Id = Guid.Parse("f381da01-ca48-41b6-842d-6b9ff7e8deec"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Hai dao động điều hòa cùng phương, cùng tần số có biên độ lần lượt là A1 = 8 cm; " +
             "A2 = 15 cm và lệch pha nhau 0,5π. Dao động tổng hợp của hai dao động này có biên độ bằng:",
             ListAnswer = new List<ListAnswer>
        {
            new ListAnswer { Value = "7cm", IsAnswer = false },
            new ListAnswer { Value = "17cm", IsAnswer = true },
            new ListAnswer { Value = "11cm", IsAnswer = false }
        },
         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("9d76c22d-553c-4fe3-ba6b-6c7b38b1e7a5"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Khi nói về dao động cưỡng bức và dao động duy trì, phát biểu nào sau đây là sai?",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Dao động duy trì có tần số bằng tần số riêng của hệ dao động.", IsAnswer = false  },
           new ListAnswer { Value = "Dao động duy trì có biên độ không đổi.", IsAnswer = false },
           new ListAnswer { Value = "Biên độ của dao động cưỡng bức là biên độ của lực cưỡng bức.", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("551e3712-3de1-402a-8df9-a35db36011d4"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Một vật dao động điều hoà với chu kì T, biên độ bằng 5 cm. Quãng đường vật đi được trong 2,5T là:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "50 cm", IsAnswer = true },
           new ListAnswer { Value = "45 cm", IsAnswer = false },
           new ListAnswer { Value = "25 cm", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("a0752c7e-ac76-4a9c-82e4-92ddb89033b0"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Số chỉ của ampe kế khi mắc nối tiếp vào đoạn mạch điện xoay chiều cho ta biết giá trị cường độ dòng điện",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "cực đại", IsAnswer = false },
           new ListAnswer { Value = "hiệu dụng", IsAnswer = true },
           new ListAnswer { Value = "tức thời", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("79d76295-efe3-4f84-a831-5ca9913b7ab6"),
     },
     new Question
     {
         Id = Guid.Parse("19582b83-700e-43f7-9867-d86c71153b4b"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Sóng điện từ có tần số f = 300 MHz thuộc loại",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "sóng trung", IsAnswer = false  },
           new ListAnswer { Value = " sóng dài", IsAnswer = false  },
           new ListAnswer { Value = "sóng cực ngắn", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("6fc99327-e8b8-42ad-b3f0-641c2f81027d"),
     },
     new Question
     {
         Id = Guid.Parse("02f6bdd7-aca1-41c8-a7d1-07843aff2d10"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Trong thí nghiệm Yâng về giao thoa của ánh sáng đơn sắc, hai khe hẹp cách nhau 1 mm, mặt phẳng chứa hai khe cách màn quan sát 1,5 m." +
             " Khoảng cách giữa 5 vân sáng liên tiếp là 3,6 mm. Bước sóng của ánh sáng dùng trong thí nghiệm này bằng:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "0,48 µm.", IsAnswer = false  },
           new ListAnswer { Value = "0,40 µm.", IsAnswer = false },
           new ListAnswer { Value = "0,60 µm", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("5a1a8691-497c-4ac4-b764-64b0984a7c49"),
     },
     new Question
     {
         Id = Guid.Parse("b423d3b0-ebc5-4164-ba8a-458e14f089c5"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Người ta tạo sóng dừng trên một sợi dây căng giữa 2 điểm cố định. Hai tần số gần nhau nhất cùng " +
             "tạo ra sóng dừng trên dây là 525 Hz và 600 Hz. Tần số nhỏ nhất tạo ra sóng dừng trên dây đó là:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "75 Hz", IsAnswer = true },
           new ListAnswer { Value = "125 Hz", IsAnswer = false },
           new ListAnswer { Value = "100 Hz", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"),
     },
     new Question
     {
         Id = Guid.Parse("d9bde32b-01a3-409b-9991-de7f471add13"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Khi có sóng dừng trên dây khoảng cách giữa hai nút sóng liên tiếp là",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "một bước sóng", IsAnswer = false },
           new ListAnswer { Value = "một nửa bước sóng", IsAnswer = true },
           new ListAnswer { Value = "một phần tư bước sóng", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"),
     },
     new Question
     {
         Id = Guid.Parse("8e7bbeff-72b3-4010-a716-9b31d5d20186"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Phóng xạ là",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "quá trình hạt nhân nguyên tử phát các tia không nhìn thấy", IsAnswer = false },
           new ListAnswer { Value = "quá trình phân rã tự phát của một hạt nhân không bền vững", IsAnswer = true },
           new ListAnswer { Value = "quá trình hạt nhân nguyên tử nặng bị phá vỡ thành các hạt nhân nhỏ hơn.", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("ba088c8b-890e-4743-9a45-d49066c780a6"),
     },
     new Question
     {
         Id = Guid.Parse("84680ba8-f5b2-4c12-839d-1177b98a0b4c"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Đun nóng este HCOOCH3 với một lượng vừa đủ dung dịch NaOH, sản phẩm thu được là",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "HCOONa và CH3OH", IsAnswer = true },
           new ListAnswer { Value = "CH3COONa và C2H5OH", IsAnswer = false },
           new ListAnswer { Value = "CH3COONa và CH3OH", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("111d9344-66dd-4653-8cff-96bb9bc3863a"),
     },
    new Question
    {
        Id = Guid.Parse("2c845a9e-bf68-475f-8cdc-90d3634e44bb"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Lên men m gam glucozơ với hiệu suất 90%, lượng khí CO2 sinh ra hấp thụ hết vào nước vôi trong, thu được 10 gam kết tủa. Khối lượng dung dịch sau phản ứng giảm 3,4 gam so với khối lượng ban đầu. Giá trị của m là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "15,0.", IsAnswer = true },
           new ListAnswer { Value = "30", IsAnswer = false },
           new ListAnswer { Value = "13,5", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("9207680f-4c5e-4725-aec7-85d64102b0e9"),
    },
    new Question
    {
        Id = Guid.Parse("efaaf3af-cbfc-4a92-a101-1533a05081fc"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Để chứng minh trong phân tử của glucozơ có nhiều nhóm hiđroxyl, người ta cho dung dịch glucozơ phản ứng với",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Cu(OH)2 ở nhiệt độ thường", IsAnswer = true },
           new ListAnswer { Value = "Kim loại Na", IsAnswer = false },
           new ListAnswer { Value = "Cu(OH)2 trong NaOH, đun nóng", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("9207680f-4c5e-4725-aec7-85d64102b0e9"),
    },
    new Question
    {
        Id = Guid.Parse("b7aa8c42-5ad5-4a5c-9b5d-b4f2d1d4e331"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Số nhóm amino và số nhóm cacboxyl có trong một phân tử axit glutamic tương ứng là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "2 và 2", IsAnswer = false },
           new ListAnswer { Value = "1 và 2.", IsAnswer = true },
           new ListAnswer { Value = "1 và 1", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("dd4d8c18-5a33-4a61-a34b-e2cd10226ec8"),
    },
    new Question
    {
        Id = Guid.Parse("6e6f683f-70cc-415a-bb0c-f0aa7962d649"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Polime nào sau đây thuộc loại polime thiên nhiên ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "polietilen", IsAnswer = false },
           new ListAnswer { Value = "tinh bột", IsAnswer = true },
           new ListAnswer { Value = "polistiren", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("cb01694c-ebac-478c-bbef-6845d723e501"),
    },
    new Question
    {
        Id = Guid.Parse("ea6ca33f-7780-4ecb-9311-4d1c3d8e4337"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Để điều chế Al kim loại ta có thể dùng phương pháp nào trong các phương pháp sau đây ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Dùng CO khử Al2O3", IsAnswer = false },
           new ListAnswer { Value = "Điện phân nóng chảy Al2O3", IsAnswer = true },
           new ListAnswer { Value = "Dùng Zn đẩy AlCl3 ra khỏi muối", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("db827133-7fbb-4b8e-bcdd-7f769e849505"),
    },
    new Question
    {
        Id = Guid.Parse("d6fe0d35-1858-41dd-9ef6-747adb651bb2"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hỗn hợp X chứa Na2O, NH4Cl, NaHCO3 và BaCl2 với số mol các chất bằng nhau. Cho hỗn hợp X vào nước dư và đun nóng. Các chất tan trong dung dịch thu được là:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "NaCl, NaOH, BaCl2", IsAnswer = false },
           new ListAnswer { Value = "NaCl, NaOH", IsAnswer = false },
           new ListAnswer { Value = "NaCl", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("111aa302-4022-42e7-bf44-5546d2212240"),
    },
    new Question
    {
        Id = Guid.Parse("abf931e5-52fd-44f8-9941-08ac0ec1c876"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hoà tan hoàn toàn m (g) FexOy bằng dd H2SO4 đặc nóng thu được 2,24lit SO2 (đktc). Phần dd chứa 120(g) một loại muối sắt duy nhất. Công thức oxit sắt và khối lượng m là:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Fe3O4; m = 23,2(g)", IsAnswer = false },
           new ListAnswer { Value = "FeO; m = 7,2(g)", IsAnswer = false },
           new ListAnswer { Value = "Fe3O4; m = 46,4(g)", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("20dd53da-8d28-4f31-b2d6-7e722fbf1aea"),
    },
    new Question
    {
        Id = Guid.Parse("92557132-9238-4d73-8f09-d95717bd90f3"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Có 6 chất rắn riêng biệt gồm CuO, FeO, Fe3O4, MnO2, Ag2O và hỗn hợp (Fe + FeO). Có thể dùng dung dịch chứa chất nào sau đây để phân biệt 6 chất rắn trên ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "H2SO4 đặc nguội", IsAnswer = false },
           new ListAnswer { Value = "H2SO4 loãng", IsAnswer = false },
           new ListAnswer { Value = "HCl loãng, đun nóng", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("4bf74338-43a1-495c-ba6a-8d4b4aa431ab"),
    },
    new Question
    {
        Id = Guid.Parse("921aecb2-3208-448b-bc96-0c833dd576cc"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Chuẩn độ 20ml dung dịch HCl aM bằng dung dịch NaOH 0,5M cần dùng hết 11ml. Gía trị của a là:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "0,275", IsAnswer = true },
           new ListAnswer { Value = "0,265", IsAnswer = false },
           new ListAnswer { Value = "0,11", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("4bf74338-43a1-495c-ba6a-8d4b4aa431ab"),
    },
    new Question
    {
        Id = Guid.Parse("1abf63a6-2a63-4b91-bd36-856c13309419"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Trong phòng thí nghiệm, người ta sử dụng 3 loại nucleotit cấu tạo nên ARN để tổng hợp 1 phân tử mARN nhân tạo. Phân tử mARN này chỉ có thể thực hiện được dịch mã khi 3 loại nucleotit được sử dụng là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "U, G và X", IsAnswer = false },
           new ListAnswer { Value = "G, A và X", IsAnswer = false },
           new ListAnswer { Value = "G, A và U", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("533446a5-2f4c-4618-a441-f02bad78e322"),
    },
    new Question
    {
        Id = Guid.Parse("7af0247b-a9fe-48e0-aa2f-eb7b31dcd698"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Ở các loài sinh vật lưỡng bội, số nhóm gen liên kết ở mỗi loài bằng số",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "tính trạng của loài", IsAnswer = false },
           new ListAnswer { Value = "NST trong bộ lưỡng bội của loài", IsAnswer = false },
           new ListAnswer { Value = "NST trong bộ đơn bội của loài", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("f0a45c6c-be92-4c73-829e-907591c7694a"),
    },
    new Question
    {
        Id = Guid.Parse("58aca4f0-7ef3-4d69-828b-35d19e42cace"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Trong 1 quần thể giao phối, nhận định nào dưới đây là đúng?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Tần số tương đối của các alen trong 1gen nào đó là không đặc trưng cho từng quần thể.", IsAnswer = false },
           new ListAnswer { Value = "Tần số tương đối của các alen trong 1gen nào đó là đặc trưng cho từng quần thể.", IsAnswer = false },
           new ListAnswer { Value = "Tần số tương đối của các kiểu gen có tính đặc trưng cho từng quần thể.", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("0546ebd3-376e-4246-bdb3-9ae20e6f253c"),
    },
    new Question
    {
        Id = Guid.Parse("67077697-1769-4658-b9ce-e443180e6ff4"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Quy trình tạo ra những tế bào hoặc sinh vật có gen bị biến đổi hoặc có thêm gen mới, từ đó tạo ra các cơ thể với những đặc điểm mới được gọi là:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "công nghệ vi sinh vật", IsAnswer = false },
           new ListAnswer { Value = "công nghệ gen", IsAnswer = true },
           new ListAnswer { Value = "công nghệ tế bào", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("45b651e7-9e76-42d0-b996-aeb00ec00d3f"),
    },
    new Question
    {
        Id = Guid.Parse("cf13aa13-1104-4b55-bc06-bef52a8dcdb3"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Di truyền y học là ngành khoa học vận dụng những hiểu biết về Di truyền học người vào y học",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "để điều trị trong 1 số trường hợp bệnh lí", IsAnswer = false },
           new ListAnswer { Value = "giúp cho việc giải thích, chẩn đoán, phòng ngừa, hạn chế các bệnh tật di truyền và điều trị trong 1 số trường hợp bệnh lí.", IsAnswer = true },
           new ListAnswer { Value = "để giải thích, chẩn đoán các tật, bệnh di truyền", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("4881c89c-4995-4833-a00c-90bac688b8c4"),
    },
    new Question
    {
        Id = Guid.Parse("75a4aef4-0914-4509-a778-149c8c18edce"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Mỗi loài giao phối là một tổ chức tự nhiên, có tính toàn vẹn là do cách li",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "di truyền", IsAnswer = false },
           new ListAnswer { Value = "sinh sản", IsAnswer = true },
           new ListAnswer { Value = "sinh thái", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("b2a7a480-c0e9-424a-a3cf-e35ed4f7e794"),
    },
    new Question
    {
        Id = Guid.Parse("188c4fda-2283-4ab1-8eae-e1f9db22a2b0"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Sự phát sinh, phát triển của sự sống trên Trái Đất lần lượt trải qua các giai đoạn:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Tiến hóa hóa học – tiến hóa tiền sinh học - tiến hóa sinh học", IsAnswer = true },
           new ListAnswer { Value = "Tiến hóa hóa học – tiến hóa sinh học.", IsAnswer = false },
           new ListAnswer { Value = "Tiến hóa sinh học – tiến hóa hóa học – tiến hóa tiền sinh học.", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("03699ee1-aa9b-4695-8593-8112a5b7145f"),
    },
    new Question
    {
        Id = Guid.Parse("e7d454dc-e07b-4d56-bfc0-c33b4455192d"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Dấu hiệu nào không phải là đặc trưng của quần thể?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "độ đa dạng", IsAnswer = true },
           new ListAnswer { Value = "tỉ lệ đực – cái", IsAnswer = false },
           new ListAnswer { Value = "mật độ", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("c444dd00-cde1-43b3-9761-ea0eca9553e9"),
    },
    new Question
    {
        Id = Guid.Parse("733909fe-c214-4d72-b6fc-f4c8e176f842"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hiện tượng khống chế sinh học đã",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "đảm bảo cân bằng sinh thái trong quần xã", IsAnswer = true },
           new ListAnswer { Value = "làm cho một loài bị tiêu diệt", IsAnswer = false },
           new ListAnswer { Value = "mất cân bằng trong quần xã", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("49d712a6-e7ca-4252-a430-308f954047ff"),
    },
    new Question
    {
        Id = Guid.Parse("51c0e4fa-7565-4230-9dd6-cd40f4667ccc"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hệ sinh thái tự nhiên có cấu trúc ổn định và hoàn chỉnh vì",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "có nhiều chuỗi và lưới thức ăn", IsAnswer = false },
           new ListAnswer { Value = "có sự đa dạng sinh học", IsAnswer = true },
           new ListAnswer { Value = "có cấu trúc lớn nhất", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("356135ae-0bc9-4560-af03-191995168919"),
    },
    new Question
    {
        Id = Guid.Parse("3848919c-ba2f-41f3-8c50-176275dd76cb"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Năm 1977, Việt Nam trở thành thành viên thứ mấy của Liên hợp quốc?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Thành viên thứ 148", IsAnswer = false },
           new ListAnswer { Value = "Thành viên thứ 149", IsAnswer = true },
           new ListAnswer { Value = "Thành viên thứ 147", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("c5470d64-b50b-447c-8d89-fc5b9bf338d3"),
    },
    new Question
    {
        Id = Guid.Parse("cbdea889-463d-4ecc-bf8f-f05467f1fc19"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Kế hoạch 5 năm (1946-1950) của Liên Xô được tiến hành trong thời gian bao lâu?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "1 năm 3 tháng", IsAnswer = false },
           new ListAnswer { Value = "4 năm 3 tháng", IsAnswer = true },
           new ListAnswer { Value = "9 tháng", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("bffb16de-cbfc-4a26-8e27-370225aa09aa"),
    },
    new Question
    {
        Id = Guid.Parse("75eeeaf3-5d75-48e4-aa8b-f18f4fbe81eb"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Sự kiện Nenxơn Manđêla trở thành tổng thống Nam Phi (1994) đánh dấu",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "sự chấm dứt hoàn toàn chủ nghĩa phân biệt chủng tộc ở Nam Phi.", IsAnswer = true },
           new ListAnswer { Value = "sự sụp đổ hoàn toàn của chủ nghĩa thực dân cũ trên thế giới.", IsAnswer = false },
           new ListAnswer { Value = "sự thắng lợi của phong trào giải phóng dân tộc ở châu Phi.", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("c20ee29b-c548-4a55-9f5c-2c78113b445e"),
    },
    new Question
    {
        Id = Guid.Parse("de226c30-025a-4f46-b071-fc76cbfc5ff5"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hậu quả của Chiến tranh thế giới thứ hai (1939-1945) để lại đã làm cho nền kinh tế Tây Âu trở nên",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Phát triển mạnh mẽ", IsAnswer = false },
           new ListAnswer { Value = "Phát triển chậm", IsAnswer = false },
           new ListAnswer { Value = "Kiệt quệ", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("5054a03a-17d9-4ba1-b33c-fef16aa2ffc0"),
    },
    new Question
    {
        Id = Guid.Parse("f1854eb1-754b-4488-9d4a-088c008c5cf0"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Sau chiến tranh thế giới thứ hai, quan hệ giữa Mĩ và Liên Xô đã có sự chuyển biến như thế nào?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Hợp tác với nhau trong việc giải quyết nhiều vấn đề quốc tế lớn", IsAnswer = false },
           new ListAnswer { Value = "Từ đồng minh trong chiến tranh chuyển sang đối đầu và đi đến tình trạng chiến tranh lạnh.", IsAnswer = true },
           new ListAnswer { Value = "Chuyển từ đối đầu sang đối thoại, thực hiện hợp tác trên nhiều lĩnh vực", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("b4f8ba38-e4f6-4fa9-a49a-18e74322e133"),
    },
    new Question
    {
        Id = Guid.Parse("a294a985-9bdb-4eee-b593-837776db1553"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Thực dân Pháp tiến hành cuộc khai thác thuộc địa lần thứ hai ở Đông Dương (1919 - 1929) khi",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Thế giới tư bản đang lâm vào khủng hoảng thừa", IsAnswer = false },
           new ListAnswer { Value = "Cuộc chiến tranh thế giới thứ nhất kết thúc.", IsAnswer = true },
           new ListAnswer { Value = "Kinh tế các nước tư bản đang trên đà phát triển", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("9654577c-a684-4ec7-ac30-fd49386482a7"),
    },
    new Question
    {
        Id = Guid.Parse("9cd5e3c3-056e-48ea-948c-707e2fb4efb3"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hình thức mặt trận được thành lập trong phong trào 1930 - 1931 là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Chỉ có liên minh công - nông.", IsAnswer = true },
           new ListAnswer { Value = "Mặt trận dân chủ Đông Dương", IsAnswer = false },
           new ListAnswer { Value = "Mặt trận nhân dân phản đế Đông Dương", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("670f0b14-435e-413f-ac27-7271ed1b87bb"),
    },
    new Question
    {
        Id = Guid.Parse("79c09f5a-9ee5-4a93-b268-05d178d43f23"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Đường lối kháng chiến chống Pháp của Đảng là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "toàn dân, toàn diện, đánh nhanh thắng nhanh, tự lực cánh sinh", IsAnswer = false },
           new ListAnswer { Value = "toàn dân, toàn diện, trường kì, chỉ dựa vào sức lực bản thân", IsAnswer = false },
           new ListAnswer { Value = "toàn dân, toàn diện, trường kì, tự lực cánh sinh và tranh thủ sự ủng hộ quốc tế", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("596c886d-ae82-4b7e-9d88-7f185f57778e"),
    },
    new Question
    {
        Id = Guid.Parse("8e9f36cb-54eb-48d4-b5c9-d7cbaf1f744c"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Chiến tranh cục bộ khác Chiến tranh đặc biệt ở điểm nào ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Chiến tranh cục bộ sử dụng vũ khí và phương tiện chiến tranh do Mĩ cung cấp", IsAnswer = false },
           new ListAnswer { Value = "Chiến tranh cục bộ là hình thức chiến tranh của chủ nghĩa thực dân mới", IsAnswer = false },
           new ListAnswer { Value = "Chiến tranh cục bộ chủ yếu được tiến hành bằng lực lượng quân viễn chinh Mĩ", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("1649f0c1-8557-4c2a-99a8-b4ffde8e7bbe"),
    },
    new Question
    {
        Id = Guid.Parse("b0a4c2fe-9e68-438b-898f-e2161826d722"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hội nghị lần thứ 24 Ban Chấp hành Trung ương Đảng (9/1975) đã",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "đề ra nhiệm vụ thống nhất đất nước về mặt nhà nước", IsAnswer = true },
           new ListAnswer { Value = "đề ra đường lối đổi mới đất nước đi lên chủ nghĩa xã hội", IsAnswer = false },
           new ListAnswer { Value = "đề ra chủ trương giải phóng miền Nam, thống nhất đất nước", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("179ea3f8-4ed8-4151-b360-7dbe9f033e0c"),
    },
    new Question
    {
        Id = Guid.Parse("e3ddebdc-b041-4f1a-9c32-1f287ee75c08"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Đường biên giới dài nhất trên đất liền nước ta là với",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Lào", IsAnswer = true },
           new ListAnswer { Value = "Campuchia", IsAnswer = false },
           new ListAnswer { Value = "Trung Quốc", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("0bca65ca-2ce4-4923-a507-43e381130c9f"),
    },
    new Question
    {
        Id = Guid.Parse("e6b2ed05-8c88-47ce-8cb7-ab7038ac93c5"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hạn chế lớn nhất của nguồn lao động nước ta là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Trình độ chuyên môn, kĩ thuật chưa cao", IsAnswer = true },
           new ListAnswer { Value = "Thể lực chưa thật tốt", IsAnswer = false },
           new ListAnswer { Value = "Còn thiếu kĩ năng làm việc", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("370bb392-410b-46b5-9971-2df9a53e7670"),
    },
    new Question
    {
        Id = Guid.Parse("17a5ca0d-c4da-4554-a714-e0b9badada82"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Trong cơ cấu lao động có việc làm ở nước ta phân theo trình độ chuyên môn kĩ thuật, thành phần chiếm tỉ trọng cao nhất là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Chưa qua đào tạo", IsAnswer = true },
           new ListAnswer { Value = "Cao đẳng, địa học, trên đại học", IsAnswer = false },
           new ListAnswer { Value = "Có chứng chỉ sơ cấp", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("370bb392-410b-46b5-9971-2df9a53e7670"),
    },
    new Question
    {
        Id = Guid.Parse("9fd1ad12-cebb-4450-bfeb-c8618d924b75"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Từ năm 1990 đến năm 2005, trong ngành trồng trọt hai nhóm cây trồng có tốc độ tăng trưởng giá trị sản xuất cao nhất là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Cây rau đạu, cây ăn quả", IsAnswer = false },
           new ListAnswer { Value = "Cây công nghiệp, cây rau đậu", IsAnswer = true },
           new ListAnswer { Value = "Cây lương thực, cây ăn quả", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("0c83b2dc-372d-4687-8a51-c35b5e51c991"),
    },
    new Question
    {
        Id = Guid.Parse("d9cf5916-5fe2-424b-bf05-83d07b07fce1"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Để tăng sản lượng lương thực ở nước ta, biện pháp quan trọng nhất là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Mở rộng diện tích đất trồng cây lương thực", IsAnswer = false },
           new ListAnswer { Value = "Đẩy mạnh thâm canh, tăng năng suất", IsAnswer = true },
           new ListAnswer { Value = "Kêu gọi đầu tư nước ngoài vào sản xuất nông nghiệp", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("0c83b2dc-372d-4687-8a51-c35b5e51c991"),
    },
    new Question
    {
        Id = Guid.Parse("b57da0ee-c931-43bc-8709-1eaf851a6aec"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Tỉnh nào sau đây không thuộc vùng Tây Nguyên ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Kon Tum", IsAnswer = false },
           new ListAnswer { Value = "Đồng Nai", IsAnswer = true },
           new ListAnswer { Value = "Gia Lai", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("020841e0-c4da-4010-9556-e67ad0b7d816"),
    },
    new Question
    {
        Id = Guid.Parse("75e9556c-f0b0-4b3b-b2d1-c34f19e7491b"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Tây Nguyên có vị trí đặc biệt về mặt quốc phòng vì",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Giáp với vùng Duyên hải Nam Trung Bộ", IsAnswer = false },
           new ListAnswer { Value = "Rất gần với TP Hồ Chí Minh", IsAnswer = false },
           new ListAnswer { Value = "Có biên giới kéo dài với Lào và Campuchia", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("020841e0-c4da-4010-9556-e67ad0b7d816"),
    },
    new Question
    {
        Id = Guid.Parse("b6477824-5d8c-4b82-a725-b765000c7830"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Các cây công nghiệp lâu năm có giá trị kinh tê cao của nước ta là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Cà phê, cao su, mía", IsAnswer = false },
           new ListAnswer { Value = "Hồ tiêu, bông, chè", IsAnswer = false },
           new ListAnswer { Value = "Cà phê, điều, chè", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("a9902cb8-b044-4e0e-8e22-9ec0337dea6b"),
    },
    new Question
    {
        Id = Guid.Parse("7a03d7ad-eeef-48ae-b732-6833bcf3a044"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Một trong những đặc điểm cơ bản của điểm công nghiệp ở nước ta là:",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Do Chính phủ thành lập", IsAnswer = false },
           new ListAnswer { Value = "Có các ngành chuyên môn hóa", IsAnswer = false },
           new ListAnswer { Value = "Thường hình thành ở các tỉnh miền núi", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("adda106e-b8ba-4bfb-bdea-e2fcd916137c"),
    },
    new Question
    {
        Id = Guid.Parse("be7ac590-66b0-4c93-81e5-6b893c386844"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Một trong những di sản thiên nhiên thế giới ở nước ta là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Vịnh Hạ Long", IsAnswer = true },
           new ListAnswer { Value = "Thánh địa Mỹ Sơn", IsAnswer = false },
           new ListAnswer { Value = "Phố cổ Hội An", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("e992f53a-b7b0-4a1e-9b81-36ed3328c6e1"),
    },
    new Question
    {
        Id = Guid.Parse("5c780d44-d323-48ad-9cc4-8f03b61c6678"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Pháp luật được Nhà nước ban hành và bảo đảm thực hiện bằng",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Ý chí của Nhà nước", IsAnswer = false },
           new ListAnswer { Value = "Quyền lực Nhà nước", IsAnswer = true },
           new ListAnswer { Value = "Dư luận xã hội.", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("28bbe836-de18-4d85-9555-a47d95f85a5f"),
    },
    new Question
    {
        Id = Guid.Parse("7ef701de-6f5d-4059-9bfe-596bddfbeaac"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Nội dung nào không phải là hình thức thực hiện pháp luật?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Thi hành pháp luật.", IsAnswer = false },
           new ListAnswer { Value = "Phổ biến pháp luật.", IsAnswer = true },
           new ListAnswer { Value = "Sử dụng pháp luật", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("6880b25a-40ec-410e-b332-e6616982e206"),
    },
    new Question
    {
        Id = Guid.Parse("6d8d0d49-2fcb-438b-b0f7-16496a737a6c"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Đảm bảo quyền bình đẳng của công dân trước pháp luật là trách nhiệm của",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Nhà nước và công dân", IsAnswer = false },
           new ListAnswer { Value = "Nhà nước và xã hội.", IsAnswer = true },
           new ListAnswer { Value = "Nhà nước và công dân", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("898a8245-bff3-4cbb-9ac4-8692cc84d2e1"),
    },
    new Question
    {
        Id = Guid.Parse("9c51879f-c0d9-48ac-8b12-4815d5b44974"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Nội dung nào sau đây không thuộc về quan hệ bình đẳng trong hôn nhân và gia đình?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Bình đẳng giữa chú bác và cháu", IsAnswer = true },
           new ListAnswer { Value = "Bình đẳng giữa anh, chị, em.", IsAnswer = false },
           new ListAnswer { Value = "Bình đẳng giữa cha mẹ và con", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("fa93b3f0-ed5f-4b84-af34-6cc4f5b3831c"),
    },
    new Question
    {
        Id = Guid.Parse("043ce175-c8d9-421e-a4fe-c56bec91b704"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Các dân tộc có quyền dùng tiếng nói, chữ viết của mình là nội dung bình đẳng về",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Văn hóa", IsAnswer = true },
           new ListAnswer { Value = "Xã hội", IsAnswer = false },
           new ListAnswer { Value = "Chính trị", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("b80adb23-18d3-4b5e-9fc0-2fa25d47dd49"),
    },
    new Question
    {
        Id = Guid.Parse("b4134c55-0411-45c9-9d97-89d8ab11bfc4"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Đánh người là hành vi xâm phạm đến quyền nào sau đây của công dân?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Quyền được pháp luật bảo hộ về tính mạng, sức khỏe", IsAnswer = true },
           new ListAnswer { Value = "Quyền bất khả xâm phạm về thân thể", IsAnswer = false },
           new ListAnswer { Value = "Quyền được sống và được tôn trọng của công dân", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("c2b93d0f-1032-45c9-94bf-a53e2c5aa3be"),
    },
    new Question
    {
        Id = Guid.Parse("99b02765-cceb-4bc3-a28e-705d20737154"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Quyền bầu cử và quyền ứng cử là các quyền dân chủ cơ bản của công dân trong lĩnh vực",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Văn hóa", IsAnswer = false },
           new ListAnswer { Value = "Kinh tế", IsAnswer = false },
           new ListAnswer { Value = "Chính trị", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("0faf3a0d-3e02-41f1-890c-51610de8e8cb"),
    },
    new Question
    {
        Id = Guid.Parse("45d36bbc-a0fb-44bb-9d53-0a957348a341"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Công dân có thể học bất cứ ngành, nghề nào phù hợp với",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Mục đích, yêu cầu của bản thân và điều kiện của gia đình", IsAnswer = false },
           new ListAnswer { Value = "Mục đích, sở thích, điều kiện và đam mê của mình", IsAnswer = false },
           new ListAnswer { Value = "Năng khiếu, khả năng, sở thích và điều kiện của mình", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("7b39b159-82aa-48a9-9dd1-6d0b435f50be"),
    },
    new Question
    {
        Id = Guid.Parse("72606ff9-6cb1-4466-a9c1-f2143e68f4cf"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Củng cố quốc phòng, bảo vệ an ninh quốc gia là nhiệm vụ của toàn dân mà nòng cốt là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Công an nhân dân", IsAnswer = false },
           new ListAnswer { Value = "Quân đội nhân dân", IsAnswer = false },
           new ListAnswer { Value = "Quân đội nhân dân và Công an nhân dân", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("72c5c4ca-e8f8-4b02-97cd-4666ab7ccd44"),
    },
    new Question
    {
        Id = Guid.Parse("bc590d16-97bb-4ccf-8245-584675f0cd60"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Cơ sở pháp lí để thực hiện có hiệu quả quá trình hợp tác là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Hiến pháp", IsAnswer = false },
           new ListAnswer { Value = "Pháp luật", IsAnswer = true },
           new ListAnswer { Value = "Luật", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("86f6ce80-f585-47d8-b3f0-c2f1d6cd084a"),
    },
    new Question
    {
        Id = Guid.Parse("65fce6a4-b1fc-4cea-a040-5fd0cf7e0958"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Cho hàm số y = - x^3 + 3x^2 - 3x + 1, mệnh đề nào sau đây là đúng?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Hàm số luôn nghịch biến.", IsAnswer = true },
           new ListAnswer { Value = "Hàm số luôn đồng biến", IsAnswer = false },
           new ListAnswer { Value = "Hàm số đạt cực đại tại x = 1", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("77963fa2-2bc8-4273-929b-835f0efd31f6"),
    },
    new Question
    {
        Id = Guid.Parse("5801238f-e7f7-4335-8e99-f92728cc6d59"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Ngày 27 tháng 3 năm 2016 bà Mai gửi tiết kiệm vào ngân hàng số tiền 100 triệu đồng với hình thức lãi kép và lãi suất 6,8% một năm. Bà Mai dự tính đến ngày 27 tháng 3 năm 2020 thì rút hết tiền ra để lo công chuyện. Hỏi bà sẽ rút được bao nhiêu tiền (làm tròn kết quả đến hàng nghìn) ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "38949000 đồng", IsAnswer = false },
           new ListAnswer { Value = "31259000 đồng", IsAnswer = false },
           new ListAnswer { Value = "30102000 đồng", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e"),
    },
    new Question
    {
        Id = Guid.Parse("208c8070-f3bd-4caa-8a72-fcfc805a2756"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Dân số Việt Nam năm 2015 là 91,71 triệu người. Giả sử trong 5 năm tỉ lệ tăng dân số là không đổi. Hỏi tỉ lệ này có thể nhận giá trị tối đa là bao nhiêu để dân số Việt Nam năm 2020 không vượt quá 96,5 triệu người (làm tròn kết quả đến phần chục nghìn) ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "1,08%", IsAnswer = false },
           new ListAnswer { Value = "1,02%", IsAnswer = true },
           new ListAnswer { Value = "0,91%", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("f9c20b6d-10ed-4d8c-bb76-f418113c4a8e"),
    },
    new Question
    {
        Id = Guid.Parse("7d2ef0c9-bbcc-4313-a9b5-45e7ea76bdd0"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Trong các mệnh đề sau mệnh đề nào nhận giá trị đúng?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Hàm số y = 1/x có nguyên hàm trên (-∞; +∞).", IsAnswer = true },
           new ListAnswer { Value = "Hàm số y = |x| có nguyên hàm trên (-∞;+∞).", IsAnswer = false },
           new ListAnswer { Value = "1/x + C là họ nguyên hàm của ln⁡x trên (0;+∞).", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("56057547-6172-4967-a8c3-e8e9afc494ac"),
    },
    new Question
    {
        Id = Guid.Parse("9bf57282-2764-4111-a657-eb17760c070a"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Hàm số nào dưới đây không phải là một nguyên hàm của f(x)=2x-sin⁡2x ?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "x^2 + (1/2).cos⁡2x", IsAnswer = false },
           new ListAnswer { Value = "x^2 + cos^2 x", IsAnswer = false },
           new ListAnswer { Value = "x^2 + cos⁡2x", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("56057547-6172-4967-a8c3-e8e9afc494ac"),
    },
    new Question
    {
        Id = Guid.Parse("7c142395-2435-4549-a4cf-d483179cd48a"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Giá trị lớn nhất của hàm số f(x) = -x^2 + 4 là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "0", IsAnswer = false },
           new ListAnswer { Value = "2", IsAnswer = false },
           new ListAnswer { Value = "4", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("468f1e58-d93b-46db-b4df-4a173513befb"),
    },
    new Question
    {
        Id = Guid.Parse("32cea7fb-b070-4f98-a1af-e5d7fdb494e2"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Tìm các số thực x, y sao cho (x – 2y) + (x + y + 4).i = (2x + y) + 2yi.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "x = -3, y = 1", IsAnswer = true },
           new ListAnswer { Value = "x = -3, y = -1", IsAnswer = false },
           new ListAnswer { Value = "x = 3, y = 1 ", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("74d64b16-20e1-4f3c-9f54-facf73dd9740"),
    },
    new Question
    {
        Id = Guid.Parse("30746883-03fd-47aa-99eb-d9c0c3c39f93"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Phần thực của số phức z = -i là",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "1", IsAnswer = false },
           new ListAnswer { Value = "0", IsAnswer = true },
           new ListAnswer { Value = "-i", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("74d64b16-20e1-4f3c-9f54-facf73dd9740"),
    },
    new Question
    {
        Id = Guid.Parse("37c803d8-be52-48c9-af20-aa586878cd6f"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Với giá trị nào của m, hàm số y = (x - m)^3 - 3x đạt cực tiểu tại điểm có hoành độ x = 0?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "-1", IsAnswer = true },
           new ListAnswer { Value = "1", IsAnswer = false },
           new ListAnswer { Value = "Không tồn tại", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("7612387b-bd34-4ff2-bc52-535d32fe45ec"),
    },
    new Question
    {
        Id = Guid.Parse("479690de-b69a-4652-b0db-49545b76a26e"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Một công ti quản lí chuẩn bị xây dựng một khu chung cư mới. Họ tính toán nếu tòa nhà có x căn hộ thì chi phí bảo trì của tòa nhà là: C(x) = 4000 - 14x + 0,04x^2. Khu đất của họ có thể xây được tòa nhà chứa tối đa 300 căn hộ. Hỏi họ nên xây dựng tòa nhà có bao nhiêu căn hộ để chi phí bảo trì của tòa nhà là nhỏ nhất?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "150", IsAnswer = false },
           new ListAnswer { Value = "175", IsAnswer = true },
           new ListAnswer { Value = "225", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("e83b8918-df70-4d49-8ddc-adcdac56a057"),
    },
    new Question
    {
        Id = Guid.Parse("22dd9c89-34df-47bf-9c84-fd4f64ba32f6"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Quan niệm về độc giả của văn học Việt Nam sau năm 1975 có gì mới?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Độc giả là những đối tượng để tuyên truyền, giác ngộ", IsAnswer = false },
           new ListAnswer { Value = "Độc giả là người mua hàng, nhà văn là người bán hàng", IsAnswer = false },
           new ListAnswer { Value = "Độc giả là những người bạn để giao lưu, dối thoại một cách bình đẳng", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
    },
     new Question
     {
         Id = Guid.Parse("12d2f288-dedb-414d-a7ca-3a7e4d527495"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Giai đoạn 1945-1975, văn học Việt Nam đã tìm đến những hình thức nghệ thuật nào để phù hợp với nhu cầu thẩm mĩ của đại chúng",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Mới mẻ đối với nhân dân, được thể hiện bằng một ngôn ngữ nghệ thuật tinh tế, trau chuốt.", IsAnswer = false },
           new ListAnswer { Value = "Quen thuộc đối với nhân dân, được thể hiện bằng một ngôn ngữ bình dị, trong sáng, dễ hiểu", IsAnswer = true },
           new ListAnswer { Value = "Dễ dãi đối với nhân dân, được thể hiện bằng ngôn ngữ bình dân, suồng sã", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
     new Question
     {
         Id = Guid.Parse("bc0e149e-20a5-4216-ba3f-245bb9e3e929"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Ý nào sau đây không đúng khi nói về đặc điểm khuynh hướng lãng mạn được thể hiện như thế nào trong văn học giai đoạn 1945-1975",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Là khuynh hướng tràn đầy mơ ước, hướng tới tương lai", IsAnswer = false },
           new ListAnswer { Value = "Khẳng định lí tưởng của cuộc sống mới, vẻ đẹp của con người mới", IsAnswer = false },
           new ListAnswer { Value = "Các tác phẩm đều có kết thúc có hậu, được hưởng cuộc sống hạnh phúc, no ấm", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
      new Question
      {
          Id = Guid.Parse("1bd17c9e-5fd5-4f20-8af6-8b25ccffddcd"),
          Content = JsonSerializer.Serialize(new Content
          {
              Question = "Văn học Việt Nam giai đoạn 1945-1975 không mắc phải hạn chế nào?",
              ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Một số cây bút chạy theo thị hiếu thấp kém của 1 bộ phận công chúng, biến sáng tác văn học mọt thứ hàng hóa để câu khách.", IsAnswer = true },
           new ListAnswer { Value = "Yêu cầu về phẩm chất nghệ thuật của tác phẩm nhiều khi bị hạ thấp", IsAnswer = false },
           new ListAnswer { Value = "Cá tính, phong cách riêng của nhà văn chưa được phát huy mạnh mẽ", IsAnswer = false }
        },

          }),
          TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
      },
     new Question
     {
         Id = Guid.Parse("9edf87ce-ec37-4e8c-ba8c-79c800ad5d4e"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Từ năm 1929 đến năm 1936, Phạm Văn Đồng bị thực dân Pháp bắt, kết án tù và bị đi đày ở:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Quảng Ngãi", IsAnswer = false },
           new ListAnswer { Value = "Côn Đảo", IsAnswer = true },
           new ListAnswer { Value = "Tam Đảo", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
      new Question
    {
        Id = Guid.Parse("acd7e283-1edb-40f9-bd36-2228d69a1819"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Truyện thơ nào sau đây không phải của Nguyễn Đình Chiểu?",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Dương Từ - Hà Mậu", IsAnswer = false },
           new ListAnswer { Value = "Sơ kính tân trang", IsAnswer = true },
           new ListAnswer { Value = "Ngư Tiều Y thuật vấn đáp", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
    },
     new Question
     {
         Id = Guid.Parse("a1c0ea7c-58b7-4083-b9cc-e67423275a58"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Giá trị nội dung của tác phẩm : Nguyễn Đình Chiểu, ngôi sao sáng trong văn nghệ của dân tộc là:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Tác giả hết lời ca ngợi Nguyễn Đình Chiểu, một người trọn đời dùng cây bút làm vũ khí chiến đấu cho dân, cho nước, một ngôi sao sáng trong nền văn nghệ của dân tộc Việt Nam.", IsAnswer = false },
           new ListAnswer { Value = "Làm sáng tỏ mối liên hệ khăng khít giữa thơ văn của Nguyễn Đình Chiểu với hoàn cảnh của Tổ quốc lúc bấy giờ và với thời đại hiện nay.", IsAnswer = false },
           new ListAnswer { Value = "Cả hai đáp án trên đều đúng", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
     new Question
     {
         Id = Guid.Parse("4cfbb40a-4b1d-472f-b6ed-f621ff2e9f58"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Tác phẩm được chia thành mấy phần?",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Hai phần", IsAnswer = false },
           new ListAnswer { Value = "Ba phần", IsAnswer = true },
           new ListAnswer { Value = "Năm phần", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
     new Question
     {
         Id = Guid.Parse("f4e17213-cfe6-4fd4-8f04-6ad9127c8ef7"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Tác phẩm được viết theo thể loại nào?",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Văn nghị luận", IsAnswer = true },
           new ListAnswer { Value = "Văn xuôi", IsAnswer = false },
           new ListAnswer { Value = "Văn chính luận", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
     new Question
     {
         Id = Guid.Parse("b6cb7448-a377-42c8-ae85-75c3f65fea88"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Đặc điểm nào sau đây không phải là đặc trưng của phong cách ngôn ngữ khoa học?",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Tính khái quát trừu tượng", IsAnswer = false },
           new ListAnswer { Value = "Tính khách quan, phi cá thể", IsAnswer = false },
           new ListAnswer { Value = "Tính truyền cảm thuyết phục", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("7c506348-0444-4c91-ad50-15b952135294"),
     },
    new Question
    {
        Id = Guid.Parse("cc760427-bedc-4728-bf27-96bf043db449"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "You are old enough to take …… for what you have done.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "responsibility", IsAnswer = true },
           new ListAnswer { Value = "responsible", IsAnswer = false },
           new ListAnswer { Value = "responsibly ", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("33fcdca5-2b11-49cf-8824-f91d45c86dd2"),
    },
    new Question
    {
        Id = Guid.Parse("760f9cce-e1bf-415f-9432-71cc69c9af85"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "The USA is a country of high youth unemployment.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "We find high youth unemployment a problem in the USA", IsAnswer = false },
           new ListAnswer { Value = "High youth unemployment is found in the USA", IsAnswer = true },
           new ListAnswer { Value = "The USA is a country of young people", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("4f830591-4a73-4976-9a63-dcebb53ca4c2"),
    },
    new Question
    {
        Id = Guid.Parse("cca4025d-9a6e-4f2a-8759-2dfac58c6a6a"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "A water polo team …… seven players, six swimmers and a goalie.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "composes", IsAnswer = false },
           new ListAnswer { Value = "consists of", IsAnswer = true },
           new ListAnswer { Value = "includes of ", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("9a4f72df-ee78-4455-8b67-76b3a26ce507"),
    },
    new Question
    {
        Id = Guid.Parse("3e62a92e-e050-42b4-8d13-4194ecac2f42"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "The Spirit of …… 22nd SEA GAMES was solidarity, co-operation for peace and development.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "the", IsAnswer = true },
           new ListAnswer { Value = "a", IsAnswer = false },
           new ListAnswer { Value = "an", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("838f30bd-d9cf-4ea6-8825-fe729c55e5af"),
    },
    new Question
    {
        Id = Guid.Parse("8d199b0b-e54f-41d1-b266-32da75652d57"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "One advantage of living in a/an …… is to strengthen relationships between young children and adults.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "nuclear family", IsAnswer = false },
           new ListAnswer { Value = "nuclear house", IsAnswer = false },
           new ListAnswer { Value = "extended family", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("2addcd1a-4f32-42dc-bf9f-637fd7769c3c"),
    },
    new Question
    {
        Id = Guid.Parse("a28c8be3-ab1e-4fc5-a641-0360d3f9f6e0"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "He is one of the most ……… bosses I have ever worked with. He behaves rudely to not only me but also others in the staff.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "thoughtful", IsAnswer = false },
           new ListAnswer { Value = "impolite", IsAnswer = true },
           new ListAnswer { Value = "communicative", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("64722757-eb15-4891-abbc-bd870caae9f1"),
    },
    new Question
    {
        Id = Guid.Parse("bd235389-9531-44ac-b2ae-707c820c939b"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "My teacher always gives me advice …… suitable career in the future.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "to choose", IsAnswer = true },
           new ListAnswer { Value = "choosing", IsAnswer = false },
           new ListAnswer { Value = "not to choose", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("451fa872-1960-4c03-a3df-374dbfc81c83"),
    },
    new Question
    {
        Id = Guid.Parse("c96a6886-0210-4059-85c0-43b32ce23730"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "A good leader should not be conservative, but rather …… to new ideas.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "receptive", IsAnswer = true },
           new ListAnswer { Value = "permissive", IsAnswer = false },
           new ListAnswer { Value = "applicable", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("55469d88-1e76-4678-ad62-e3d233602dfa"),
    },
    new Question
    {
        Id = Guid.Parse("956ad23f-9c28-42d7-aeea-764dca133c20"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "…… a desert requires a lot of careful preparation and survival skills.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Visiting", IsAnswer = false },
           new ListAnswer { Value = "Explore", IsAnswer = false },
           new ListAnswer { Value = "Exploring ", IsAnswer = true }
        },

        }),
        TopicId = Guid.Parse("7294fa9f-78c5-49f3-a9fa-c99feb6d6a5c"),
    },
    new Question
    {
        Id = Guid.Parse("2688e556-145c-4f09-8dbc-8e475b30f79e"),
        Content = JsonSerializer.Serialize(new Content
        {
            Question = "Reading …… an integral role in enhancing knowledge and relaxing.",
            ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "holds ", IsAnswer = false },
           new ListAnswer { Value = "plays", IsAnswer = true },
           new ListAnswer { Value = "takes", IsAnswer = false }
        },

        }),
        TopicId = Guid.Parse("470c4063-38b5-437c-9820-2a29a470c708"),
    }





     //new Question
     //{
     //    Id = Guid.Parse("85e5d51b-16c7-4d0d-8f40-766a6a902698"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "How many continents are there?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "7", IsAnswer = true },
     //           new ListAnswer { Value = "5", IsAnswer = false },
     //           new ListAnswer { Value = "6", IsAnswer = false }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //},
     //new Question
     //{
     //    Id = Guid.Parse("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "When was the Declaration of Independence signed?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "1776-07-04", IsAnswer = true },
     //           new ListAnswer { Value = "1789-09-25", IsAnswer = false },
     //           new ListAnswer { Value = "1800-03-12", IsAnswer = false }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //},
     //new Question
     //{
     //    Id = Guid.Parse("21eb2451-53ac-44f6-9a6c-751d394a8936"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "Which cities are in the United Kingdom?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "London", IsAnswer = true },
     //           new ListAnswer { Value = "Manchester", IsAnswer = false },
     //           new ListAnswer { Value = "Edinburgh", IsAnswer = true }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //}
 );

        }

        private class ListAnswer
        {
            public string Value { get; set; }
            public bool IsAnswer { get; set; }
        }

        private class Content
        {
            public string Question { get; set; }
            public List<ListAnswer> ListAnswer { get; set; }
        }

    }


}
