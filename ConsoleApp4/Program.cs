using System;

namespace String
{
    class Program
   {
        static void Main(string[] args)
        {
            int n = 0;
            nhap(ref n);
        }
        static int nhap(ref int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            check(n);
            return n;
            
        }
        static void check(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("n phai lon hon 0");
                nhap(ref n);
            }
            else {
                sum(Convert.ToString(n));
                 }
        }
        static void sum(string n)
        {
            Console.Write("Tong cong la: ");
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += ((int)(n[i])-48);
            }
            Console.WriteLine(sum);
        }
    } 

}


            