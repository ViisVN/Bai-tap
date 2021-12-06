using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string n ="";
            Console.Write("\n  SO THICH CA NHAN  ");
            Console.Write("\n====================");
            Console.Write("\n1. Doc sach");
            Console.Write("\n2. Nghe nhac");
            Console.Write("\n3. Choi the thao");
            Console.Write("\n4. May tinh");
            Console.Write("\n5. Thoat\n");
            Option(n);
            Console.Write("====================");

        }
        static void Option(string n)    {
            int m=0;
            Console.Write("--------------------\n");
            Console.Write("Chon: ");
            n = (Console.ReadLine());
            Console.Write("--------------------\n");
            if (n.Length >= 2)
            {
                Console.WriteLine("Ban nhap sai! Moi nhap lai!");
                Option(n);
            }
            else if (char.Parse(n) >= 'a' && char.Parse(n) >= 'a' || char.Parse(n) >= 'A' && char.Parse(n) >= 'Z')
            {
                Console.WriteLine("Ban nhap sai! Moi nhap lai!");
                Option(n);
            }
            else if ((int)Convert.ToChar(n) >= 32 & (int)Convert.ToChar(n) <= 47 || (int)Convert.ToChar(n) >= 58 && (int)Convert.ToChar(n) <= 126)
            {
                Console.WriteLine("Ban nhap sai! Moi nhap lai!");
                Option(n);
            }
            else
            { 
                switch (Convert.ToInt32(n))
                {
                    case 1: Console.WriteLine("Ban chon doc sach."); Option(n); break;
                    case 2: Console.WriteLine("Ban chon nghe nhac."); Option(n); break;
                    case 3: Console.WriteLine("Ban chon choi the thao."); Option(n); break;
                    case 4: Console.WriteLine("Ban chon may tinh."); Option(n); break;
                    case 5: Console.WriteLine("Hen gap lai!"); break;
                    default: Console.WriteLine("Ban nhap sai! Moi nhap lai!"); Option(n); break;
                }
            }
        }

    } 
}


            