using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();
            int m = 1;

            do
            {
                Console.WriteLine("Demo cac thao tac Arraylist tren C#");
                Console.WriteLine("===================================");
                Console.WriteLine("1- Khoi tao danh sach");
                Console.WriteLine("2- Them mot phan tu vao danh sach");
                Console.WriteLine("3- Xoa 1 phan tu ra khoi danh sach");
                Console.WriteLine("4- Chen 1 phan tu vao danh sach");
                Console.WriteLine("5- Duyet danh sach");
                Console.WriteLine("6- Tim 1 phan tu");
                Console.WriteLine("7- Sap xep danh sach tang dan");
                Console.WriteLine("8- Sap xep danh sach giam dan");
                Console.WriteLine("0- Thoat chuong trinh");
                Console.WriteLine("===================================");
                m = Convert.ToInt32(Console.ReadLine());
                switch(m)
                {
                    case 1: Console.WriteLine("Khoi tao danh sach"); break;
                    case 2: Them(List); break;
                    case 3: Xoa(List); break;
                    case 4: Chen(List); break;
                    case 5: Duyet(List); break;
                    case 6: Tim(List); break;
                    case 7: sortup(List); break;
                    case 8: sortdown(List); break;
                    default: m = 0; break;

                }
            } while (m >= 1 && m <= 8);

        }
        static void Them(ArrayList a)
        {
            a.Add(Convert.ToInt32(Console.ReadLine()));
        }
        static void Xoa(ArrayList a)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            a.Remove(b);
        }
        static void Chen(ArrayList a)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            a.Insert(b, c);
        }
        static void Duyet(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(Convert.ToInt32(a[i]));
            }
        }
        static void Tim(ArrayList a)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < a.Count;i++)
            {
                if(Convert.ToInt32(a[i])==b)
                {
                    Console.WriteLine(value: $"Co phan tu {b} o index {i}");
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("None");
            }
        }
        static void sortup(ArrayList a)
        {
            a.Sort();
            
        }
        static void sortdown(ArrayList a)
        {
            a.Sort();
            a.Reverse();
        }
    } 
}
        
        
    






