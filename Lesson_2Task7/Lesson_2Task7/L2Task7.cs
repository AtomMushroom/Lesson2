using System;

namespace Lesson_2Task7
{
	class L2Task7
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число: ");
			int x = int.Parse(Console.ReadLine());
			if (x<=0)
			{
				Console.WriteLine(6 - x);
			}
			else
			{
				Console.WriteLine(2 * Math.Sin(x));
			}
		}
	}
}
