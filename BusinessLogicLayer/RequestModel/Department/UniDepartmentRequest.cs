using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Department
{
    public class UniDepartmentRequest
    {
        public Guid UniversityId { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
