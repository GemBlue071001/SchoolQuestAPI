using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GroupDepartment 
    {
        public Guid UniversityDepartmentId { get; set; }
        public Guid GroupId{ get; set; }

        public Group Group { get; set; }
        public UniversityDepartment UniversityDepartment { get; set; }

    }
}
