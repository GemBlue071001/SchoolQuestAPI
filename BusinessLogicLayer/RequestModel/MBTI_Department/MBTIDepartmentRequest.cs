using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.MBTI_Department
{
    public class MBTIDepartmentRequest
    {
        public int MBTI_Id { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
