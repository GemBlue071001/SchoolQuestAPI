using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ExaminationQuestionRepository : GenericRepository<ExaminationQuestion> , IExaminationQuestionRepository
    {
        public ExaminationQuestionRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
