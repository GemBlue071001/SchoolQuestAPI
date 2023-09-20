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
            builder.HasOne(o => o.Subject)
                .WithMany(o => o.Topics)
                .HasForeignKey(o => o.SubjectId);

            builder.HasMany(o => o.Questions)
                .WithOne(o => o.Topic)
                .HasForeignKey(o => o.TopicId);
        }
    }
}
