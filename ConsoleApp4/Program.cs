using System;
using System.Collections;

namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
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
                switch(m)
                {
                    case 1: add(stack); break;
                    case 2: lay(stack); break;
                    case 3: seefirststack(stack); break;
                    case 4: danhsach(stack); break;
                    case 0: m = 0; break;
                    default: m = 0; break;
                }
            }
            while (m >= 1 && m <= 5);
        }
        static void add(Stack<int> a)
        {
            Console.WriteLine("Push vao stack");
            int b = Convert.ToInt32(Console.ReadLine());
            a.Push(b);
        }
        static void lay(Stack<int> a)
        {   
            ArrayList b = new ArrayList();
            for(int i = 0; i< a.Count; i++)
            {
                b.Add(a.Pop());                
            }
            a.Pop();
            for(int i =b.Count-1;i>=0; i--)
            {
                a.Push(Convert.ToInt32(b[i]));
            }
        }
        static void seefirststack(Stack<int> a)
        {
            ArrayList b = new ArrayList();
            for (int i = 0; i < a.Count; i++)
            {
                b.Add(a.Pop());
            }
            Console.WriteLine(a.Peek());
            for (int i = b.Count - 1; i >= 0; i--)
            {
                a.Push(Convert.ToInt32(b[i]));
            }
        }
        static void danhsach(Stack<int> a)
        {
            foreach(int b in a)
            {
                Console.WriteLine(b);
            }
        }
     
    } 
}
        
        
    






