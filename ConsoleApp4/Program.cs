using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int countmax, countmin,max,min;
            max = 0;countmin = 0;countmax = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = a[0];
            for (int i = 0;i < n; i++)
            {
               if(a[i]>=max)
                {
                    max = a[i];
                }
                else if (a[i] <= min)
                {
                    min = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (max == a[i])
                {
                    countmax += 1;
                }
                else if (min == a[i])
                {
                    countmin += 1;
                }
            }
            Console.WriteLine(max); 
                Console.WriteLine(countmax);
            Console.WriteLine(min); 
                Console.WriteLine(countmin);
        }
    }
}
            