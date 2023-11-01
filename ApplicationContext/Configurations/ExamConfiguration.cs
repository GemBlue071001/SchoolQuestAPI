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

            },
            new Examination
            {
                Id = Guid.Parse("1e157ceb-9adb-48bf-84de-ae050c2f89b8"),
                Description = "De thi hoa hoc",
                Name = "de hoa",
                TotalNumberOfQuestion = 20
            },
            new Examination
            {
                Id = Guid.Parse("e296dd9b-4007-4666-b6fe-35664dcaed77"),
                Description = "De thi sinh hoc",
                Name = "de sinh",
                TotalNumberOfQuestion = 21
            },
            new Examination
            {
                Id = Guid.Parse("80b9fa50-f8aa-4bc5-bf05-39e8f54f8f06"),
                Description = "De thi van",
                Name = "de van",
                TotalNumberOfQuestion = 5
            },
            new Examination
            {
                Id = Guid.Parse("61bb287c-ea61-47ec-883d-628ed98bb716"),
                Description = "De thi am nhac",
                Name = "de music",
                TotalNumberOfQuestion = 10
            });
        }
    }
}
