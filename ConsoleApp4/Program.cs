using System;
using System.Collections;

namespace String
{
    class program
    {
        public static void Main(string[] args)
        {
            int n = 1;//So luong tai khoan
            int m = 1;//The hien Menu
            Bank guest = new Bank();      
            ArrayList list = new ArrayList();
            do
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("SO TAI KHOAN NGAN HANG BAN DANG CO LA: " + (n - 1));
                Console.WriteLine("==============================================");
                Console.WriteLine("| 1. DANG KI TAI KHOAN");
                Console.WriteLine("| 2. GOI TIEN");
                Console.WriteLine("| 3. RUT TIEN");
                Console.WriteLine("| 4. CONG LAI XUAT");
                Console.WriteLine("| 5. TRA CUU THONG TIN");
                Console.WriteLine("| 6. THOAT");
                Console.WriteLine("==============================================");
                Console.Write("| MOI BAN NHAP MENU : ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("==============================================");
                switch (m)
                {
                    case 1:Console.WriteLine("BAN CHON DANG KI TAI KHOAN");
                        Console.WriteLine("==============================================");
                        Sign_Up(list,n);
                        ((Bank)list[n - 1]).guest();
                        n++;//Tang so luong stk
                        break;
                    case 2:Console.WriteLine("BAN CHON GOI TIEN");
                        Console.WriteLine("==============================================");
                        Goitien(list, n); break;
                    case 3:
                        Console.WriteLine("BAN CHON RUT TIEN");
                        Console.WriteLine("==============================================");
                        Ruttien(list, n); break;
                    case 4:
                        Console.WriteLine("BAN CHON CONG LAI XUAT");
                        Console.WriteLine("==============================================");
                        Conglaixuat(list, n); break;
                    case 5:
                        Console.WriteLine("BAN CHON TRA CUU THONG TIN");
                        Console.WriteLine("==============================================");
                        Tra_Cuu(list, n); break;
                    default:
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Cam on ban da ghe qua");
                        Console.WriteLine("=============================================="); 
                        break;

                }
            } while (m >= 1 && m <= 5);

        }
        public static void Sign_Up(ArrayList list,int n)
        {
            Console.Write("TEN CUA BAN LA : ");
            string name = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            Console.Write("NHAP NGAY THANG NAM SINH: ");
            int stk = Convert.ToInt32(Console.ReadLine());
            list.Add(new Bank(stk, name, 10000));
            Console.WriteLine("==============================================");
            Console.WriteLine("KHOI TAO TAI KHOANG THANH CONG");        }
        public static void Tra_Cuu(ArrayList list,int n)
        {
            Console.Write("NHAP TEN KHACH HANG: ") ;
            string name = Console.ReadLine();
            for(int i = 0;i<n -1 ;i++)
            {
                if(name == ((Bank)list[i]).name)
                {
                    ((Bank)list[i]).guest();
                }
            }
        }
        public static void Goitien(ArrayList list, int n)
        {
            Console.Write("TEN KHACH HANG MUON GUI TIEN: ");
            string name = Console.ReadLine();
            for(int i = 0; i<n-1;i++)
            {
                if (name == (((Bank)list[i]).name))
                {
                    Console.Write(value: $"NHAP SO TIEN {name} MUON GUI : ");
                    int tiengui = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(value: $"{name} DA GUI VAO TAI KHOAN {tiengui}$");
                    Console.WriteLine("==============================================");
                    ((Bank)list[i]).balance = tiengui + ((Bank)list[i]).balance;
                    Console.WriteLine(value: $"SO DU HIEN TAI CUA TAI KHOAN {name} LA {((Bank)list[i]).balance}$");
                    Console.WriteLine("==============================================");
                    break;
                }
            }
        }
        public static void Ruttien(ArrayList list, int n)
        {
            Console.Write("NHAP SO TAI KHOAN BAN MUON RUT TIEN: ");
            int stk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                if (stk == (((Bank)list[i]).stk))
                {
                    Console.Write("NHAP SO TIEN BAN MUON RUT: ");
                    int ruttien=Convert.ToInt32(Console.ReadLine());
                    if ((((Bank)list[i]).balance - ruttien) < 0)
                    {
                        Console.WriteLine("ERROR!! ERROR!! KHONG DUOC RUT QUA HAN MUC!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(value: $"SO DU TRONG TAI KHOAN TRUOC KHI RUT CUA { ((Bank)list[i]).name} LA: {((Bank)list[i]).balance}$ ");
                        ((Bank)list[i]).balance = ((Bank)list[i]).balance - ruttien;
                        Console.WriteLine(value: $"SO DU HIEN TAI TRONG TAI KHOAN { ((Bank)list[i]).name} LA {((Bank)list[i]).balance}$");
                        break;
                    }
                }
           }
        }
        public static void Conglaixuat(ArrayList list, int n)
        {
            Console.WriteLine("CONG LAI XUAT CHO TAT CA TAI KHOAN");
            for (int i = 0;i < n-1 ;i++)
            {
                ((Bank)list[i]).balance = ((Bank)list[i]).balance+(((Bank)list[i]).balance * ((Bank)list[i]).rate);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("CONG LAI XUAT THANH CONG");
            Console.WriteLine("==============================================");
            Console.WriteLine("SO DU CUA CAC TAI KHOAN");
            for(int i = 0;i < n-1;i++)
            {
                Console.WriteLine(value: $"{((Bank)list[i]).name} CO SO DU LA {((Bank)list[i]).balance}");
            }
        }
    }
            
 }

        

    
