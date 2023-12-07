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
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<Department>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Department> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Include(x => x.Majors)
                    .Take(pageSize).ToListAsync();

        }

        public async Task<int> CountPagingAsync(string search)
        {
            IQueryable<Department> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search));

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }

        public async Task<Department?> GetDepartmentDetailAsync(Guid id)
        {
            IQueryable<Department> query = _db;

            query = query.Where(b => b.Id == id);

            return await query
                    .Include(x => x.Majors)
                    .FirstOrDefaultAsync();

        }
    }
}
