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
                }
                );
        }
    }
}
