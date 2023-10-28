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
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            builder.HasOne(o => o.Subject)
                .WithMany(o => o.Topics)
                .HasForeignKey(o => o.SubjectId);

            builder.HasMany(o => o.Questions)
                .WithOne(o => o.Topic)
                .HasForeignKey(o => o.TopicId);

            builder.HasData(new Topic()
            {
                Id = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
                Index = 1,
                Name = "toan dai cuong",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                Description = "toan dai cuong",
            },
            new Topic()
            {
                Id = Guid.Parse("25b3ba1e-240a-4a3c-96b6-c0816b0a3975"),
                Index = 2,
                Name = "toan hinh",
                Description= "Toan hinh",
                SubjectId = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625")
            }
            );
        }
    }
}
