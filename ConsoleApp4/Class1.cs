using System;

namespace String
{
    public class sub
    {
        public string subname;
        public float LT;
        public float TH;
        public float TB()
        {
            return (LT + TH) / 2;
        }

        public sub(string subname, float lT, float tH)
        {
            this.subname = subname;
            LT = lT;
            TH = tH;
        }
        public sub()
        {

        }
        public void Xuatdanhsach1()
        {
            Console.WriteLine("Mon : {0}", subname);
            Console.WriteLine("DiemLT: {0}", LT);
            Console.WriteLine("DiemTH: {0}", TH);
            Console.WriteLine("DiemTB: {0}", TB());
        }
        
        public void Xuatdanhsach2()
        {
            Console.WriteLine(" {0} : {1} : {2} : {3} ", subname, LT, TH, TB());
        }
    }
    
}