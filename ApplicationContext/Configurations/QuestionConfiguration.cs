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
         Id = Guid.Parse("f381da01-ca48-41b6-842d-6b9ff7e8deec"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Hai dao động điều hòa cùng phương, cùng tần số có biên độ lần lượt là A1 = 8 cm; " +
             "A2 = 15 cm và lệch pha nhau 0,5π. Dao động tổng hợp của hai dao động này có biên độ bằng:",
             ListAnswer = new List<ListAnswer>
        {
            new ListAnswer { Value = "7cm", IsAnswer = false },
            new ListAnswer { Value = "17cm", IsAnswer = true },
            new ListAnswer { Value = "11cm", IsAnswer = false }
        },
         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("9d76c22d-553c-4fe3-ba6b-6c7b38b1e7a5"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Khi nói về dao động cưỡng bức và dao động duy trì, phát biểu nào sau đây là sai?",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "Dao động duy trì có tần số bằng tần số riêng của hệ dao động.", IsAnswer = false  },
           new ListAnswer { Value = "Dao động duy trì có biên độ không đổi.", IsAnswer = false },
           new ListAnswer { Value = "Biên độ của dao động cưỡng bức là biên độ của lực cưỡng bức.", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("551e3712-3de1-402a-8df9-a35db36011d4"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Một vật dao động điều hoà với chu kì T, biên độ bằng 5 cm. Quãng đường vật đi được trong 2,5T là:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "50 cm", IsAnswer = true },
           new ListAnswer { Value = "45 cm", IsAnswer = false },
           new ListAnswer { Value = "25 cm", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("d1e7ee41-195a-462f-906a-c8b867371e4d"),
     },
     new Question
     {
         Id = Guid.Parse("a0752c7e-ac76-4a9c-82e4-92ddb89033b0"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Số chỉ của ampe kế khi mắc nối tiếp vào đoạn mạch điện xoay chiều cho ta biết giá trị cường độ dòng điện",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "cực đại", IsAnswer = false },
           new ListAnswer { Value = "hiệu dụng", IsAnswer = true },
           new ListAnswer { Value = "tức thời", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("79d76295-efe3-4f84-a831-5ca9913b7ab6"),
     },
     new Question
     {
         Id = Guid.Parse("19582b83-700e-43f7-9867-d86c71153b4b"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Sóng điện từ có tần số f = 300 MHz thuộc loại",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "sóng trung", IsAnswer = false  },
           new ListAnswer { Value = " sóng dài", IsAnswer = false  },
           new ListAnswer { Value = "sóng cực ngắn", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("6fc99327-e8b8-42ad-b3f0-641c2f81027d"),
     },
     new Question
     {
         Id = Guid.Parse("02f6bdd7-aca1-41c8-a7d1-07843aff2d10"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Trong thí nghiệm Yâng về giao thoa của ánh sáng đơn sắc, hai khe hẹp cách nhau 1 mm, mặt phẳng chứa hai khe cách màn quan sát 1,5 m." +
             " Khoảng cách giữa 5 vân sáng liên tiếp là 3,6 mm. Bước sóng của ánh sáng dùng trong thí nghiệm này bằng:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "0,48 µm.", IsAnswer = false  },
           new ListAnswer { Value = "0,40 µm.", IsAnswer = false },
           new ListAnswer { Value = "0,60 µm", IsAnswer = true }
        },

         }),
         TopicId = Guid.Parse("5a1a8691-497c-4ac4-b764-64b0984a7c49"),
     },
     new Question
     {
         Id = Guid.Parse("b423d3b0-ebc5-4164-ba8a-458e14f089c5"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Người ta tạo sóng dừng trên một sợi dây căng giữa 2 điểm cố định. Hai tần số gần nhau nhất cùng " +
             "tạo ra sóng dừng trên dây là 525 Hz và 600 Hz. Tần số nhỏ nhất tạo ra sóng dừng trên dây đó là:",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "75 Hz", IsAnswer = true },
           new ListAnswer { Value = "125 Hz", IsAnswer = false },
           new ListAnswer { Value = "100 Hz", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"),
     },
     new Question
     {
         Id = Guid.Parse("d9bde32b-01a3-409b-9991-de7f471add13"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Khi có sóng dừng trên dây khoảng cách giữa hai nút sóng liên tiếp là",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "một bước sóng", IsAnswer = false },
           new ListAnswer { Value = "một nửa bước sóng", IsAnswer = true },
           new ListAnswer { Value = "một phần tư bước sóng", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("17ba34ec-7b7c-47ce-9491-6a28d8f0f497"),
     },
     new Question
     {
         Id = Guid.Parse("8e7bbeff-72b3-4010-a716-9b31d5d20186"),
         Content = JsonSerializer.Serialize(new Content
         {
             Question = "Phóng xạ là",
             ListAnswer = new List<ListAnswer>
        {
           new ListAnswer { Value = "quá trình hạt nhân nguyên tử phát các tia không nhìn thấy", IsAnswer = false },
           new ListAnswer { Value = "quá trình phân rã tự phát của một hạt nhân không bền vững", IsAnswer = true },
           new ListAnswer { Value = "quá trình hạt nhân nguyên tử nặng bị phá vỡ thành các hạt nhân nhỏ hơn.", IsAnswer = false }
        },

         }),
         TopicId = Guid.Parse("ba088c8b-890e-4743-9a45-d49066c780a6"),
     }



     //new Question
     //{
     //    Id = Guid.Parse("85e5d51b-16c7-4d0d-8f40-766a6a902698"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "How many continents are there?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "7", IsAnswer = true },
     //           new ListAnswer { Value = "5", IsAnswer = false },
     //           new ListAnswer { Value = "6", IsAnswer = false }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //},
     //new Question
     //{
     //    Id = Guid.Parse("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "When was the Declaration of Independence signed?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "1776-07-04", IsAnswer = true },
     //           new ListAnswer { Value = "1789-09-25", IsAnswer = false },
     //           new ListAnswer { Value = "1800-03-12", IsAnswer = false }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //},
     //new Question
     //{
     //    Id = Guid.Parse("21eb2451-53ac-44f6-9a6c-751d394a8936"),
     //    Content = JsonSerializer.Serialize(new Content
     //    {
     //        Question = "Which cities are in the United Kingdom?",
     //        ListAnswer = new List<ListAnswer>
     //        {
     //           new ListAnswer { Value = "London", IsAnswer = true },
     //           new ListAnswer { Value = "Manchester", IsAnswer = false },
     //           new ListAnswer { Value = "Edinburgh", IsAnswer = true }
     //        }
     //    }),
     //    TopicId = Guid.Parse("f722c143-412c-4721-bf5c-5b32a01d90da"),
     //}
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
