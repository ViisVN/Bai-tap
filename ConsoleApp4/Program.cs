namespace String
{
    class Program
    {
        static void socantinh(ref int[] a)
        {
            for (int i = 0; i < short.MaxValue; i++)
            {
                a[i] = i + 1;
            }
        }
        static void tinhsonguyento(int[] a, ref int[] b, int range)
        {
            int n = 0;
            int count = 0;
            for (int i = 0; i < short.MaxValue; i++)
            {
                for (int j = 0; j < short.MaxValue; j++)
                {
                    if (a[i] % (j + 1) == 0)
                    {
                        count++;
                    }
                    if (count == 2 && a[i] == (j + 1))
                    {
                        b[n] = a[i];
                        n++;
                        count = 0;
                        break;
                    }
                    if (count > 2)
                    {
                        break;
                    }
                }
                if (count > 2)
                {
                    count = 0;
                }
                if (n == range)
                {
                    break;
                }

            }
        }
        static void xuatdulieu(int[] a,int range)
        {
            for(int i =0; i<range;i++)
            {
                Console.WriteLine("[" + i + "] : " + a[i]);
            }
        }
            static void Main(string[] args)
            {
                Console.Write("Nhap so luong so nguyen to ban muon xuat ra: ");
                int range = Convert.ToInt32(Console.ReadLine());
                int[] v = new int[range];
                int[] a = new int[short.MaxValue];  //Tinh den gioi han cua short
                socantinh(ref a);
                tinhsonguyento(a, ref v, range);
                xuatdulieu(v, range);
            }
        }

    }


