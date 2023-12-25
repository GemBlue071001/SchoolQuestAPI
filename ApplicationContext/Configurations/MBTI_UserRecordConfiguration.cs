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
    public class MBTI_UserRecordConfiguration : IEntityTypeConfiguration<MBTI_UserRecord>
    {
        public void Configure(EntityTypeBuilder<MBTI_UserRecord> builder)
        {
            builder
                   .Property(b => b.CreatedDate)
                   .HasDefaultValueSql("NOW()")
                   .ValueGeneratedOnAdd();

            builder.HasOne(x => x.User)
                .WithMany(x => x.MBTI_UserRecords)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.RecordDetails)
                   .WithOne(x => x.MBTI_UserRecord)
                   .HasForeignKey(x => x.UserRecordId);
        }
    }
}
