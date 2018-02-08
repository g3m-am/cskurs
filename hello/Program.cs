

using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (;;)
            {
                Greeting();
                Age();
                Settings();
            }

            // string name = args[0];

            //snippet cw+2xTab
            //Console.WriteLine("Witaj, " + name);
            //Console.ReadKey();



            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj, " + item);
            //}  

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long longMax = long.MaxValue;

            Console.WriteLine("max int = " + maxInt);
            Console.WriteLine("min int = " + minInt);
        }


        /// <summary>
        /// ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// wiek uzytkownika
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("ile lat: ");
            //int age = int.Parse(Console.ReadLine());

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("jestes dorosly");
            }
            else
            if (!result)
            {
                Console.WriteLine("niepoprawna wartosc");
            }
            else
            {
                Console.WriteLine("za mlody");
            }
        }

        /// <summary>
        /// powitanie
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("wpisz imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
