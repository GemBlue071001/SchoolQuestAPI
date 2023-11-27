using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task RemoveByIdAsync(object id);
        Task<int> CountAsync();
        Task AddRangeAsync(List<T> entities);
        Task<List<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>? filter);
    }
}
