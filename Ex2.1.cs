using System;

namespace HomeWork2
{

    /* Написать метод, возвращающий минимальное из трёх чисел. */


    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[100];
            int n, min = 0;

            Console.Write("Input size of array : "); n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Num[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write($"{Num[i]} | ");
            }

            for(int i = 0; i < n; i++)
            {
                if(Num[i] < Num[i + 1])
                {
                    min = Num[i];
                }
            }

            Console.WriteLine();

            Console.Write(min);
        }
    }
}
