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
    public class UniversityDepartmentConfiguration : IEntityTypeConfiguration<UniversityDepartment>
    {
        public void Configure(EntityTypeBuilder<UniversityDepartment> builder)
        {
            builder.HasOne(o => o.University)
                .WithMany(o => o.UniversityDepartments)
                .HasForeignKey(o => o.UniversityId);

            builder.HasOne(o => o.Department)
                .WithMany(o => o.UniversityDepartments)
                .HasForeignKey(o => o.DepartmentId);

            builder.HasKey(sc => new { sc.UniversityId, sc.DepartmentId });
            builder.HasData(

                new UniversityDepartment()
                {
                    Id = Guid.Parse("c35a6c55-f88b-400f-9b1b-812e78e7b871"),
                    DepartmentId = Guid.Parse("38449231-c9b9-46b9-9ee1-83ebaea156f1"),
                    UniversityId = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("f4c4958c-9e2b-4131-9a02-452543deee11"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ccac8532-50f8-4eb9-a4ff-f77a61532875"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("0e755d4f-1cdb-4b91-a371-f2db5e9e9dc2"),
                    DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    UniversityId = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("2e17c493-2af0-4b21-9ec3-f53348865341"),
                    DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2"),
                    UniversityId = Guid.Parse("83e4e060-f70a-4fb3-b828-e8f1443d3f46")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("1b5409e3-c83d-4456-9a97-3a7bfc0ea1da"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("b9647f7b-e9a0-4636-80f9-45364c8b04a9")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("3c82ef12-2e05-4fba-804b-142411e06608"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("54812146-c3a3-41e1-9b46-c24a2a0a2aa1")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("b1c7db3c-5adc-45eb-94b4-c05b15dc7dc1"),
                    DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"),
                    UniversityId = Guid.Parse("54812146-c3a3-41e1-9b46-c24a2a0a2aa1")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("afcfae3f-de36-44d4-b62e-e9f4016bdf98"),
                    DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"),
                    UniversityId = Guid.Parse("54812146-c3a3-41e1-9b46-c24a2a0a2aa1")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("8ff923b2-9857-419e-b6ce-f46a02a3fd0f"),
                    DepartmentId = Guid.Parse("03a02645-69be-46a7-ad93-cf48b8c2961d"),
                    UniversityId = Guid.Parse("54812146-c3a3-41e1-9b46-c24a2a0a2aa1")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a64675d4-f7f3-4fa0-8cf4-f9c416494f84"),
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    UniversityId = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("4b6d3441-73c4-4c43-9210-7f5b02d0c408"),
                    DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9"),
                    UniversityId = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5b718b0e-33a5-455b-9023-350ec9ba15d6"),
                    DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                    UniversityId = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5182c122-8173-46cf-8ff4-0f2abe45b2e2"),
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    UniversityId = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("eac04805-6163-49b7-96f2-83116100f3e4"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("b8ec3722-2649-4738-8316-38ffd56ed04d")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("9f7d7dfe-35ca-496a-8685-c33f490a7778"),
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    UniversityId = Guid.Parse("314a233c-a95f-4026-992a-75a708d07838")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ed88daa5-98b5-4788-9974-bde351adb4b8"),
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    UniversityId = Guid.Parse("314a233c-a95f-4026-992a-75a708d07838")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("7b048c7d-d707-4fc5-b2e1-a4d220a05ab3"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("314a233c-a95f-4026-992a-75a708d07838")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("9de361f7-863f-4d47-9cf4-2807752ca358"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("75ec74b5-2ddf-48be-a62d-4c5eab61b701"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("3480333c-c628-4cd3-af80-53872212f1a3"),
                    DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ff27b635-bd80-4ee4-ba0f-cfb6318a03e2"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("6896fad6-879e-4583-ba11-7893aefcc4a9"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("e169a6d4-b586-499d-b199-8aee1b8b0d54"),
                    DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"),
                    UniversityId = Guid.Parse("2a5d2d04-9d41-4279-9337-5b0039ee1b23")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("c01ede3f-21a6-4925-ac48-2e922094ba83"),
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    UniversityId = Guid.Parse("b629e405-9aca-4c19-bbe3-f4a50d9cca62")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("d77354a4-913c-4a11-97e3-4ca47c0f5424"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("e864f3ea-4d1c-49ad-9e09-8b4a30530b5a"),
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("fe7b7c28-eadc-4313-81a8-eca850f6a64f"),
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("947274a7-eb7b-4b23-aad3-db2072eb3a75"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("d42f497b-9196-4a29-9b23-3cbb9f2a9ccf"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("aa55a474-c4b8-4a7c-8020-4639863d2009"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a41470c0-9762-4441-9a8a-cc3510b372f7"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("6b70b92b-4201-4611-b6bb-716a5b3c4fec")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("0fbe70bd-b478-419b-88ff-af343c7845ac"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("0e7c3b01-d954-4986-9d9d-f48127433211")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("93527c9b-71fa-4cb9-9286-a0fe534a7608"),
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    UniversityId = Guid.Parse("0e7c3b01-d954-4986-9d9d-f48127433211")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("6c552337-a58e-493d-90f4-ff6299dfbd0a"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("0e7c3b01-d954-4986-9d9d-f48127433211")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("57f0e5e0-e41f-4d51-813a-ef55550902d7"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("f84e78ea-4426-4728-a3f6-c41c3ed22072")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("8c3ee2a4-a9f1-4ff4-b09a-9242f7cf6bc6"),
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    UniversityId = Guid.Parse("f84e78ea-4426-4728-a3f6-c41c3ed22072")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("46233795-1b64-448a-a629-21c12c40c804"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("f84e78ea-4426-4728-a3f6-c41c3ed22072")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5d18842d-3612-46a4-a0a8-bc6f633c0a27"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("f84e78ea-4426-4728-a3f6-c41c3ed22072")
                }
                /* new UniversityDepartment()
                {
                    Id = Guid.Parse(""),
                    DepartmentId = Guid.Parse(""),
                    UniversityId = Guid.Parse("")
                } */
                );

        }
    }
}
