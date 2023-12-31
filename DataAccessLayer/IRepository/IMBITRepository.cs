﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBITRepository : IGenericRepository<MBTI>
    {
        Task<MBTI?> GetMBTIDetail(int id);
        Task<MBTI?> GetMBTIDetailByCode(string code);
    }
}
