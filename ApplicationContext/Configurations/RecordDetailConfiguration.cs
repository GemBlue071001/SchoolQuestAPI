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
    internal class RecordDetailConfiguration : IEntityTypeConfiguration<RecordDetail>
    {
        public void Configure(EntityTypeBuilder<RecordDetail> builder)
        {
            builder.HasOne(x => x.MBTI_Question)
                .WithMany(x => x.RecordDetails)
                .HasForeignKey(x => x.QuestionId);
        }
    }
}
