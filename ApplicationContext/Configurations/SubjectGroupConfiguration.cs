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

        }
    }
}
