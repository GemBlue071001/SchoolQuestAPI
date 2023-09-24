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
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<Subject>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Subject> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Include(x => x.Topics)
                    .Take(pageSize).ToListAsync();

        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Subject> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }
    }
}
