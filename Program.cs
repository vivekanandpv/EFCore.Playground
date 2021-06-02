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
                //  Projection: Every element of the source sequence is transformed to other element
                //  in this case, from Book to BookViewModel
                //  More about ViewModel here: https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel#Components_of_MVVM_pattern
                //  Similar concept is that of DTO: https://en.wikipedia.org/wiki/Data_transfer_object
                var books = 
                    context
                    .Books
                    .Select(b => new BookViewModel
                    {
                        Id = b.Id,
                        Author = b.Author,
                        Category = b.Category,
                        NPages = b.NPages,
                        Price = b.NPages,
                        Title = b.Title
                    })
                    .ToList();

                foreach (var book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine("--------------------------------------------");
                }
            }

           
        }
    }
}
