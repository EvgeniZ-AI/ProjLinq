using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjLinq
{
    public class ClassDbContext : DbContext
    {
        protected ClassDbContext() :base("ShoolDbConnectionsString")
        {
        }
    }
}
