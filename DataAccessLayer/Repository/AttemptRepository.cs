using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<List<Attempt>> GetStudentAttemptsPagingAsync(int pageIndex, int pageSize, string search, Guid userId)
        {
            IQueryable<Attempt> query = _db;

            query = query.Where(b => b.UserId == (userId));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Include(x => x.AttemptDetails)
                        .ThenInclude(x => x.ExaminationQuestion)
                            .ThenInclude(x => x.Question)
                     .Include(x=>x.User)   
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<List<Attempt>> GetAllAttemptsPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Attempt> query = _db;

            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.UserId == (Guid.Parse(search)));


            return await query
                    .Where(b => !b.IsDeleted)
                    .Include(x => x.AttemptDetails)
                        .ThenInclude(x => x.ExaminationQuestion)
                            .ThenInclude(x => x.Question)
                    .Include(x=>x.User)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> GetStudentAttemptCountAsync(string search, Guid userId)
        {
            IQueryable<Attempt> query = _db;

            query = query.Where(b => b.UserId == (userId));

            return await query
                    .Where(b => !b.IsDeleted)
                    .CountAsync();
        }

        public async Task<int> GetAllAttemptCountAsync(string search)
        {
            IQueryable<Attempt> query = _db;

            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.UserId == (Guid.Parse(search)));

            return await query
                    .Where(b => !b.IsDeleted)
                    .CountAsync();
        }

        public async Task<int?> GetHighestScore(Guid userId)
        {
            IQueryable<Attempt> query = _db;

            var score = await query
                    .Where(b => b.UserId == userId)
                    .OrderByDescending(x => x.Score)
                    .Take(1)
                    .Select(x => x.Score)
                    .FirstOrDefaultAsync();

            return score;
        }
    }
}
