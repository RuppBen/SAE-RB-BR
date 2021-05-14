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
        public string PrintList(List<Säugetier> säugetierliste)
        {
            output = "\n";
            foreach (Säugetier item in säugetierliste)
            {
                output += item+"\n"+item.Verhalten_bei_Gefahr()+"\n\n";
            }
            return output;
        }
        public List<Säugetier> AddAnimal(List<Säugetier> säugetierliste, string name, string[] futter, string animal)
        {
            if (animal == "elefant")
            {
                säugetierliste.Add(new Elefant(name, futter));
            }
            else if(animal == "leopard")
            {
                säugetierliste.Add(new Leopard(name, futter));
            }
            else
            {
                System.Console.WriteLine("Error in Code");
            }
            return säugetierliste;
        }
    }
}