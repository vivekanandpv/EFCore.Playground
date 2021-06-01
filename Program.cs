using System;
using System.Linq;

namespace EFCore.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                var books = context.Books.ToList();

                foreach (var book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine("--------------------------------------------");
                }
            }

           
        }
    }
}
