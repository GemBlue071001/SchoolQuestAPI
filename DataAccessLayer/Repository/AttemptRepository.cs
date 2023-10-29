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
    internal class AttemptRepository : GenericRepository<Attempt>, IAttemptRepository
    {
        public AttemptRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<Attempt>> GetAttemptsPagingAsync(int pageIndex, int pageSize, string search, Guid userId)
        {
            IQueryable<Attempt> query = _db;
            //if (!string.IsNullOrEmpty(search))
            //    query = query.Where(b => b..Contains(search) || b.SubjectId == new Guid(search));

            return await query
                    .Where(b => !b.IsDeleted && b.UserId == userId)
                    .Include(x => x.AttemptDetails)
                        .ThenInclude(x => x.ExaminationQuestion)
                            .ThenInclude(x => x.Question)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> GetAttemptCountAsync(string search, Guid userId)
        {
            IQueryable<Attempt> query = _db;

            return await query
                    .Where(b => !b.IsDeleted && b.UserId == userId)
                    .CountAsync();
        }
    }
}
