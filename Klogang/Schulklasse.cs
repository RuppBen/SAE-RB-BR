using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Schulklasse
    {
        public string KlassenName { get; set; }
        public List<Schüler> SchülerDerKlasse { get; set; }

        public Schulklasse(string klassenname, List<Schüler> schüler)
        {
            KlassenName = klassenname;
            //uncleare if SchülerDerKlasse = new List<Schüler>(); must be used, coud lead to error
            SchülerDerKlasse = schüler; 
        }
        public Schulklasse(string klassenname, string pathtofile)
        {
            KlassenName = klassenname;  
            SchülerDerKlasse = new List<Schüler>();        
            StreamReader sr = new StreamReader(pathtofile);
            string buffer = sr.ReadToEnd();
            string[] names = buffer.Split(new char[] { ';', '\n' });
            sr.Close();
            for (int a = 0; a < names.Length; a+=2)
            {
                //System.Console.WriteLine(names[a]+" "+names[a+1])); //Debug Instructions
                SchülerDerKlasse.Add(new Schüler(names[a], names[a+1]));
            }
        }

        public override string ToString()
        {
            int index = 1;
            string buffer= KlassenName+"\n";
            foreach (var item in SchülerDerKlasse)
            {
                buffer += Convert.ToString(index)+" "+item+"\n";
                index ++;
            }
            return buffer;
        }
    }
}