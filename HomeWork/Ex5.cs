using System;
using System.Threading.Tasks.Dataflow;

namespace Ex5
{

    /*Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.
     */

    //Дариус Гажим

    class Program
    {

        public static int d, e;

        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Number : "); a = int.Parse(Console.ReadLine());
            b = a;
            c = b;
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");

            ExB();
        }

        public static void ExB()
        {
            Console.Write("Number : "); d = int.Parse(Console.ReadLine());
            e = d;
            Console.WriteLine($"E = {e}");
        }
    }
}
