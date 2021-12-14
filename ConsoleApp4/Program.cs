namespace String
{
    class program
    {
        static void Main(string[] args)
        {
            product mayin = new product(1,"Mayin",5,150);
            product LCD = new product(2, "Man hinh LCD", 10, 350);
            product Mitsumi = new product(3, "Chuot Mitsumi", 25, 10);
            product Banphim = new product(4, "Ban phim", 10, 12);
            product USB = new product(5, "USB 2G", 100, 13);
            float tongcong = mayin.tongtien(mayin.soluong, mayin.dongia) + LCD.tongtien(LCD.soluong, LCD.dongia) + Mitsumi.tongtien(Mitsumi.soluong, Mitsumi.dongia) + Banphim.tongtien(Banphim.soluong, Banphim.dongia) + USB.tongtien(USB.soluong, USB.dongia);
            Console.WriteLine("DANH MUC SAN PHAM");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(":STT:  Ten san pham    : So luong :  Dongia   : Tongtien");
            Console.WriteLine(value: $": {mayin.stt} :   {mayin.tensanpham}          : {mayin.soluong}        :  {mayin.dongia}      : {mayin.tongtien(mayin.soluong, mayin.dongia)}");
            Console.WriteLine(value: $": {LCD.stt} :   {LCD.tensanpham}   : {LCD.soluong}       :  {LCD.dongia}      : {LCD.tongtien(LCD.soluong, LCD.dongia)}");
            Console.WriteLine(value: $": {Mitsumi.stt} :   {Mitsumi.tensanpham}  : {Mitsumi.soluong}       :  {Mitsumi.dongia}       : {Mitsumi.tongtien(Mitsumi.soluong, Mitsumi.dongia)}");
            Console.WriteLine(value: $": {Banphim.stt} :   {Banphim.tensanpham}       : {Banphim.soluong}       :  {Banphim.dongia}       : {Banphim.tongtien(Banphim.soluong, Banphim.dongia)}");
            Console.WriteLine(value: $": {USB.stt} :   {USB.tensanpham}         : {USB.soluong}      :  {USB.dongia}       : {USB.tongtien(USB.soluong, USB.dongia)}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(value: $":                                             : {tongcong}");

        }
    }
}
        

    
