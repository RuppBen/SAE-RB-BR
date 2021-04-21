using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    abstract class Säugetier
    {
        public string Name {get; set;}
        public string[] Futter {get; set;}
        public Säugetier(string name, string[] futter)
        {
            Name = name;
            Futter = futter;
        }
        public Säugetier()
        {
        }
        public abstract string Verhalten_bei_Gefahr();

        public override string ToString()
        {
            return ("Ich Heiße "+Name+" und bin ein ");
        }
    }
}