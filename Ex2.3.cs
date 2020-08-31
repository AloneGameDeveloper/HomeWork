using System;

namespace HomeWork2._3
{
    /* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. */

    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int [100];
            int n, z = 0, sum = 0;

            Console.WriteLine("Input number > 0 (Input <0> if wanna end) : "); n = Int32.Parse(Console.ReadLine());
            if(n > 0)
            {
                if (n % 2 == 1)
                {
                    z++;
                    Array[0] = n;
                }
            }


            while(n != 0)
            {
                Console.WriteLine("Input number > 0 (Input <0> if wanna end) : "); n = Int32.Parse(Console.ReadLine());
                if(n > 0)
                {
                    if(n % 2 == 1)
                    {
                        Array[z] = n;
                        z++;
                    }
                    
                }
            }
            
            for (int j = 0; j < z; j++)
            {
                sum = sum + Array[j];
                Console.WriteLine($"{Array[j]} | ");
            }

            Console.WriteLine($"Sum is : {sum}");


        }
    }
}
