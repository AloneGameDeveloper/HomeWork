using System;

namespace HomeWork2._5
{
    class Program
    {
        /* Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
         * нужно ли человеку похудеть, набрать вес или всё в норме. */

        static void Main(string[] args)
        {
            double m, h, i;

            Console.Write("Mass : "); m = Double.Parse(Console.ReadLine());
            Console.Write("Height : "); h = Double.Parse(Console.ReadLine());

            i = m / (h * h);

            Console.WriteLine($"Index = {i}");

            if(i < 18.5)
            {
                Console.WriteLine("To gain weight");
            }
            if(i > 18.5 || i < 25)
            {
                Console.WriteLine("Standart");
            }
            if(i > 25)
            {
                Console.WriteLine("Lose weight");
            }

        }
    }
}
