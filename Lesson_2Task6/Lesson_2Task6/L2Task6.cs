using System;

namespace Lesson_2Task6
{
	class L2Task6
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число: ");
			int x = int.Parse(Console.ReadLine());

			if ((-2 <= x) && (x >= 2))
			{
				Console.WriteLine(2 * x);
			}
			else
			{
				Console.WriteLine(-3 * x);
			}
		}
	}
}
