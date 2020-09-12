using System;
using System.Text;

namespace popocka2
{
    public static class Message
    {
        public static string[] message = new string[100];
        public static int n;

        public static void CreateMethod()
        {
            Console.WriteLine("Input number of words : "); n = Int32.Parse(Console.ReadLine());
 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input {i} word : ");
                message[i] = Console.ReadLine();
            }

            Console.WriteLine("Messages : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{message[i]} | ");
                Console.WriteLine("");
            }
        }

        public static void SizeMethod()
        {
            int m;

            Console.WriteLine("Input size of word : "); m = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (message[i].Length <= m)
                {
                    Console.WriteLine($"Message {i} : {message[i]}");
                }
            }
        }

        public static void lastletter()
        {
            string test;
            string s;

            Console.WriteLine("Input symbol : "); s = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                test = message[i].Substring(message[i].Length - 1);
                if(test == s)
                {
                    message[i - 1] = message[i];
                }
                else
                {
                    Console.Write($"{message[i]} | ");
                }
            }
        }

        public static void LongWord()
        {
            string max;

            max = message[0];

            for (int i = 0; i < n; i++)
            {         
                    if (max.Length < message[i].Length)
                    {
                        max = message[i];
                    }
            }
            Console.WriteLine($"The most long word {max}");
        }

        public static void MakeStringBild()
        {
            StringBuilder s = new StringBuilder("");

            string max;

            max = message[0];

            for (int i = 0; i < n; i++)
            {
                if (max.Length < message[i].Length)
                {
                    max = message[i];
                    s.Append(max);
                }
            }

            Console.WriteLine(s);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n ;

            Message.CreateMethod();
            Console.WriteLine("-----------------------MENU-----------------------");
            Console.WriteLine("||                   1.Size                     ||");
            Console.WriteLine("||                   2.Symbol                   ||");
            Console.WriteLine("||                   3.LongWord                 ||");
            Console.WriteLine("||                   4.StringBild               ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input n : "); n = Int32.Parse(Console.ReadLine());


            switch (n)
            {
                case 1 : Message.SizeMethod(); break;
                case 2 : Message.lastletter(); break;
                case 3 : Message.LongWord(); break;
                case 4 : Message.MakeStringBild(); break;
                default: Console.WriteLine("Error"); break;
            }

            
            
        }
    }
}
