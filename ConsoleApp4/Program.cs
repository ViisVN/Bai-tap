using System;

namespace String
{
    class Program
    {
        static void fina(long d)
        {
          double b = (1 / Math.Sqrt(5) * ((Math.Pow(((1 + Math.Sqrt(5)) / 2), d)) - (Math.Pow(((1 - Math.Sqrt(5)) / 2), d))));
            Console.WriteLine("Gia tri so fina thu "+d+" la : "+(int)b);
        }
        static void Main(string[] args)
        {
            Console.Write("\nNhap thu tu so fina: ");
            int a= Convert.ToInt32(Console.ReadLine());
            fina(a);
        }
      
    }
}
            