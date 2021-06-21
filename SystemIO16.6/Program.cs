using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\users\rupperbe\source\repos\ConsoleApp1\TestFile.csv"; For Windows
            string path = @"/mnt/19410a79-7976-4fc8-8bce-3c4d762a06d5/Work/SAE-RB-BR/SystemIO16.6/TsetFile.csv";
            StreamWriter sw = new StreamWriter(path);

            int[] zufallszahlen = new int[100];
            Random random = new Random();

            for (int a = 0; a < zufallszahlen.Length; a++)
            {
                zufallszahlen[a] = random.Next(0, 256);
            }
            for (int i = 0; i < zufallszahlen.Length; i++)
            {
                if ((i+1)%10 == 0)
                {
                    sw.Write(zufallszahlen[i] + ",");
                    sw.WriteLine();
                }
                else
                {
                    sw.Write(zufallszahlen[i] + ",");
                }
            }
            sw.Close(); // This closes the file, must be used
        }
    }
}