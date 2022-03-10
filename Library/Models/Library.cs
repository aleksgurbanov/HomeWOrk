using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    class Library1 
    {
        private List<Book> _books;
        public List<Book> Books => _books;



        public Library1()
        {
            _books = new List<Book>();
        }
        public void RemoveByNo(string no)
        {
            Book book = Books.Find(b => b.Code == no);

            if (book == null)
            {
                Console.WriteLine("ilk once kitab elave et");
            }
            else Books.Remove(book);

        }

        
        public void RemoveAllBookByName(string name)
        {
            Books.RemoveAll(book => book.Name.Contains(name));

        }
        public List<Book> FindAllBooksByName(string name)
        {
            return Books.FindAll(book => book.Name.Contains(name));
            
        }

        public List<Book> FindAllBooksByPageCountRange(int enaz, int encox)
        {
            return Books.FindAll(b => b.PageCount >= enaz && b.PageCount <= encox);

        }
        public void Add(Book book)
        {
            

            _books.Add(book);

        }

    }
}