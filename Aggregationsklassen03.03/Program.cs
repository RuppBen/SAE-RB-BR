using System;
using System.Collections.Generic; 

namespace Aggregationsklassen03._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuhrpark fuhrpark = new Fuhrpark(); 
            Fahrtenbuch fahrtenbuch = new Fahrtenbuch();
            Fahrer fahrer = new Fahrer();   //may be implimentet with class depenxees in future
            string eingabe1;
            string eingabe2;
            string eingabe3;
            char auswahl;
            bool loobctl = true;
            DateTime time1 = new DateTime();
            DateTime time2 = new DateTime();
            int numberin1;
            int numberin2;
            int numberin3;

            System.Console.WriteLine("Welcome to Autovermietungssimulator2021\n");
            do
            {           
                eingabe1 = "3";
                while (loobctl)
                {
                    System.Console.Write("Wollen sie eine Fahrt eintragen(1) oder ein Fahrzeug hinzufügen(2):");    //normale ausgabe der Listen muss noch Implementiert werden 
                    eingabe1 = Console.ReadLine();
                    if (eingabe1 != "1" && eingabe1 != "2")
                    {
                        System.Console.WriteLine("Falsche Eingabe, versuchen Sie es nocheinmal");
                    }
                    else
                    {
                        break;
                    }
                }
                loobctl = true; //set loobctl to true for use at the end of programm

                auswahl = Convert.ToChar(eingabe1);

                switch (auswahl)
                {
                    case '1':
                        //time1 - Missing Hour/Minute/Second + Add two more int variables
                        System.Console.Write("Jahr der Vergabe: "); //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin3 = Convert.ToInt32(eingabe1);
                        System.Console.Write("Monat der Vergabe: ");//leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin2 = Convert.ToInt32(eingabe1);
                        System.Console.Write("Tag der Vergabe: ");  //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin1 = Convert.ToInt32(eingabe1);
                        time1 = new DateTime(numberin3, numberin2, numberin1);
                        //time2 - Missing Hour/Minute/Second + Add two more int variables
                        System.Console.Write("Jahr der Rückgabe: ");    //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin3 = Convert.ToInt32(eingabe1);
                        System.Console.Write("Monat der Rückgabe: ");   //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin2 = Convert.ToInt32(eingabe1);
                        System.Console.Write("Tag der Rückgabe: ");      //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin1 = Convert.ToInt32(eingabe1);
                        time2 = new DateTime(numberin3, numberin2, numberin1);
                        //fahrer
                        System.Console.Write("Vorname: ");
                        eingabe2 = Console.ReadLine();
                        System.Console.Write("Nachnahme: ");
                        eingabe3 = Console.ReadLine();
                        System.Console.Write("ID: ");   //leyer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin1 = Convert.ToInt32(eingabe1);
                        fahrer = new Fahrer(eingabe2, eingabe3, numberin1);
                        //fahrtstrecke
                        System.Console.Write("Fhartstrecke: ");
                        eingabe1 = Console.ReadLine();
                        numberin2 = Convert.ToInt32(eingabe1);
                        //printfahrzeuge und Fahrzeugaußwahl - Fahrzeugauswahl auf Kennzeichenauswahl umstellen
                        numberin1 = 1;      //counter 4 vehicles
                        foreach (Fahrzeug item in fuhrpark.DieFahrzeuge)
                        {
                            System.Console.WriteLine(item.ToString()+" Nummer: "+ numberin1);
                            numberin1++; 
                        }
                        System.Console.Write("Welches Fahrzeug möchten sie auswählen? [number of Vehicle]: ");  //layer 8 protection missing
                        eingabe1 = Console.ReadLine();
                        numberin1 = Convert.ToInt32(eingabe1);
                        numberin1--;
                        fahrtenbuch.AddneueFahrt("bananen kaufen", numberin2, time1, time2, fahrer, fuhrpark.DieFahrzeuge[numberin1]);
                        //succsess message will be removed down the line
                        System.Console.WriteLine("success");
                    break;

                    case '2':
                        //kennzeichen
                        System.Console.Write("Kennzeichen: ");
                        eingabe1 = Console.ReadLine();
                        //kmstand
                        System.Console.Write("Kmstand: ");  //leyer 8 protection missingss
                        eingabe2 = Console.ReadLine();
                        numberin1 = Convert.ToInt32(eingabe2);
                        //hersteller
                        System.Console.Write("Hersteller: ");
                        eingabe2 = Console.ReadLine();
                        //modell
                        System.Console.Write("Modell: ");
                        eingabe3 = Console.ReadLine();
                        fuhrpark.AddneuesFahrzeug(eingabe1, 4, eingabe2, eingabe3 );
                        //success message will be removed down the line
                        System.Console.WriteLine("success");
                    break;

                    case '3':
                        System.Console.WriteLine("impossible error occured, contact the Maintainor and pray to God");
                    break;
                }

                while (loobctl)
                {   
                    System.Console.Write("Programm widerholen(n or y): ");
                    eingabe1 = Console.ReadLine();
                    if (eingabe1.Length != 1)
                    {
                        System.Console.Write("Falsche Eingabe, versuchen Sie es nocheinmal\n");
                    }
                    else
                    {
                        auswahl = Convert.ToChar(eingabe1);
                        if (auswahl != 'Y' && auswahl != 'y')
                            loobctl = false;
                            break;
                    }
                }
            }while(loobctl);
        }
    }
}