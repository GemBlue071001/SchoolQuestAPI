using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class MBTI_ExamRepository : GenericRepository<MBTI_Exam>, IMBTI_ExamRepository
    {
        public MBTI_ExamRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<MBTI_Exam>> GetExam()
        {
            IQueryable<MBTI_Exam> query = _db;
            return await query
                    .Include(x => x.MBTI_ExamDetails)
                        .ThenInclude(x => x.MBTI_Question)
                    .ToListAsync();
        }
    }
}
