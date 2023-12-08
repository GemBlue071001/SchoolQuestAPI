using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationContext.Configurations
{
    public class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();
            builder.HasData(

            new Major()
                {
                    Id = Guid.Parse("c731c3f5-a1d2-4b8f-bd7f-2d57fa0acb0f"),
                    MajorName = "Kỹ thuật phần mềm",
                    Code = "KTPM",
                    Description = "Học về thiết kế phần mềm",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("63da08f2-e70f-488d-8d5a-eb24063697e5"),
                    MajorName = "Khoa học máy tính",
                    Code = "KHMT",
                    Description = "Nghiên cứu lý thuyết và thuật toán máy tính",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("2b72f32c-5d96-4b5d-ae68-597bbeead505"),
                    MajorName = "An toàn thông tin",
                    Code = "ATTT",
                    Description = "Nghiên cứu và bảo mật hệ thống thông tin",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("f5e68a91-1e8e-4ef7-9f0d-6da923dc5611"),
                    MajorName = "Trí tuệ nhân tạo",
                    Code = "TTNT",
                    Description = "Nghiên cứu và ứng dụng trí tuệ nhân tạo",
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013")
                },
                new Major()
                {
                    Id = Guid.Parse("ce320b5a-4eac-4436-92ef-90b985aec10f"),
                    MajorName = "Makerting",
                    Code = "MKT",
                    Description = "Makerting",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("1b320b9a-3eac-4336-92ef-90b985aec101"),
                    MajorName = "Quản trị kinh doanh",
                    Code = "QTKD",
                    Description = "Ngành học về quản lý và điều hành các hoạt động trong doanh nghiệp",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("2c430b7a-5eac-4536-93ef-80b985aec202"),
                    MajorName = "Thương mại điện tử",
                    Code = "TMĐT",
                    Description = "Ngành học về kinh doanh trực tuyến sử dụng nền tảng công nghệ thông tin với sự hỗ trợ của Internet để thực hiện các giao dịch mua bán, trao đổi, thanh toán trực tuyến.",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("3d550b8a-6eac-4636-92ef-70b985aec303"),
                    MajorName = "Kinh doanh quốc tế",
                    Code = "KDQT",
                    Description = "Ngành học về kinh doanh và thương mại giữa các quốc gia",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("4e661b9a-7eac-4736-92ef-60b985aec404"),
                    MajorName = "Kế toán",
                    Code = "KT",
                    Description = "Ngành học về công tác ghi chép, phân tích và kiểm tra các nghiệp vụ tài chính",
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97")
                },
                new Major()
                {
                    Id = Guid.Parse("1a111b2a-1eac-4132-92ef-90b985ae0101"),
                    MajorName = "Y khoa",
                    Code = "YK",
                    Description = "Ngành học về chẩn đoán, điều trị bệnh và nâng cao sức khỏe",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("2b222b3a-2eac-4233-93ef-80b985ae0202"),
                    MajorName = "Dược học",
                    Code = "DH",
                    Description = "Ngành học về nghiên cứu, phát triển và sản xuất thuốc",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("3c333b4a-3eac-4333-94ef-70b985ae0303"),
                    MajorName = "Điều dưỡng",
                    Code = "DD",
                    Description = "Ngành học về chăm sóc người bệnh tại các cơ sở y tế",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("4d444b5a-4eac-4434-95ef-60b985ae0404"),
                    MajorName = "Răng-Hàm-Mặt",
                    Code = "RHM",
                    Description = "Ngành học về phục hình, nha khoa và chỉnh nha",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("5e555b6a-5eac-4535-96ef-50b985ae0505"),
                    MajorName = "Y học cổ truyền",
                    Code = "YHCT",
                    Description = "Ngành học về phương pháp chữa bệnh bằng y học cổ truyền",
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                },
                new Major()
                {
                    Id = Guid.Parse("a52a3b15-3a21-44cd-8d74-b4c6751e2963"),
                    MajorName = "Sư phạm toán học",
                    Code = "SPTH",
                    Description = "Đào tạo giáo viên toán học",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },
                new Major()
                {
                    Id = Guid.Parse("1dcd3794-f8d5-4d4e-9788-74a3b9426421"),
                    MajorName = "Sư phạm ngữ văn",
                    Code = "SPNV",
                    Description = "Đào tạo giáo viên ngữ văn",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },

                new Major()
                {
                    Id = Guid.Parse("cf3913ca-fa92-4f90-a55b-93725cae4b32"),
                    MajorName = "Sư phạm tiếng Anh",
                    Code = "SPTA",
                    Description = "Đào tạo giáo viên tiếng Anh",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },            
                new Major()
                {
                    Id = Guid.Parse("7ea9448b-e686-49e2-a0df-c425bd44f3ea"),
                    MajorName = "Quản lý giáo dục",
                    Code = "QLGD",
                    Description = "Đào tạo quản lý ngành giáo dục",
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78")
                },
                new Major()
                {
                    Id = Guid.Parse("387c472b-1f7d-4655-838c-80982b8f9e24"),
                    MajorName = "Thiết kế đồ họa",
                    Code = "TKĐH",
                    Description = "Thiết kế các sản phẩm truyền thông đồ họa",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("b629fa64-5dea-4129-9d59-f48c265bca62"),
                    MajorName = "Thiết kế thời trang",
                    Code = "TKTT",
                    Description = "Thiết kế các sản phẩm thời trang",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("44929c3d-dd91-4405-9d4e-f4be315b7fbb"),
                    MajorName = "Thiết kế nội thất",
                    Code = "TKNT",
                    Description = "Thiết kế các sản phẩm nội thất",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("17d5462c-3a8a-4e93-b5e6-69d36186577e"),
                    MajorName = "Điêu khắc",
                    Code = "DK",
                    Description = "Đào tạo nghệ thuật điêu khắc",
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                },
                new Major()
                {
                    Id = Guid.Parse("c74e4f33-a078-4219-8f69-7398435aff4d"),
                    MajorName = "Luật kinh tế",
                    Code = "LKT",
                    Description = "Ngành học đào tạo kỹ năng về luật kinh tế",
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b")
                },
                 new Major()
                 {
                     Id = Guid.Parse("31b92a5b-8354-450f-a023-6e7d74349ab4"),
                     MajorName = "Luật Hiến pháp và luật hành chính",
                     Code = "LHP",
                     Description = "Ngành học đào tạo kỹ năng về luật Hiến pháp và luật hành chính",
                     DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b")
                 },
                  new Major()
                  {
                      Id = Guid.Parse("3c25899c-f1a5-48d0-9276-03ef9fd60a24"),
                      MajorName = "Luật dân sự và tố tụng dân sự",
                      Code = "LDS",
                      Description = "Ngành học đào tạo kỹ năng về luật dân sự và tố tụng dân sự",
                      DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b")
                  },
                   new Major()
                   {
                       Id = Guid.Parse("71bbd6ba-141b-4990-b2fa-28d59e026c75"),
                       MajorName = "Luật hình sự và tố tụng hình sự",
                       Code = "LHS",
                       Description = "Ngành học đào tạo kỹ năng về luật dân sự và tố tụng dân sự",
                       DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b")
                   },
                    new Major()
                    {
                        Id = Guid.Parse("c0d46118-35a4-4a25-982b-584781b45ca8"),
                        MajorName = "Báo chí",
                        Code = "BC",
                        Description = "Ngành học đào tạo kỹ năng về lĩnh vực báo chí",
                        DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b")
                    },
                     new Major()
                     {
                         Id = Guid.Parse("19d935fe-5772-48a6-98bd-782450be775a"),
                         MajorName = "Quan hệ công chúng",
                         Code = "QHCC",
                         Description = "Ngành học đào tạo kỹ năng về lĩnh vực quan hệ công chúng",
                         DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b")
                     },
                      new Major()
                      {
                          Id = Guid.Parse("dc05a4d6-7019-424c-bc3b-118c7aa1272b"),
                          MajorName = "Truyền thông đa phương tiện",
                          Code = "TTĐPT",
                          Description = "Ngành học đào tạo kỹ năng về lĩnh vực truyền thông đa phương tiện",
                          DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b")
                      },
                       new Major()
                       {
                           Id = Guid.Parse("07951ef0-d8df-47a3-82c2-c16dd3a16a3f"),
                           MajorName = "Truyền thông quốc tế",
                           Code = "TTQT",
                           Description = "Ngành học đào tạo kỹ năng về truyền thông quốc tế",
                           DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b")
                       },
                        new Major()
                        {
                            Id = Guid.Parse("0035306f-de5e-4c60-9e55-4f2282e7dda9"),
                            MajorName = "Ngôn ngữ Anh",
                            Code = "NNA",
                            Description = "Ngành học đào tạo kỹ năng về ngôn ngữ Anh",
                            DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146")
                        },
                         new Major()
                         {
                             Id = Guid.Parse("0ab02d77-61fb-46ea-8340-7236296c4022"),
                             MajorName = "Ngôn ngữ Nhật",
                             Code = "NNN",
                             Description = "Ngành học đào tạo kỹ năng về ngôn ngữ Nhật",
                             DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146")
                         },
                          new Major()
                          {
                              Id = Guid.Parse("317f2de4-b76e-4d4b-8b0a-94166493623e"),
                              MajorName = "Tiếng Việt và văn hóa Việt Nam",
                              Code = "VHVN",
                              Description = "Ngành học đào tạo kỹ năng về tiếng Việt và văn hóa Việt Nam",
                              DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146")
                          },
                           new Major()
                           {
                               Id = Guid.Parse("42308b7d-8d80-4077-a960-433b4eb6ec7a"),
                               MajorName = "Quản lý văn hóa",
                               Code = "QLVH",
                               Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản lý văn hóa",
                               DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146")
                           },
                            new Major()
                            {
                                Id = Guid.Parse("0c7c4a30-d3d1-48ea-9526-1b31fe4c0103"),
                                MajorName = "Công nghệ dệt,may",
                                Code = "CNDM",
                                Description = "Ngành học đào tạo kỹ năng về công nghệ dệt,may",
                                DepartmentId = Guid.Parse("d2322472-e7af-47e7-ab8f-eba6e8e7baad")
                            },
                             new Major()
                             {
                                 Id = Guid.Parse("92913faa-9607-43da-b4aa-b6269cad9d12"),
                                 MajorName = "Công nghệ da giày",
                                 Code = "CNDG",
                                 Description = "Ngành học đào tạo kỹ năng về công nghệ da giày",
                                 DepartmentId = Guid.Parse("d2322472-e7af-47e7-ab8f-eba6e8e7baad")
                             },
                              new Major()
                              {
                                  Id = Guid.Parse("524954ba-d75f-4cd7-a2af-acf23d383a05"),
                                  MajorName = "Công nghệ vật liệu dệt, may",
                                  Code = "CNVL",
                                  Description = "Ngành học đào tạo kỹ năng về công nghệ vật liệu dệt, may",
                                  DepartmentId = Guid.Parse("d2322472-e7af-47e7-ab8f-eba6e8e7baad")
                              },
                               new Major()
                               {
                                   Id = Guid.Parse("bc1e9f85-8404-46eb-a6e6-bab6f898566a"),
                                   MajorName = "Kỹ thuật điện",
                                   Code = "KTĐ",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật điện",
                                   DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("667330de-e435-45d1-ab72-4d6504cbba14"),
                                   MajorName = "Kỹ thuật hạt nhân",
                                   Code = "KTHN",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật hạt nhân",
                                   DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("ac30fa55-823c-4f49-aa01-98a15822af37"),
                                   MajorName = "Kỹ thuật công nghiệp",
                                   Code = "KTCN",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật công nghiệp",
                                   DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("8136a6cf-c815-4d9e-9888-399d76d7c8e1"),
                                   MajorName = "Kỹ thuật hàng không",
                                   Code = "KTHK",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật hàng không",
                                   DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("0af0e064-0927-45b7-b9cc-8e8a49996c1c"),
                                   MajorName = "Hội họa",
                                   Code = "HH",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực hội họa",
                                   DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("d6f2b6ab-0f91-4ffc-ade1-65b934718b68"),
                                   MajorName = "Sư phạm mỹ thuật",
                                   Code = "SPMT",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực sư phạm mỹ thuật",
                                   DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("335f8cf8-94b0-47bd-ba70-eb2aaf0c07b1"),
                                   MajorName = "Thanh nhạc",
                                   Code = "TN",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thanh nhạc",
                                   DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("8c2d3663-1012-4a24-809d-bb12e6ed5d23"),
                                   MajorName = "Sư phạm âm nhạc",
                                   Code = "SPAN",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực sư phạm âm nhạc",
                                   DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("4c97f72e-0560-449e-a32d-7fac374b5bbf"),
                                   MajorName = "Quản lý nhà nước",
                                   Code = "QLNN",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản lý nhà nước",
                                   DepartmentId = Guid.Parse("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("7e623947-4413-48ab-a0e1-c797405f5f10"),
                                   MajorName = "Công tác xã hội",
                                   Code = "CTXH",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực công tác xã hội",
                                   DepartmentId = Guid.Parse("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("b430ab31-8762-4f35-906f-989f981f61b7"),
                                   MajorName = "Quốc tế học",
                                   Code = "QTH",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực quốc tế học",
                                   DepartmentId = Guid.Parse("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("fa88d41b-f627-4e5e-af66-19ead35fb082"),
                                   MajorName = "Xây dựng Đảng và chính quyền nhà nước",
                                   Code = "XDĐ",
                                   Description = "Ngành học đào tạo kỹ năng về xây dựng Đảng và chính quyền nhà nước",
                                   DepartmentId = Guid.Parse("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("e812ac28-8fa5-4c08-8d45-e40b6018056f"),
                                   MajorName = "Thông tin - thư viện",
                                   Code = "TTTV",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực thông tin - thư viện",
                                   DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("9186a969-d349-4cc8-866b-352a5056418c"),
                                   MajorName = "Bảo tàng học",
                                   Code = "BTH",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực bảo tàng học",
                                   DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("2332343e-e798-496b-9ea5-841bdc10552a"),
                                   MajorName = "Khoa học thư viện",
                                   Code = "KHTV",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực khoa học thư viện",
                                   DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("ad437f7f-3242-4270-997f-a0a6f8a0c9b2"),
                                   MajorName = "Quản lý thông tin",
                                   Code = "QLTT",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản lý thông tin",
                                   DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441")
                               },
                               new Major()
                               {
                                   Id = Guid.Parse("74757d60-d6c9-4cf3-a657-8f01bf8c42c7"),
                                   MajorName = "Quản lý tài nguyên và môi trường",
                                   Code = "QLTNMT",
                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản lý tài nguyên và môi trường",
                                   DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d")
                               },
                                new Major()
                                {
                                    Id = Guid.Parse("282b4ad3-d00d-4275-97ae-7480635636e8"),
                                    MajorName = "Địa lý tự nhiên",
                                    Code = "ĐLTN",
                                    Description = "Ngành học đào tạo kỹ năng về lĩnh vực địa lý tự nhiên",
                                    DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d")
                                },
                                 new Major()
                                 {
                                     Id = Guid.Parse("6d3f0b5b-f3f1-444b-a642-e83b527d7c3a"),
                                     MajorName = "Khoa học môi trường",
                                     Code = "KHMT",
                                     Description = "Ngành học đào tạo kỹ năng về lĩnh vực khoa học môi trường",
                                     DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d")
                                 },
                                  new Major()
                                  {
                                      Id = Guid.Parse("5ee2fae8-eae3-495a-95b6-303307cb596c"),
                                      MajorName = "Kinh tế tài nguyên thiên nhiên",
                                      Code = "KTTNTN",
                                      Description = "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế tài nguyên thiên nhiên",
                                      DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d")
                                  },
                                   new Major()
                                   {
                                       Id = Guid.Parse("8ae7996c-505b-4343-9df7-caebf86c9e60"),
                                       MajorName = "Toán học",
                                       Code = "TH",
                                       Description = "Ngành học đào tạo kỹ năng về toán học",
                                       DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457")
                                   },
                                    new Major()
                                    {
                                        Id = Guid.Parse("c2a1d4aa-eb5a-4850-84c2-2b4cd2db77e0"),
                                        MajorName = "Toán ứng dụng",
                                        Code = "TUD",
                                        Description = "Ngành học đào tạo kỹ năng về toán ứng dụng",
                                        DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457")
                                    },
                                     new Major()
                                     {
                                         Id = Guid.Parse("9e39d8ed-8447-45e6-aa07-9aa76e5c6c49"),
                                         MajorName = "Toán-tin",
                                         Code = "TT",
                                         Description = "Ngành học đào tạo kỹ năng về toán-tin",
                                         DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457")
                                     },
                                      new Major()
                                      {
                                          Id = Guid.Parse("825d82f4-470c-4eb5-bf4f-6106b682260e"),
                                          MajorName = "Thống kê",
                                          Code = "TK",
                                          Description = "Ngành học đào tạo kỹ năng về thống kê",
                                          DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457")
                                      },
                                       new Major()
                                       {
                                           Id = Guid.Parse("0e9599e3-0279-4ac6-8af5-eb14b3f1e584"),
                                           MajorName = "Kỹ thuật xây dựng",
                                           Code = "KTXD",
                                           Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật xây dựng",
                                           DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9")
                                       },
                                        new Major()
                                        {
                                            Id = Guid.Parse("56306665-f58b-4188-8613-578b0fe470ed"),
                                            MajorName = "Kiến trúc",
                                            Code = "KT",
                                            Description = "Ngành học đào tạo kỹ năng về lĩnh vực kiến trúc",
                                            DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9")
                                        },
                                         new Major()
                                         {
                                             Id = Guid.Parse("86ac7343-b4cd-4dbb-946f-81db8c117f87"),
                                             MajorName = "Đô thị học",
                                             Code = "ĐTH",
                                             Description = "Ngành học đào tạo kỹ năng về lĩnh vực đô thị học",
                                             DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9")
                                         },
                                          new Major()
                                          {
                                              Id = Guid.Parse("dd5be2ec-dd31-41ad-8674-d870f7b13ee8"),
                                              MajorName = "Kinh tế xây dựng",
                                              Code = "KNTXD",
                                              Description = "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế xây dựng",
                                              DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9")
                                          },
                                           new Major()
                                           {
                                               Id = Guid.Parse("bfe5f392-c582-4915-9360-3d90134295d5"),
                                               MajorName = "Công nghệ thực phẩm",
                                               Code = "CNTP",
                                               Description = "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ thực phẩm",
                                               DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2")
                                           },
                                            new Major()
                                            {
                                                Id = Guid.Parse("e026cfb6-343f-4af1-a15d-c840165a09b4"),
                                                MajorName = "Kỹ thuật thực phẩm",
                                                Code = "KTTP",
                                                Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật thực phẩm",
                                                DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2")
                                            },
                                             new Major()
                                             {
                                                 Id = Guid.Parse("da699b0b-c55d-417f-93d8-e9571e712189"),
                                                 MajorName = "Công nghệ chế biến thủy sản",
                                                 Code = "CNCBTS",
                                                 Description = "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ chế biến thủy sản",
                                                 DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2")
                                             },
                                              new Major()
                                              {
                                                  Id = Guid.Parse("8ff0d04b-da37-4345-853c-71b66a2d94eb"),
                                                  MajorName = "Công nghệ sau thu hoạch",
                                                  Code = "CNSTH",
                                                  Description = "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ sau thu hoạch",
                                                  DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2")
                                              },
                                               new Major()
                                               {
                                                   Id = Guid.Parse("97c46aeb-da40-47de-9a6f-52254c3f5eb8"),
                                                   MajorName = "Quản trị khách sạn",
                                                   Code = "QTKS",
                                                   Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản trị khách sạn",
                                                   DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9")
                                               },
                                                new Major()
                                                {
                                                    Id = Guid.Parse("995cb552-a1a7-40c9-9032-d374f11f3ed4"),
                                                    MajorName = "Quản trị dịch vụ du lịch và lữ hành",
                                                    Code = "QTDVDL",
                                                    Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản trị dịch vụ du lịch và lữ hành",
                                                    DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9")
                                                },
                                                 new Major()
                                                 {
                                                     Id = Guid.Parse("2793f8f1-98fb-4b13-b5e1-04085ae78762"),
                                                     MajorName = "Du lịch địa chất",
                                                     Code = "DLĐC",
                                                     Description = "Ngành học đào tạo kỹ năng về lĩnh vực du lịch địa chất",
                                                     DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9")
                                                 },
                                                  new Major()
                                                  {
                                                      Id = Guid.Parse("9f9cdb58-040c-472e-9f6a-576a9ee87fb4"),
                                                      MajorName = "Du lịch sinh thái",
                                                      Code = "DLST",
                                                      Description = "Ngành học đào tạo kỹ năng về lĩnh vực du lịch sinh thái",
                                                      DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9")
                                                  },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("8a085ad7-3a1e-4cfd-8be9-c1bac0c36517"),
                                                       MajorName = "Điều tra trinh sát",
                                                       Code = "ĐTTS",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực điều tra trinh sát",
                                                       DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("91f89343-44ab-47a9-964b-15437a9678a1"),
                                                       MajorName = "Điều tra hình sự",
                                                       Code = "ĐTHS",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực điều tra hình sự",
                                                       DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("6090009b-8534-4200-a83b-f544d9be8732"),
                                                       MajorName = "Quân sự cơ sở",
                                                       Code = "QSCS",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực quân sự cơ sở",
                                                       DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("bc19438f-ee7e-4e59-ad83-e7879c0a54e5"),
                                                       MajorName = "Chỉ huy tham mưu đặc công",
                                                       Code = "CHTMĐC",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực chỉ huy tham mưu đặc công",
                                                       DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("dc482730-bf16-4558-b1b6-8a7f1b8b855d"),
                                                       MajorName = "Kỹ thuật cơ khí",
                                                       Code = "KTCK",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực kỹ thuật cơ khí",
                                                       DepartmentId = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("0d036fb3-5ff7-4b63-86db-4342a62f886e"),
                                                       MajorName = "Công nghệ chế tạo máy",
                                                       Code = "CNCTM",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ chế tạo máy",
                                                       DepartmentId = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("b0377a76-981e-4af2-a0d8-d7ae1f723e7b"),
                                                       MajorName = "Bảo dưỡng công nghiệp",
                                                       Code = "BDCN",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực bảo dưỡng công nghiệp",
                                                       DepartmentId = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("d05498a2-0502-4a9d-a535-d548db92000a"),
                                                       MajorName = "Công nghệ vật liệu",
                                                       Code = "CNVL",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực công nghệ vật liệu",
                                                       DepartmentId = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("748bbfcd-20b9-4be4-8ec5-522afcc5caf4"),
                                                       MajorName = "Quản lý biển",
                                                       Code = "QLB",
                                                       Description = "Ngành học đào tạo kỹ năng về quản lý biển",
                                                       DepartmentId = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("5f246722-c823-466e-a024-254ba25d1750"),
                                                       MajorName = "Hải dương học",
                                                       Code = "HDH",
                                                       Description = "Ngành học đào tạo kỹ năng về hải dương học",
                                                       DepartmentId = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("348cdef7-2ec8-4814-883b-c41218128a3c"),
                                                       MajorName = "Thủy văn học",
                                                       Code = "TVH",
                                                       Description = "Ngành học đào tạo kỹ năng về thủy văn học",
                                                       DepartmentId = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("9e518c87-c522-4fa7-abe1-a318ceec4e09"),
                                                       MajorName = "Khí tượng học",
                                                       Code = "KTH",
                                                       Description = "Ngành học đào tạo kỹ năng về khí tượng học",
                                                       DepartmentId = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("2b49fa02-7c48-45ab-9f81-4605ff991bd4"),
                                                       MajorName = "Quản lý chuỗi cung ứng",
                                                       Code = "QLCCU",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản lý chuỗi cung ứng",
                                                       DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("ca49e2d3-f880-4a4f-9e60-04c57660d730"),
                                                       MajorName = "Quản trị chất lượng",
                                                       Code = "QTCL",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản trị chất lượng",
                                                       DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("66e52181-c48e-4fcc-a68e-421a02a9443e"),
                                                       MajorName = "Thương mại",
                                                       Code = "TM",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực thương mại",
                                                       DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("ad84e105-1ca7-401e-abd7-fdc5d2e40999"),
                                                       MajorName = "Quản trị doanh nghiệp",
                                                       Code = "QTDN",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực quản trị doanh nghiệp",
                                                       DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("1569cd2c-deef-4d74-bdcd-f785f52b465d"),
                                                       MajorName = "Tài chính doanh nghiệp",
                                                       Code = "TCDN",
                                                       Description = "Ngành học đào tạo kỹ năng về tài chính doanh nghiệp",
                                                       DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("bc73983d-1bb7-447b-be96-c4fc7b653e5c"),
                                                       MajorName = "Ngân hàng",
                                                       Code = "NH",
                                                       Description = "Ngành học đào tạo kỹ năng về ngân hàng",
                                                       DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("99c6c608-54b0-44b5-b018-65b506bb5398"),
                                                       MajorName = "Tài chính công",
                                                       Code = "TCC",
                                                       Description = "Ngành học đào tạo kỹ năng về tài chính công",
                                                       DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("820d7547-37d2-480a-84bf-a3cae888b55c"),
                                                       MajorName = "Thuế - Hải quan",
                                                       Code = "THQ",
                                                       Description = "Ngành học đào tạo kỹ năng về thuế - Hải quan",
                                                       DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("4989ef16-62cd-4aa1-850f-ef6a8e2b3b2c"),
                                                       MajorName = "Kinh tế vận tải",
                                                       Code = "KTVT",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực kinh tế vận tải",
                                                       DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("6b9f2a3b-e60e-45ef-b5ec-056b362cf874"),
                                                       MajorName = "Khoa học hàng hải",
                                                       Code = "KHHH",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực khoa học hàng hải",
                                                       DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("a767ae08-1162-4d9d-a6f0-e74123c4e055"),
                                                       MajorName = "Khai thác vận tải",
                                                       Code = "KTVT",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực khai thác vận tải",
                                                       DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("2445d565-594a-419b-ab0a-bcd87c2b9a2a"),
                                                       MajorName = "Logistics",
                                                       Code = "LGS",
                                                       Description = "Ngành học đào tạo kỹ năng về lĩnh vực logistics",
                                                       DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("9fff7eda-6093-4ce8-b467-f102b0f09430"),
                                                       MajorName = "Văn hóa đô thị",
                                                       Code = "VHĐT",
                                                       Description = "Ngành học đào tạo kỹ năng về văn hóa đô thị",
                                                       DepartmentId = Guid.Parse("9bf92746-e6c9-46ae-a8ba-9fa93671dcce")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("5c1310fb-b35b-4529-beb1-79664cc85fc6"),
                                                       MajorName = "Quản lý văn hóa",
                                                       Code = "QLVH",
                                                       Description = "Ngành học đào tạo kỹ năng về quản lý văn hóa",
                                                       DepartmentId = Guid.Parse("9bf92746-e6c9-46ae-a8ba-9fa93671dcce")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("d8393091-0dbd-4ab8-b18c-50ae38579ce8"),
                                                       MajorName = "Văn hóa ẩm thực",
                                                       Code = "VHAT",
                                                       Description = "Ngành học đào tạo kỹ năng về văn hóa ẩm thực",
                                                       DepartmentId = Guid.Parse("9bf92746-e6c9-46ae-a8ba-9fa93671dcce")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("fcab8031-99a2-40cb-921c-f76e7f250ab6"),
                                                       MajorName = "Văn hóa Nam bộ",
                                                       Code = "VHNB",
                                                       Description = "Ngành học đào tạo kỹ năng về văn hóa Nam bộ",
                                                       DepartmentId = Guid.Parse("9bf92746-e6c9-46ae-a8ba-9fa93671dcce")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("e10926c7-63e0-48e0-947c-060ba13d0a8e"),
                                                       MajorName = "Đạo diễn sân khấu",
                                                       Code = "ĐDSK",
                                                       Description = "Ngành học đào tạo kỹ năng về đạo diễn sân khấu",
                                                       DepartmentId = Guid.Parse("07563189-01d5-4ec1-80a6-f9c7ced12408")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("b49b3229-b46c-4821-a0f9-2ead482c2bf1"),
                                                       MajorName = "Đạo diễn điện ảnh, truyền hình",
                                                       Code = "ĐDĐATH",
                                                       Description = "Ngành học đào tạo kỹ năng về đạo diễn điện ảnh, truyền hình",
                                                       DepartmentId = Guid.Parse("07563189-01d5-4ec1-80a6-f9c7ced12408")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("0273f179-b2ae-434d-835f-6035e8b6ae52"),
                                                       MajorName = "Diễn viên kịch, điện ảnh - truyền hình",
                                                       Code = "DVKDATH",
                                                       Description = "Ngành học đào tạo kỹ năng về diễn viên kịch, điện ảnh - truyền hình",
                                                       DepartmentId = Guid.Parse("07563189-01d5-4ec1-80a6-f9c7ced12408")
                                                   },
                                                   new Major()
                                                   {
                                                       Id = Guid.Parse("2fa7fc82-948a-45bb-a33e-b37a98579b05"),
                                                       MajorName = "Quay phim",
                                                       Code = "QP",
                                                       Description = "Ngành học đào tạo kỹ năng về quay phim",
                                                       DepartmentId = Guid.Parse("07563189-01d5-4ec1-80a6-f9c7ced12408")
                                                   }
                );
        }
    }
}
