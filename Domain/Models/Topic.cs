using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Topic : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        
        //Navigation Prop
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }

        public List<Question> Questions { get; set; }
    }
}
