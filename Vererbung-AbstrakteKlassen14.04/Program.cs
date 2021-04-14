using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Säugetier> säugetier1 = new List<Säugetier>(); //Elefant Liste
            List<Säugetier> säugetier2 = new List<Säugetier>(); //Leopart Liste 
            // Separate Liste Funktioniert nicht 
            Elefant elefant;
            Leopart leopart;
            string[] leopartFutter = new string[] {"Käfer","kleine Affen","Nagetiere","Fische","Antilopen","Impala"};
            string[] elefantFutter = new string[] {"Gras", "Ästen", "allerlei Baumrinde", "Blättern", "Früchten", "Wurzeln"};

            säugetier1.Add(elefant = new Elefant());
            säugetier2.Add(leopart = new Leopart());

            foreach ( Elefant item in säugetier1)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            
            foreach ( Leopart item in säugetier2)
            {
                System.Console.WriteLine(item);
            }
            
        }
    }
}
