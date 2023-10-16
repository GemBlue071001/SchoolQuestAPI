using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationContext.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(x => x.Majors)
                   .WithOne(x => x.Department)
                   .HasForeignKey(x => x.DepartmentId);
        }
    }
}
