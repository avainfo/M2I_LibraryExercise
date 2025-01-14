using Library.Models;
using Xunit;
using Xunit.Abstractions;

namespace Library.Tests;

/// <summary>
/// Class for testing library manager
/// </summary>
public class LibraryTests
{

	[Fact]
	public void AddBook()
	{
		LibraryManager libManager = new LibraryManager();

		Book book = new Book("Test Book", "Moi Test", true);
		libManager.AddBook(book);
		Assert.Single(libManager.books);
		Assert.True(libManager.books[0] == book);
	}

	[Fact]
	public void FindBookByTitle()
	{
		LibraryManager libManager = new LibraryManager();

		Book book = new Book("Test Book", "Moi Test", true);
		Book book2 = new Book("Test Book", "Moi Test2", true);
		libManager.AddBook(book);
		libManager.AddBook(book2);

		Assert.True(book == libManager.FindBookByTitle("Test Book"));
		Assert.False(book == libManager.FindBookByTitle("TestBook"));
	}
}