using System;

namespace String_Class_PW
{
    static class PwAnalyse
    {
        public static bool CheckPwSecurity(string pw)
        {
            bool pwdlenght = false;
            bool wnum = false;
            bool wlet = false;
            //Check if PW has at least 8 Letters
            if (pw.Length >= 8)
            {
                pwdlenght = true;
            }
            
            foreach (var zeichen in pw)
            {
                //Check if PW contains a Number
                if (char.IsNumber(zeichen))
                {
                    wnum = true;
                }
                //Check if PW contains a Letter
                if (char.IsLetter(zeichen))
                {
                    wlet = true;
                }
            }

            return (pwdlenght && wnum && wlet );
        }
    }
}