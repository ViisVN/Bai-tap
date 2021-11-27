using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Nhap vao so luong phan tu: "); int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("\n Cac so nam trong n gom: ");
            for (int i=0; i<n;i++)
            {
                Console.Write("\na[" + i + "]");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nPhan tu nam o day chan la: ");
            for(int i=0; i<n;i+=2)
            {
                Console.Write("\na[" + i + "]");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }    
        }
    }
}