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
                    quantity = 5
                };
                var secondClass = new Shool()
                {
                    NameClass = "2A",
                    quantity = 8
                };
                var thirdСlass = new Shool()
                {
                    NameClass = "3A",
                    quantity = 3
                };
                var fourthClass = new Shool()
                {
                    NameClass = "4A",
                    quantity = 6
                };

                conntext.Shools.Add(firstСlass);
                conntext.Shools.Add(secondClass);
                conntext.Shools.Add(thirdСlass);
                conntext.Shools.Add(fourthClass);

                var PetiaSidorov = new Class()
                {
                    studentName = "Петя Сидоров",
                    age = 6,
                    shoolID = 1
                };
                var EvgeniiRasskazov = new Class()
                {
                    studentName = "Евгений Рассказов",
                    age = 7,
                    shoolID = 1
                };
                var AleksandrVoskresenski = new Class()
                {
                    studentName = "Александр Воскресенский",
                    age = 7,
                    shoolID = 1
                };
                var AleksandrMoshalin = new Class()
                {
                    studentName = "Александр Мочалин",
                    age = 6,
                    shoolID = 1
                };
                var AlinaBorovkova = new Class()
                {
                    studentName = "Алина боровкова",
                    age = 6,
                    shoolID = 1
                };

                conntext.Classes.Add(PetiaSidorov);
                conntext.Classes.Add(EvgeniiRasskazov);
                conntext.Classes.Add(AlinaBorovkova);
                conntext.Classes.Add(AleksandrMoshalin);
                conntext.Classes.Add(AleksandrVoskresenski);

                conntext.SaveChanges();


            }
        }
    }
}
