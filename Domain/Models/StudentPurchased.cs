using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class StudentPurchased
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ExaminationId { get; set; }

        public User User { get; set; }
        public Examination Examination { get; set; }
    }
}
