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
    public class GroupDepartmentConfiguration : IEntityTypeConfiguration<GroupDepartment>
    {
        public void Configure(EntityTypeBuilder<GroupDepartment> builder)
        {
            builder.HasOne(o => o.Group)
               .WithMany(o => o.GroupDepartments)
               .HasForeignKey(o => o.GroupId);

            builder.HasOne(o => o.UniversityDepartment)
                .WithMany(o => o.GroupDepartments)
                .HasForeignKey(o => o.UniversityDepartmentId);

            builder.HasKey(sc => new { sc.UniversityDepartmentId, sc.GroupId });
        }
    }
}
