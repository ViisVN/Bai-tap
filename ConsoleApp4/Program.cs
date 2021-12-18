using System;

namespace String
{
    class program
    {
        static void xet(string a, char b, int c)
        {
            a = Console.ReadLine();
            b = Convert.ToChar(Console.ReadLine());
            c = 0;
            for(int i = 0; i< a.Length;i++)
            {
                if(a[i]==b)
                {
                    c++;
                }    
            }
            Console.WriteLine(value: $"So ki tu ({b}) cua chuoi: ({a}) la ({c})");
        }
        static void Main(string[] args)
        {
            string a=null; char b=' '; int c=0; int m = 1;
            Console.WriteLine("Bam 1 de xet chuoi ki tu");
            do
            {
                m = Convert.ToInt32(Console.ReadLine());
                switch(m)
                {
                    case 1: Console.WriteLine(value: $" Xet chuoi ki tu");
                        xet(a, b, c); break;
                    default: Console.WriteLine("Thoat"); break;
                }    
            } while (m == 1);    

        }
    }
            
 }

        

    
