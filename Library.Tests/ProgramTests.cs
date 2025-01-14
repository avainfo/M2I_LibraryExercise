using Library;
using Xunit;

namespace Library.Tests;

public class ProgramTests
{
	[Fact]
	public void AdditionTest()
	{
		int result = Program.Addition(20, 40);
		Assert.Equal(60, result);
	}

	[Fact]
	public void AdditionFromStringTest()
	{
		int result = Program.AdditionFromString("20", "40");
		Assert.Equal(60, result);
	}

	[Fact]
	public void AdditionFromStringExceptionTest()
	{
		Action function = () => Program.AdditionFromString("aa", "aa");
		Assert.Throws<FormatException>(function);
	}
}