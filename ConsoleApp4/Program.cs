using System;

namespace String
{
    class Program
    { 
     static void power(int a,int b)
        {
            double c = Math.Pow(a, b);
            Console.Write("Gia tri cua a mu n la: "+ c);
        }
     static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            power(a,b);
        }
    }
}
            