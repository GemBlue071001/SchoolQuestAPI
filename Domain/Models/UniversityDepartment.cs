using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UniversityDepartment : Base
    {


        //Navigation Property
        //public List<MBTI_Department> MBTI_Departments { get; set; }
        //public List<GroupDepartment> GroupDepartments { get; set; }
        //public List<Major> Majors { get; set; }
        public Department? Department { get; set; }
        public University University { get; set; }
        public Guid UniversityId { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
