using ApplicationContext;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }
        private HighSchoolQuestContext _context;
        public UnitOfWork(HighSchoolQuestContext context)
        {
            _context = context;
            Users = new UserRepository(context);
        }
        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
