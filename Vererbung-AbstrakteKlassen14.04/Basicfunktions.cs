using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    class Basicfunktiosn
    {   
        private string output;
        public string PrintArray(string[] array, int length)
        {
            output = null;
            for (int a = 0; a < length; a ++)
            {
                output += array[a]+"\n";
            }
            return output;
        }
        public string PrintListLeopart(List<Säugetier> säugetierliste)
        {
            output = "Leoparten:\n";
            foreach (Leopart item in säugetierliste)
            {
                output += item+"\n";
            }
            return output;
        }
        public string PrintListElefant(List<Säugetier> säugetierliste)
        {
            output = "Elefanten:\n";
            foreach (Elefant item in säugetierliste)
            {
                output += item+"\n";
            }
            return output;
        }
    }
}