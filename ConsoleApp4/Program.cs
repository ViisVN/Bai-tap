using System;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            string a = null;
            int m = 1;
            do
            {
                Console.WriteLine("------------------------");
                Console.Write("Nhap chuoi ki tu: ");
                a = Console.ReadLine();
                Console.WriteLine("------------------------");
                Console.WriteLine("1. So luong ki tu");
                Console.WriteLine("2. So nguyen am phu am");
                Console.WriteLine("3. So tu");
                Console.WriteLine("------------------------");
                m= Convert.ToInt32(Console.ReadLine());
                switch(m)
                {
                    case 1: sokitu(a); break;
                    case 2: Nguyenphuam(a); break;
                    case 3: Sotu(a); break;
                    default: Console.WriteLine("Thoat"); break;
                }    
            } while (m >= 1 && m <= 3);
        }
        static void sokitu(string a)
        {
            int b = 0;
            for (int i =0; i < a.Length; i++)
            {
              
                if(a[i] !=' ')
                {
                    b++;
                }
               
            }
            Console.WriteLine(value: $"So ki tu trong chuoi ({a}) la {b}");
        }
        static void Nguyenphuam(string a)
        {
            int b = 0; int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'i' || a[i] == 'u'|| a[i] == 'e' || a[i] == 'o' || a[i] == 'A' || a[i] == 'I' || a[i] == 'O' || a[i] == 'E' || a[i] == 'U')
                {
                    b++;
                }    
                else if(a[i]==' ')
                {
                    continue;
                }    
                else
                {
                    c++;
                }    
            }
            Console.WriteLine(value: $"Chuoi ({a}) co {b} nguyen am va {c} phu am");
        }
        static void Sotu(string a)
        {
            int b = 0;
            for (int i =0; i< a.Length; i++)
            {
                if (a[i] == ' '&&a[i-1]!=' ')
                {
                    b++;
                }
            }
            if(a[a.Length-1]!=' ')
            {
                b++;
            }    
            Console.WriteLine(value: $"So tu co trong chuoi ({a}) la {b}");
        }
    }
            
 }

        

    
