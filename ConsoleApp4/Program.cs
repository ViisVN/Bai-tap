using System;

namespace Vong_lap
{
    class baitap
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so nguyen lon hon 0:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Convert.ToString(n).Length];
            int sum = 0;
            for (int i = 0; i < Convert.ToString(n).Length; i++)
            {
                arr[i] = (Convert.ToInt32(Convert.ToString(n)[i]) - 48);
            }
            Console.Write("\nDay so bao gom: ");
            for (int i = 0; i < Convert.ToString(n).Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
            Console.Write("\nTong cac so trong do la: " + sum);

        }

    }
}
    