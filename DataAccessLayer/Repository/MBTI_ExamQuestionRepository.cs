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
    public class MBTI_ExamQuestionRepository : GenericRepository<MBTI_ExamQuestion>, IMBTI_ExamQuestionRepository
    {
        public MBTI_ExamQuestionRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
