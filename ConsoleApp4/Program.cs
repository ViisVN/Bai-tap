using System;
using System.Globalization;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            string a = "Don't nod";
            string b = null;
            string c = null;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {

                for (int j = 65; j <= 90; j++)
                {
                    if ((int)b[i] == j)
                    {
                        b = b.Replace(b[i], (char)(j + 32));
                    }
                }
            }
            b = b.Replace(" ", "");
            b = b.Replace("'", "");
            b = b.Replace(",", "");
            for (int i = b.Length - 1; i >= 0; i--)
            {
                c += b[i];
            }
            if(b == c)
            {
                Console.WriteLine(value: $"{a} are Palindrome");
            }
            else
            {
                Console.WriteLine(value: $"{a} are not Palindrome");
            }    
        }
    }
}


        

    
