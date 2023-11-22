using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<MBTI_Question>> PagingAsync(int pageIndex, int pageSize)
        {
            IQueryable<MBTI_Question> query = _db;
            

            return await query
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();

        }
    }
}
