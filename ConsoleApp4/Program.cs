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
                Console.Write("\n\nKi tu vua nhap co nhieu hon mot chu cai");
            }    
            else if (int.TryParse(ktra, out b) == true)
            {
                Console.Write("\n\n Ki tu vua nhap la con so");
                goto kethuc;
            }    
            else if ((Char.ToUpper(a) == a))
            {
                Console.Write("\n\n Ki tu vua nhap la chu in hoa");
            }    
            else
            {
                Console.Write("\n\n Ki tu vua nhap la chu in thuong");

            }
        kethuc:;


        }
          
    }
}
    