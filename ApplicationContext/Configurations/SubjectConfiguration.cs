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
                    Name = "Toán"
                },
                new Subject()
                {
                    Id = Guid.Parse("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"),
                    Name = "Ngữ Văn"
                },
                new Subject()
                {
                    Id = Guid.Parse("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"),
                    Name = "Tiếng Anh"
                },
                new Subject()
                {
                    Id = Guid.Parse("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"),
                    Name = "Lịch Sử"
                },
                new Subject()
                {
                    Id = Guid.Parse("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"),
                    Name = "Địa Lý"
                },
                new Subject()
                {
                    Id = Guid.Parse("af6197e1-8fc6-4afe-9f63-6b4f426ad502"),
                    Name = "Sinh học"
                },
                new Subject()
                {
                    Id = Guid.Parse("0141a511-2028-4a5a-b81d-4a61d98ee0a8"),
                    Name = "Hóa học"
                },
                new Subject()
                {
                    Id = Guid.Parse("00940497-7f82-493d-aac3-a56e9e92f390"),
                    Name = "Giáo dục công dân"
                },
                new Subject()
                {
                    Id = Guid.Parse("ab091cc2-6f9a-4023-8003-2ca82076f5a4"),
                    Name = "Vật Lý"
                }
                );
        }
    }
}
