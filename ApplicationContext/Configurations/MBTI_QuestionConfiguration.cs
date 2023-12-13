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

            builder
            .HasIndex(q => q.NameAns1)
            .IsUnique();

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
                },
                new MBTI_Question
                {
                    Id = 23,
                    NameQuestion = "Khi quyết định việc gì bạn thường dựa vào : ",
                    NameAns1 = "a. Cảm nhận từ con tim.",
                    NameAns2 = "b. Những quy tắc chung.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                },
                new MBTI_Question
                {
                    Id = 24,
                    NameQuestion = "Bạn thích làm việc với người Sếp",
                    NameAns1 = "a. Làm việc có phương pháp, tổ chức tốt.",
                    NameAns2 = "b. Ứng biến xoay trở tốt trước khó khăn.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 25,
                    NameQuestion = "Bạn nghiêng về :",
                    NameAns1 = "a. Sự chắc chắn.",
                    NameAns2 = "b. Sự cởi mở.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 26,
                    NameQuestion = "Bạn là người có tư tưởng :",
                    NameAns1 = "a. Công tư phân minh.",
                    NameAns2 = "b. Bị tình cảm chi phối.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 27,
                    NameQuestion = "Bạn thích học các môn :",
                    NameAns1 = "a. Nghệ thuật.",
                    NameAns2 = "b. Khoa học.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 28,
                    NameQuestion = "Trong một nhóm bạn bè bạn thường :",
                    NameAns1 = "a. Trầm lặng, ít nói.",
                    NameAns2 = "b. Hoạt bát, vui vẻ.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 29,
                    NameQuestion = "Khi đánh giá một người bạn thường :",
                    NameAns1 = "a. Dựa vào vẻ ngoài của họ.",
                    NameAns2 = "b. Dựa vào cảm nhận của bạn.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 30,
                    NameQuestion = "Sẽ thật tai hại khi bạn :",
                    NameAns1 = "a. Quá nồng nhiệt, mong chờ.",
                    NameAns2 = "b. Quá khách quan.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 31,
                    NameQuestion = "Phong cách của bạn :",
                    NameAns1 = "a. Thích những thứ quen thuộc.",
                    NameAns2 = "b. Thích những điều mới mẻ.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 32,
                    NameQuestion = "Khi giải quyết một công việc thông thường, bạn sẽ :",
                    NameAns1 = "a. Tìm kiếm một cách làm mới.",
                    NameAns2 = "b. Làm theo cách mọi người hay làm.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.P,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.J,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 33,
                    NameQuestion = "Bạn thích làm việc :",
                    NameAns1 = "a. Độc lập.",
                    NameAns2 = "b. Theo nhóm.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 34,
                    NameQuestion = "Bạn có hành động theo bản năng :",
                    NameAns1 = "a. Hiếm khi.",
                    NameAns2 = "b. Hay xảy ra.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 35,
                    NameQuestion = "Trong cuộc sống, một người sẽ tốt hơn nếu :",
                    NameAns1 = "a. Giàu lý trí.",
                    NameAns2 = "b. Giàu cảm xúc.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 36,
                    NameQuestion = "Khi nghe một album nhạc mới, bạn thường nghe :",
                    NameAns1 = "a. Theo thứ tự.",
                    NameAns2 = "b. Phát ngẫu nhiên.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 37,
                    NameQuestion = "Bạn là người :",
                    NameAns1 = "a. Khéo léo, lanh lợi.",
                    NameAns2 = "b. Thẳng thắn, thực tế.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 38,
                    NameQuestion = "Sẽ khó khăn hơn khi bạn cố:",
                    NameAns1 = "a. Sử dụng người khác.",
                    NameAns2 = "b. Hiểu và chia sẻ với người khác.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 39,
                    NameQuestion = "Khi trình bày bạn thường :",
                    NameAns1 = "a. Diễn đạt trực tiếp nhất có thể.",
                    NameAns2 = "b. Diễn đạt một cách gián tiếp.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 40,
                    NameQuestion = "Khi cảm thấy buồn bạn thường :",
                    NameAns1 = "a. Tìm bạn bè tâm sự hoặc đi chơi.",
                    NameAns2 = "b. Muốn ở một mình cho khuây khỏa.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 41,
                    NameQuestion = "Đối với các hoạt động của cơ quan, lớp học :",
                    NameAns1 = "a. Tham gia khi bị ép.",
                    NameAns2 = "b. Năng nổ, tích cực.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 42,
                    NameQuestion = "Bạn cảm thấy thoải mái với :",
                    NameAns1 = "a. Những thứ không xác định.",
                    NameAns2 = "b. Những thứ có logic.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 43,
                    NameQuestion = "Cảm xúc của bạn thường được người khác :",
                    NameAns1 = "a. Dễ dàng nắm bắt.",
                    NameAns2 = "b. Giấu kín, khó nhận biết.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 44,
                    NameQuestion = "Thật tồi tệ khi :",
                    NameAns1 = "a. Hành xử thiếu cân nhắc.",
                    NameAns2 = "b. Chỉ trích, phê phán người khác.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 45,
                    NameQuestion = "Bạn muốn một sự kiện như thế nào :",
                    NameAns1 = "a. Chuẩn bị chu toàn trước.",
                    NameAns2 = "b. Diễn ra tự nhiên.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 46,
                    NameQuestion = "Bạn là người có tình cách :",
                    NameAns1 = "a. Dễ gần, hòa đồng.",
                    NameAns2 = "b. Thân thiện nhưng kín đáo.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 47,
                    NameQuestion = "Bạn có ưu điểm về :",
                    NameAns1 = "a. Trí tưởng tượng phong phú.",
                    NameAns2 = "b. Sự quan sát thực tế.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 48,
                    NameQuestion = "Khi quyết định điều gì đó, bạn tin vào :",
                    NameAns1 = "a. Linh cảm.",
                    NameAns2 = "b. Sự việc thực tế.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 49,
                    NameQuestion = "Bạn muốn được người khác khen ngợi như thế nào :",
                    NameAns1 = "a. Bạn là người có đầu óc suy luận.",
                    NameAns2 = "b. Bạn là người giàu tình cảm và sự tinh tế.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 50,
                    NameQuestion = "Bạn thích các sự việc xảy ra :",
                    NameAns1 = "a. Có chọn lựa và suy tính.",
                    NameAns2 = "b. Một cách tự nhiên.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 51,
                    NameQuestion = "Bạn hay hành động một cách :",
                    NameAns1 = "a. Bộc phát, linh hoạt.",
                    NameAns2 = "b. Kỹ lưỡng, cẩn thận.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.P,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.J,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 52,
                    NameQuestion = "Bạn muốn bổ sung thêm điều gì ở bản thân :",
                    NameAns1 = "a. Tình cảm dồi dào.",
                    NameAns2 = "b. Lý trí mạnh mẽ.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                //new MBTI_Question
                //{
                //    Id = 53,
                //    NameQuestion = "Bạn là người :",
                //    NameAns1 = "a. Mơ mộng và tưởng tượng.",
                //    NameAns2 = "b. Thực tế và thực dụng.",
                //    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                //    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                //    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                //    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                //},
                new MBTI_Question
                {
                    Id = 54,
                    NameQuestion = "Khi điện thoại bàn trong văn phòng công ty đổ chuông :",
                    NameAns1 = "a. Nhấc máy trước để nghe.",
                    NameAns2 = "b. Để cho đồng nghiệp nhấc máy.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 55,
                    NameQuestion = "Bạn mới tham gia một lớp Ngoại ngữ :",
                    NameAns1 = "a. Cố làm quen với nhiều người.",
                    NameAns2 = "b. Chỉ nói chuyện với vài người.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 56,
                    NameQuestion = "Theo bạn, các sự việc, sự kiện :",
                    NameAns1 = "a. Bản thân nó giải thích cho chính nó.",
                    NameAns2 = "b. Là bằng chứng giải thích cho các quy tắc, quy luật.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 57,
                    NameQuestion = "Bạn là người :",
                    NameAns1 = "a. Đa sầu đa cảm.",
                    NameAns2 = "b. Thực dụng, không bị chi phối bởi tình cảm.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 58,
                    NameQuestion = "Bạn thường quan tâm tới người khác thông qua :",
                    NameAns1 = "a. Những suy nghĩ của họ.",
                    NameAns2 = "b. Những gì họ làm được.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 59,
                    NameQuestion = "Bạn nghiêng về điều nào sau đây :",
                    NameAns1 = "a. Thói quen.",
                    NameAns2 = "b. Những điều mới mẻ.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 60,
                    NameQuestion = "Mọi việc sẽ tốt hơn nếu :",
                    NameAns1 = "a. Luôn được chuẩn bị kỹ lưỡng.",
                    NameAns2 = "b. Tùy cơ ứng biến.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 61,
                    NameQuestion = "Bạn thích mối quan hệ :",
                    NameAns1 = "a. Ít bạn nhưng chơi rất thân.",
                    NameAns2 = "b. Nhiều bạn nhưng không thân thiết lắm.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 62,
                    NameQuestion = "Nếu bạn là nhà văn, bạn sẽ viết bài theo cách :",
                    NameAns1 = "a. Diễn đạt lời văn qua các phép so sánh, ẩn dụ.",
                    NameAns2 = "b. Nghĩ sao viết vậy, diễn đạt rõ ràng.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 63,
                    NameQuestion = "Khi quyết định một việc :",
                    NameAns1 = "a. Phụ thuộc vào tâm trạng.",
                    NameAns2 = "b. Suy tính cẩn trọng.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.P,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.J,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 64,
                    NameQuestion = "Bạn thường hay đưa ra quyết định :",
                    NameAns1 = "a. Một cách chắn chắn.",
                    NameAns2 = "b. Không chắc lắm, có thể thay đổi sau.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 65,
                    NameQuestion = "Bạn là người sống thiên về :",
                    NameAns1 = "a. Nguyên tắc, lý trí.",
                    NameAns2 = "b. Cảm xúc, tình cảm.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 66,
                    NameQuestion = "Bạn thích thú với sự việc :",
                    NameAns1 = "a. Thực tế.",
                    NameAns2 = "b. Bất ngờ, mới mẻ",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 67,
                    NameQuestion = "Khi nói về một chủ đề mới lạ chưa gặp, bạn cảm thấy :",
                    NameAns1 = "a. Không hứng thú.",
                    NameAns2 = "b. Hào hứng.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 68,
                    NameQuestion = "Đối với một suy luận được nhiều người tin dùng, bạn sẽ :",
                    NameAns1 = "a. Kiểm tra lại trước khi áp dụng.",
                    NameAns2 = "b. Tin tưởng và áp dụng theo.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 69,
                    NameQuestion = "Điều gì làm cho bạn ấn tượng :",
                    NameAns1 = "a. Những thứ có tính logic cao.",
                    NameAns2 = "b. Những thứ gây cảm động.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.T,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.F,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 70,
                    NameQuestion = "Bạn là người có xu hướng thiên về :",
                    NameAns1 = "a. Những thứ thực tế và rõ ràng.",
                    NameAns2 = "b. Những suy đoán.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.S,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.N,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 71,
                    NameQuestion = "Ở một nơi đông người làm bạn :",
                    NameAns1 = "a. Không thoải mái.",
                    NameAns2 = "b. Thích thú.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 72,
                    NameQuestion = "Bạn đánh giá một người dựa trên :",
                    NameAns1 = "a. Hoàn cảnh nhất định.",
                    NameAns2 = "b. Nguyên tắc chung.",
                    Category = Domain.Enums.MBTI_Category.Thinking_Feeling,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.F,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.T,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 73,
                    NameQuestion = "Bạn được mời tới bữa tiệc của công ty :",
                    NameAns1 = "a. Ra về sớm vì không hào hứng lắm.",
                    NameAns2 = "b. Vui chơi hết mình cho đến khi tàn tiệc.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.I,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.E,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 74,
                    NameQuestion = "Khi làm việc bạn sẽ :",
                    NameAns1 = "a. Tuân thủ thời gian.",
                    NameAns2 = "b. Làm việc tùy hứng.",
                    Category = Domain.Enums.MBTI_Category.Judgment_Perception,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.J,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.P,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 75,
                    NameQuestion = "Khi đi tham dự một buổi liên hoan/tiệc tùng, bạn sẽ :",
                    NameAns1 = "a. Trò chuyện cùng nhiều người, quen hoặc không quen.",
                    NameAns2 = "b. Chỉ trò chuyện với một số người quen.",
                    Category = Domain.Enums.MBTI_Category.Extroversion_Introversion,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.E,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.I,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                },
                new MBTI_Question
                {
                    Id = 76,
                    NameQuestion = "Điều gì làm bạn cảm thấy tồi tệ :",
                    NameAns1 = "a. Những thứ mơ hồ, không rõ ràng.",
                    NameAns2 = "b. Những thứ nhàm chán, tẻ nhạt.",
                    Category = Domain.Enums.MBTI_Category.Sensing_Intution,
                    FirstAnswerType = Domain.Enums.MBTI_Letter.N,
                    SecondAnswerType = Domain.Enums.MBTI_Letter.S,
                    CreatedBy = Guid.Parse("a6be20e2-5927-4cce-bed4-258f919f82e6")
                }
                );
        }
    }
}
