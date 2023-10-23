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

            builder.HasData
                (
                new MBTI_Department()
                {
                    DepartmentId = Guid.Parse("de305d54-75b4-431b-adb2-eb6b9e546013"),
                    MBTI_Id = 2
                },
                new MBTI_Department()
                {
                    DepartmentId = Guid.Parse("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                    MBTI_Id = 2
                },
                new MBTI_Department()
                {
                    DepartmentId = Guid.Parse("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                    MBTI_Id = 9
                }
                );
        }
    }
}
