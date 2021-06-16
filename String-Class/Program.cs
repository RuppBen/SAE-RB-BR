using System;
using System.Collections;
using System.Globalization;

namespace String_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo deutsch = new CultureInfo("de-DE"); //Grammatik dies das
            string teststring = "Nachts sint alle Katzen grau und keiner wird aus keinem schlau";
            string copy = teststring;
            string[] words = teststring.Split(' '); //i
            

            System.Console.WriteLine("String Länge: "+teststring.Length); //a
            System.Console.WriteLine("Index K: "+teststring.IndexOf('K')); //b
            System.Console.WriteLine("Bevor: "+teststring); //c
            teststring = teststring.Replace("sint","sind",true, deutsch); //d
            System.Console.WriteLine("Danach: "+teststring); //d
            System.Console.WriteLine("Ist Wort Katze enthalten?: "+teststring.Contains("Katze")); //f
            System.Console.WriteLine("Copy ohne Katze: "+copy.Remove(17, 23)); //g 
            //System.Console.WriteLine("Ohne a: "+teststring.Replace("a", "", true, deutsch)); //h
            
            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
            string neuesWort = String.Concat(words[3], words[10]);
            System.Console.WriteLine(neuesWort);
        }
    }
}
