using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Attempt : Base
    {
        //Navigation Property

        public List<AttemptDetail> AttemptDetails { get; set; }
    }
}
