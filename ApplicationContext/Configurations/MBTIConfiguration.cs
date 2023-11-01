using Domain.Models;
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
            builder.HasData(
    new MBTI
    {
        Id = 1,
        Code = "INTJ",
        Name = "The Architect",
        Description = "Imaginative and strategic thinkers, with a plan for everything."
    },
    new MBTI
    {
        Id = 2,
        Code = "INTP",
        Name = "The Logician",
        Description = "Innovative inventors with an unquenchable thirst for knowledge."
    },
    new MBTI
    {
        Id = 3,
        Code = "ENTJ",
        Name = "The Commander",
        Description = "Bold, imaginative and strong-willed leaders, always finding a way – or making one."
    },
    new MBTI
    {
        Id = 4,
        Code = "ENTP",
        Name = "The Debater",
        Description = "Smart and curious thinkers who cannot resist an intellectual challenge."
    },
    new MBTI
    {
        Id = 5,
        Code = "INFJ",
        Name = "The Advocate",
        Description = "Quiet and mystical, yet very inspiring and tireless idealists."
    },
    new MBTI
    {
        Id = 6,
        Code = "INFP",
        Name = "The Mediator",
        Description = "Poetic, kind and altruistic people, always eager to help a good cause."
    },
    new MBTI
    {
        Id = 7,
        Code = "ENFJ",
        Name = "The Protagonist",
        Description = "Charismatic and inspiring leaders, able to mesmerize their listeners."
    },
    new MBTI
    {
        Id = 8,
        Code = "ENFP",
        Name = "The Campaigner",
        Description = "Enthusiastic, creative and sociable free spirits, who can always find a reason to smile."
    },
    new MBTI
    {
        Id = 9,
        Code = "ISTJ",
        Name = "The Logistician",
        Description = "Practical and fact-minded individuals, whose reliability cannot be doubted."
    },
    new MBTI
    {
        Id = 10,
        Code = "ISFJ",
        Name = "The Defender",
        Description = "Very dedicated and warm protectors, always ready to defend their loved ones."
    },
    new MBTI
    {
        Id = 11,
        Code = "ESTJ",
        Name = "The Executive",
        Description = "Excellent administrators, unsurpassed at managing things – or people."
    },
    new MBTI
    {
        Id = 12,
        Code = "ESFJ",
        Name = "The Consul",
        Description = "Extraordinarily caring, social and popular people, always eager to help."
    },
    new MBTI
    {
        Id = 13,
        Code = "ISTP",
        Name = "The Virtuoso",
        Description = "Bold and practical experimenters, masters of all kinds of tools."
    },
    new MBTI
    {
        Id = 14,
        Code = "ISFP",
        Name = "The Adventurer",
        Description = "Flexible and charming artists, always ready to explore and experience something new."
    },
    new MBTI
    {
        Id = 15,
        Code = "ESTP",
        Name = "The Entrepreneur",
        Description = "Smart, energetic and very perceptive people, who truly enjoy living on the edge."
    },
    new MBTI
    {
        Id = 16,
        Code = "ESFP",
        Name = "The Entertainer",
        Description = "Spontaneous, energetic and enthusiastic people – life is never boring around them."
    }
);

        }
    }
}
