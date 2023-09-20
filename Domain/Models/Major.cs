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

        //Nav
        public UniversityDepartment UniversityDepartment { get; set;}
        public Guid UniversityDepartmentId { get; set;}
    }
}
