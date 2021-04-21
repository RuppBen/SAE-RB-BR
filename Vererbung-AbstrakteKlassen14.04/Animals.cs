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
            return "Verhalten bei Gefahr:\nGoes Tooooröööööööööööööööööööööööö";
        }

        public override string ToString()
        {
            return base.ToString() + "Elefant";
        }
    }
    class Leopard : Säugetier
    {
        public Leopard(string name, string[] futter) : base (name, futter)
        {
        }
        public Leopard() {}
        public override string Verhalten_bei_Gefahr()
        {
            return ("Verhalten bei Gefahr:\nbrrrrrrrrrrrr scrraaaa brbr");
        }

        public override string ToString()
        {
            return base.ToString() + "Leopard";
        }
    }
}