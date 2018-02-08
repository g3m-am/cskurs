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
            diary.AddRating(5);
            diary.AddRating(8.5f);
        }
    }


}
