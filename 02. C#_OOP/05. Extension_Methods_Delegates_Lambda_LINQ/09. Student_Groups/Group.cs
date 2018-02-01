using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Groups
{
    public class Group
    {
        private int groupNum;
        private string departmentName;

        public Group(int groupNum, string departmentName)
        {
            this.groupNum = groupNum;
            this.departmentName = departmentName;
        }

        public int GroupNumber => groupNum; 
        public string DepartmentName => departmentName; 
    }
}
