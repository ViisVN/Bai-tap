using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            double km, tientaxi, tiengiamgia;
            Console.Write("\n Nhap so km da di: ");
            km = double.Parse(Console.ReadLine());
            if (km <= 1)
            {
                tientaxi = km * 15000;
            }
            else if (km>1 && km<=5)
            {
                tientaxi = km * 13500;
            }    
            else
            {
                tientaxi = km * 11000;
            }
            if(km>120)
            {
                tiengiamgia = tientaxi * 0.9;
                Console.WriteLine("Tong tien Taxi là : " + tiengiamgia + " VND");
            }    
            else
            {
                Console.WriteLine("Tong tien taxi là : " + tientaxi + " VND");
            } 

        }
    }
}
    