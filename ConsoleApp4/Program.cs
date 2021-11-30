using System;

namespace String
{
    class Program
    {
        public static void GiaiPT2(double a, double b, double c)
        {
            double delta = (Math.Pow(b, 2)) - (4 * a * c);
            if (delta < 0)
            {
                Console.Write("\nPhuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / a;
                Console.Write("\nPhuong trinh co nghiem kep x la: "+x);
                
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2*a);
                Console.Write("\nPhuong trinh co hai nghiem");
                Console.Write("\nx1: "+x1);
                Console.Write("\nx2: "+x2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("\nNhap a b c:\n");
            nhaplai:
            int a = int.Parse(Console.ReadLine());
            if (a==0)
            {
                Console.Write("\na phai khac khong, nhap lai a\n");
                goto nhaplai;
            }    
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GiaiPT2(a, b, c);
        }
    }
}
            