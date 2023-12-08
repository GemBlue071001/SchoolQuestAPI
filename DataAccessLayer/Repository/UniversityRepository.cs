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
    }
}
