using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> test = new List<string> { "5689", "-56", "ds58c", "002" };
			int[] result = test.Where(x => x.CanConvert2Int()).Select(x => x.ToInt(1)).ToArray();

			foreach(var x in result)
			{
				Console.WriteLine(x);
			}

			Console.ReadLine();
		}
	}
	public static class StringExtension
	{
		public static int ToInt(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);
			return isInt ? number : defaultValue;
		}
		public static bool CanConvert2Int(this string source)
		{
			return int.TryParse(source, out int number);
		}
	}
}
