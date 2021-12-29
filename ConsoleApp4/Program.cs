using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            int m = 1;
            do
            {
                Console.WriteLine("Chuong trinh danh sach sinh vien su dung Arraylist");
                Console.WriteLine("===================================");
                Console.WriteLine("1- Them mot sinh vien vao danh sach");
                Console.WriteLine("2- Duyet danh sach");
                Console.WriteLine("3- Tim thong tin mot sinh vien theo ten");
                Console.WriteLine("4- Sua diem sinh vien");
                Console.WriteLine("5- Danh sach sinh vien nhan hoc bong");
                Console.WriteLine("6- Xem diem cuar sinh vien");
                Console.WriteLine("7- Sap xep giam dan theo diem tb");
                Console.WriteLine("8- Sap xep giam dan theo diem tb, tang dan theo ten");
                Console.WriteLine("0- Thoat chuong trinh");
                Console.WriteLine("===================================");
                m = Convert.ToInt32(Console.ReadLine());
                switch(m)
                {
                    case 1: input_student(a); break;
                    case 2: duyet(a); break;
                    case 3: output_student(a); break;
                    case 4: suadiem(a); break;
                    case 5: hocbong(a); break;
                    case 6: xemdiem(a); break;
                    case 7: sortdown(a); break;
                    case 8: sortdown_name(a); break;
                    case 0: m = 0; break;
                    default: m = 0; break;
                    
                }
            } while (m >= 1 && m <= 8);
        }
        public static void input_student(ArrayList a)
        {
            Console.WriteLine("Ho hoc sinh");
            string f_name = Console.ReadLine();
            Console.WriteLine("Ten lot hoc sinh");
            string s_name = Console.ReadLine();
            Console.WriteLine("Ten hoc sinh");
            string p_name = Console.ReadLine();
            Console.WriteLine("Ma so hoc sinh");
            string code = Console.ReadLine();
            Console.WriteLine("Tuoi hoc sinh");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diem trung binh");
            double mark = Convert.ToDouble(Console.ReadLine());
            a.Add(new students(code,f_name,s_name,p_name,age,mark));
        }
        public static void output_student(ArrayList a)
        {
            Console.Write("Nhap ten sinh vien: ");
            string b = Console.ReadLine();
            for (int i = 0; i < a.Count; i++)
            {
                if (((students)a[i]).p_name.ToLower().Contains(b.ToLower()))
                {
                    ((students)a[i]).infor();
                }
            }
        }
        public static void duyet(ArrayList a)
        {
            for(int i = 0; i<a.Count;i++)
            {
                ((students)a[i]).infor();
            }    
        }
        public static void suadiem(ArrayList a)
        {
            Console.Write("Nhap ho ten sinh vien: ");
            string b = Console.ReadLine();

            for (int i = 0; i < a.Count; i++)
            {
                if (((students)a[i]).p_name.ToLower().Contains(b.ToLower()))
                {
                    Console.Write("Sua diem sinh vien: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(value: $"Diem truoc khi sua la {((students)a[i]).s_mark}");
                    ((students)a[i]).s_mark = c;
                    Console.WriteLine(value: $"Diem sau khi sua la {((students)a[i]).s_mark}");
                    ((students)a[i]).infor();
                }
            }
        }
        public static void hocbong(ArrayList a)
        {
            Console.WriteLine("Danh sach sinh vien nhan hoc bong la");
            for(int i = 0; i< a.Count ; i++)
            {
                if(((students)a[i]).s_mark >=8)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(((students)a[i]).name());
                    Console.WriteLine(((students)a[i]).s_mark);
                    Console.WriteLine("----------------------");
                }
            }
        }
        public static void xemdiem(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(((students)a[i]).name());
                    Console.WriteLine(((students)a[i]).s_mark);
                    Console.WriteLine("----------------------");
            }
        }
        public static void sortdown(ArrayList a)
        {
            ArrayList replace = new ArrayList();
            for(int i =0; i< a.Count; i++)
            {
                replace.Add(i);
            }
            for(int i = 0; i<a.Count;i++)
            {
                for(int j = i+1; j<a.Count; j++)
                {
                    if(((students)a[i]).s_mark >= ((students)a[j]).s_mark)
                            
                      {
                        replace[i] = a[i];
                        a[i] = a[j];
                        a[j] = replace[i];

                      }
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                ((students)a[i]).infor();
            }
        }
        public static void sortdown_name(ArrayList a)
        {
            ArrayList replace = new ArrayList();
            for (int i = 0; i < a.Count; i++)
            {
                replace.Add(i);
            }
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (((students)a[i]).s_mark >= ((students)a[j]).s_mark)

                    {
                        replace[i] = a[i];
                        a[i] = a[j];
                        a[j] = replace[i];

                    }
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (((students)a[i]).s_mark >= ((students)a[j]).s_mark)
                    {
                        if (((students)a[i]).p_name[0] > ((students)a[j]).p_name[0])
                        {
                            replace[i] = a[i];
                            a[i] = a[j];
                            a[j] = replace[i];
                            break;
                        }
                        else if (((students)a[i]).p_name[1] > ((students)a[j]).p_name[1])
                        {
                            replace[i] = a[i];
                            a[i] = a[j];
                            a[j] = replace[i];
                            break;
                        }
                        else if (((students)a[i]).p_name[2] > ((students)a[j]).p_name[2])
                        {
                            replace[i] = a[i];
                            a[i] = a[j];
                            a[j] = replace[i];
                            break;
                        }
                        else if (((students)a[i]).p_name[3] > ((students)a[j]).p_name[3])
                        {
                            replace[i] = a[i];
                            a[i] = a[j];
                            a[j] = replace[i];
                            break;
                        }
                        else
                        {
                            replace[i] = a[i];
                            a[i] = a[j];
                            a[j] = replace[i];
                            break;
                        }
                    }
                }
            }
        }
    }
}
    






