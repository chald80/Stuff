using System;
using System.Linq;
using System.Net.Sockets;
using InClass_LINQ.Services;

namespace InClass_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieCatalog mc = new MovieCatalog();
            StudioCatalog sc = new StudioCatalog();

            //  var result1 = from m in mc.GetMovies() 
            //                             where m.Year < 1999 
            //  foreach (var m in result1)
            // {
            //
            //     Console.WriteLine(m);
            // }

            // var result2 = from m in mc.GetMovies()
            //               where m.Year < 1995
            //                             Select m

            var result = from m in mc.GetMovies()
                where m.Year < 1994
                select m;
            foreach (var m in result)
            {
                Console.WriteLine(m.Title);
            }



                 var result3 = mc.GetMovies();
            foreach (var m in result3)
            {
                Console.WriteLine($"{m.Title}{m.Year}");
            }


            var result4 = mc.GetMovies().OrderBy(m => m.Year);
            foreach (var m in result4)
            {
                Console.WriteLine($"{m.Title} {m.Year}");
            }








        }
    }
}
