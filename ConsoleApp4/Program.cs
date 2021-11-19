using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhập hai giá trị");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            if(b ==0)
            {
                Console.WriteLine("Error Divide to Zero");
            }    
            else
            {
                c = a / b;
                Console.WriteLine(c);
            }   
        }
    }
}
    