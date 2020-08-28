using System;

namespace Ex1
{
  /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
    В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.*/

    //Дариус Гажим

    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;

            Console.Write("Name : "); name = Console.ReadLine();
            Console.Write("Surname : "); surname = Console.ReadLine();
            Console.Write("Age : ");  age = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Surname : {0}", surname);
            Console.WriteLine($"Age : {age}");
        }
    }
}
