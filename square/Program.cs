using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            int numb = int.Parse (input);
            int sqr = numb * numb;
            Console.WriteLine(sqr);
        }
    }
}
