using System;

namespace Vong_lap
{
    class baitap
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap m va n: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[m - n];
            for(int i=0;i< m-n;i++)
            {
                a[i]=i+n;
            }
            Console.Write("\nCai so chia het cho 7 la: ");
            for(int i=0; i<m-n;i++)
            {
                if(a[i]%7==0)
                {
                    Console.Write(a[i] + "  ");
                }
            }
        }
    }
}
    