using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0;
            nhap(n, m);
        }
        static void nhap(int n,int m)
        {
            Console.Write("\nNhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap m: ");
            m = Convert.ToInt32(Console.ReadLine());
            if(n<=0||m<=0||n>m)
            {
                Console.WriteLine("Nhap lai");
                nhap(n,m);
            }
            else
            {
                chia7(n,m);
            }
        }
        static void chia7(int n,int m)
        {
            Console.Write("\nSo chia het cho 7 la: ");
            for(int i = n; i <=m; i++)
            {
                if(i%7==0)
                {
                    Console.Write(i + " ");
                }
            }    
        }
     } 
}


            