using System;
using System.Collections.Generic;
class Fahrzeug
{
    //Getter and setter cause stack overflow
    public string Kennzeichen {set; get;}
    public int KmStand {set; get;}
    public string Hersteller {set; get;}
    public string Modell {set; get;}
    public Fahrzeug()
    {
    }
    public Fahrzeug(string kennzeichen, int kmstand, string hersteller, string modell)
    {
        Kennzeichen = kennzeichen;
        KmStand = kmstand;
        Hersteller = hersteller;
        Modell = modell;
    }

    public override string ToString()
    {
        return ("Kennzeichen: "+Kennzeichen+" Hersteller: "+Hersteller+" Modell: "+Modell);
    }
}