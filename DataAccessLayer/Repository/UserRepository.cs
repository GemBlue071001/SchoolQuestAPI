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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<User>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<User> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(
                    b => b.Email!.Contains(search) ||
                    b.FirstName!.Contains(search) ||
                    b.UserName!.Contains(search) ||
                    b.LastName!.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted && b.Role != Domain.Enums.UserRole.Admin)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<User> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(
                    b => b.Email!.Contains(search) ||
                    b.FirstName!.Contains(search) ||
                    b.UserName!.Contains(search) ||
                    b.LastName!.Contains(search));

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }
    }
}
