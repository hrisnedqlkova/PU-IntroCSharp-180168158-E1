using System;

namespace RectangleArea
{
	class Program
	{
		static void Main()
		{
			//Rectangle Area: A (area) = L (length) x W (width)
			Console.Write("Please write the length of your rectangle: ");
			decimal lengthSide = decimal.Parse(Console.ReadLine());
			Console.Write("Please write the width of your rectangle: ");
			decimal widthSide = decimal.Parse(Console.ReadLine());

			decimal area = lengthSide * widthSide;
			Console.WriteLine("The area of your rectangle is: {0}", area);
		}

     }

}
    

