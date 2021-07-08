using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Schulklasse schulklasse;
            string path = @"/mnt/19410a79-7976-4fc8-8bce-3c4d762a06d5/Work/E2FS2_Schülerdaten.CSV";
            string eingabe;
            int index;
            DateTime start = new DateTime();
            DateTime stop = new DateTime();
            schulklasse = new Schulklasse("E2FS2", path);
            //Write Klogangdoku.md 
            System.Console.WriteLine("Welcome to Kolgang aufzeichnung 2021\nPlease read the Klogangdoku.md for documentation");
            System.Console.Write(">");
            eingabe = Console.ReadLine();
            switch (eingabe)
            {
                //Output of every Member of the Klass with index Number
                case "list klassen":
                    System.Console.WriteLine(schulklasse);
                break;

                //Add Klogang
                case "add klogang":
                    System.Console.Write("Indexnumber of Student: ");
                    eingabe = Console.ReadLine();
                    index = Convert.ToInt32(eingabe);
                    
                    System.Console.Write("Start [Default Now]: ");
                    eingabe = Console.ReadLine();
                    if (eingabe == "\n")
                        start = DateTime.Now;
                    else
                        //start = new DateTime(,,,,,);    //Add fitting input

                    System.Console.Write("Stop [Default Now]: ");
                    eingabe = Console.ReadLine();
                    if (eingabe == "\n")
                        stop = DateTime.Now;
                    else
                        //stop = new DateTime(,,,,,);    //Add fitting input
                
                schulklasse.SchülerDerKlasse[index].AddTGang(start, stop);
                break;

                //List all "Klogänge" of a choosen student
                case "list klogang":
                    System.Console.WriteLine("Index of Student: ");
                    eingabe = Console.ReadLine();
                    index = Convert.ToInt32(eingabe);
                    foreach (var item in schulklasse.SchülerDerKlasse[index].TGänge)
                    {
                        System.Console.WriteLine(item + " gesamt: "+ item.GetDauer());
                    }
                break;
                
                default:
                    System.Console.WriteLine("Syntax error");
                break;
                
            }
        }
    }
}