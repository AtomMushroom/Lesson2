using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2Lab1
{
    class L2Lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Введенное число отрицательное");
            }
            else
            {
                Console.WriteLine("Введеное число положительное");
            }
            Console.ReadKey();
        }
    }
}
