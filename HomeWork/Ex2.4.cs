using System;

namespace HomeWork2._4
{
    class Program
    {

        /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

        static void Main(string[] args)
        {

           
            string login , password;
            int a = 0;
            
                do
                {
                    Console.WriteLine("Input Login : "); login = Console.ReadLine();
                    Console.WriteLine("Input Password : "); password = Console.ReadLine();

                    if (login == "root" || password == "GeekBrains")
                    {
                        Console.WriteLine("Succes");
                    a = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        a++;
                    }
                }
                while (a < 3);
            
            
            
        }
    }
}
