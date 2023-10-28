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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder
        .Property(b => b.CreatedDate)
        .HasDefaultValueSql("NOW()")
        .ValueGeneratedOnAdd();

            builder.HasData(
     new Question
     {
         Id = Guid.Parse("238f27e2-fe56-4ce8-88f8-d3aa7b56f976"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "What is the capital of France?",
             ListAnswer = new List<ListAnswer>
             {
                new ListAnswer { Value = "Paris", IsAnswer = true },
                new ListAnswer { Value = "London", IsAnswer = false },
                new ListAnswer { Value = "Berlin", IsAnswer = false }
             },

         }),
         TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     },
     new Question
     {
         Id = Guid.Parse("85e5d51b-16c7-4d0d-8f40-766a6a902698"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "How many continents are there?",
             ListAnswer = new List<ListAnswer>
             {
                new ListAnswer { Value = "7", IsAnswer = true },
                new ListAnswer { Value = "5", IsAnswer = false },
                new ListAnswer { Value = "6", IsAnswer = false }
             }
         }),
         TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     },
     new Question
     {
         Id = Guid.Parse("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "When was the Declaration of Independence signed?",
             ListAnswer = new List<ListAnswer>
             {
                new ListAnswer { Value = "1776-07-04", IsAnswer = true },
                new ListAnswer { Value = "1789-09-25", IsAnswer = false },
                new ListAnswer { Value = "1800-03-12", IsAnswer = false }
             }
         }),
         TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     },
     new Question
     {
         Id = Guid.Parse("21eb2451-53ac-44f6-9a6c-751d394a8936"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Which cities are in the United Kingdom?",
             ListAnswer = new List<ListAnswer>
             {
                new ListAnswer { Value = "London", IsAnswer = true },
                new ListAnswer { Value = "Manchester", IsAnswer = false },
                new ListAnswer { Value = "Edinburgh", IsAnswer = true }
             }
         }),
         TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     }
 );

        }

        private class ListAnswer
        {
            public string Value { get; set; }
            public bool IsAnswer { get; set; }
        }

        private class Content
        {
            public string Question { get; set; }
            public List<ListAnswer> ListAnswer { get; set; }
        }

    }


}
