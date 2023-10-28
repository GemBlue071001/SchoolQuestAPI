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
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();
            builder.HasMany(x => x.Majors)
                   .WithOne(x => x.Department)
                   .HasForeignKey(x => x.DepartmentId);
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
                },
                new Department()
                {
                    Id = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    Code = "SP",
                    Name = "Sư phạm",
                    Description = "Các ngành sư phạm",
                    RequiredScore = 25
                },
                new Department()
                {
                    Id = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    Code = "TK",
                    Name = "Thiết kế",
                    Description = "Các ngành thiết kế/nghệ thuật",
                    RequiredScore = 22
                }
                );
        }

    }
}
