using System;

namespace String
{
    class Program
    {
        static void lietke(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
                if (count == 2)
                {
                    Console.Write(n + " ");
                }
            
        }

            static void Main(string[] args)
            {
                int[] a = new int[10];
            Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                a[i] = r.Next(1, 100000);
                }
            Console.WriteLine("So nguyen to gom");
                for (int i = 0; i < 10; i++)
                {
                    lietke(a[i]);
                }

            }
        }

    }

            