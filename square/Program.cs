using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numb = Console.ReadLine();
            int sqr = numb * numb;
            Console.WriteLine(sqr);
        }
    }
}
