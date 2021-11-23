using System;

namespace Vong_lap
{
    class baitap
    {
        static void Main(string[] args)
        {
            char n;
            int n1;
        Back:
            Console.Write("\nNhap ki tu: ");
            string ktra = Console.ReadLine();
            if (char.TryParse(ktra, out n) == false)
            {
                Console.WriteLine("Dong vua nhap nhieu hon mot ki tu");
                goto Back;
            }
            if (char.TryParse(ktra, out n) == true&&int.TryParse(ktra,out n1) == false)
            {
                n = Convert.ToChar(ktra);
                    if((int)n>=65&&(int)n<=90||(int)n>=97&&(int)n<=122)
                    {
                        Console.WriteLine("Chu cai");
                    }
                    else if((int)n==32)
                {
                    Console.WriteLine("Ket thuc");
                    goto end;
                }
                    else
                    {
                        Console.WriteLine("Ki tu dac biet");
                    }           
            }
            else
            {
                Console.WriteLine("Con so");
            }
        end:;


        }
    }
}
    