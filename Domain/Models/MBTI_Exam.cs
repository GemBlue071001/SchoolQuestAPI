using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MBTI_Exam
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int NumberOfQuestion { get; set; }
        public Guid? CreatedBy { get; set; }

        //Navigation Property 
        public List<MBTI_ExamDetail> MBTI_ExamDetails { get; set; }
    }
}
