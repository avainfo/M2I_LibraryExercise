using Library.Models;

namespace Library;

public class LibraryManager
{
    public List<Book> books;

    public LibraryManager()
    {
        books = new List<Book>();
    }

    // Add a book
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    
    // List all books
    public void ListBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }
    
    // Find a book by Title
    public Book? FindBookByTitle(string title)
    {
        try
        {
            Book book = books.First(book => book.Title == title);
            return book;
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        
        // foreach (Book book in books)
        // {
        //     if (book.Title == title)
        //     {
        //         return book;
        //     }
        // }
        // return null;
    }
}