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
    public class ExamConfiguration : IEntityTypeConfiguration<Examination>
    {
        public void Configure(EntityTypeBuilder<Examination> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();
            builder.HasData(new Examination
            {
                Id = Guid.Parse("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                Description = "de thi toan",
                Name = "de toan",
                TotalNumberOfQuestion = 4

            });
        }
    }
}
