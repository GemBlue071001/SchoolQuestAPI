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
    public class MBTI_ExamQuestionConfiguration : IEntityTypeConfiguration<MBTI_ExamQuestion>
    {
        public void Configure(EntityTypeBuilder<MBTI_ExamQuestion> builder)
        {
            builder.HasOne(x => x.MBTI_Exam)
                .WithMany(x => x.MBTI_ExamQuestions)
                .HasForeignKey(x => x.ExamId);

            builder.HasOne(x => x.MBTI_Question)
                .WithMany(x => x.MBTI_ExamQuestions)
                .HasForeignKey(x => x.QuestionId);

            builder.HasMany(x => x.RecordDetails)
                .WithOne(x => x.MBTI_ExamQuestion)
                .HasForeignKey(x => x.MBTI_ExamQuestionId);


            builder.HasData(new MBTI_ExamQuestion
            {
                ExamId = 1,
                Id = 1,
                QuestionId = 1,
            },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 2,
     QuestionId = 2,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 3,
     QuestionId = 3,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 4,
     QuestionId = 4,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 5,
     QuestionId = 5,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 6,
     QuestionId = 6,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 7,
     QuestionId = 7,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 8,
     QuestionId = 8,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 9,
     QuestionId = 9,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 10,
     QuestionId = 10,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 11,
     QuestionId = 11,
 },
 new MBTI_ExamQuestion
 {
     ExamId = 1,
     Id = 12,
     QuestionId = 12,
 });

        }
    }
}
