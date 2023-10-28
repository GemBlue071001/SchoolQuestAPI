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
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();
            builder.HasOne(o => o.Question)
                .WithMany(o => o.ExaminationQuestions)
                .HasForeignKey(o => o.QuestionId);

            builder.HasOne(o => o.Examination)
                .WithMany(o => o.ExaminationQuestions)
                .HasForeignKey(o => o.ExaminationId);

            builder.HasData(
                new ExaminationQuestion
                {
                    Id = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                    ExaminationId = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                    QuestionId = Guid.Parse("238f27e2-fe56-4ce8-88f8-d3aa7b56f976")
                },
                new ExaminationQuestion
                {
                    Id = Guid.Parse("046b0f97-130a-48c7-b1ad-40033ae41fff"),
                    ExaminationId = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                    QuestionId = Guid.Parse("85e5d51b-16c7-4d0d-8f40-766a6a902698")
                },
                new ExaminationQuestion
                {
                    Id = Guid.Parse("2339983b-33db-4333-9b1b-a5514faa280a"),
                    ExaminationId = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                    QuestionId = Guid.Parse("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe")
                },
                new ExaminationQuestion
                {
                    Id = Guid.Parse("139c3a57-af40-4c80-96fc-508957db3780"),
                    ExaminationId = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                    QuestionId = Guid.Parse("21eb2451-53ac-44f6-9a6c-751d394a8936")
                }
                );
        }
    }
}
