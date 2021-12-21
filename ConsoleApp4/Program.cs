namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            string c = null;

            do//Xóa kí hiệu đặc biệt và dấu cách
            {
                a = a.Remove(0, 1);
            } while (a[0] >= ' ' && a[0] <= '/' || a[0] >= ':' && a[0] <= '@' || a[0] >= '[' && a[0] <= '`' || a[0] >= '{' && a[0] <= '~');
            for (int i = a.Length - 1; i >= 0; i--)//Đảo ngược lại để xóa
            {
                b += a[i];
            }
            do//Xóa dấu cách và kí tự đặc biệt cuối câu
            {
                b = b.Remove(0, 1);
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
                b = b.Remove(0, 1);
            } while (b[0] >= ' ' && b[0] <= '/' || b[0] >= ':' && b[0] <= '@' || b[0] >= '[' && b[0] <= '`' || b[0] >= '{' && b[0] <= '~');
            for (int i = b.Length - 1; i >= 0; i--)//Đảo về câu đúng thứ tự
            {
                c += b[i];
            }
            for (int i = c.Length - 1; i >= 0; i--)//Upcase ki tu
            {
                if (c[i] == ' ' && c[i + 1] != ' ')
                {
                    Console.WriteLine((char)(int)(c[i + 1] - 32));
                    c = c.Insert(i+1, Convert.ToString((char)(int)(c[i + 1] - 32)));
                    c =c.Remove(i + 2,1);
                   
                }    
            }
            Console.WriteLine("Cau goc");
            Console.WriteLine(a);   
            Console.WriteLine("Sau khi sua");
            Console.WriteLine(c);
        }
    }
}
        
        
    






