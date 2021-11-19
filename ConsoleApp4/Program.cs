using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            float a, b, c, d;
            Console.Write("\n Nhap bon so 4 a b c d:");
            Console.Write("\n Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("\n Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("\n Nhap c: ");
            c = float.Parse(Console.ReadLine());
            Console.Write("\n Nhap d: ");
            d = float.Parse(Console.ReadLine());
            float min1 = Math.Min(a, b);
            float min2 = Math.Min(c, d);
            float min = Math.Min(min1, min2);
            float max1 = Math.Max(a, b);
            float max2 = Math.Max(c, d);
            float max = Math.Max(max1, max2);
            Console.Write("\n\n Số min của dãy a b c d là: "+ min);
            Console.Write("\n\n Số max của dãy a b c d là: " + max);
        }
    }
}
    