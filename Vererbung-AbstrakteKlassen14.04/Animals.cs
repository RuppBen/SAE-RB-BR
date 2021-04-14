using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    class Elefant : Säugetier
    {
        public Elefant(string name, string[] futter) : base (name, futter)
        {
        }
        public Elefant() {}
        public override string Verhalten_bei_Gefahr()
        {
            return "Goes Tooooröööööööööööööööööööööööö";
        }

        public override string ToString()
        {
            return ("Ich heiße "+Name+" und bin ein Elefant");
        }
    }
    class Leopart : Säugetier
    {
        public Leopart(string name, string[] futter) : base (name, futter)
        {
        }
        public Leopart() {}
        public override string Verhalten_bei_Gefahr()
        {
            return ("brrrrrrrrrrrr scrraaaa brbr");
        }

        public override string ToString()
        {
            return ("Ich heiße "+Name+" und bin ein Leopart");
        }
    }
}