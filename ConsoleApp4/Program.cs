namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            string c = null;

            Console.WriteLine("Cau goc");
            Console.WriteLine(a);
            a = a.ToLower();
            do//Xóa kí hiệu đặc biệt và dấu cách
            {
                if ((a[0] >= ' ' && a[0] <= '/' || a[0] >= ':' && a[0] <= '@' || a[0] >= '[' && a[0] <= '`' || a[0] >= '{' && a[0] <= '~'))
                {
                    a = a.Remove(0, 1);
                }
            } while (a[0] >= ' ' && a[0] <= '/' || a[0] >= ':' && a[0] <= '@' || a[0] >= '[' && a[0] <= '`' || a[0] >= '{' && a[0] <= '~');
            for (int i = a.Length - 1; i >= 0; i--)//Đảo ngược lại để xóa
            {
                b += a[i];
            }
            do//Xóa dấu cách và kí tự đặc biệt cuối câu
            {
                if ((b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~'))
                {
                    b = b.Remove(0, 1);
                }
            } while (b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~');
            for (int i = b.Length - 1; i >= 0; i--)
            {
                c += b[i];
            }
            b = null;
            for (int i = 33; i <= 47; i++)//Xóa các kí tự đặc biệt giữa câu
            {
                c = c.Replace(Convert.ToString((char)i), "");
            }
            for (int i = 58; i <= 64; i++)
            {
                c = c.Replace(Convert.ToString((char)i), "");
            }
            for (int i = 91; i <= 96; i++)
            {
                c = c.Replace(Convert.ToString((char)i), "");
            }
            for (int i = 123; i <= 126; i++)
            {
                c = c.Replace(Convert.ToString((char)i), "");
            }
            for (int i = 0; i < c.Length; i++)//Xoa dau bang ngang cau
            {
                if (c[i] == ' ' && c[i] == c[i + 1])
                {
                Again:
                    c = c.Remove(i, 1);
                    c += ',';

                    if (c[i] == ' ' && c[i] == c[i + 1])
                    {
                        goto Again;
                    }
                }
            }
            for (int i = c.Length - 1; i >= 0; i--)//Đảo ngược lại để xóa
            {
                b += c[i];
            }
            c = null;
            do//Xóa dấu cách và kí tự đặc biệt cuối câu
            {
                if ((b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~'))
                {
                    b = b.Remove(0, 1);
                }
            } while (b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~');
            for (int i = b.Length - 1; i >= 0; i--)//Đảo về câu đúng thứ tự
            {
                c += b[i];
            }
            if(c[0]>='a'&&c[0]<='z')//Upcase kí tự đầu
            {
                c = c.Insert(0, Convert.ToString((char)(int)(c[0] - 32)));
                c = c.Remove(1, 1);
            }    
            for (int i = c.Length - 1; i >= 0; i--)//Upcase các kí tự giữa
            {
                if (c[i] == ' ' && c[i + 1] != ' '&&c[i+1]>='a'&& c[i + 1] <= 'z')
                {
                    c = c.Insert(i+1, Convert.ToString((char)(int)(c[i + 1] - 32)));
                    c =c.Remove(i + 2,1);
                   
                }    
            } 
            Console.WriteLine("Sau khi sua");
            Console.WriteLine(c);
        }
    }
}
        
        
    






