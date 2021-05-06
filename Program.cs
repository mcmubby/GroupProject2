using System;

namespace GroupProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nigeria = Holiday.NigeriasIndependence();
            var xmas = new Holiday("Christmas", 25, "December");
            Console.WriteLine($"{nigeria._month} {nigeria._day} {nigeria._name}");
            System.Console.WriteLine($"{xmas._day} {xmas._month} {xmas._name}");
            Console.WriteLine(Holiday.inSameMonth(nigeria,xmas));
            var niu = Movie.CasinoRoyale();
            System.Console.WriteLine(Holiday.NigeriasIndependence()._month);
        }
    }
}
