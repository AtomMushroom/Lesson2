using System;

namespace Lesson_2Task5
{
	class L2Task5
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите 3 стороны треугольника: ");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
			{
				Console.WriteLine("Треугольник существует!");
				double p = (a + b + c) / 2.0;
				double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
				Console.WriteLine("Площадь треугольника: ");
				Console.WriteLine(s);
			}
			else
			{
				Console.WriteLine("Треугольник не существует!");
			}
		}
	}
}
