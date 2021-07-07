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
            schulklasse = new Schulklasse("E2FS2", path);
            System.Console.WriteLine(schulklasse);
        }
    }
}