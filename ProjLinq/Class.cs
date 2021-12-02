using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq
{
    class Class
    {
        public int id { get; set; }
        public string studentName { get; set; }
        public int age { get; set; }
        public int shoolID { get; set; }

        public virtual Shool Shool { get; set; }
    }
}
