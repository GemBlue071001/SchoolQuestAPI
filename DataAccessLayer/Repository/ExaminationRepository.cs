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
    public class ExaminationRepository : GenericRepository<Examination>, IExaminationRepository
    {
        public ExaminationRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<Examination>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Examination> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> CountPagingAsync(string search)
        {
            IQueryable<Examination> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .CountAsync();
        }

        public async Task<Examination?> GetExamDetailAsync(Guid id)
        {
            return await _db.Where(x => x.Id == id)
                            .Include(x => x.ExaminationQuestions)
                                .ThenInclude(x => x.Question)
                            .FirstOrDefaultAsync();
        }
    }
}
