using System;
using System.Threading;

namespace HomeWork2._6
{
    class Program
    {
        /* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * «Хорошим» называется число, которое делится на сумму своих цифр. 
         * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         */

        static void Main(string[] args)
        {
         
            int min = 1, max = 1000000, temp, testnum, goodnum = 0;

            long Time = DateTime.Now.Ticks;

            for (int num = min; num <= max; num++)
            {
                temp = 0;
                testnum = num;
                while (testnum != 0)
                {
                    temp += testnum % 10;
                    testnum /= 10;
                }
                if (num % temp == 0) goodnum++;
            }

            Console.WriteLine(goodnum);
            
            Thread.Sleep(10000);
            Time = DateTime.Now.Ticks - Time;
            Console.WriteLine($"Time : {Time} ");
        }
    }
}
