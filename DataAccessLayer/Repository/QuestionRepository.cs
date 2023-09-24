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
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(HighSchoolQuestContext context) : base(context)
        {
        }
        public async Task<List<Question>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Question> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Content.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();

        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Question> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Content.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .CountAsync();
        }
    }
}
