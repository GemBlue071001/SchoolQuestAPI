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
    public class AttemptDetailConfiguration : IEntityTypeConfiguration<AttemptDetail>
    {
        public void Configure(EntityTypeBuilder<AttemptDetail> builder)
        {
            builder.HasOne(o => o.Attempt)
                .WithMany(o => o.AttemptDetails)
                .HasForeignKey(o => o.AttemptId);

            //builder.HasOne(o => o.User)
            //    .WithMany(o => o.AttemptDetails)
            //    .HasForeignKey(o => o.UserId);


            builder.HasOne(o => o.ExaminationQuestion)
                .WithMany(o => o.AttemptDetails)
                .HasForeignKey(o => o.ExaminationQuestionId);

            builder.HasKey(sc => new { sc.AttemptId, sc.ExaminationQuestionId });
        }
    }
}
