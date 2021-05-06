using System;

namespace GroupProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var nigeria = Holiday.NigeriasIndependence();
            // var xmas = new Holiday("Christmas", 25, "December");
            // Console.WriteLine($"{nigeria._month} {nigeria._day} {nigeria._name}");
            // System.Console.WriteLine($"{xmas._day} {xmas._month} {xmas._name}");
            // Console.WriteLine(Holiday.inSameMonth(nigeria,xmas));
            // var niu = Movie.CasinoRoyale();
            // System.Console.WriteLine(Holiday.NigeriasIndependence()._month);

            Movie movieA = new Movie("a", "desert", "PG");
            Movie movieB = new Movie("b", "desert", "R");
            Movie movieC = new Movie("c", "desert", "PG13");
            Movie movieD = new Movie("d", "desert");

            Movie[] movieArray = {movieA, movieB, movieC, movieD};

           var result = Movie.getPG(movieArray);
           for (int i = 0; i < result.Length ; i++)
           {
               if (result[i] != null)
               {
                   Console.WriteLine($"{result[i]._title} {result[i]._studio} {result[i]._rating}");
               }
           }
        }
    }
}
