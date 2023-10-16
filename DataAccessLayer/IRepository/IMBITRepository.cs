using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBITRepository : IGenericRepository<MBTI>
    {
        Task<List<MBTI>> GetDepartmentByMBTI(string mbti);
    }
}
