using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result1 = 88.IsEven();
			Console.WriteLine(result1);
			bool result2 = 89.IsEven();
			Console.WriteLine(result2);
			bool result3 = 98.IsOdd();
			Console.WriteLine(result3);
			bool result4 = 99.IsOdd();
			Console.WriteLine(result4);

			Console.ReadLine();
		}
	}
	public static class MyMath
	{
		public static bool IsEven(this int number)
		{
			return number % 2 == 0;
		}
		public static bool IsOdd(this int number)
		{
			return number % 2 == 1;
		}
	}
}
