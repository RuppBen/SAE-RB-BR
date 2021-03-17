using System;

namespace Vererbung17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Zylinder zylinder = new Zylinder(2, 2);
            Kegel kegel = new Kegel(2, 2);
            System.Console.WriteLine("Zylinder Oberfläche: "+zylinder.GetZylinderOberfläche());   
            System.Console.WriteLine("Zylinder Volumen: "+zylinder.GetZylinderVolumen());
            System.Console.WriteLine("Kegel Oberfläche: "+kegel.GetKegelOberfläche());
            System.Console.WriteLine("Kegel Volumen: "+kegel.GetKegelVolumen());
        }
    }
}