using System;

namespace Luudo
{
    class baitap
    {
      static void Main(string[] args)
        {
            Nhap_n:
            Console.Write("\nNhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<=0)
            {
                Console.WriteLine("Ban phai nhap n lon hon 0");
                goto Nhap_n;
            }
            else
            {
                for(int i =0; i<=n; i++)
                {
                    if (i % 2==0)
                    {
                        Console.Write(i + " ");
                    }
                }    
            }
        }
                                      


    }
}
    