using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                n[i] = r.Next(1, 30);
                Console.Write("n[" + i + "]: "+n[i]+"\n");
            }
           for (int i = 0; i < 10; i++)
                {
                    if (cong(n[i]) == n[i])
                    {
                        Console.WriteLine(n[i]+" la so hoan hao");
                    }
                }

            }

            static int cong(int n)
            {
                int[] b = new int[n];
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    b[i] = i + 1;
                }
                for (int i = 0; i < (n - 1); i++)
                {
                    if (n % b[i] == 0)
                    {
                        sum += b[i];
                    }
                }

                return sum;
            }
        }
    }


            