using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class University : Base
    {
        public string Name { get; set; }
        
        //Property Navigation
        public List<UniversityDepartment> UniversityDepartments { get; set; }
    }
}
