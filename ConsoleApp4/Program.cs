using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = " ";
            nhap(a);
         
        }

        static void nhap(string a)
        {
            Console.Write("\n Nhap: ");
            a = Console.ReadLine();
            haikitu(a);
        }
        static void haikitu(string a)
            {
                if (a.Length >= 2)
                {
                    Console.WriteLine("- Co hon hai ki tu");
                nhap(a);
            }
                else
                {
                    kitu(char.Parse(a));
                }
            }
        static void kitu(char a)
            {
                if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                {
                    Console.WriteLine("- "+a + " la chu cai");
                nhap(Convert.ToString(a));
            }
                else
                {
                chuso(a);
                 }
            }
        static void chuso(char a)
            { 
                if (a >= '0' && a<= '9')
                {
                    Console.WriteLine("- " + a + " la chu so");
                nhap(Convert.ToString(a));
            }
                else if (a ==' ')
            {
                Console.WriteLine("- Ket thuc");
            }
                else
            {
                Console.WriteLine("- " + a + "la ki tu dac biet");
                nhap(Convert.ToString(a));
            }
            }
        }
    }


            