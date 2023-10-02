using BusinessLogicLayer.RequestModel.AttempDetail;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Attemp
{
    public class NewAttemptRequest
    {
        public DateTime ExamDate { get; set; }
        public AttempType AttempType { get; set; }
        public List<AttemptDetailRequest> AttemptDetails { get; set; }
    }
}
