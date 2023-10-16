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
                    Id = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    Code = "KT",
                    Name = "Kinh tế",
                    Description = "các ngành về kinh tế",
                    RequiredScore = 22
                },
                new Department()
                {
                    Id = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    Code = "YH",
                    Name = "Y học",
                    Description = "Các ngành y dược",
                    RequiredScore = 27
                } 
                );
        }

    }
}
