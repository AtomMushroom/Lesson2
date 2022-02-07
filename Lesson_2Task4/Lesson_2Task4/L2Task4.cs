using System;

namespace Lesson_2Task4
{
	class L2Task4
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите 3 целых числа:");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			if ((a!=b) && (b!=c) && (a!=c))
			{
				Console.WriteLine(true);
			}
			else
			{
				Console.WriteLine(false);
			}
		}
	}
}
