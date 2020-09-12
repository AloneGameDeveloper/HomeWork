using System;
using System.Text.RegularExpressions;

namespace popocka
{
    class Program
    {

        public static class ClassicClass
        {
            public static void RedexMethod()
            {
                string logininput, passwordinput;
                string test;
                string login, password;

                Console.WriteLine("Register : ");
                Console.Write("Login : "); login = Console.ReadLine();
                Console.Write("Password : "); password = Console.ReadLine();

                Console.WriteLine("Login : ");
                Console.Write("Input Login : "); logininput = Console.ReadLine();
                Console.Write("Input Password : "); passwordinput = Console.ReadLine();

                test = logininput.Substring(0, 1);

                if (logininput.Length > 10 || logininput.Length < 2)
                {
                    Console.WriteLine("The login is > 10 of < 2");
                }
                else
                {
                    if (Regex.IsMatch(test, @"\d"))
                    {
                        Console.WriteLine("First simbol is number.");
                    }
                    else
                    {
                        if (logininput == login)
                        {
                            if (passwordinput == password)
                            {
                                Console.WriteLine("U hacked the Pentagon))");
                            }
                            else
                            {
                                Console.WriteLine("Wrong Password");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Login");
                        }
                    }
                }
            }

            public static void VanillaMethod()
            {
                string logininput, passwordinput;
                string login, password;

                Console.WriteLine("Register : ");
                Console.Write("Login : "); login = Console.ReadLine();
                Console.Write("Password : "); password = Console.ReadLine();

                Console.WriteLine("Login : ");
                Console.Write("Input Login : "); logininput = Console.ReadLine();
                Console.Write("Input Password : "); passwordinput = Console.ReadLine();

                if (logininput.Length > 10 || logininput.Length < 2)
                {
                    Console.WriteLine("The login is > 10 of < 2");
                }
                else
                {
                    if (logininput[0] >= '0' && logininput[0] <= '9')
                    {
                        Console.WriteLine("First simbol is number.");
                    }
                    else
                    {
                        if (logininput == login && passwordinput == password)
                        {
                            Console.WriteLine("U hacked the Pentagon))");
                        }
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("-----------------------MENU-----------------------");
            Console.WriteLine("||                   1.RedexMethod              ||");
            Console.WriteLine("||                   2.Vanilla                  ||");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input n : "); n = Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1 : ClassicClass.RedexMethod(); break;
                case 2 : ClassicClass.VanillaMethod(); break;
                default : Console.WriteLine("Error"); break;
            }

        }
    }
}
