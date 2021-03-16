using System;
using System.Collections.Generic;
class Fahrtenbuch
{
    public List<Fahrt> DieFahrten;
    public List<Fahrer> DieFahrer {set; get;}
    public Fahrtenbuch()
    {
        DieFahrten = new List<Fahrt>();
    }
    public void AddneueFahrt(string zweck, int fahrtstrecke, DateTime start, DateTime ende, Fahrer derfahrer, Fahrzeug dasfahrzeug)
    {
        DieFahrten.Add(new Fahrt(zweck, fahrtstrecke, start, ende, derfahrer, dasfahrzeug));
        //Killometerstand in Fharzeug übertragen
    }
    public override string ToString()
    {
        return DieFahrten.ToString();
    }
}