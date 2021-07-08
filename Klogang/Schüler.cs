using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Schüler
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public List<TGang> TGänge { get; set; }

        public Schüler(string name, string vorname)
        {
            Name = name;
            Vorname = vorname;
            TGänge = new List<TGang>();
        }
        //spublic Schüler() {}
        public void AddTGang(DateTime start, DateTime ende)
        {
            TGänge.Add(new TGang(start, ende));
        }

        public override string ToString()
        {
            return Name +" "+Vorname;
        }
    }
}