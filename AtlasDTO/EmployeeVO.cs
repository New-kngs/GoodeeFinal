﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasDTO
{
    public class EmployeeVO
    {
        public string EmpID { get; set; }

        public string EmpName { get; set; }

        public string EmpPwd { get; set; }

        public string EmpPhone { get; set; }

        public string EmpEmail { get; set; }

        public string DeptName { get; set; }

        public DateTime Createtime { get; set; }

        public string CreateUser { get; set; }

        public DateTime ModifyDate { get; set; }

        public string ModifyUser { get; set; }

        public char DeleteYN { get; set; }

    }
}
