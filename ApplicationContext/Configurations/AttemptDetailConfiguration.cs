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

            builder.HasData(new AttemptDetail
            {
                AttemptId = Guid.Parse("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                IsCorrect = true,
                ExaminationQuestionId = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                UserAnswered = "Paris"
            },
                new AttemptDetail
                {
                    AttemptId = Guid.Parse("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                    IsCorrect = true,
                    ExaminationQuestionId = Guid.Parse("046b0f97-130a-48c7-b1ad-40033ae41fff"),
                    UserAnswered = "7"
                },
                new AttemptDetail
                {
                    AttemptId = Guid.Parse("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                    IsCorrect = true,
                    ExaminationQuestionId = Guid.Parse("2339983b-33db-4333-9b1b-a5514faa280a"),
                    UserAnswered = "1776-07-04"
                },
                new AttemptDetail
                {
                    AttemptId = Guid.Parse("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                    IsCorrect = true,
                    ExaminationQuestionId = Guid.Parse("139c3a57-af40-4c80-96fc-508957db3780"),
                    UserAnswered = "London"
                });
        }
    }
}
