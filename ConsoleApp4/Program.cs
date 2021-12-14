namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            diem Java = new diem("Nhap mon Lap trinh voi Java", 9, 8);
            Console.WriteLine("THONG TIN VE MON HOC");
            Console.WriteLine("================================");
            Java.lietke(Java.tenmonhoc, Java.diemLT, Java.diemTH);
            Java.diem_TB(Java.diemLT, Java.diemTH);
        }

    }
}


