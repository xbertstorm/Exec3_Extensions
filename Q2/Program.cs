using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入一字串：");
			string userinput = Console.ReadLine();
			Console.Write("請輸入一數字：");
			int num = int.Parse(Console.ReadLine());
			string result = string.Empty;

			result = userinput.StringLeft(num);
			Console.WriteLine(result);

			Console.ReadLine();
		}
	}
	public static class StringUtility
	{
		public static string StringLeft(this string input, int numinput)
		{
			return input.Substring(0,numinput);
		}
	}
}
