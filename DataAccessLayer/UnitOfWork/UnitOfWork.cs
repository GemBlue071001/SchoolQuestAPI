﻿using ApplicationContext;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using Domain.Models;
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
        private HighSchoolQuestContext _context;
        public IUserRepository Users { get; }
        public ISubjectRepository Subjects { get; }
        public ITopicRepository Topics { get; }
        public IUniversityRepository Universities { get; }
        public IQuestionRepository Questions { get; }
        public IExaminationRepository Examinations { get; }
        public IExaminationQuestionRepository ExaminationQuestions { get; }

        public IMajorRepository Major { get; }
        public IUniversityDepartmentRepository UniversityDepartments { get; }
        public IGroupDepartmentRepository GroupDepartments { get; }
        public IGroupRepository Groups { get; }
        public ISubjectGroupRepository SubjectGroups { get; }
        public IAttemptDetailRepository AttemptDetails { get; }
        public IAttemptRepository Attempts { get; }
        public IMBTI_DepartmentRepository MBTI_Departments { get; }
        public IMBITRepository MBITs { get; }
        public IMBTI_QuestionRepository MBTI_Questions { get; }
        public IMBTI_ExamRepository MBTI_Exams { get; }
        public IMBTI_ExamQuestionRepository MBTI_ExamQuestions { get; }
        public IMBTI_UserRecordRepository MBTI_UserRecords { get; }

        public UnitOfWork(HighSchoolQuestContext context)
        {
            _context = context;
            Users = new UserRepository(context);
            Subjects = new SubjectRepository(context);
            Topics = new TopicRepository(context);
            Universities = new UniversityRepository(context);
            Questions = new QuestionRepository(context);
            Examinations = new ExaminationRepository(context);
            ExaminationQuestions = new ExaminationQuestionRepository(context);
            Major = new MajorRepository(context);
            UniversityDepartments = new UniversityDepartmentRepository(context);
            GroupDepartments = new GroupDepartmentRepository(context);
            Groups = new GroupRepository(context);
            SubjectGroups = new SubjectGroupRepository(context);
            AttemptDetails = new AttemptDetailRepository(context);
            Attempts = new AttemptRepository(context);
            MBTI_Departments = new MBTI_DepartmentRepository(context);
            MBITs = new MBITRepository(context);
            MBTI_Questions = new MBTI_QuestionRepository(context);
            MBTI_Exams = new MBTI_ExamRepository(context);
            MBTI_ExamQuestions = new MBTI_ExamQuestionRepository(context);
            MBTI_UserRecords = new MBTI_UserRecordRepository(context);
        }
        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
