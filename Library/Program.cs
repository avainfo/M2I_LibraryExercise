using Library.Models;

namespace Library;

class Program
{
	static void Main(string[] args)
	{
		LibraryManager libManager = new LibraryManager();

		Book book1 = new Book("Livre 1", "Moi", true);
		Book book2 = new Book("Livre 2", "Pas moi", false);
		Book book3 = new Book("Livre 2", "Enfait si c'était moi", false);
		libManager.AddBook(book1);
		libManager.AddBook(book2);
		libManager.AddBook(book3);

		libManager.ListBooks();

		Book? researchedBook = libManager.FindBookByTitle("Livre 2");
		// if (researchedBook == null)
		// {
		// 	Console.WriteLine($"Researched book : {"Non trouvé"}");
		// }
		// else
		// {
		// 	Console.WriteLine($"Researched book : {researchedBook.Title}");
		// }
		Console.WriteLine($"Researched book : {(researchedBook is null ? "Not founded" : researchedBook.ToString())}");
	}
}