using ApplicationContext;
using DataAccessLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _db;
        protected readonly HighSchoolQuestContext _context;

        public GenericRepository(HighSchoolQuestContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
        }
        public async Task<int> CountAsync() => await _db.CountAsync();

        public async Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
#nullable disable
            IQueryable<T> query = _db;
            return await query.FirstOrDefaultAsync(filter);
#nullable restore
        }

        public async Task RemoveByIdAsync(object id)
        {
#nullable disable
            T existing = await _db.FindAsync(id);
#nullable restore
            if (existing != null)
            {
                _db.Remove(existing);
            }
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

    }
}
