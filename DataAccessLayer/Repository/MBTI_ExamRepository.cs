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

        public async Task<List<MBTI_Exam>> GetExam(int pageIndex, int pageSize)
        {
            IQueryable<MBTI_Exam> query = _db;
            return await query
                    .Include(x => x.MBTI_ExamQuestions)
                        .ThenInclude(x => x.MBTI_Question)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }
    }
}
