using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            string ktra;
            ktra = Console.ReadLine();
            Console.Write("\n Ki tu vua nhap là: " + ktra);
            if (char.TryParse(ktra, out a) == false)
            {
                Console.Write("\n\nKi tu vua nhap khong phai mot chua cai");
            }    
            else if (int.TryParse(ktra, out b) == true)
            {
                Console.Write("\n\n Ki tu vua nhap la con so");
                goto kethuc;
            }    
            else if (a == 'a'|| a== 'e' || a == 'o' || a == 'i' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
            {
                Console.Write("\n\n Ki tu vua nhap la chu nguyen am");
            }    
            else
            {
                Console.Write("\n\n Ki tu vua nhap la phu am");

            }
        kethuc:;


        }
          
    }
}
    