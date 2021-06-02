using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                //  When using group by in EF/EF Core, please be aware of:
                //  https://docs.microsoft.com/en-us/ef/core/querying/client-eval
                var groupResult = 
                    context
                    .Books
                    .AsEnumerable()             //  required. This forces the client evalutation
                    .GroupBy(b => b.Category);

                foreach (var g in groupResult)
                {
                    Console.WriteLine(g.Key);

                    foreach (var b in g)
                    {
                        Console.WriteLine($"{b}");
                        Console.WriteLine("-------------------------------------------------");
                    }
                }
            }

           
        }
    }

    class BookGroup
    {
        public string Key { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
