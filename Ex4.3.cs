using System;

namespace HomeWork4._3
{
    public static class ClassMethods
    {
        public static void CreateArray()
        {
            Console.Write("Input size of Array : "); Program.n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < Program.n; i++)
            {
                Console.Write($"{i+1} : "); Program.Array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array : ");
            for(int i = 0; i < Program.n; i++)
            {
                Console.Write($"{Program.Array[i]} | ");
            }
            Console.WriteLine("");
        }

        public static void Sum()
        {
            int sum = 0;

            for (int i = 0; i < Program.n; i++)
            {
                sum = sum + Program.Array[i];
            }

            Console.WriteLine(sum);
        }

        public static void Inverse()
        {
            int[] AnotherArray = new int[100];

            for(int i = 0; i < Program.n; i++)
            {
                Random random = new Random();
                AnotherArray[i] = random.Next(9);
            }

            Console.WriteLine("Array : ");
            for(int i = 0; i < Program.n; i++)
            {
                Console.Write($"{Program.Array[i]} | ");
            }
            Console.WriteLine("");

            Console.WriteLine("AnotherArray : ");
            for (int i = 0; i < Program.n; i++)
            {
                Console.Write($"{AnotherArray[i]} | ");
            }
            Console.WriteLine("");
        }

        public static void Multi()
        {
            int mult = 0;
            int[] sum = new int[Program.n];

            Console.WriteLine("Intpu multi num : "); mult = int.Parse(Console.ReadLine());

            for(int i = 0; i < Program.n; i++)
            {
                sum[i] = Program.Array[i] * mult; 
            }

            for(int i = 0; i < Program.n; i++)
            {
                Console.WriteLine($"{Program.Array[i]} * {mult} : {sum[i]}");
            }
        }

        public static void MaxCount()
        {
            int max = 0;
            int count = 0;

            for (int i = 0; i < Program.n; i++)
            {
                if(max < Program.Array[i])
                {
                    max = Program.Array[i];
                }
            }

            for(int i = 0; i < Program.n; i++)
            {
                if(Program.Array[i] == max)
                {
                    count++;
                }
            }

            Console.WriteLine($"Max num : {max}");
            Console.WriteLine($"Count : {count}");
        }
    }

    class Program
    {
        public static int[] Array = new int[100];
        public static int n;

        static void Main(string[] args)
        {
            int switchn = 0;
            ClassMethods.CreateArray();

            Console.WriteLine("1 : Sum of Array");
            Console.WriteLine("2 : Inverse");
            Console.WriteLine("3 : Multi");
            Console.WriteLine("4 : MaxCount");
            Console.Write("Input Num : "); switchn = int.Parse(Console.ReadLine());

            switch(switchn)
            {
                case 1 : ClassMethods.Sum(); break;
                case 2 : ClassMethods.Inverse(); break;
                case 3 : ClassMethods.Multi(); break;
                case 4 : ClassMethods.MaxCount(); break;
                default : Console.WriteLine("Error"); break;
            }
            
        }
    }
}
