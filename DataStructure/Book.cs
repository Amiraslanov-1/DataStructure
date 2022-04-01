using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Book
    {
        public Book()
        {
            _no++;
            No = _no;
            Count += PageCount;
            PageCount = 0;
        }
         static int _no;
        public int No { get; set;}
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount;
        public string Count { get }



    }
}
