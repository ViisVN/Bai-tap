using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Nhap vao so luong phan tu: "); int n = 10;
            int[] a = new int[n];
            Console.Write("\n Nhap vao so luong phan tu: "); int m = 5;
            double[] b = new double[m];
            for (int i=0; i<m;i++)
            {
                Console.Write("\nb[" + i + "]: ");
                b[i]=Convert.ToDouble(Console.ReadLine());
            }
            for (int i=0; i < m ;i++)
            {
                if(i%2!=0)
                {
                   a[i] = (int)b[i];
                }
            }
            Console.Write("\nMang a gom: ");
            for(int i=0; i<n ;i++)
            {
                Console.Write("\na[" + i + "] :" + a[i]);
            }    
        }
    }
}