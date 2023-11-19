using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationContext.Configurations
{
    public class MBTI_ExamConfiguration : IEntityTypeConfiguration<MBTI_Exam>
    {
        public void Configure(EntityTypeBuilder<MBTI_Exam> builder)
        {
            builder.HasData(new MBTI_Exam
            {
                Id = 1,
                Note = "MBTI Exam",
                NumberOfQuestion = 12
            });
        }
    }
}
