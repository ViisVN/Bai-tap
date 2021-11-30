using System;

namespace String
{
    class Program
    {
        static void Diem(float a)
        {
            if(a>=0&&a<=3.9)
            {
                Console.Write("F");
            }    
            else if(a>=4.0&&a<=5.4)
            {
                Console.Write("D");
            }
            else if (a >= 5.5 && a <= 6.9)
            {
                Console.Write("C");
            }
            else if (a >= 7.0 && a <= 8.4)
            {
                Console.Write("B");
            }
            else if (a >= 8.5 && a <= 10)
            {
                Console.Write("A");
            }
            else
            {
                Console.Write("E");
            }    
        }
        static void Main(string[] args)
        {
            Console.Write("\nNhap diem: ");
            float a= float.Parse(Console.ReadLine());
            Console.Write("Thu hang la: ");
            Diem(a);
        }
      
    }
}
            