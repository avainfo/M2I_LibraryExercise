namespace Library;

public class Program
{
	public delegate void alert(string message);
	
	static void Main(string[] args)
	{
		// LibraryManager libManager = new LibraryManager();
		//
		// Book book1 = new Book("Livre 1", "Moi", true);
		// Book book2 = new Book("Livre 2", "Pas moi");
		// Book book3 = new Book("Livre 2", "Enfait si c'était moi");
		// libManager.AddBook(book1);
		// libManager.AddBook(book2);
		// libManager.AddBook(book3);
		//
		// libManager.ListBooks();
		//
		// Book? researchedBook = libManager.FindBookByTitle("Livre 2");
		// // if (researchedBook == null)
		// // {
		// // 	Console.WriteLine($"Researched book : {"Non trouvé"}");
		// // }
		// // else
		// // {
		// // 	Console.WriteLine($"Researched book : {researchedBook.Title}");
		// // }
		// Console.WriteLine($"Researched book : {(researchedBook is null ? "Not founded" : researchedBook.ToString())}");
		//
		// Book b = new Book("Antonin", "Antonin", true);
		//
		// Console.WriteLine(b.Available);
		//
		// List<int> test = [1, 2, 3, 4, 5, 6];
		//
		// // Where
		// List<int> filtered = test.Where(n => n + 1 == 2).ToList();
		//
		// List<string> test2 = ["az", "by", "cx", "dw"];
		//
		// // Order by
		// List<string> filtered2 = test2.OrderBy(value => value[1]).ToList();
		//
		// // Select || Reduce
		// List<string> test3 = test2.Select(n => n.ToUpper()).ToList();
		//
		// // First
		// int test4 = test.First(i => i % 2 == 0);
		//
		// // Any
		// bool test5 = test2.Any(s => s.Contains('e'));
		//
		// Console.WriteLine(string.Join(" ", filtered));
		// Console.WriteLine(string.Join(" ", filtered2));
		// Console.WriteLine(string.Join(" ", test3));
		// Console.WriteLine(string.Join(" ", test4));
		// Console.WriteLine(string.Join(" ", test5));
		// Console.WriteLine(string.Join(" ", test));
		// Console.WriteLine(string.Join(" ", test2));
	}

	public static int Addition(int a, int b)
	{
		return a + b;
	}

	public static int AdditionFromString(string a, string b)
	{
		int x;
		int y;
		try
		{
			x = int.Parse(a);
			y = int.Parse(b);
		}
		catch (FormatException e)
		{
			throw;
		}
		return x + y;
	}
}