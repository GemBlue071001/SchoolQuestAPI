using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subject : Base
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        //Navigation Prop 
        public List<SubjectGroup> SubjectGroups { get; set; }
        public List<Topic> Topics { get; set; }

    }
}
