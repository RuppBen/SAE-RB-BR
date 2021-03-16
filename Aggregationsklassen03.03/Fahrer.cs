using System;
using System.Collections.Generic;
class Fahrer
{
    public string Vorname {set; get;}
    public string Name {set; get;}
    public int FahrerID {set; get;}
    public Fahrer()
    {
    }
    public Fahrer(string vorname, string name, int fahrerid = 100000)
    {
        Vorname = vorname;
        Name = name;
        FahrerID = fahrerid;
        fahrerid++;
    }

    public override string ToString()
    {
        return ("Vorname: "+Vorname+" Name: "+ Name+" FahrerID: "+FahrerID);
    }
}