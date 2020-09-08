using System;

namespace Test
{
    /*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
      б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
      в) Добавить диалог с использованием switch демонстрирующий работу класса. */


    class Program
    {
        static double sum;
        public static int n;

        static Complex SumPlus(Complex x, Complex y)
        {
            Complex res;

            res.a = x.a + y.a;
            res.b = x.b + y.b;

            return res;
        }

        static Complex SumMin(Complex x, Complex y)
        {
            Complex res;

            res.a = x.a - y.a;
            res.b = x.b - y.b;
            

            return res;
        }

        static Complex SumMult(Complex x, Complex y)
        {
            Complex res;

            res.a = x.a * y.a;
            res.b = x.b * y.b;
            sum = res.a + res.b;

            return res;
        }

        static void Main()
        {
            int n;
            Console.WriteLine("1.Exercise(Complex) ");
            Console.WriteLine("2.Exercise(TryParse) ");

            Console.WriteLine("Input Number : "); n = Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1 : MethodComplex(); break;
                case 2 : MethodTryParse(); break;
                default : Console.WriteLine("Error"); break;
            }
        }

        static void MethodComplex()
        {
            Console.WriteLine("1 : < + > ; 2 : < - > ; 3 : < * > ;");
            Console.WriteLine("Input n : "); n = int.Parse(Console.ReadLine());

            Complex z1;
            Console.WriteLine("Input z1.a : "); z1.a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input z1.b : "); z1.b = Double.Parse(Console.ReadLine());
            Console.WriteLine(z1);

            Complex z2;
            Console.WriteLine("Input z2.a : "); z2.a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input z2.b : "); z2.b = Double.Parse(Console.ReadLine());
            Console.WriteLine(z2);

            Console.WriteLine("--------------------------------");

            Complex z3;

            switch (n)
            {
                case 1: z3 = SumPlus(z1, z2); Console.WriteLine(z3); break;
                case 2: SumMin(z1, z2); Console.WriteLine($"{sum}i"); break;
                case 3: SumMult(z1, z2); Console.WriteLine($"{sum}i"); break;
            }
        }

        static void MethodTryParse()
        {
            string Num, sum = "";
            int res, ressum = 0;

            Console.WriteLine("Input Number(0 if wanna exit : )"); Num = Console.ReadLine();

            int.TryParse(Num, out res);

            while (res != 0)
            {
                Console.WriteLine($"Num : {Num}");
                if (res > 0 && res % 2 == 1)
                    ressum = ressum + res;

                Console.WriteLine("Input Number(0 if wanna exit : )"); Num = Console.ReadLine();

                int.TryParse(Num, out res);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine(ressum);
        }
      

      
    }
}
