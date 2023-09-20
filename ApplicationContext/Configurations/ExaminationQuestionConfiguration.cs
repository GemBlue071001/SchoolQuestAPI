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
    public class ExaminationQuestionConfiguration : IEntityTypeConfiguration<ExaminationQuestion>
    {
        public void Configure(EntityTypeBuilder<ExaminationQuestion> builder)
        {
            builder.HasOne(o => o.Question)
                .WithMany(o => o.ExaminationQuestions)
                .HasForeignKey(o => o.QuestionId);

            builder.HasOne(o => o.Examination)
                .WithMany(o => o.ExaminationQuestions)
                .HasForeignKey(o => o.ExaminationId);
        }
    }
}
