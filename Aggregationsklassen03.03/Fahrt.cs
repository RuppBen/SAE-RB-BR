using System;
using System.Collections.Generic;
class Fahrt
{
    public string Zweck {set; get;}
    public int Fahrtstrecke {set; get;}
    public DateTime Start {set; get;}
    public DateTime Ende {set; get;}
    public Fahrer DerFahrer {set; get;}
    public Fahrzeug DasFahrzeug {set; get;}

    /*
    public Fahrt()
    {
    }
    */

    public Fahrt(string zweck, int fahrtstrecke, DateTime start, DateTime ende, Fahrer derfahrer, Fahrzeug dasfahrzeug)
    {
        Zweck = zweck;
        Fahrtstrecke = fahrtstrecke;
        Start = start;
        Ende = ende;
        DerFahrer = derfahrer;
        DasFahrzeug = dasfahrzeug;
 
    }
    public override string ToString()
    {
        return ("Zweck: "+Zweck+" Fahrtstrecke: "+ Fahrtstrecke+" Start: "+Start+" Ende: "+Ende+" "+ DerFahrer+" "+DasFahrzeug);
    }
}