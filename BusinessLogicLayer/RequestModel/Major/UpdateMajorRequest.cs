using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Major
{
    public class UpdateMajorRequest
    {
        public string MajorName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
