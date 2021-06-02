using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Playground
{
    [Table("Books")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int NPages { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }

        public override string ToString()
        {
            return $"\tTitle: {Title}{Environment.NewLine}\tAuthor: {Author}{Environment.NewLine}\tCategory: {Category}{Environment.NewLine}\tPages: {NPages}{Environment.NewLine}\tPrice: {Price}{Environment.NewLine}\tPublisher: {Publisher}";
        }
    }
}
