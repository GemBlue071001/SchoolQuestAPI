using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBTI_DepartmentRepository : IGenericRepository<MBTI_Department>
    {
        Task<List<MBTI_Department>> GetMBTIDepartment(int pageIndex, int pageSize, int mbtiId);
    }
}
