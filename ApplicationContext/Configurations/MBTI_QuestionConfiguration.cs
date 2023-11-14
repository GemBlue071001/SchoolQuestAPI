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
    public class MBTI_QuestionConfiguration : IEntityTypeConfiguration<MBTI_Question>
    {
        public void Configure(EntityTypeBuilder<MBTI_Question> builder)
        {
            builder.HasData(new MBTI_Question
            {
                Id = 1,
                NameQuestion = "Bạn thích công việc kiểu : ",
                NameAns1 = "a. Xã hội, giao tiếp.",
                NameAns2 = "b. Thiết kế, nghiên cứu.",
                Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                
            });
        }
    }
}
