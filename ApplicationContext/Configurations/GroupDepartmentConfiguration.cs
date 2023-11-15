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
    public class GroupDepartmentConfiguration : IEntityTypeConfiguration<GroupDepartment>
    {
        public void Configure(EntityTypeBuilder<GroupDepartment> builder)
        {
            builder.HasOne(o => o.Group)
               .WithMany(o => o.GroupDepartments)
               .HasForeignKey(o => o.GroupId);

            builder.HasOne(o => o.Department)
                .WithMany(o => o.GroupDepartments)
                .HasForeignKey(o => o.DepartmentId);

            builder.HasKey(sc => new { sc.DepartmentId, sc.GroupId });
            builder.HasData(
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    GroupId = Guid.Parse("632ba05a-9ed9-4a00-9ac8-e1c642919806")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    GroupId = Guid.Parse("632ba05a-9ed9-4a00-9ac8-e1c642919806")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    GroupId = Guid.Parse("20bbb66d-3117-4050-ae30-4caf85831530")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    GroupId = Guid.Parse("b8de514a-7bba-4b8b-bae1-fc36c07ed52b")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new GroupDepartment()
                {
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                }
              );  
        }
    }
}
