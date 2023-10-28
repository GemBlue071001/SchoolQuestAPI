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
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            builder.HasData(
                new Subject()
                {
                    Id = Guid.Parse("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                    Name = "Toan",
                });
        }
    }
}
