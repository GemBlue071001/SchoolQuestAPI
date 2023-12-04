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
                    Description = "Các ngành sư phạm-giáo dục",
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
                },
                new Department()
                {
                    Id = Guid.Parse("d2322472-e7af-47e7-ab8f-eba6e8e7baad"),
                    Code = "DM",
                    Name = "Dệt May",
                    Description = "Các ngành về dệt may",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    Code = "KT",
                    Name = "Kỹ Thuật",
                    Description = "Các ngành về kỹ thuật",
                    RequiredScore = 26
                },
                new Department()
                {
                    Id = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498"),
                    Code = "NK",
                    Name = "Năng Khiếu",
                    Description = "Các ngành về năng khiếu",
                    RequiredScore = 27
                },
                new Department()
                {
                    Id = Guid.Parse("6c7f8637-25d3-4284-a4e5-3aa20ceda1f4"),
                    Code = "CT",
                    Name = "Chính trị",
                    Description = "Các ngành về chính trị",
                    RequiredScore = 30
                }, new Department()
                {
                    Id = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                    Code = "QL",
                    Name = "Quản lý-Lưu trữ thông tin",
                    Description = "Các ngành về quản lý-lưu trữ thông tin",
                    RequiredScore = 25
                },
                new Department()
                {
                    Id = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"),
                    Code = "MT",
                    Name = "Môi trường",
                    Description = "Các ngành về môi trường",
                    RequiredScore = 26
                },
                new Department()
                {
                    Id = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"),
                    Code = "TH",
                    Name = "Toán học",
                    Description = "Các ngành về toán học",
                    RequiredScore = 25
                },
                new Department()
                {
                    Id = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    Code = "XD",
                    Name = "Xây Dựng",
                    Description = "Các ngành về xây dựng-kiến trúc",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2"),
                    Code = "TP",
                    Name = "Thực phẩm",
                    Description = "Các ngành về thực phẩm",
                    RequiredScore = 20
                },
                new Department()
                {
                    Id = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9"),
                    Code = "DL",
                    Name = "Du lịch",
                    Description = "Các ngành về du lịch",
                    RequiredScore = 25
                },
                new Department()
                {
                    Id = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a"),
                    Code = "CA",
                    Name = "Công an- quân đội",
                    Description = "Các ngành về công an- quân đội",
                    RequiredScore = 20
                },
                 new Department()
                 {
                     Id = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1"),
                     Code = "CK",
                     Name = "Cơ khí",
                     Description = "Các ngành về cơ khí",
                     RequiredScore = 23
                 },
                  new Department()
                  {
                      Id = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d"),
                      Code = "HD",
                      Name = "Hải dương",
                      Description = "Các ngành về hải dương học",
                      RequiredScore = 21
                  },
                   new Department()
                   {
                       Id = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                       Code = "KD",
                       Name = "Kinh doanh",
                       Description = "Các ngành về kinh doanh-marketing",
                       RequiredScore = 22
                   },
                    new Department()
                    {
                        Id = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                        Code = "TC",
                        Name = "Tài chính",
                        Description = "Các ngành về tài chính-ngân hàng",
                        RequiredScore = 26
                    },
                     new Department()
                     {
                         Id = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                         Code = "LG",
                         Name = "Logistics",
                         Description = "Các ngành về logistics",
                         RequiredScore = 27
                     });
        }

    }
}
