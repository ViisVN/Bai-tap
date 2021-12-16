using System;

namespace String
{
    public class Bank
    {

        public int stk;
        public string name;
        public double balance;
        public double rate = 0.045;
        public Bank(int stk1, string name1, int balance1)
        {
            stk = stk1;
            name = name1;
            balance = balance1;          
        }
        public Bank()
        {

        }
        public void guest()
            {
            Console.WriteLine("==============================================");
            Console.WriteLine("TEN KHACH HANG: {0}", name);
                Console.WriteLine("SO TAI KHOAN: {0}", stk);
                Console.WriteLine("SO DU: {0}$", balance);
            Console.WriteLine("==============================================");
        }
        
    }
    
}