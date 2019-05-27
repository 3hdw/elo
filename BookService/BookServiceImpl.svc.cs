using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BookService.models;
using System.Collections;

namespace BookService
{
    public class BookServiceImpl : IBookService
    {
        public static ArrayList books = new ArrayList();

        public void deleteBook(string title)
        {
            for(int i=0; i<books.Count; i++)
            {
                if (((Book)books[i]).title.Equals(title))
                {
                    books.RemoveAt(i);
                }
            }
        }

        public Book[] getBooks()
        {
            Book[] booksArray = new Book[books.Count];
            for(int i=0; i<booksArray.Length; i++)
            {
                booksArray[i] = (Book)books[i];
            }
            return booksArray;
        }

        public void updateBook(string title, Book updatedBook)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (((Book)books[i]).title.Equals(title))
                {
                    ((Book)books[i]).title = updatedBook.title;
                    ((Book)books[i]).author = updatedBook.author;
                    ((Book)books[i]).publisher = updatedBook.publisher;
                    ((Book)books[i]).yearOfPublishion = updatedBook.yearOfPublishion;
                }
            }
        }

        void IBookService.addBook(Book newBook)
        {
            books.Add(newBook);
        }

        Book IBookService.getBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (((Book)books[i]).title.Equals(title))
                {
                    return (Book)books[i];
                }
            }
            return null;
        }
    }
}
