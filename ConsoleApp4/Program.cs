using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 8;//Bien dem cho tong so mon hoc
            int m = 0;//Bien dem menu cho do-while
            ArrayList list = new ArrayList();
            Console.WriteLine("1. Nhap danh sach mon hoc");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Diem TB cao nhat");
            Console.WriteLine("4. Thoat");
            do
            {
                Console.WriteLine();
                Console.Write("Hay chon mot option: ");
                 m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("MOI BAN NHAP DANH SACH MON HOC");
                        Nhapdanhsach(list, n);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("DANH SACH MON HOC");
                        Console.WriteLine("=======================");
                        Console.WriteLine("Mon - LT - TH - TB");
                        Indanhsach(list, n);
                        Console.WriteLine("=======================");
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("MON TB CAO NHAT LA");
                        MaxTB(list, n);
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Tam biet");
                        m = 5;
                        break;
                }
            } while (m >= 1 && m <= 4);
         
        }
        static void Nhapdanhsach(ArrayList list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(value: $"Nhap ten mon hoc thu {i + 1} : ");
                string name = Console.ReadLine();
                list.Add(new sub(name, new Random().Next(6, 10), new Random().Next(6, 10)));
            }
        }
        static void Indanhsach(ArrayList list,int n)
        {
            for (int i =0;i< n;i++)
            {
                ((sub)list[i]).Xuatdanhsach2();
            }
        }
        static void MaxTB(ArrayList list, int n)
        {
            sub max = new sub();
            max = (sub)list[0];
            for (int i = 0;i< n;i++)
            {
                if(max.TB()<=((sub)list[i]).TB())
                {
                    max = ((sub)list[i]);
                }              
            }
            max.Xuatdanhsach1();
        }
    }
}
        

    
