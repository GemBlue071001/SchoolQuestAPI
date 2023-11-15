using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationContext.Configurations
{
    public class SubjectGroupConfiguration : IEntityTypeConfiguration<SubjectGroup>
    {
        public void Configure(EntityTypeBuilder<SubjectGroup> builder)
        {
            builder.HasOne(o => o.Subject)
                .WithMany(o => o.SubjectGroups)
                .HasForeignKey(o => o.SubjectId);

            builder.HasOne(o => o.Group)
                .WithMany(o => o.SubjectGroups)
                .HasForeignKey(o => o.GroupId);

            builder.HasKey(sc => new { sc.SubjectId, sc.GroupId });
            builder.HasData(
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                    GroupId = Guid.Parse("632ba05a-9ed9-4a00-9ac8-e1c642919806")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                    GroupId = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                    GroupId = Guid.Parse("32ba05a-9ed9-4a00-9ac8-e1c642919806")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                    GroupId = Guid.Parse("632ba05a-9ed9-4a00-9ac8-e1c642919806")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                    GroupId = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                    GroupId = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("50051095-391a-4abf-94f2-ac3cf912f07b"),
                    GroupId = Guid.Parse("b8de514a-7bba-4b8b-bae1-fc36c07ed52b")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                    GroupId = Guid.Parse("b8de514a-7bba-4b8b-bae1-fc36c07ed52b")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                    GroupId = Guid.Parse("b8de514a-7bba-4b8b-bae1-fc36c07ed52b")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"),
                    GroupId = Guid.Parse("20bbb66d-3117-4050-ae30-4caf85831530")
                },
                new SubjectGroup()
                {
                    SubjectId = Guid.Parse("50051095-391a-4abf-94f2-ac3cf912f07b"),
                    GroupId = Guid.Parse("20bbb66d-3117-4050-ae30-4caf85831530")
                }
                );
        }
    }
}
