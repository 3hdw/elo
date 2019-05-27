using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.models
{
    public class Book
    {
        public Book() { }

        public Book(String title, String author, String publisher, int yearOfPublishion)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.yearOfPublishion = yearOfPublishion;
        }

        public String title { get; set; }
        public String author { get; set; }
        public String publisher { get; set; } 
        public int yearOfPublishion { get; set; } 

    }
}