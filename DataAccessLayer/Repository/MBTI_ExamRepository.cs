using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;

namespace DataAccessLayer.Repository
{
    public class MBTI_ExamRepository : GenericRepository<MBTI_Exam> , IMBTI_ExamRepository
    {
        public MBTI_ExamRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
