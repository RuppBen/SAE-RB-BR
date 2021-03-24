using System;

namespace Vererbung17._03
{
    class Kegeldings : Zylinder
    {
        public Kegel Kegel {get; set;}
        public Kegeldings(double höhe, double radius) :base(höhe, radius)
        {
            Kegel = new Kegel(radius, höhe);
        }
        public double DVolumen()
        {
            return Kegel.GetVolumen() + base.GetVolumen();
        }
        public double DOberfläche()
        {
            return Kegel.GetOberfläche() + base.GetOberfläche() - 2 * base.GetFläche();
        }
    }
}