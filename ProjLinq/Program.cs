using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var conntext = new ClassDbContext())
            {
                var firstСlass = new Shool()
                {
                    NameClass = "1А",
                    quantity = 14
                };

                conntext.Shools.Add(firstСlass);
                conntext.SaveChanges();

                Console.WriteLine($"id-{firstСlass.id} Class-{firstСlass.NameClass}  quantity-{firstСlass.quantity}");
            }
        }
    }
}
