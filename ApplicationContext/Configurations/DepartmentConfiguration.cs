using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace ApplicationContext.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(x => x.Majors)
                   .WithOne(x => x.Department)
                   .HasForeignKey(x => x.DepartmentId);

            //var jsonString = File.ReadAllText("../ApplicationContext/SeedData/DepartmentSeedData.json");
            //var entities = JsonSerializer.Deserialize<List<Department>>(jsonString);
            builder.HasData(
                new Department()
                {
                    Id = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    Code = "SE",
                    Name = "Cong Nghe Thong Tin",
                    Description = "lam ve may tinh",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("98b5de7d-6326-47ab-972e-9138c299f10e"),
                    Code = "SE",
                    Name = "Cong Nghe Thong Tin",
                    Description = "lam ve may tinh",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("5f68a389-ef79-4a8d-aa8e-1f6e944eb241"),
                    Code = "UI",
                    Name = "Do Hoa",
                    Description = "thiet ke giao dien web, mobile, game, content",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("b120b5a0-5eac-4836-96ef-90b9834ea88a"),
                    Code = "GM",
                    Name = "Mobile Game",
                    Description = "lam ve game tren dien thoai",
                    RequiredScore = 23
                },
                new Department ()
                {
                    Id = Guid.Parse("7c220b5a-4eac-4536-92ef-90b983fea88b"),
                    Code = "CS",
                    Name = "Computer Science",
                    Description = "Khoa học máy tính",
                    RequiredScore = 24
                },
                new Department()
                {
                    Id = Guid.Parse("9e520b5a-2eac-4336-90ef-90b985fe322d"),
                    Code = "AI",
                    Name = "Artificial Intelligence",
                    Description = "Trí tuệ nhân tạo",
                    RequiredScore = 26
                },
                new Department() 
                {
                    Id = Guid.Parse("ac120b5a-8fac-4536-95ef-90b983aea09e"),
                    Code = "IB",
                    Name = "International Business",
                    Description = "Kinh doanh quốc tế",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("ce320b5a-4eac-4436-92ef-90b985aec10f"),
                    Code = "MK",
                    Name = "Marketing",
                    Description = "Marketing",
                    RequiredScore = 23
                },
                new Department()
                {
                    Id = Guid.Parse("df520b5a-3fac-4836-91ef-90b986ced11f"),
                    Code = "BA",
                    Name = "Business Administration",
                    Description = "Quản trị kinh doanh",
                    RequiredScore = 21
                },
                new Department() 
                {
                    Id = Guid.Parse("eg620b5a-2ebc-4336-90ef-90b987bed22f"),
                    Code = "AC",
                    Name = "Accounting",
                    Description = "Kế toán",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("1f120b5a-2fac-4536-95ef-90b983aec13g"),
                    Code = "HTM",
                    Name = "Hospitality & Tourism Management",
                    Description = "Quản lý khách sạn và du lịch",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("1f120b5a-2fac-4536-95ef-90b983aec13g"),
                    Code = "HTM",
                    Name = "Hospitality & Tourism Management",
                    Description = "Quản lý khách sạn và du lịch",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("8m920b5a-2dac-4436-92ef-90b985bed1ah"),
                    Code = "PH",
                    Name = "Photography",
                    Description = "Nhiếp ảnh",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("7l820b5a-3eac-4236-94ef-90b984aeb19h"),
                    Code = "SC",
                    Name = "Sculpture",
                    Description = "Điêu khắc",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("ao520b5a-4fac-4236-90ef-90b987aeb1ch"),
                    Code = "FA",
                    Name = "Fine Arts",
                    Description = "Mỹ thuật",
                    RequiredScore = 24
                }
                );
        }

    }
}
