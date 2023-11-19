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
                    Name = "Công nghệ thông tin",
                    Description = "các ngành về máy tính",
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
                },
                new Department()
                {
                    Id = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    Code = "LAW",
                    Name = "Luật",
                    Description = "Các ngành về luật",
                    RequiredScore = 23
                },
                new Department()
                {
                    Id = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    Code = "TT",
                    Name = "Truyền Thông",
                    Description = "Các ngành về báo chí/truyền thông",
                    RequiredScore = 24
                },
                new Department()
                {
                    Id = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    Code = "NN",
                    Name = "Ngôn Ngữ",
                    Description = "Các ngành về ngôn ngữ",
                    RequiredScore = 22
                }
                new Department()
                {
                    Id = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    Code = "LAW",
                    Name = "Luật",
                    Description = "Các ngành về luật",
                    RequiredScore = 23
                },
                new Department()
                {
                    Id = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    Code = "TT",
                    Name = "Truyền Thông",
                    Description = "Các ngành về báo chí/truyền thông",
                    RequiredScore = 24
                },
                new Department()
                {
                    Id = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    Code = "NN",
                    Name = "Ngôn Ngữ",
                    Description = "Các ngành về ngôn ngữ",
                    RequiredScore = 22
                }
                );
        }

    }
}
