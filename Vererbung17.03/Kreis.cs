using System;

namespace Vererbung17._03
{
    class Kreis
    {
        private double radius;
        public double Radius { get => radius; set => radius = value; }

        public Kreis(double radius)
        {
            Radius = radius;
        }
        public double GetFläche()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double GetUmfnag()
        {
            return 2.0 * Math.PI * Radius;
        }
    }
    //Zweite KLasse im Dokument wegen Übersicht
    class Zylinder : Kreis 
    {
        private double höhe;
        public double Höhe { get => höhe; set => höhe = value; }
        
        public Zylinder(double radius, double höhe) : base(radius) 
        {
            Höhe = höhe;
        }
        public double GetZylinderVolumen()
        {
            return GetFläche() * Höhe;
        }
        public double GetZylinderOberfläche()
        {
            return (2.0 * GetFläche()) + (Höhe * GetUmfnag());
        }
    }
    class Kegel : Kreis
    {
        private double höhe;

        public double Höhe { get => höhe; set => höhe = value; }

        public Kegel(double radius, double höhe) : base(radius)
        {
           Höhe = höhe; 
        }
        public double GetKegelVolumen()
        {
            return GetFläche() * Höhe * 1/3; // 1/3 as int causes formular to be 0 but it works
        } 
        public double GetKegelOberfläche()
        {
            //Math.Pow causes major differance
            //return GetFläche() + Math.PI * Radius * Math.Sqrt(Math.Pow(Radius, 2))+(Math.Pow(Höhe, 2));
            return GetFläche() + Math.PI * Radius * Math.Sqrt(Radius*Radius+Höhe*Höhe);
        }
    }
}