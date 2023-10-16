﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApplicationContext.Configurations
{
    public class MBTIConfiguration : IEntityTypeConfiguration<MBTI>
    {
        public void Configure(EntityTypeBuilder<MBTI> builder)
        {
            var jsonString = File.ReadAllText("../ApplicationContext/SeedData/MBTISeedData.json");
            var entities = JsonSerializer.Deserialize<List<MBTI>>(jsonString);
            builder.HasData(entities);
        }
    }
}