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

        public async Task<List<University>> GetUniversitíeByCriteria(int pageIndex, int pageSize, string department, string name)
        {
            IQueryable<University> query = _db;
            if (!string.IsNullOrEmpty(name))
                query = query.Where(b => b.Name.Contains(name));

            if (!string.IsNullOrEmpty(department))
                query = query.Where(b => b.Name.Contains(department));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();

        }
    }
}
