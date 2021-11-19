using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            float a, b;
            char c;
            Console.Write("Nhap so thu nhat: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("           MENU          ");
            Console.WriteLine("=========================");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("=========================");
            Console.Write("\nChon : ");  
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    float d = a + b;
                    Console.WriteLine("Tong: "+a+" + "+b +" = "+d);
                    break;
                case '-':
                    d = a - b;
                    Console.WriteLine("Thuong: " + a + " - " + b + " = " + d);
                    break;
                case '*':
                    d = a * b;
                    Console.WriteLine("Nhan: " + a + " * " + b + " = " + d);
                    break;
                case '/':
                    d = a / b;
                    Console.WriteLine("Chia: " + a + " / " + b + " = " + d);
                    break;
                default:
                    Console.WriteLine("Ban da nhap sai");
                    break;
            }

            
        }
          
    }
}
    