using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class TGang
    {
        public DateTime Start { get; set; }
        public DateTime Ende { get; set; }

        public TGang(DateTime start, DateTime ende)
        {
            Start = start;
            Ende = ende;
        }
        //public Get Dauer außrechnen der Dauer :TimeSpan
        public double GetDauer()
        {
            return Convert.ToDouble(Start) - Convert.ToDouble(Ende);
        }

        public override string ToString()
        {
            return "Klogang von "+Start+" bis "+ Ende; 
        }
    }
}