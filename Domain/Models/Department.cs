using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Department : Base
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public float? RequiredScore { get; set; }
        public string? Description { get; set; }


        //Navigation Property
        public List<UniversityDepartment> UniversityDepartments { get; set; }
        public List<GroupDepartment> GroupDepartments { get; set; }
        public List<Major> Majors { get; set; }
        public List<MBTI_Department> MBTI_Departments { get; set; }
    }
}
