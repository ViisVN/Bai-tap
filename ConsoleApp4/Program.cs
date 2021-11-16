using System;

namespace Congthuctoan
{
    class canbanhac
    {
        static void Main(string[] args)
        {
            float a, b, c;
            string stra, strb, strc;
            
            Console.Write("\nTinh phuong trinh bac 2");
            Nhap_lai://trong truong hop nhap sai
            Console.Write("\n -------------------------\n");
            Console.Write("\n\n Nhap ba bien a, b, c");
            Console.Write("\n Nhap a: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            stra = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.Write("\n Nhap b: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            strb = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.Write("\n Nhap c: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            strc = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.Write("\n");
            if (float.TryParse(stra, out a) == false|| float.TryParse(strb, out b) == false || float.TryParse(strc, out c) == false)
            {
                Console.Write("\n Gia tri vua nhap khong phai so\n");
                Console.Write("\n Moi ban nhap lai");
                goto Nhap_lai;
            }
            else
            {
                if(a==0)//Phuong trinh bac hai a phai khac 0
                {
                    Console.Write("\n Gia tri a phai khac 0\n");
                    Console.Write("\n Moi ban nhap lai");
                    goto Nhap_lai ;
                  
                }
                float delta = (b * b) - (4 * a * c);
                Console.Write("\n Gia tri cua delta la : " + delta+"\n");
                if (delta == 0)
                {
                    float x = (-b) / 2 * a;
                    Console.Write("\nPhuong trinh co nghiem kep\n");
                    Console.Write("\nx1 = x2 = " + x);

                }
                else if (delta > 0)
                {
                    double x1 = (-b + Convert.ToDouble(Math.Sqrt(delta))) / 2 * a;
                    double x2 = (-b - Convert.ToDouble(Math.Sqrt(delta))) / 2 * a;
                    Console.Write("\nPhuong trinh co hai nghiem\n");
                    Console.Write("\nx1 = " + x1);
                    Console.Write("\nx2 = " + x2);
                }
                else
                {
                    Console.Write("\nPhuong trinh vo nghiem");

                }
            }
            

        }
    }
}
