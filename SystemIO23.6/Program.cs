using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\users\rupperbe\source\repos\ConsoleApp2\TestFile.txt"; //Windows Path
            string path = @"/mnt/19410a79-7976-4fc8-8bce-3c4d762a06d5/Work/SAE-RB-BR/SystemIO23.6/TesetFile.txt";
            StreamWriter sw;
            StreamReader sr = new StreamReader(path);
            FileInfo fi = new FileInfo(path);
            string buffer = (sr.ReadToEnd());
            
            //Leicher Weg um umlaute zu Überschrieben
            buffer = buffer.Replace("ä", "ae");
            buffer = buffer.Replace("ö", "oe");
            buffer = buffer.Replace("ü", "ue");
            buffer = buffer.Replace("Ä", "Ae");
            buffer = buffer.Replace("ö", "Oe");
            buffer = buffer.Replace("ü", "Ue");
            sr.Close();
            System.Console.WriteLine("Gespeicherter Satz:  "+buffer);

            sw = new StreamWriter(path);
            sw.WriteLine(buffer);
            sw.Close();

            Console.WriteLine("Dateigröße in byte:  "+fi.Length);
            Console.WriteLine("Dateipfad:           "+fi.FullName);
            string[] words = buffer.Split(new char[] { ' ', '\n', '.' });
            Console.WriteLine("Anzahl der Wörter:   "+ words.Length);
            
            /*
             *Einlesen von allen Zeichen in ein Char Array
             *Aufwendiger Weg um Umlaute zu ersetzten
            char[] puffer = new char[fi.Length];
            sr.Read(puffer, 0, (int)fi.Length);
            sr.Close();
            //Abgleich im char Array ob ein Umlaut vorhanden ist
            sw = new StreamWriter(path);
            foreach  (char item  in puffer)
            {
                switch (item)
                {
                    case 'ä':
                        sw.Write("ae");
                        break;
                    case 'ö':
                        sw.Write("oe");
                        break;
                    case 'ü':
                        sw.Write("ue");
                        break;
                    case 'Ä':
                        sw.Write("Ae");
                        break;
                    case 'Ö':
                        sw.Write("Oe");
                        break;
                    case 'Ü':
                        sw.Write("Ue");
                        break;
                    default:
                        sw.Write(item);
                        break;
                }
            }
            sw.Close();
            */
        }
    }
}