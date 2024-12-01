using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Library
    {
        public List<Book> books = new List<Book>();

        public IReadOnlyList<Book> Books => books; // butun kitablar oxumag

        public Book this[int index] => (index >= 0 && index < books.Count)? books[index] : null;

        public void AddBook (Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(value.ToLower()))
                {
                    result.Add(book);
                }
            }
            return result;
        }
        public Book FindBookByCode (string Code)
        {
           var wantedBook = books.Find(x => x.Code == Code);
           return wantedBook;
        }
        public void RemoveALlBooksByName(string name)
        {
            books.RemoveAll(x => x.Name == name);
        }
        public List<Book> SearchBooks (string value)
        {
            List<Book> wantedBook = new List<Book>();
            foreach (var book in books)
            {
                if (book.Code == value || book.AuthorName == value)
                {
                    wantedBook.Add(book);
                    return wantedBook;
                }
            }
            return null;
        }
        
        public void RemoveBookByCode(string code)
        {
            var book = FindBookByCode(code);
            if (book != null)
            {
                books.Remove(book);
            }
        }
    }
}