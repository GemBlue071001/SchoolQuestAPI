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
    public class StudentPurchasedConfiguration : IEntityTypeConfiguration<StudentPurchased>
    {
        public void Configure(EntityTypeBuilder<StudentPurchased> builder)
        {
            builder.HasOne(x => x.User)
                   .WithMany(u=>u.StudentPurchaseds)
                   .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Examination)
                   .WithMany(u=>u.StudentPurchaseds)
                   .HasForeignKey(x => x.ExaminationId);

            
        }
    }
}
