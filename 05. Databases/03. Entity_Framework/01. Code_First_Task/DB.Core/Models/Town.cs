using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Core.Models
{
    public partial class Town
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
