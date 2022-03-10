using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    class Book
    {
         public string Name { get; set; }
         public string AuthorName { get; set; }
         public int PageCount { get; set; }
         public string Code { get; set; }
        private static int _count = 10;

        public Book(string name, string authorName, int pagecount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pagecount;
            _count++;
            Code = $"{Name.Substring(0, 2).ToUpper()}{_count}";



        }
        public override string ToString()
        {
            return $"Adi: {Name}\nMuellifi: {AuthorName}\n Sehife Sayi: {PageCount}";
        }

    }
}
