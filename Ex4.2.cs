using System;
using System.IO;

namespace test3
{
    public static class StaticClass
    {
        public static void ClassMethod()
        {
            int[] Array = new int[20];
            int count = 0;

            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-10000, 10000);
            }

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} | ");
            }

            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] % 3 == 0 || Array[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Pairs Num : {0} and {1}", Array[i], Array[i + 1]);
            }
            Console.WriteLine("Pairs : " + count);
        }

        public static void FileMethod()
        {
            int[] aArray = new int [20];
            int a, count = 0;

            var lines = File.ReadAllLines(@"text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                a = Convert.ToInt32(lines[i]);
                aArray[i] = a;
            }

            Console.WriteLine("Array : ");
            for (int i = 0; i < aArray.Length; i++)
            {
                Console.Write($"{aArray[i]} | ");
            }
            Console.WriteLine("");

            for (int i = 0; i < aArray.Length - 1; i++)
            {
                if (aArray[i] % 3 == 0 || aArray[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Pairs Num : {0} and {1}", aArray[i], aArray[i + 1]);
            }
            Console.WriteLine("Pairs : " + count);

        }

            

        class Program
        {
            static void Main(string[] args)
            {
                int n;

                Console.WriteLine("1: ClassMehtod;");
                Console.WriteLine("2: FileMethod;");
                Console.WriteLine("Input Num : "); n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1: ClassMethod(); break;
                    case 2: FileMethod(); break;
                    default: Console.WriteLine("Error"); break;
                }
            }
        }
    }
}

