using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
         ArrayList Namelist = new ArrayList();
         ArrayList Chuanhoa = new ArrayList();
            int m = 0;
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("             MENU             ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Nhap ten hoc vien moi");
                Console.WriteLine("2. Tim kiem hoc vien");
                Console.WriteLine("3. Chuan hoa ten hoc vien");
                Console.WriteLine("4. Hien thi danh sach hoc vien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("------------------------------");
                Console.Write("Nhap menu: ");
                m=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------");
                switch(m)
                {                    
                    case 1: Nhapten(Namelist); break;
                    case 2: timkiemten(Namelist); break;
                    case 3:
                        if(Chuanhoa.Count > 0)
                        {
                            Chuanhoa.Clear();
                        }    
                        chuanhoaten(Namelist, Chuanhoa);
                        break;
                    case 4: Xuatten(Namelist,Chuanhoa); break;
                    case 0: Console.WriteLine("BAN DA THOAT"); break;
                }    

            }
            while (m >= 1 && m <= 4);
        }
        static void Nhapten(ArrayList Name)
        {          
                Name.Add(Console.ReadLine());
            
        }
        static void Xuatten(ArrayList Name,ArrayList ChuanHoa)
        { 
                Console.WriteLine("-----------------------------------------");
            Console.WriteLine(":STT:     TEN CU       : TEN MOI ");
                Console.WriteLine("-----------------------------------------");
                for (int i = 0; i < Name.Count; i++)
                {
                    Console.WriteLine(value: $":{i + 1}: {Name[i]}    : {ChuanHoa[i]} ");
                }
                Console.WriteLine("-----------------------------------------");
           
        }
        static void chuanhoaten(ArrayList Name, ArrayList ChuanHoa)
        {
            string d = null;
            string b = null;
            string c = null;
            

            for (int i = 0; i < Name.Count; i++)
            {
                b = null;
                c = null;
                d = Convert.ToString(Name[i]);
                d = d.ToLower();
                do//Xóa kí hiệu đặc biệt và dấu cách
                {
                    if (d[0] >= ' ' && d[0] <= '/' || d[0] >= ':' && d[0] <= '@' || d[0] >= '[' && d[0] <= '`' || d[0] >= '{' && d[0] <= '~')
                    {
                        d = d.Remove(0, 1);
                    }
                } while (d[0] >= ' ' && d[0] <= '/' || d[0] >= ':' && d[0] <= '@' || d[0] >= '[' && d[0] <= '`' || d[0] >= '{' && d[0] <= '~');
                for (int j = d.Length - 1; j >= 0; j--)//Đảo ngược lại để xóa
                {
                    b += d[j];
                }
                do//Xóa dấu cách và kí tự đặc biệt cuối câu
                {
                    if ((b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~'))
                    {
                        b = b.Remove(0, 1);
                    }
                } while (b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~');
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    c += b[j];
                }
                b = null;
                for (int j = 33; j <= 47; j++)//Xóa các kí tự đặc biệt giữa câu
                {
                    c = c.Replace(Convert.ToString((char)i), "");
                }
                for (int j = 58; j <= 64; j++)
                {
                    c = c.Replace(Convert.ToString((char)i), "");
                }
                for (int j = 91; j <= 96; j++)
                {
                    c = c.Replace(Convert.ToString((char)i), "");
                }
                for (int j = 123; j <= 126; j++)
                {
                    c = c.Replace(Convert.ToString((char)i), "");
                }
                for (int j = 0; j < c.Length; j++)//Xoa dau bang ngang cau
                {
                    if (c[j] == ' ' && c[j] == c[j + 1])
                    {
                    Again:
                        c = c.Remove(j, 1);
                        c += ',';

                        if (c[j] == ' ' && c[j] == c[j + 1])
                        {
                            goto Again;
                        }
                    }
                }
                for (int j = c.Length - 1; j >= 0; j--)//Đảo ngược lại để xóa
                {
                    b += c[j];
                }
                c = null;
                do//Xóa dấu cách và kí tự đặc biệt cuối câu
                {
                    if ((b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~'))
                    {
                        b = b.Remove(0, 1);
                    }
                } while (b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~');
                for (int j = b.Length - 1; j >= 0; j--)//Đảo về câu đúng thứ tự
                {
                    c += b[j];
                }
                if (c[0] >= 'a' && c[0] <= 'z')//Upcase kí tự đầu
                {
                    c = c.Insert(0, Convert.ToString((char)(int)(c[0] - 32)));
                    c = c.Remove(1, 1);
                }
                for (int j = c.Length - 1; j >= 0; j--)//Upcase các kí tự giữa
                {
                    if (c[j] == ' ' && c[j + 1] != ' ' && c[j + 1] >= 'a' && c[j + 1] <= 'z')
                    {
                        c = c.Insert(j + 1, Convert.ToString((char)(int)(c[j + 1] - 32)));
                        c = c.Remove(j + 2, 1);

                    }
                }
                ChuanHoa.Add(c);
            }
            again:
            Console.Write("Ban co muon xuat danh sach? Y/N: ");
            string a = Console.ReadLine();
            {
                if (a == "Y")
                {
                   Xuatten(Name,ChuanHoa);
                }
                else if(a=="N")
                {
                    Console.WriteLine("Tiep tuc");
                }    
                else
                {
                    Console.WriteLine("SAI LENH!!NHAP LAI!!");
                    goto again;
                }    
            }

        }
                
        static void timkiemten(ArrayList Name)
        {
            Console.WriteLine("HO HOAC TEN BAN CAN TIM: ");
            string a = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < Name.Count; i++)
            {
                if (Convert.ToString(Name[i]).ToLower().Contains(a.ToLower()))
                {
                    Console.WriteLine(Name[i]);
                }
                else
                {
                    count += 1;
                }
            }
            if (count == Name.Count)//Truong hop count = name.count co nghia la khong co ten
            {
                Console.WriteLine("Khong co du lieu ten ban can tim");
            }
        }

    }
}
        
        
    






