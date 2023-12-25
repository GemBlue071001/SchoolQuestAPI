using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MBTI_UserRecord
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string? Result { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Navigation Property
        public User User { get; set; }
        public List<RecordDetail> RecordDetails { get; set; }
    }
}
