using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			double b = 12.78;

			string operator4e = Console.ReadLine();
			switch (operator4e)
			{
				case "+":
					double sum = a + b;
					double withPercentage = sum + (sum * (10 / 100));
				default:
					break;
			}
		}
	}
}