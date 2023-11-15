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
                     Id = Guid.Parse("479425da-bd87-4ef1-8bc2-1b6c3711825d"),
                     Name = "Đại học Mở Thành phố Hồ Chí Minh",
                     Code = "MBS",
                     Description = "Trường đại học đa ngành trực thuộc Bộ Giáo dục và Đào tạo, có nhiệm vụ đào tạo đại học và sau đại học, với các hình thức đào tạo chính quy và giáo dục thường xuyên, đào tạo các điểm vệ tinh,…nhằm đáp ứng nhu cầu học tập đa dạng của xã hội, góp phần tăng cường đội ngũ cán bộ khoa học-kỹ thuật cho đất nước."
                 },
                  new University()
                  {
                      Id = Guid.Parse("90cb0c86-83e2-45ae-accd-0b74f30a19d2"),
                      Name = "Đại học Hutech",
                      Code = "DKC",
                      Description = "Trường Đại học uy tín chất lượng hàng đầu Việt Nam, đào tạo đa ngành nghề, đảm bảo thực tập, việc làm cho sinh viên theo học."
                  },
                   new University()
                   {
                       Id = Guid.Parse("de267db5-790b-4c50-a369-f50b74b80b19"),
                       Name = "Đại học HUFLIT",
                       Code = "DNT",
                       Description = "Trường đại học đào tạo tin học ngoại ngữ hàng đầu Việt Nam"
                   },
                    new University()
                    {
                        Id = Guid.Parse("1e499317-eaa4-4284-8bea-8f1c6b67021d"),
                        Name = "Đại học RMIT",
                        Code = "RMU",
                        Description = "Trường đại học toàn cầu về quản lý, công nghệ và thiết kế và là trường đại học lớn nhất của Úc."
                    },
                    new University()
                    {
                        Id = Guid.Parse("54a5a1ae-88d3-4b3d-8940-d3ed50b98ceb"),
                        Name = "Đại học Fulbright",
                        Code = "FBU",
                        Description = "Trường Đại học Fulbright Việt Nam là một trường đại học độc lập với 100% vốn đầu tư nước ngoài dưới sự tài trợ của Chính phủ Hoa Kỳ, hoạt động không vì lợi nhuận."
                    }
                );
        }
    }
}
