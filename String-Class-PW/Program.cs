using System;

namespace String_Class_PW
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            System.Console.Write("Password: ");
            eingabe = Console.ReadLine();
            System.Console.WriteLine(PwAnalyse.GenPW(eingabe));

            /*
            if (PwAnalyse.CheckPwSecurity(eingabe))
            {
                System.Console.WriteLine("succes");
            }
            else
            {
                System.Console.WriteLine("ur pw sucks");
            }
            */
        }
    }
}