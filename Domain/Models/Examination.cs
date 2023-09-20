using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Examination : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalNumberOfQuestion { get; set; }

        //Navigation Property
        public List<ExaminationQuestion> ExaminationQuestions { get; set; }
    }
}
