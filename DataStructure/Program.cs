using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          Library library = new Library();


            Book book1 = new Book
            {
                Name = "Nadir",
                AuthorName = "Salman",
                PageCount = 1,
                No = 1
            };
            Book book2 = new Book
            {
                Name = "Nadir",
                AuthorName = "Salman",
                PageCount = 15,
                No = 2
            };
            Book book3 = new Book
            {
                Name = "Nizami",
                AuthorName = "Eli",
                PageCount = 20,
                No = 3
            };
            Book book4 = new Book
            {
                Name = "Vuqar",
                AuthorName = "Sarvan",
                PageCount = 25,
               
            };
            Book book5 = new Book();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            //Console.WriteLine(book5.No);

            //library.SearchBooks("Salam");
            //library.FindAllBooksByPageCountRange(0, 19);
            //library.FindAllBooksByName("Nadir");
            //library.RemoveByCode(4);
            //library.RemoveAllBookByName("Nadir");


        }



























    }
}

