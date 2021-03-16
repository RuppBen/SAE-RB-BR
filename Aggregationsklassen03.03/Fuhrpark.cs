using System;
using System.Collections.Generic;
class Fuhrpark
{
    public List<Fahrzeug> DieFahrzeuge = new List<Fahrzeug>();
    public Fuhrpark()
     {
        AddneuesFahrzeug("UL-Weebmobiel", 69, "BrumBrumGO", "BRumBrumgoesBrrr");
     }
    public void AddneuesFahrzeug(string kennzeichen, int kmstand, string hersteller, string modell)
    {
        DieFahrzeuge.Add(new Fahrzeug(kennzeichen, kmstand, hersteller, modell));
    }
    public Fahrzeug GetFahrzeug(string kennzeichen)
    {
        Fahrzeug fahrzeug = null;
        foreach (Fahrzeug item in DieFahrzeuge)
        {
            if (item.Kennzeichen == kennzeichen)
            {
                    fahrzeug = item;
                    break;
            }
            else   
            {
            }  
        }
        return fahrzeug;
     }

    //ToString Methode needet
}