using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBTI_ExamRepository : IGenericRepository<MBTI_Exam>
    {
        Task<List<MBTI_Exam>> GetExam(int pageIndex, int pageSize);
    }
}
