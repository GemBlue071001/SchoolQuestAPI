using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MBTI_Department
    {
        public int MBTI_Id { get; set; }
        public Guid DepartmentId { get; set; }

        //Navigation Property
        public MBTI MBTI { get; set; }
        public Department? Department { get; set; }
    }
}
