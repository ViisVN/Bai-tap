using System;

namespace String
{
    public class diem
    {
        public string tenmonhoc;
        public float diemLT;
        public float diemTH;
        public diem(string monhoc, float LT,float TH)
        {
            tenmonhoc = monhoc;
            diemLT = LT;
            diemTH = TH;
        }
        public void diem_TB(float diemLT, float diemTH)
        {
            float TB = (diemLT + diemTH) / 2;
            Console.WriteLine(TB);
        }
        public void lietke(string monhoc, float diemLT, float diemTH)
        { 
            Console.WriteLine("Ten mon hoc: " + monhoc);
            Console.WriteLine("Diem ly thuyet: " + diemLT);
            Console.WriteLine("Diem thuc hanh: " + diemTH);
            Console.Write("Diem trung binh: ");
        }

    }
}