using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Library
    {
        public List<Book> books = new List<Book>();


        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> newbooks = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Name.Contains(name))
                {
                    newbooks.Add(book);
                }
            }
            return newbooks;

        }

//         public List<Book> FindAllBooksByName(string name)
//         {
//             List<Book> newbooks = new List<Book>();

//             foreach (Book book in books)
//             {
//                 if (book.Name == name)
//                 {
//                     newbooks.Add(book);
//                 }
//             }
//             return newbooks;

//         }

        //Elave ozumden yeqinki buna gore basl kesmersiz,Add ilede yaza bilerdim :)
        public void AddBook(Book book)
        {
            books.Add(book);
        }


        
         public void RemoveAllBookByName(string name)
              {
               foreach (Book book in books)
                {
                 if (book.Name.Contains(name))
                    {
                       books.Remove(book);
                        return;
                    }
                }

            }   
//         public void RemoveAllBookByName(string name)
//         {
//             foreach (Book book in books)
//             {
//                 if (book.Name == name)
//                 {
//                     books.Remove(book);
//                     return;
//                 }
//             }

//         }


       
        public List<Book> SearchBooks(string search)
        {
            List<Book> filteredbooks = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Name.Contains(search) )
                {
                    filteredbooks.Add(book);
                }
                if(book.AuthorName.Contains(search))
                {
                     filteredbooks.Add(book);
                }  
                if(book.Count.Contains(search))
                {
                     filteredbooks.Add(book);
                }   
                
            }
            return filteredbooks;
        }
        
//         public List<Book> SearchBooks(string search)
//         {
//             List<Book> filteredbooks = new List<Book>();
//             foreach (Book book in books)
//             {
//                 if (book.Name == search)
//                 {

//                     filteredbooks.Add(book);
//                 }
//                 else if (book.AuthorName == search)
//                 {
//                     filteredbooks.Add(book);
//                 }
//                 else if (book.Count == search)
//                 {
//                     filteredbooks.Add(book);
//                 }

//             }
//             return filteredbooks;

//         }
        
        
        
        
        
        public List<Book> FindAllBooksByPageCountRange(int minCount, int maxCount)
        {
            List<Book> filteredbooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.PageCount >= minCount && book.PageCount <= maxCount)
                {
                   
                    filteredbooks.Add(book);
                }
            }
            return filteredbooks;
        }
    
        
    

        public void RemoveByCode(int no)
        {
            List<Book> filteredbooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.No==no)
                {
                    books.Remove(book);
                    return;
                }
               
                    
            }

        }
    }
}
