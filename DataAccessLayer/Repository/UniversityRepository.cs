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
    public class UniversityRepository : GenericRepository<University>, IUniversityRepository
    {
        public UniversityRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<University>> GetUniversities()
        {
            IQueryable<University> query = _db;
            query = query.Include(x => x.UniversityDepartments)
                .ThenInclude(x => x.Department);
            return await query
                    .Where(b => !b.IsDeleted)
                    .ToListAsync();
        }

        public async Task<University?> GetUniversityDetail(Guid id)
        {
            IQueryable<University> query = _db;
            query = query.Include(x => x.UniversityDepartments)
                .ThenInclude(x => x.Department);
            return await query
                    .Where(b => b.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<List<University>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<University> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Include(x => x.UniversityDepartments)
                        .ThenInclude(x => x.Department)
                    .Take(pageSize).ToListAsync();

        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<University> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }
    }
}
