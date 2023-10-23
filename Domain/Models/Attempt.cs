using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Attempt : Base
    {
        public DateTime ExamDate { get; set; }
        public AttempType AttempType { get; set; }
        public int? Score { get; set; }
        public string? Result { get; set; }



        //Navigation Property
        public Guid UserId { get; set; }
        public List<AttemptDetail> AttemptDetails { get; set; }
        public User User { get; set; }
    }


    // Enum
    public enum AttempType
    {
        Knowledge,
        MBTI
    }
}
