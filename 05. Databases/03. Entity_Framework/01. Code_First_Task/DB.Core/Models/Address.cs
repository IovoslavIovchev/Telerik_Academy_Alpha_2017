using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Core.Models
{
    public partial class Address
    {
        public Address()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }

        public string AddressText { get; set; }

        public int? TownID { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
