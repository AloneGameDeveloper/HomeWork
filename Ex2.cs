using System;

namespace Ex2
{
    /*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
      где m — масса тела в килограммах, h — рост в метрах.
     */

    //Дариус Гажим

    class Program
    {
        static void Main(string[] args)
        {
            float m, h, i;

            Console.Write("Mass : "); m = float.Parse(Console.ReadLine());
            Console.Write("Height : "); h = float.Parse(Console.ReadLine());

            i = m / (h * h);

            Console.Write($"Index = {i}");
        }
    }
}
