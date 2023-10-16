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
    public class MBTI_DepartmentConfiguration : IEntityTypeConfiguration<MBTI_Department>
    {
        public void Configure(EntityTypeBuilder<MBTI_Department> builder)
        {
            builder.HasOne(o => o.Department)
               .WithMany(o => o.MBTI_Departments)
               .HasForeignKey(o => o.DepartmentId);

            builder.HasOne(o => o.MBTI)
                .WithMany(o => o.MBTI_Departments)
                .HasForeignKey(o => o.MBTI_Id);

            builder.HasKey(sc => new { sc.MBTI_Id, sc.DepartmentId });
        }
    }
}
