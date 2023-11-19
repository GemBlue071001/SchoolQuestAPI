using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class MBTI_ExamQuestion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ExamId { get; set; }

        //property navigation 
        public MBTI_Exam MBTI_Exam { get; set; }
        public MBTI_Question MBTI_Question { get; set; }
        public List<RecordDetail> RecordDetails { get; set; }
    }
}
