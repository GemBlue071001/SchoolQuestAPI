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
    public class UniversityConfiguration : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasData(
                new University()
                {
                    Id = Guid.Parse("f84e78ea-4426-4728-a3f6-c41c3ed22072"),
                    Name = "Đại học FPT",
                    Code = "FPT",
                    Description = "Trường đại học tư thục hàng đầu Việt Nam về công nghệ thông tin và truyền thông.",
                },
                new University()
                {
                    Id = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec"),
                    Name = "Đại học kinh tế TPHCM",
                    Code = "UEH",
                    Description = "Trường đại học công lập đào tạo về kinh tế, tài chính, ngân hàng hàng đầu tại Việt Nam",
                },
                new University()
                {
                    Id = Guid.Parse("0e7c3b01-d954-4986-9d9d-f48127433211"),
                    Name = "Đại học Sư phạm Thành phố Hồ Chí Minh",
                    Code = "HCMUE",
                    Description = "Trường đại học công lập đào tạo sư phạm lớn nhất Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("b629e405-9aca-4c19-bbe3-f4a50d9cca62"),
                    Name = "Đại học Y Dược Thành phố Hồ Chí Minh",
                    Code = "UMP",
                    Description = "Trường đại học công lập đào tạo về y dược lớn nhất Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("cf30b5ef-1a8f-472f-af90-337a5cee4c16"),
                    Name = "Đại học Kiến trúc Thành phố Hồ Chí Minh",
                    Code = "UAH",
                    Description = "Trường đại học công lập đào tạo về kiến trúc hàng đầu Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46"),
                    Name = "Trường Đại học Bách Khoa TP.Hồ Chí Minh",
                    Code = "QSB",
                    Description = "Trường đại học đầu ngành về lĩnh vực kỹ thuật ở miền Nam Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("b9647f7b-e9a0-4636-80f9-45364c8b04a9"),
                    Name = "Trường Đại học Công nghệ Thông tin TP.HCM",
                    Code = "QSC",
                    Description = "Trường đại học công lập đào tạo về công nghệ thông tin và truyền thông"
                },
                new University()
                {
                    Id = Guid.Parse("54812146-c3a3-41e1-9b46-c24a2a0a2aa1"),
                    Name = "Trường Đại học Khoa học Tự nhiên TPHCM",
                    Code = "QST",
                    Description = "Trường đại học đầu ngành về đào tạo, nghiên cứu khoa học cơ bản, khoa học công nghệ và ứng dụng ở miền Nam Việt Nam."
                },
                new University()
                {
                    Id = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d"),
                    Name = "Trường Đại học Khoa học Xã hội và Nhân văn TP.HCM",
                    Code = "QSX",
                    Description = "Trường là trung tâm nghiên cứu, đào tạo trong lĩnh vực khoa học xã hội và nhân văn lớn nhất miền Nam."
                },
                new University()
                {
                    Id = Guid.Parse("314a233c-a95f-4026-992a-75a708d07838"),
                    Name = "Đại học Kiến trúc Thành phố Hồ Chí Minh",
                    Code = "QSK",
                    Description = "Trường đại học đào tạo và nghiên cứu khối ngành kinh tế, kinh doanh quản lý và luật hàng đầu Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23"),
                    Name = "Trường Đại học Quốc tế",
                    Code = "QSQ",
                    Description = "Trường đại học công lập đa ngành đầu tiên tại Việt Nam giảng dạy hoàn toàn tiếng Anh"
                },
                new University()
                {
                    Id = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f"),
                    Name = "Trường Đại học Tôn Đức Thắng",
                    Code = "DTT",
                    Description = "Trường đại học công lập đầu tiên tại Việt Nam có cơ sở vật chất và điều kiện giảng dạy được xếp hạng quốc tế"
                },
                new University()
                {
                    Id = Guid.Parse("3d6888a4-17b8-4173-9f12-7ce55983d1cc"),
                    Name = "Trường Đại học Việt Đức",
                    Code = "VGU",
                    Description = "Trường đại học công lập của Việt Nam được xây dựng trên cơ sở quan hệ đối tác chặt chẽ với CHLB Đức"
                },
                new University()
                {
                    Id = Guid.Parse("059779f5-c84c-455a-85d0-798ca039ba72"),
                    Name = "Trường Đại học VinUni",
                    Code = "VIN",
                    Description = "Trường đại học tư thục phi lợi nhuận được thành lập bởi Tập đoàn Vingroup – tập đoàn tư nhân lớn nhất Việt Nam"
                },
                new University()
                {
                    Id = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c"),
                    Name = "Trường Đại học Công nghiệp Thực phẩm",
                    Code = "DCT",
                    Description = "Trường đại học đạt chuẩn kiểm định chất lượng giáo dục với chương trình đào tạo đa hệ, đa ngành"
                },
                 new University()
                 {
                     Id = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11"),
                     Name = "Trường Đại học Ngân hàng TP.HCM",
                     Code = "NHS",
                     Description = "Trường đại học công lập trực thuộc Ngân hàng Nhà nước Việt Nam được thành lập từ ngày 16/12/1976."
                 },
                  new University()
                  {
                      Id = Guid.Parse("3fdd5b92-3e52-4434-8f21-176732be0cc1"),
                      Name = "Trường Đại học Cảnh sát Nhân dân",
                      Code = "CSS",
                      Description = "trường đại học công lập trực thuộc Bộ Công an tại Việt Nam đào tạo trình độ và phẩm chất cán bộ Cảnh sát nhân dân ở bậc đại học và sau đại học"
                  },
                   new University()
                   {
                       Id = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190"),
                       Name = "Trường Đại học Mở",
                       Code = "MBS",
                       Description = "có nhiệm vụ đào tạo đại học và sau đại học, với các hình thức đào tạo chính quy và giáo dục thường xuyên, đào tạo các điểm vệ tinh"
                   },
                    new University()
                    {
                        Id = Guid.Parse("8ae6dc6f-c859-4fb9-b038-366470876d80"),
                        Name = "Trường Đại học Mỹ thuật TP.HCM",
                        Code = "MTS",
                        Description = " Trường đại học chuyên ngành về đào tạo nhóm ngành mỹ thuật tại Việt Nam."
                    },
                     new University()
                     {
                         Id = Guid.Parse("1d5312be-a745-4a4a-b1df-41abd3dc01e8"),
                         Name = "Trường Đại học Thể dục Thể thao TP. HCM",
                         Code = "TDS",
                         Description = "trường đại học với mô hình kết hợp giữa đào tạo và huấn luyện"
                     },
                      new University()
                      {
                          Id = Guid.Parse("b8620337-894a-4339-926e-dff2cd9f09ba"),
                          Name = "Trường Đại học Văn hóa TP.HCM",
                          Code = "VHS",
                          Description = "Trường đại học đào tạo và nghiên cứu khoa học các lĩnh vực: văn hóa, nghệ thuật, thông tin và du lịch."
                      }
                );
        }
    }
}
