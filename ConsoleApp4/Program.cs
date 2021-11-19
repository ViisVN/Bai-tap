using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("\n Nhap bon so 3 a b c :");
            Console.Write("\n Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("\n Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("\n Nhap c: ");
            c = float.Parse(Console.ReadLine());
            float d1 = a + b;
            float d2 = b + c;
            float d3 = a + c;
            // Tam giac co tong hai canh lon hon canh con lai
            Console.WriteLine(" Tong cua a va b la: " + d1 + " gia tri cua c la : " + c);
            Console.WriteLine(" Tong cua b va c la: " + d2 + " gia tri cua a la : " + a);
            Console.WriteLine(" Tong cua a va c la: " + d3 + " gia tri cua b la : " + b);
            if (d1 < c|| d2<a || d3<b)
            {
                Console.WriteLine(" a b c không phải cạnh của tam giác");
            }    
            else
            {
                Console.WriteLine(" a b c là cạnh của tam giác");
            }
             
                  
                    

            

          
        }
    }
}
    