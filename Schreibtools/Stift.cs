using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Stift
    {
        //Prop
        public int Strichstärke { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }


        //Konstruktor

        public Stift(int strichstärke)
        {
            Strichstärke = strichstärke;
            Typ = "unbekannt";
            Farbe = ConsoleColor.Black;
               
        }

        public Stift(int strichstärke, ConsoleColor farbe) : this(strichstärke)
        {
            Farbe = farbe;
        }

        public abstract string void SchreibeText(string text);
        
    }
}
