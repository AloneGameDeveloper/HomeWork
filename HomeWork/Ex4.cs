using System;

namespace Ex4
{

    /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
      r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
      б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
     */

    //Дариус Гажим

    class Program
    {

       public static int x1, x2, y1, y2;
       public static double r;

        static void Main(string[] args)
        {
            

            Console.Write("X1 : "); x1 = int.Parse(Console.ReadLine());
            Console.Write("Y1 : "); y1 = int.Parse(Console.ReadLine());
            Console.Write("X2 : "); x2 = int.Parse(Console.ReadLine());
            Console.Write("Y2 : "); y2 = int.Parse(Console.ReadLine());

            calculations();

            Console.Write("{0:f2}", r);
        }

        public static void calculations()
        {
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
