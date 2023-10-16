using BusinessLogicLayer.ResponseModel.MBTI_Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModel.MBTI
{
    public class MBTIResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<MBTI_DepartmentResponse> MBTI_Departments { get; set; }  
    }
}
