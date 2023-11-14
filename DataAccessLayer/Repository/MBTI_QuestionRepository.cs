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
    public class MBTI_QuestionRepository : GenericRepository<MBTI_Question>, IMBTI_QuestionRepository
    {
        public MBTI_QuestionRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
