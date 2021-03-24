using System;

namespace Vererbung17._03
{
    abstract class Kreiskörper
    {
        private double radius;
        private double höhe;
        public double Radius { get => radius; set => radius = value; }
        public double Höhe { get => höhe; set => höhe = value; }

        public Kreiskörper(double radius, double höhe)
        {
            Radius = radius;
            Höhe = höhe;
        }
        public double GetFläche()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double GetUmfnag()
        {
            return 2.0 * Math.PI * Radius;
        }
        public abstract double GetVolumen();
        public abstract double GetOberfläche();
    }
    //Zweite KLasse im Dokument wegen Übersicht
    class Zylinder : Kreiskörper 
    {
        public Zylinder(double radius, double höhe) : base(radius, höhe) 
        {
        }
        public override double GetVolumen()
        {
            return GetFläche() * Höhe;
        }
        public override double GetOberfläche()
        {
            return (2.0 * GetFläche()) + (Höhe * GetUmfnag());
        }
    }
    class Kegel : Kreiskörper
    {
        public Kegel(double radius, double höhe) : base(radius, höhe)
        {
        }
        public override double GetVolumen()
        {
            return GetFläche() * Höhe * 1/3; // 1/3 as int causes formular to be 0 but it works
        } 
        public override double GetOberfläche()
        {
            //Math.Pow causes major differance
            //return GetFläche() + Math.PI * Radius * Math.Sqrt(Math.Pow(Radius, 2))+(Math.Pow(Höhe, 2));
            return GetFläche() + Math.PI * Radius * Math.Sqrt(Radius*Radius+Höhe*Höhe);
        }
    }
}