﻿using BusinessLogicLayer.ResponseModel.Major;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.Department
{
    public class DepartmentResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

        public List<MajorResponse> Majors { get; set; }
    }
}
