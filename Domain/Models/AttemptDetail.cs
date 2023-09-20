using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AttemptDetail
    {
        public Guid AttemptId { get; set; }
        public Guid UserId { get; set; }
        public Guid ExaminationQuestionId { get; set; }

        public Attempt Attempt { get; set; }
        public User User { get; set; }
        public ExaminationQuestion ExaminationQuestion { get; set; }

    }
}
