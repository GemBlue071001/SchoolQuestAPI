using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UniversityDepartment : Base
    {

        //
        public List<GroupDepartment> GroupDepartments { get; set; }
        public List<Major> Majors { get; set; }
        public University University { get; set; }
        public Guid UniversityId { get; set; }
    }
}
