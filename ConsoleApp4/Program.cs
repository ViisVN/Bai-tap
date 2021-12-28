using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            Queue<int> a = new Queue<int>();
            int m = 1;
            do
            {
                Console.WriteLine("----------");
                Console.WriteLine("1. Them 1 phan tu vao stack");
                Console.WriteLine("2. Lay phan tu dau khoi stack");
                Console.WriteLine("3. Xem phan tu dau stack");
                Console.WriteLine("4. Duyet stack");
                Console.WriteLine("0. Thoat");
                m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {
                    case 1: Add(a); break;
                    case 2: Lay(a); break;
                    case 3: Xem(a); break;
                    case 4: Duyet(a); break;
                    case 0: m = 0; break;
                    default: m = 0; break;
                }
            }
            while (m >= 1 && m <= 5);
        }
        static void Add(Queue<int> a)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            a.Enqueue(b);
        }
        static void Lay(Queue<int> a)
        {
            a.Dequeue();
        }
        static void Xem(Queue<int> a)
        {
            Console.WriteLine(a.Peek());
        }
        static void Duyet(Queue<int> a)
        {
            foreach(int b in a)
                Console.WriteLine(b);
        }
     
    } 
}
        
        
    






