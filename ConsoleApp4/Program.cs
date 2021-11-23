using System;

namespace Vong_lap
{
    class baitap
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("\nSO THICH CA NHAN");
            Console.Write("\n================");
            Console.Write("\n1. Doc sach");
            Console.Write("\n2. Nghe nhac");
            Console.Write("\n3. Choi the thao");
            Console.Write("\n4. May tinh");
            Console.Write("\n5. Thoat");
            Console.Write("\n================");
            Console.Write("\nChon: ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out n1) == true)
            {
                while (int.TryParse(n, out n1) == true)
                {
                    if (Convert.ToInt32(n) == 1)
                    {
                        Console.Write("Ban thich doc sach");
                        break;
                    }
                    else if (Convert.ToInt32(n) == 2)
                    {
                        Console.Write("Ban thich nghe nhac");
                        break;
                    }
                    else if (Convert.ToInt32(n) == 3)
                    {
                        Console.Write("Ban thich choi the thao");
                        break;
                    }
                    else if (Convert.ToInt32(n) == 4)
                    {
                        Console.Write("Ban thich may tinh");
                        break;
                    }
                    else if (Convert.ToInt32(n) == 5)
                    {
                        Console.Write("Hen gap lai");
                        break;
                    }
                    else if (Convert.ToInt32(n) < 1 || Convert.ToInt32(n) > 5)
                    {
                        Console.Write("Ban nhap sai");
                        break;
                    }
                }
              }
             else
              {
                Console.Write("\nBan da nhap sai");
              }
            }
        }
    }

    