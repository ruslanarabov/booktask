using System;
using BookLibrary;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Programming", "John Doe", 450);
        Book book2 = new Book("Cooking", "Jane Smith", 200);
        Book book3 = new Book("Programming Html", "John Smith", 300);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All Books:");
        foreach (var book in library.Books)
        {
            Console.WriteLine($"{book.Code} - {book.Name} by {book.AuthorName}, Pages: {book.PageCount}");
        }

        Console.WriteLine("\nBooks containing 'Programming':");
        var programmingBooks = library.FindAllBooksByName("Programming");
        foreach (var book in programmingBooks)
        {
            Console.WriteLine($"{book.Code} - {book.Name}");
        }

        Console.WriteLine("\nFinding book with code 'PR2':");
        var booksByCode = library.FindBookByCode("PR2");
        if (booksByCode != null)
        {
            Console.WriteLine($"{booksByCode.Code} - {booksByCode.Name}");
        }

        // Səhifə sayı aralığında kitablar
        Console.WriteLine("\nBooks with page count between 200 and 400:");
        var booksByPageCount = library.FindAllBooksByPageCountRange(200, 400);
        foreach (var book in booksByPageCount)
        {
            Console.WriteLine($"{book.Code} - {book.Name}");
        }

        // Kitabı koduna görə sil
        Console.WriteLine("\nRemoving book with code 'PR1':");
        library.RemoveBookByCode("PR1");

        Console.WriteLine("\nAll Books After Removal:");
        foreach (var book in library.Books)
        {
            Console.WriteLine($"{book.Code} - {book.Name}");
        }
    }
}
