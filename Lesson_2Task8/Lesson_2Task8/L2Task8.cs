using System;

namespace Lesson_2Task8
{
	class L2Task8
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число от 1 до 7: ");
			string choice = Console.ReadLine();
			string day;

			switch (choice)
			{
				case "1":
					Console.WriteLine("Черный понедельник...");
					break;
				case "2":
					Console.WriteLine("Вторник");
					break;
				case "3":
					Console.WriteLine("Среда");
					break;
				case "4":
					Console.WriteLine("Четверг");
					break;
				case "5":
					Console.WriteLine("УРААА ПЯТНИЦА");
					break;
				case "6":
					Console.WriteLine("УРААА СУББОТА");
					break;
				case "7":
					Console.WriteLine("УРААА ВОСКРЕСЕНЬЕ");
					break;
				default:
					Console.Write("Дня недели не существует!");
					break;
			}

		}
	}
}
