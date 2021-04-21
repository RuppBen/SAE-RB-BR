using System;
using System.Collections.Generic;

namespace Vererbung_AbstrakteKlassen14._04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Säugetier> säugetier = new List<Säugetier>();      //List for all Säugetier Objects
            Basicfunktiosn basicfunktiosn = new Basicfunktiosn();   //Basic Funktions fot switch case
            string eingabe;                                         //Input variable
            bool loobctl = true;                                    //This controls if the programm will be executed again
            //String Arra for the what the Animal Eats
            string[] leopartFutter = new string[] {"Käfer","kleine Affen","Nagetiere","Fische","Antilopen","Impala"};       
            string[] elefantFutter = new string[] {"Gras", "Ästen", "allerlei Baumrinde", "Blätter", "Früchte", "Wurzeln"}  ;
        
            //Default Animals
            säugetier.Add(new Elefant("Benjamin", elefantFutter));
            säugetier.Add(new Leopard("Leo", leopartFutter));

            //Systaxmistakes in programm will be simply ignored
            System.Console.WriteLine("Viertueller Zoobesuch\nGeben Sie ? oder help ein, um angezeigt zu bekommen was Sie tuhn können");
            do
            {
            System.Console.Write(">");
            eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "help":    //Shows user possible commands
                    System.Console.WriteLine("Fragen:\nWas fressen Elefanten(not case sensitive)\nWas fressen Leoparden(not case sensitive)\n\nPrint Database:\nprint zoo(print entire Database)\n\nAdd Animals:\nadd elefant\nadd leopart\n\nEnter q or exit to exit Programm"); //Hilfeoptionen
                    break;
                case "?":       //Shows user possible commands
                    System.Console.WriteLine("Fragen:\nWas fressen Elefanten(not case sensitive)\nWas fressen Leoparden(not case sensitive)\n\nPrint Database:\nprint zoo(print entire Database)\n\nAdd Animals:\nadd elefant\nadd leopart\n\nEnter q or exit to exit Programm"); //Hilfeoptionen
                    break;
                case "Was fressen Elefanten":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(elefantFutter,6));
                    break;
                case "was fressen elefanten":   //case un sensitive
                    System.Console.WriteLine(basicfunktiosn.PrintArray(elefantFutter,6));
                    break;
                case "Was fressen Leoparden":
                    System.Console.WriteLine(basicfunktiosn.PrintArray(leopartFutter,6));
                    break;
                case "was fressen leoparden":   //not case sensitive
                    System.Console.WriteLine(basicfunktiosn.PrintArray(leopartFutter,6));
                    break;
                case "print zoo":   //print out entire säugetier list
                    System.Console.WriteLine(basicfunktiosn.PrintList(säugetier));
                    break;
                case "add elefant": //Adding new Elefant
                    System.Console.Write("Name: ");
                    eingabe = Console.ReadLine();
                    basicfunktiosn.AddAnimal(säugetier, eingabe, elefantFutter, "elefant");
                    eingabe = null;
                    break;
                case "add leopard": //Adding new Leopard
                    System.Console.Write("Name: ");
                    eingabe = Console.ReadLine();
                    basicfunktiosn.AddAnimal(säugetier, eingabe ,leopartFutter, "leopard");
                    eingabe = null;
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
