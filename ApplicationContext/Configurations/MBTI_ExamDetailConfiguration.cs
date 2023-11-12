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
    public class MBTI_ExamDetailConfiguration : IEntityTypeConfiguration<MBTI_ExamDetail>
    {
        public void Configure(EntityTypeBuilder<MBTI_ExamDetail> builder)
        {
            builder.HasOne(x => x.MBTI_Exam)
                .WithMany(x => x.MBTI_ExamDetails)
                .HasForeignKey(x => x.ExamId);

            builder.HasOne(x => x.MBTI_Question)
                .WithMany(x => x.MBTI_ExamDetails)
                .HasForeignKey(x => x.QuestionId);
        }
    }
}
