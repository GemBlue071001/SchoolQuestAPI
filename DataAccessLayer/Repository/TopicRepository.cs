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
    public class TopicRepository : GenericRepository<Topic>, ITopicRepository
    {
        public TopicRepository(HighSchoolQuestContext context) : base(context)
        {
        }
        public async Task<List<Topic>> PagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Topic> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search) || b.SubjectId == new Guid(search));

            return await query
                    .Where(b => !b.IsDeleted)
                    .Include(x => x.Questions)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToListAsync();
        }

        public async Task<int> CountPagingAsync(int pageIndex, int pageSize, string search)
        {
            IQueryable<Topic> query = _db;
            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Name.Contains(search) || b.SubjectId == new Guid(search));

            return await query
          .Where(b => !b.IsDeleted)
          .CountAsync();
        }


        public async Task<List<Topic>> GetTopicBySubjectAsync(Guid subjectId)
        {
            IQueryable<Topic> query = _db;
            return await query
                    .Where(b => b.SubjectId == subjectId)
                    .Include(x => x.Questions)
                    .ToListAsync();
        }
    }
}
