using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Book
    {
        public int id { get; set; }

        public string title { get; set; } = null!;

        public string ISBN { get; set; } = null!;

        public Decimal price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublishedYear { get; set; }

        public bool InStock { get; set; }

        public int AuthorId { get; set; }          
        public Author Author { get; set; } = null!;

        public int CategoryId { get; set; }         
        public Category Category { get; set; } = null!;



    }
}
