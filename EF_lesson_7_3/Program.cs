using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MobileContext db = new MobileContext())
            {
                db.Phones.Add(new Phone { Name = "Samsung Galaxy S5", Company = "Samsung", Price = 14000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 8000 });

                Smartphone s1 = new Smartphone { Name = "iPhone 6", Company = "Apple", Price = 32000, OS = "iOS" };
                db.Smarts.Add(s1);
                db.SaveChanges();

                foreach (Phone p in db.Phones)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);
                Console.WriteLine();
                foreach (Smartphone p in db.Smarts)
                    Console.WriteLine("{0} ({1}, {2}) - {3}", p.Name, p.Company, p.Price, p.OS);
            }
            Console.ReadLine();
        }
    }
}
