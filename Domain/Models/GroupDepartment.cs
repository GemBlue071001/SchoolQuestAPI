using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GroupDepartment 
    {
        public Guid DepartmentId { get; set; }
        public Guid GroupId{ get; set; }

        public Group Group { get; set; }
        public Department Department { get; set; }

    }
}
