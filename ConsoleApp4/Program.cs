using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 7;
            double[,] a = new double[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(15,20);
                    Console.Write("\na[" + i + "," + j + "]: " + a[i, j]);

                }
            }
                Console.Write("\nHoc vien :  CF  :  C   :  HDJ  : DU  :RDBNS : Java :  TB  ");
                Console.Write("\n----------------------------------------------------------");
            for (int ai = 0; ai < n; ai++)
            {
                Console.Write("\nHV" + (ai + 1) + "      ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(": " + string.Format("{0:0.0}", a[ai, j]) + " ");
                }
            }
                Console.Write("\n----------------------------------------------------------");
            }
        }
    }
            