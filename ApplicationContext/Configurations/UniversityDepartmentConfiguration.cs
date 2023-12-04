﻿using Domain.Models;
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

            builder.HasOne(o => o.Department)
                .WithMany(o => o.UniversityDepartments)
                .HasForeignKey(o => o.DepartmentId);

            builder.HasKey(sc => new { sc.UniversityId, sc.DepartmentId });
            builder.HasData(
             new UniversityDepartment()
             {
                 Id = Guid.Parse(""),
                 DepartmentId = Guid.Parse(""),
                 UniversityId = Guid.Parse(""),

             }
              );
        }
    }
}
