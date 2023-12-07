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
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("fe787b7f-254f-4ed3-ae20-8f3c376d0efd"),
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    UniversityId = Guid.Parse("cf30b5ef-1a8f-472f-af90-337a5cee4c16")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("298ccff7-9a81-437c-8473-5a0333e8cae2"),
                    DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    UniversityId = Guid.Parse("cf30b5ef-1a8f-472f-af90-337a5cee4c16")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("699ecb87-e496-4781-945d-8aeb5455cae1"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("da0dfcbb-e846-45a2-baf9-7ec9e8f52f3d"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("1bf38b36-9663-4368-8d61-e33d8606bd62"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("32c9fe4e-66f9-4d7b-847d-efa87a4642a3"),
                    DepartmentId = Guid.Parse("c63be8dc-3a1e-494a-9b2a-ba49b5eef457"),
                    UniversityId = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("9b797f4c-6b7f-470a-bdcc-f3c7e6599985"),
                    DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    UniversityId = Guid.Parse("d1ee778a-2d89-402f-aa5e-c914315dbc3f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a896dca0-76e5-4a96-8858-838a8b8114ab"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("3d6888a4-17b8-4173-9f12-7ce55983d1cc")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("77263dce-bbcb-44ae-8b6d-adff278fe00b"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("3d6888a4-17b8-4173-9f12-7ce55983d1cc")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("f38136d0-5602-49a2-b8fd-da73e0a65c16"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("3d6888a4-17b8-4173-9f12-7ce55983d1cc")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ade3c37a-030e-4f43-810b-10688b7512a2"),
                    DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    UniversityId = Guid.Parse("3d6888a4-17b8-4173-9f12-7ce55983d1cc")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a943a4e3-7633-4990-9ecd-431d93bf2b71"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("059779f5-c84c-455a-85d0-798ca039ba72")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ce8bd0dc-c001-4586-bceb-7ee83abde2b3"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("059779f5-c84c-455a-85d0-798ca039ba72")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("65ee4308-6e91-4772-8009-be274a6ecced"),
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    UniversityId = Guid.Parse("059779f5-c84c-455a-85d0-798ca039ba72")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("3bd0e623-e6d7-4792-a697-a6b8c6ca6797"),
                    DepartmentId = Guid.Parse("37ac6580-0e40-465f-b9f6-aa7e803487b2"),
                    UniversityId = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5ac24503-c23b-4905-bf2c-6fb68c53e877"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("aa7add7f-d344-4d73-bc0a-5e6ea6f42aa2"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5ea0df8b-390c-47f5-92a4-75e2c66e0f2b"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("66c58733-d8f0-4900-afd7-70a54246f773"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("3f5ffdad-a0e1-478c-8ae1-7f0af8fd438c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("2d4e9205-6c66-47d1-aa4d-2c7365e27b4c"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("b4e33b7e-eadc-411b-97fb-46366844f73d"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("fe9af913-73d2-4d3a-a189-e81ccea8c82e"),
                    DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                    UniversityId = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("d41fdfa1-8429-46cf-9941-de8fae4281b2"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("3cfdd28f-1d05-4fe1-b934-3837fbe2eec9"),
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    UniversityId = Guid.Parse("0de6a90f-780c-41a4-9920-3dc6a86e3f11")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("065e10eb-73c1-4279-9082-2cad7c132c68"),
                    DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a"),
                    UniversityId = Guid.Parse("3fdd5b92-3e52-4434-8f21-176732be0cc1")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("c58937df-64bd-4f63-b998-27e5ba347b3c"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("17e0e068-e177-4c6b-9ce3-8e2913f534d4"),
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("cd585229-73d4-4048-aac0-9dde7259fa5e"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("bb2d1988-7500-48ca-9ab5-aee3fca24deb"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a2398a84-25e4-4766-bade-27d1da1178ac"),
                    DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("2ec0d13f-068f-4aa8-8022-c1c0ec394b07"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("2721d2b3-c6e1-4253-8823-cf73744e0190")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("47896fae-da8b-41c3-a554-8a2405659199"),
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    UniversityId = Guid.Parse("8ae6dc6f-c859-4fb9-b038-366470876d80")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("9ba9d579-afc3-4123-8047-c981a145ff37"),
                    DepartmentId = Guid.Parse("f9cf3140-b872-4837-b965-d37f94e33c0b"),
                    UniversityId = Guid.Parse("8ae6dc6f-c859-4fb9-b038-366470876d80")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("395ee7e1-c73b-432b-8ef2-011e98655c3d"),
                    DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498"),
                    UniversityId = Guid.Parse("1d5312be-a745-4a4a-b1df-41abd3dc01e8")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("4a077579-638c-4bb5-b991-330d2972a5b5"),
                    DepartmentId = Guid.Parse("d7ab840a-0e06-4785-aa71-f82bef075ff9"),
                    UniversityId = Guid.Parse("b8620337-894a-4339-926e-dff2cd9f09ba")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("0776c065-b631-4331-80bd-c87e7ca881db"),
                    DepartmentId = Guid.Parse("9bf92746-e6c9-46ae-a8ba-9fa93671dcce"),
                    UniversityId = Guid.Parse("b8620337-894a-4339-926e-dff2cd9f09ba")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("071cfad3-f6a1-4bf3-8632-692f5e48e706"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("9db07138-e420-4be8-b9bf-3cdd043ca55f"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("8fa757e4-ef5b-4ad4-8162-b8c75e6ed1ba"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("c7070cd0-fe91-497c-8865-7bb6a104ba47"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("cdbd71b3-7fe4-4917-9eed-616b4c2f2a97")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5b37cfac-ef3a-4862-9200-63a9b84d5a84"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("253fca55-c797-4f1d-8c83-a66d81342921")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("16009e9f-b6a5-48fd-850e-c4cd633b1e3f"),
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    UniversityId = Guid.Parse("253fca55-c797-4f1d-8c83-a66d81342921")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("f0b547f6-2f60-446f-a3cb-ad312af4fd55"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("253fca55-c797-4f1d-8c83-a66d81342921")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("d6f7ed4c-57d1-4680-80a2-a42de8d4c16d"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("253fca55-c797-4f1d-8c83-a66d81342921")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("1e5e5710-cbe3-4ad7-91cb-5b9e1ff6a495"),
                    DepartmentId = Guid.Parse("d2322472-e7af-47e7-ab8f-eba6e8e7baad"),
                    UniversityId = Guid.Parse("253fca55-c797-4f1d-8c83-a66d81342921")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("ea30506f-3ee8-438f-8f98-e5b73837e64d"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("ddb202ca-e224-48d6-a463-6b32ed962693")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("b7a246b7-b1ec-418b-8d09-3049363a6104"),
                    DepartmentId = Guid.Parse("47243cb9-ad17-4590-bf72-bef8ca382fa9"),
                    UniversityId = Guid.Parse("ddb202ca-e224-48d6-a463-6b32ed962693")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("0f04c625-6886-4755-b7e4-8339df3a9a12"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("ddb202ca-e224-48d6-a463-6b32ed962693")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("4e6e422f-3d85-45a0-891d-898a3b96e23b"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("ddb202ca-e224-48d6-a463-6b32ed962693")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("b34ccc66-d9c3-438b-b989-b9af063cca86"),
                    DepartmentId = Guid.Parse("5fbe7741-917c-45f5-8f78-c06327ede146"),
                    UniversityId = Guid.Parse("ddb202ca-e224-48d6-a463-6b32ed962693")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("7152be3b-19dc-47fa-b74c-3fe92044789d"),
                    DepartmentId = Guid.Parse("07563189-01d5-4ec1-80a6-f9c7ced12408"),
                    UniversityId = Guid.Parse("778c4103-05d3-4dab-9019-7196f6772dc8")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("dd7d6a2a-285f-4f43-bd3e-eb6b117310c5"),
                    DepartmentId = Guid.Parse("eb977e5d-b2a9-48c2-a540-cefe5a960c1d"),
                    UniversityId = Guid.Parse("abf76dc2-7086-4836-badb-a520e720caaa")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("e8e3d5f7-dd13-4ac1-acb3-e26e0be0009f"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("abf76dc2-7086-4836-badb-a520e720caaa")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("806293ab-12c3-429c-8155-72740bc38d23"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("abf76dc2-7086-4836-badb-a520e720caaa")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("3e3340a9-1416-41b4-8ee6-ee6023a78a7c"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("166d0a24-7e52-45af-a795-d8e082d3749a")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("32470d5f-84cb-4b60-a744-ce6303b9b948"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("166d0a24-7e52-45af-a795-d8e082d3749a")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("b5c79e2b-3b5f-4fdd-926c-8bef0e208811"),
                    DepartmentId = Guid.Parse("e63527a5-2326-4d15-afb5-8244fd0fa441"),
                    UniversityId = Guid.Parse("166d0a24-7e52-45af-a795-d8e082d3749a")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("852c8bf8-960c-4215-ab98-29077f50c08a"),
                    DepartmentId = Guid.Parse("575e2a34-3e4e-40b3-be97-37310e59085a"),
                    UniversityId = Guid.Parse("b83746d5-641b-40ef-9804-a8fb7ae9fb4f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a2f6ef18-44b0-476c-86f4-06a19fff80e1"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("b83746d5-641b-40ef-9804-a8fb7ae9fb4f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("1e93a09e-1d42-40c4-ae6e-a8971ef5f663"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("b83746d5-641b-40ef-9804-a8fb7ae9fb4f")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("252df49b-dd26-4a31-aa0a-1a0bbf90cc6f"),
                    DepartmentId = Guid.Parse("adb460f7-aa33-4efd-8346-9f3b76a0484b"),
                    UniversityId = Guid.Parse("98f712a7-3847-46f7-90cc-2e3cb2348123")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("dd268132-4b4c-4d4f-b599-8b4ff5ac91a9"),
                    DepartmentId = Guid.Parse("934b3542-92d5-431c-9271-f39dedcac50f"),
                    UniversityId = Guid.Parse("98f712a7-3847-46f7-90cc-2e3cb2348123")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("611ba8a9-3e62-4f93-814c-34887d31174d"),
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    UniversityId = Guid.Parse("98f712a7-3847-46f7-90cc-2e3cb2348123")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("94b6acfa-7225-4df2-bb2d-eb99e203e7a7"),
                    DepartmentId = Guid.Parse("67d181a2-ac85-4aaa-bcad-863b8695071b"),
                    UniversityId = Guid.Parse("98f712a7-3847-46f7-90cc-2e3cb2348123")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("d483a375-8e79-4042-8724-68ff7cc9c33c"),
                    DepartmentId = Guid.Parse("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                    UniversityId = Guid.Parse("7d8960c2-ee10-4813-9522-106512a9b802")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("dcf16f10-8db3-4f2e-9625-de864300b443"),
                    DepartmentId = Guid.Parse("3a8a3b94-db19-44cb-91ae-a895fe50c498"),
                    UniversityId = Guid.Parse("7d8960c2-ee10-4813-9522-106512a9b802")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("254b48e7-a1d9-47a3-b2da-e237c4f85244"),
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    UniversityId = Guid.Parse("6d35b512-5dcc-49af-9f26-29eddd7f475c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("e6ca6917-c81e-4b05-b1f6-a4bc81d25a20"),
                    DepartmentId = Guid.Parse("cbeac466-d627-466c-8300-6ee4d5505a20"),
                    UniversityId = Guid.Parse("6d35b512-5dcc-49af-9f26-29eddd7f475c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("a8f151e5-5c82-45ab-81a6-fd407298145f"),
                    DepartmentId = Guid.Parse("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                    UniversityId = Guid.Parse("6d35b512-5dcc-49af-9f26-29eddd7f475c")
                },
                new UniversityDepartment()
                {
                    Id = Guid.Parse("5c33610f-8629-484a-a1ba-2f7ed31e61ab"),
                    DepartmentId = Guid.Parse("bf4524c1-1150-48f6-8c57-d922d925426f"),
                    UniversityId = Guid.Parse("6d35b512-5dcc-49af-9f26-29eddd7f475c")
                }
                );

        }
    }
}
