using System;

namespace Lesson_C_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число - ");
            int numberA = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            int numberB = Console.ReadLine();
            int Sum = numberA + numberB;
            Console.Write("Ответ на ваш запрос: ");
            Console.WriteLine(Sum);
        }
    }
}
