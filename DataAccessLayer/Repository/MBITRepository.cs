﻿using ApplicationContext;
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
    public class MBITRepository : GenericRepository<MBTI>, IMBITRepository
    {
        public MBITRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<MBTI>> GetDepartmentByMBTI(string mbti)
        {
            IQueryable<MBTI> query = _db;
            return await query
                   .Where(x => x.Name.Equals(mbti))
                   .Include(x => x.MBTI_Departments).ThenInclude(x => x.Department)
                   .ToListAsync();
        }
    }
}