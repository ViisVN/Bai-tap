using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            float n =float.Parse(Console.ReadLine());
            float m = 2;
            float r;
        Comback:
            r = n % m;
            Console.WriteLine("Gia tri r là :" + r);
            if (r == 0)
            {
                Console.WriteLine("N is NOT prime number");
            }    
            else if (m < n-1)
            {
                Console.WriteLine("N is a Prime Number");
            }    
            else
            {
                m = m + 1;
                goto Comback;
            }    
            }   
        }
    }
    