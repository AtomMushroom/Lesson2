using System;

namespace Lesson_2Task3
{
	class L2Task3
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите трехзначное число: ");
			int number = int.Parse(Console.ReadLine());
			int first = number / 100;
			int second = (number / 10) % 10;
			int third = number % 10;
			int result = first * 100 + second * 0 + third; // second не имеет смысла прибавлять
			Console.WriteLine(result);
		}
	}
}
