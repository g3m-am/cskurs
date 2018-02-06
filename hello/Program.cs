

using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {

                Console.WriteLine("wpisz imie: ");
                string name = Console.ReadLine();
                Console.WriteLine("Witaj, " + name);

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

                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
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
    }
}
