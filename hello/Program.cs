

using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = args[0];

            //snippet cw+2xTab
            //Console.WriteLine("Witaj, " + name);
            //Console.ReadKey();

            Console.WriteLine("wpisz imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);

            Console.WriteLine("ile lat: ");
            int age = int.Parse(Console.ReadLine());
            
            if (age > 18)
            {
                Console.WriteLine("jestes dorosly");
            }
            else
            {
                Console.WriteLine("za mlody");
            }

            Console.ReadKey();


            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj, " + item);
            //}  

        }
    }
}
