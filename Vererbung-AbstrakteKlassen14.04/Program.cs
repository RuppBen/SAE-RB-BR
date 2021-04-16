using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Säugetier> säugetier1 = new List<Säugetier>(); //Elefant Liste
            List<Säugetier> säugetier2 = new List<Säugetier>(); //Leopart Liste // Use of single list not functioning jet
            Basicfunktiosn basicfunktiosn = new Basicfunktiosn();   //Basic Funktions fot switch case
            Elefant elefant;
            Leopart leopart;
            string eingabe;
            bool loobctl = true;
            //int indicator =0;
            string[] leopartFutter = new string[] {"Käfer","kleine Affen","Nagetiere","Fische","Antilopen","Impala"};
            string[] elefantFutter = new string[] {"Gras", "Ästen", "allerlei Baumrinde", "Blätter", "Früchte", "Wurzeln"};
            
            //Default Animals
            säugetier1.Add(elefant = new Elefant("Benjamin", elefantFutter));
            säugetier2.Add(leopart = new Leopart("Leo", leopartFutter));

            /*
            //test List Data
            foreach ( Elefant item in säugetier1)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            
            foreach ( Leopart item in säugetier2)
            {
                System.Console.WriteLine(item);
            }
            */

            //Systaxmistakes in programm will be simply ignored
            System.Console.WriteLine("Viertueller Zoobesuch\nGeben Sie ? oder help ein, um angezeigt zu bekommen was Sie tuhn können");
            do
            {
            System.Console.Write(">");
            eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "help":
                    System.Console.WriteLine("Fragen:\nWas fressen Elefanten(not case sensitive)\nWas fressen Leoparten(not case sensitive)\n\nPrint Database:\nprint zoo(print entire Database)\nprint Leoparten(not case sensitive)\nprint Elefanten(not case sensitive)\n\nAdd Animals:\nadd elefant\nadd leopart\n\nEnter q or exit to exit Programm"); //Hilfeoptionen
                    break;
                case "?":
                    System.Console.WriteLine("Fragen:\nWas fressen Elefanten(not case sensitive)\nWas fressen Leoparten(not case sensitive)\n\nPrint Database:\nprint zoo(print entire Database)\nprint Leoparten(not case sensitive)\nprint Elefanten(not case sensitive)\n\nAdd Animals:\nadd elefant\nadd leopart\n\nEnter q or exit to exit Programm"); //Hilfeoptionen
                    break;
                case "Was fressen Elefanten":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(elefantFutter,6));
                    break;
                case "was fressen elefanten":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(elefantFutter,6));
                    break;
                case "Was fressen Leoparten":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(leopartFutter,6));
                    break;
                case "was fressen leoparten":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(leopartFutter,6));
                    break;
                case "print zoo":
                    System.Console.WriteLine(basicfunktiosn.PrintListElefant(säugetier1));
                    System.Console.WriteLine(basicfunktiosn.PrintListLeopart(säugetier2));
                    break;
                case "print leoparten":
                    System.Console.WriteLine(basicfunktiosn.PrintListLeopart(säugetier2));
                    break;
                case "print Leoparten":
                    System.Console.WriteLine(basicfunktiosn.PrintListLeopart(säugetier2));
                    break;
                case "print Elefanten":
                    System.Console.WriteLine(basicfunktiosn.PrintListElefant(säugetier1));
                    break;
                case "print elefanten":
                    System.Console.WriteLine(basicfunktiosn.PrintListElefant(säugetier1));
                    break;
                case "add elefant":
                    System.Console.Write("Name: ");
                    eingabe = Console.ReadLine();
                    säugetier1.Add(elefant = new Elefant(eingabe, elefantFutter));
                    eingabe = null;
                    break;
                case "add leopart":
                    System.Console.Write("Name: ");
                    eingabe = Console.ReadLine();
                    säugetier2.Add(leopart = new Leopart(eingabe, leopartFutter));
                    eingabe = null;
                    break;
                case "q":
                    break;
                case "exit":
                    break;
            }
            if (eingabe == "q" || eingabe == "exit") //Do not question why the exitoption is defined like this and not in }while()
            {
                loobctl = false;
            }
            }while(loobctl);
        }
    }
}
