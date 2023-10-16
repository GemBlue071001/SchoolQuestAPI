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
                }
                );
        }

    }
}
