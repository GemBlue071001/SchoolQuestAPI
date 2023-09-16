using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SubjectGroup
    {
        public Guid SubjectId { get; set; }
        public Guid GroupId { get; set; }

        //Navtigation Prop
        public Group Group { get; set; }
        public Subject Subject { get; set; }
    }
}
