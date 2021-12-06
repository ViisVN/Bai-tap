using System;

namespace String
{
    class Program
   {
        static void Main(string[] args)
        {
            int n = 0;
             n = Convert.ToInt32(Console.ReadLine());
            check(n);
        }
        static double fina(double n)
        {
            n = (1 / Math.Sqrt(5) * ((Math.Pow(((1 + Math.Sqrt(5)) / 2), n)) - (Math.Pow(((1 - Math.Sqrt(5)) / 2), n))));
            return n;
        }
        static void check(int n)
        {
            double [] a = new double[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = fina(i+1);
            }
            Console.WriteLine("Day finabocci gom cua " + n+" so gom: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write((int)a[i] + " ");
            }
        }
    } 

}


            