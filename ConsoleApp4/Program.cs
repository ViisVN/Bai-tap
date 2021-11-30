using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            string[] ktra = new string[n];
            char[] a = new char[n];
            int a1;
        vietlai:
            for (int i = 0; i < n; i++)
            {
                Console.Write("\na[" + i + "]: ");
                ktra[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (char.TryParse(ktra[i], out a[i]) == false)
                {
                    Console.Write("Trong chuoi co ki khong phai a-z");
                    goto vietlai;
                }
            } 
                for (int i = 0; i < n; i++)
            {
                if(Char.Parse(ktra[i])<'a'|| Char.Parse(ktra[i]) > 'z')
                {
                    Console.Write("Trong chuoi co ki khong phai a-z");
                    goto vietlai;
                }
            }
            for (int i = 0; i < n; i++)
            {
                a[i] = Char.ToUpper(Char.Parse(ktra[i]));
                Console.Write("\na[" + i + "]: " + a[i]);
            }

        }
    }
}
            