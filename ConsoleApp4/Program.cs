using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++) 
            {
                a[i] = r.Next(1, 1000);
                Console.Write("\na[" + i + "]: "+a[i]);
                
            }
            Console.Write("\n Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Cac so chia het cho x la: ");
            {
                for (int i = 0; i < n; i++)
                {
                    if(a[i]%x==0)
                    {
                        Console.Write("\na[" + i + "]: "+a[i]);
                    }
                }
            }
          
           
        }
    }
}
            