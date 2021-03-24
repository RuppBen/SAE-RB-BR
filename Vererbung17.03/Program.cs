using System;

namespace Vererbung17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Zylinder zylinder = new Zylinder(2, 2);
            Kegel kegel = new Kegel(2, 2);
            Kegeldings kegeldings = new Kegeldings(2, 2);
            
            System.Console.WriteLine("KegelVolumen: "+kegeldings.DVolumen());
            System.Console.WriteLine("KegelOberfläche "+kegeldings.DOberfläche());
            /*
            System.Console.WriteLine("Zylinder Oberfläche: "+zylinder.GetOberfläche());   
            System.Console.WriteLine("Zylinder Volumen: "+zylinder.GetVolumen());
            System.Console.WriteLine("Kegel Oberfläche: "+kegel.GetOberfläche());
            System.Console.WriteLine("Kegel Volumen: "+kegel.GetVolumen());
            */


        }
    }
}