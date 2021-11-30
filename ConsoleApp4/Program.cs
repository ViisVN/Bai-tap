using System;

namespace String
{
    class Program
    { 
        static void Diemtb(double a, double b)
        {
           double c= (a + b) / 2;
            Console.Write(c);
        }
        static void Main(string[] args)
        {            
            Console.Write("\n -----------------------------");
            Console.Write("\n Ho ten   : ");
            string ten = Console.ReadLine();
            Console.Write(" Lop      : ");
            string lop = Console.ReadLine();
            Console.Write(" Diemtoan : ");
            int diemtoan = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Diemvan  : ");
            int diemvan = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Diemtb   : ");
            Diemtb(diemtoan, diemvan);
            Console.Write("\n -----------------------------");
        }

    }
}
            