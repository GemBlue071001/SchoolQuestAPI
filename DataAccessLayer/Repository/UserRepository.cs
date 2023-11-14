using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessLayer.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<User>> PagingAsync(int pageIndex, int pageSize, string search, bool isStudent)
        {
            IQueryable<User> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(
                    b => b.Email!.Contains(search) ||
                    b.FirstName!.Contains(search) ||
                    b.UserName!.Contains(search) ||
                    b.LastName!.Contains(search));
            if (isStudent)
                query = query.Where(b => b.Role != Domain.Enums.UserRole.Admin);

            return await query
                    .Where(b => !b.IsDeleted)
                    .Include(b => b.Attempts.OrderBy(x => x.Score))
                        .ThenInclude(x => x.AttemptDetails)
                            .ThenInclude(x => x.ExaminationQuestion)
                                .ThenInclude(x => x.Question)
                    .OrderBy(x => x.HighestScore)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search, bool isStudent)
        {
            IQueryable<User> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(
                    b => b.Email!.Contains(search) ||
                    b.FirstName!.Contains(search) ||
                    b.UserName!.Contains(search) ||
                    b.LastName!.Contains(search));

            if (isStudent)
                query = query.Where(b => b.Role != Domain.Enums.UserRole.Admin);

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }
    }
}
