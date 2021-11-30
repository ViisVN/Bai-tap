using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\na[" + i + "]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int vitri=0, xcount=0;
            for (int i = 0; i < n; i++)
            {
                if(x==a[i])
                    {
                    vitri = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if(x==a[i])
                {
                    xcount += 1;
                }
            }
            Console.Write("\n Vitri dau tien cua x trong mang la: " + vitri);
            Console.Write("\n So lan x xuat hien trong mang la: " + xcount)
;           
        }
    }
}
            