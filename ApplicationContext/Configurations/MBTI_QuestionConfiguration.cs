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
    public class MBTI_QuestionConfiguration : IEntityTypeConfiguration<MBTI_Question>
    {
        public void Configure(EntityTypeBuilder<MBTI_Question> builder)
        {
            builder.HasData(new MBTI_Question
            {
                Id = 1,
                NameQuestion = "Bạn thích công việc kiểu : ",
                NameAns1 = "a. Xã hội, giao tiếp.",
                NameAns2 = "b. Thiết kế, nghiên cứu.",
                Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
            },
            new MBTI_Question
            {
                Id = 2,
                NameQuestion = "Bạn tiếp xúc với một người theo xu hướng : ",
                NameAns1 = "a. Khách quan.",
                NameAns2 = "b. Chủ quan.",
                Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
            },
            new MBTI_Question
            {
                Id = 3,
                NameQuestion = "Bạn đánh giá sự việc dựa trên : ",
                NameAns1 = "a. Ý nghĩa, giá trị.",
                NameAns2 = "b. Tính logic.",
                Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
            },
             new MBTI_Question
             {
                 Id = 4,
                 NameQuestion = "Bạn là người có tác phong : ",
                 NameAns1 = "a. Thong thả, thoải mái.",
                 NameAns2 = "b. Nhanh nhẹn, đúng giờ.",
                 Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                 FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                 SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                 CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
             },
              new MBTI_Question
              {
                  Id = 5,
                  NameQuestion = "Trong các cuộc giao tiếp, bạn là người : ",
                  NameAns1 = "a. Bắt đầu cho cuộc nói chuyện.",
                  NameAns2 = "b. Chỉ nói khi người khác bắt chuyện.",
                  Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                  FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                  SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                  CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
              },
               new MBTI_Question
               {
                   Id = 6,
                   NameQuestion = "Bạn là người thế nào : ",
                   NameAns1 = "a. Là người có cái đầu lạnh.",
                   NameAns2 = "b. Là người có trái tim ấm.",
                   Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                   FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                   SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                   CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
               },
                new MBTI_Question
                {
                    Id = 7,
                    NameQuestion = "Tính cách của bạn : ",
                    NameAns1 = "a. Dễ chịu, thoải mái.",
                    NameAns2 = "b. Nghiêm chỉnh, quả quyết.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 8,
                    NameQuestion = "Những người có tầm nhìn xa thường : ",
                    NameAns1 = "a. Khá thú vị.",
                    NameAns2 = "b. Khó hiểu.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 9,
                    NameQuestion = "Đối với những người mới gặp, bạn thường : ",
                    NameAns1 = "a. Dễ dàng bắt chuyện và trò chuyện nhiều điều cùng họ.",
                    NameAns2 = "b. Cảm thấy khó khăn và không biết nên nói gì.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 10,
                    NameQuestion = "Một công việc gây nhàm chán khi : ",
                    NameAns1 = "a. Không có quy trình cụ thể.",
                    NameAns2 = "b. Thiếu tính sáng tạo.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 11,
                    NameQuestion = "Bạn bị hấp dẫn bởi : ",
                    NameAns1 = "a. Sự hòa hợp với mọi người.",
                    NameAns2 = "b. Sự nhất quán trong suy nghĩ.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 12,
                    NameQuestion = "Bạn bị lôi cuốn bởi kiểu người : ",
                    NameAns1 = "a. Giàu trí tưởng tượng.",
                    NameAns2 = "b. Nắm bắt tình huống tốt.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 13,
                    NameQuestion = "Trong các cuộc trò chuyện bạn thường : ",
                    NameAns1 = "a. Dè dặt.",
                    NameAns2 = "b. Thoải mái.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 14,
                    NameQuestion = "Lựa chọn của bạn có xu hướng : ",
                    NameAns1 = "a. Tuân theo chuẩn mực.",
                    NameAns2 = "b. Đôi lúc không hiểu rõ nguyên nhân.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 15,
                    NameQuestion = "Trong hai điều sau, điều nào tồi tệ hơn : ",
                    NameAns1 = "a. Không công bằng.",
                    NameAns2 = "b. Tàn nhẫn.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 16,
                    NameQuestion = "Tính cách nào giống bạn hơn : ",
                    NameAns1 = "a. Kiên quyết.",
                    NameAns2 = "b. Nhẹ nhàng.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 17,
                    NameQuestion = "Đối với một vấn đề trong nhóm : ",
                    NameAns1 = "a. Độc lập giải quyết.",
                    NameAns2 = "b. Trao đổi với mọi người.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 18,
                    NameQuestion = "Trong cuộc sống, bạn cảm thấy hứng thú với : ",
                    NameAns1 = "a. Những điều bất ngờ không tính trước.",
                    NameAns2 = "b. Những điều có kế hoạch trước.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 19,
                    NameQuestion = "Bạn thấy tâm đắc với bản thân bởi sự : ",
                    NameAns1 = "a. Chắc chắn trong tư tưởng.",
                    NameAns2 = "b. Cống hiến hết mình.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 20,
                    NameQuestion = "Bạn nhìn nhận một vấn đề với : ",
                    NameAns1 = "a. Khả năng lý luận phân tích.",
                    NameAns2 = "b. Sự liên tưởng.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 21,
                    NameQuestion = "Trong các kỳ nghỉ lễ bạn có xu hướng : ",
                    NameAns1 = "a. Ở nhà cùng gia đình.",
                    NameAns2 = "b. Đi du lịch cùng bạn bè.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 22,
                    NameQuestion = "Bạn bị lôi cuốn bởi : ",
                    NameAns1 = "a. Các ngụ ý, hàm ý, ẩn ý.",
                    NameAns2 = "b. Các nguyên tắc, nguyên lý.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                });
        }
    }
}
