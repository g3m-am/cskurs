using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Program
    {
        /// <summary>
        /// dzienniczek ocen
        /// </summary>
        /// <param name="args"> argumentem jest ocena w formacie x,xxxx </param>
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (;;)
            {
                Console.WriteLine("podaj ocene ");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                

                if (rating == 11)
                {
                    break;
                }

                if (result)
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("niepoprawna liczba");
                    }
            }


            Console.WriteLine("srednia = " + diary.CalculateAverage());
            Console.WriteLine("max = " + diary.GiveMaxRating());
            Console.WriteLine("a min to = " + diary.GiveMinRating());

            Console.ReadKey();
        }
    }


}
