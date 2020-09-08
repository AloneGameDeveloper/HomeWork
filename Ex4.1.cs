using System;

namespace HomeWrok4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Array = new int[20];
            int count = 0;

            Random random = new Random();
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-10000, 10000);
            }

            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} | ");
            }

            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] % 3 == 0 || Array[i+1] % 3 == 0)
                    count++;
                Console.WriteLine("Pairs Num : {0} and {1}", Array[i], Array[i + 1]);
            }
            Console.WriteLine("Pairs : " + count);

        }
    }
}
