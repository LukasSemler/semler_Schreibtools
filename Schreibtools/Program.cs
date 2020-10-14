using System;
using System.Collections.Generic;

namespace Schreibtools
{
    class Program
    {
        static void Main(string[] args)
        {
            Buntstift b1 = new Buntstift(3, ConsoleColor.Green);
            Buntstift b2 = new Buntstift(4, ConsoleColor.Blue);

            Kugelschreiber k1 = new Kugelschreiber(5);
            Kugelschreiber k2 = new Kugelschreiber(5);

            List<Stift> liste = new List<Stift>();
            liste.Add(k1);
            liste.Add(k2);
            liste.Add(b1);
            liste.Add(b2);


            foreach (var item in liste)
            {
                Console.ForegroundColor = item.Farbe;
                Console.WriteLine(item.SchreibeText("Hallo")); 
            }

        }
    }
}
