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
    public class UniversityDepartmentConfiguration : IEntityTypeConfiguration<UniversityDepartment>
    {
        public void Configure(EntityTypeBuilder<UniversityDepartment> builder)
        {
            builder.HasOne(o => o.University)
                .WithMany(o => o.UniversityDepartments)
                .HasForeignKey(o => o.UniversityId);

            builder.HasMany(o => o.Majors)
                .WithOne(o => o.UniversityDepartment)
                .HasForeignKey(o => o.UniversityDepartmentId);
        }
    }
}
