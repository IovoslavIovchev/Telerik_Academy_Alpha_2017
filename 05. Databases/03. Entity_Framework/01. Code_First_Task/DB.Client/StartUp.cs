using DB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Client
{
    class StartUp
    {
        static void Main()
        {
            var db = new TelerikContext();

            db.SaveChanges();
        }
    }
}
