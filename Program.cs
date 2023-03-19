using System.Text;

namespace StringArrayFilter;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Please set the size of initial array");
		var arraySize = Convert.ToInt32(Console.ReadLine());
		var initinalStringArray = new string[arraySize];
		Console.Write("Please, fullfill initial array with value");
		for (var i = 0; i < arraySize; i++)
		{
			Console.WriteLine($"Please, set value for {i + 1}th element");
			initinalStringArray[i] = Console.ReadLine() ?? string.Empty;
		}

		Console.WriteLine(GetResultString(initinalStringArray));
	}

	private static string GetResultString(string[] initialArray)
	{
		var resultStringBuilder = new StringBuilder("[");
		foreach(var initialString in initialArray)
		{
			if(initialString.Length > 3)
			{
				continue;
			}

			resultStringBuilder.Append(initialString + ", ") ;
		}

		resultStringBuilder.Append(']');
		return resultStringBuilder.ToString();
	}
}
