using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasData(
                new Group()
                {
                    Id = Guid.Parse("f5e0affd-9745-4859-8171-77b99fc725c1"),
                    Code = "GroupA",
                    Description = "Khối A"
                },
                new Group()
                {
                    Id = Guid.Parse("632ba05a-9ed9-4a00-9ac8-e1c642919806"),
                    Code = "GroupB",
                    Description = "Khối B"
                },
                new Group()
                {
                    Id = Guid.Parse("dab75dab-d28c-45ad-98a6-b3f25dec3ad0"),
                    Code = "GroupC",
                    Description = "Khối C"
                },
                new Group()
                {
                    Id = Guid.Parse("09f798c3-4d01-437f-b361-bf230efd7ddf"),
                    Code = "GroupD",
                    Description = "Khối D"
                },
                new Group()
                {
                    Id = Guid.Parse("20bbb66d-3117-4050-ae30-4caf85831530"),
                    Code = "GroupH",
                    Description = "Khối H"
                },
                new Group()
                {
                    Id = Guid.Parse("b8de514a-7bba-4b8b-bae1-fc36c07ed52b"),
                    Code = "GroupV",
                    Description = "Khối V"
                });
        }
    }
}
