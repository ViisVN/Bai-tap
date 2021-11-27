using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            double[] a = new double[n];
            for (int i = 1; i < n + 1; i++)
            {
                if (i == 1)
                {
                    a[i - 1] = 1;
                }
                if (i == 2)
                {
                    a[i - 1] = 1;
                }
                if (i > 2)
                {
                    a[i - 1] = (1 / Math.Sqrt(5) * ((Math.Pow(((1 + Math.Sqrt(5)) / 2), i)) - (Math.Pow(((1 - Math.Sqrt(5)) / 2), i))));
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("\na[" + i + "]: " + (int)a[i]);
            }
        }
    }
}
            