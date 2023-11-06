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
    public class AttemptConfiguration : IEntityTypeConfiguration<Attempt>
    {
        public void Configure(EntityTypeBuilder<Attempt> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.Attempts)
                .HasForeignKey(x => x.UserId);

            builder.HasData(new Attempt
            {
                Id = Guid.Parse("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                CreatedDate = DateTime.UtcNow,
                Result = "Pass",
                Score = 10,
                ExamDate = DateTime.UtcNow.AddDays(1),
                UserId = Guid.Parse("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
            });
        }
    }
}
