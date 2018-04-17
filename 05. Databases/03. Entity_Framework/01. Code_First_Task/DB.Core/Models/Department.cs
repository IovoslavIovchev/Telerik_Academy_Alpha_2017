using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Core.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int? ManagerID { get; set; }
        
        public virtual Employee Employee { get; set; }

        public virtual ICollection<Employee> Employees{ get; set; }
    }
}
