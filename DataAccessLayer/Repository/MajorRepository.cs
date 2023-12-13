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
    public class MajorRepository : GenericRepository<Major>, IMajorRepository
    {
        public MajorRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Major> query = _db;
            if (string.IsNullOrEmpty(search) is false)
            {
                query = query.Where(entry => entry.MajorName.Contains(search)
                                          || entry.DepartmentId == new Guid(search));
            }

            return await query
                            //.Where(entry => entry.IsDeleted)
                            .CountAsync();
        }
        public async Task<List<Major>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Major> query = _db;
            if (string.IsNullOrEmpty(search) is false)
            {
                query = query.Where(entry => entry.MajorName.Contains(search)
                                           || entry.DepartmentId == new Guid(search));
            }

            return await query
                        .Where(entry => !entry.IsDeleted)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToListAsync();
        }

        public async Task<Major?> GetMajorDetailAsync(Guid id)
        {
            IQueryable<Major> query = _db;

            return await query
                            .Where(entry => entry.Id == id)
                            .FirstOrDefaultAsync();
        }


    }
}
