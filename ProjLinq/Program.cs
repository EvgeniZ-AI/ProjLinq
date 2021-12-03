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
                var secondClass = new Shool()
                {
                    NameClass = "2A",
                    quantity = 19
                };
                var thirdСlass = new Shool()
                {
                    NameClass = "3A",
                    quantity = 16
                };
                var fourthClass = new Shool()
                {
                    NameClass = "4A",
                    quantity = 20
                };

                conntext.Shools.Add(firstСlass);
                conntext.Shools.Add(secondClass);
                conntext.Shools.Add(thirdСlass);
                conntext.Shools.Add(fourthClass);
                conntext.SaveChanges();

                Console.WriteLine($"id-{firstСlass.id} Class-{firstСlass.NameClass}  quantity-{firstСlass.quantity}");
            }
        }
    }
}
