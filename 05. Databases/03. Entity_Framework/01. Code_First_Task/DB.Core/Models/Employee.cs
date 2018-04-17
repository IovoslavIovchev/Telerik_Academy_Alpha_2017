using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Core.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Departments = new HashSet<Department>();
            this.Employees = new HashSet<Employee>();
            this.Projects = new HashSet<Project>();
        }
        
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public decimal? Salary { get; set; }

        public int? AddressID { get; set; }

        public int? DepartmentID { get; set; }

        public int? ManagerID { get; set; }

        public DateTime HireDate { get; set; }

        //[ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        //[ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        //[ForeignKey("ManagerID")]
        public virtual Employee Manager { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
