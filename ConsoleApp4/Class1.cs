using System;

namespace String
{
    public class product
    {
        public int stt;
        public string tensanpham;
        public float soluong;
        public float dongia;
        public float tongtien(float soluong, float dongia)
        {
            return (soluong * dongia);
        }
        public float tongcong(float a, float b, float c, float d, float e)
        {
            return a + b + c + d + e;
        }
        public product(int stt1, string tensanpham1, float soluong1, float dongia1)
        {
            stt = stt1;
            tensanpham = tensanpham1;
            soluong = soluong1;
            dongia = dongia1;
        }
    }
   
}