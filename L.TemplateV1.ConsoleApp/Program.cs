using L.TemplateV1.Domain.Entity;
using L.TemplateV1.Infrasturture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TemplateDBContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new User: ");
                var name = Console.ReadLine();

                _User user = new _User();
                user._ID = "TEST1";
                user.Firstname = "Lucky";
                user.Lastname = "Putra";
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db._Users
                            orderby b.Firstname
                            select b;

                Console.WriteLine("All users in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Firstname);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
