using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IStudentPurchasedRepository : IGenericRepository<StudentPurchased>
    {
        Task<List<Examination>> GetStudentPurches(Guid userId);
    }
}
