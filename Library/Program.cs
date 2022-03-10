using System;
using Library.Models;
namespace LibraryHomeWork
{
    class Program
    {
        delegate void WriteDelegate<T>(T item);

        static void Main(string[] args)
        {

            Book book1 = new Book("Sefiller", "fyodor", 100);
            Book book2 = new Book("Salam", "fyodor", 10);
            Book book3 = new Book("Sagol", "fyodor", 30);
            Book book4 = new Book("Oldum ay allah", "fyodor", 100);
            Book book5 = new Book("bir iki yoxlama","fyodor", 100);


            Library1 library = new Library1();
            library.Add(book1);
            library.Add(book2); 
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);
            foreach (var item in library.FindAllBooksByName("Sefiller"))
            {
                Console.WriteLine(item);
            }
            foreach (var item in library.FindAllBooksByPageCountRange(10,30))
            {
                Console.WriteLine(item); ;
            }
            ////Bu hisseden sonra removeni yoxlayiram
            ///
            library.RemoveAllBookByName("Sefiller");
            foreach (var item in library.FindAllBooksByName("Sefiller"))
            {
                Console.WriteLine(item);
                ///yazdirmadi console.Ishleyir normal
            }
            library.RemoveByNo("SE11");
            foreach (var item in library.FindAllBooksByName("Sefiller"))
            {
                Console.WriteLine(item);
            }
          }

    }
}






