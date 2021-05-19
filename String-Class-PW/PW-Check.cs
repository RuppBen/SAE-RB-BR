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
        public static string GenPW(string satz) //my Verion
        {
            string result = null;
            string[] words = satz.Split(' ');

            int i = 0;
            foreach (var word in words)
            {
                int pwl = word.Length;
                words[i] = word.Remove(1, pwl -1);
                i++;
            }
            foreach (var word in words)
            {
                result += word;
            }
            return (result+ Convert.ToString(result.Length));
        }
        public static string GenPWE(string satz)    //efficent version
        {
            string pwd = null;
            string[] words = satz.Split(new char[] { ' '} );
            foreach (string word in words)
            {
                pwd += word[0];
            }
            return pwd + Convert.ToString(pwd.Length);
        }
    }
}