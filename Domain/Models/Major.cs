using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Major : Base
    {
        public string MajorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public Department? Department { get; set;}
        public Guid DepartmentId { get; set;}
    }
}
