﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBTI_QuestionRepository : IGenericRepository<MBTI_Question>
    {
        Task<List<MBTI_Question>> PagingAsync(int pageIndex, int pageSize);
    }
}
