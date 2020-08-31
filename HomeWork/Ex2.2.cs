using System;

namespace HomeWork2._2
{
    /* Написать метод подсчета количества цифр числа. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");

            int num = int.Parse(Console.ReadLine());
            int i = 0;

            while (num > 0)
            {
                i++;
                num /= 10;
            }

            Console.WriteLine(i);

        }
    }
}
