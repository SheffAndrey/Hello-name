using System;

namespace Lesson_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как зовут тебя человек?   -   ");
            string username = Console.ReadLine();

            if (username.ToLower() == "андрей")
            {
                Console.WriteLine("Привет Андрюха");
            }
            else{
                Console.WriteLine("Привет, ");
                Console.WriteLine(username);
            }
        }
    }
}
