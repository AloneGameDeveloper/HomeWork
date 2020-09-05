using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    /*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
      б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
      в) Добавить диалог с использованием switch демонстрирующий работу класса. */

    struct Complex
    {
        public double a, b;

        public override string ToString()
        {
            if(Program.n == 1)
            {
                return $"{a} + {b}i";
            }
            else if(Program.n == 2)
            {
                return $"{a} - {b}i";
            }
            else
            {
                return $"{a} * {b}i";
            }

           
            
            
            

        }
    }
}
