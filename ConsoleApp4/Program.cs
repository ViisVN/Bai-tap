using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            double xA,xB,xC,yA,yB,yC;
            Console.Write("Diem A co x la: ");
            xA = double.Parse(Console.ReadLine());
            Console.Write("Diem A co y la: ");
            yA = double.Parse(Console.ReadLine());
            Console.Write("Diem B co x la: ");
            xB = double.Parse(Console.ReadLine());
            Console.Write("Diem B co y la: ");
            yB = double.Parse(Console.ReadLine());
            Console.Write("Diem C co x la: ");
            xC = double.Parse(Console.ReadLine());
            Console.Write("Diem C co y la: ");
            yC = double.Parse(Console.ReadLine());
            double AB, AC, BC;
            AB = Math.Sqrt((Math.Pow((xB - xA), 2)) + (Math.Pow((yB - yA), 2)));
            AC = Math.Sqrt((Math.Pow((xC - xA), 2)) + (Math.Pow((yC - yA), 2)));
            BC = Math.Sqrt((Math.Pow((xC - xB), 2)) + (Math.Pow((yC - yB), 2)));
            Console.Write("Do dai canh AB la: " + AB);
            Console.Write("\nDo dai canh AC la: " + AC);
            double cosBAC, sinBAC, SABC;
            cosBAC = (((xC - xA) * (xB - xA)) + ((yC - yA) * (yB - yA))) / (AB * AC);
            sinBAC = Math.Sqrt(1 + cosBAC);
            SABC = 0.5 * AB * AC * sinBAC;
            Console.WriteLine("\nDien tích ABC là: "+SABC);
            double xM, yM;
            Console.Write("\nDiem M co x la: ");
            xM = double.Parse(Console.ReadLine());
            Console.Write("\nDiem M co y la: ");
            yM = double.Parse(Console.ReadLine());
            double SBAM, SCAM, SBCM, AM, CB, CM;
            AM = Math.Sqrt((Math.Pow((xM - xA), 2)) + (Math.Pow((yM - yA), 2)));
            CB = Math.Sqrt((Math.Pow((xB - xC), 2)) + (Math.Pow((yB - yC), 2)));
            CM = Math.Sqrt((Math.Pow((xM - xC), 2)) + (Math.Pow((yM - yC), 2)));
            SBAM = 0.5 * AB * AM * (Math.Sqrt(1 + ((((xM - xA) * (xB - xA)) + ((yM - yA) * (yB - yA))) / (AB * AM))));
            SCAM = 0.5 * AC * AM * (Math.Sqrt(1 + ((((xM - xA) * (xC - xA)) + ((yM - yA) * (yC - yA))) / (AC * AM))));
            SBCM = 0.5 * BC * CM * (Math.Sqrt(1 + ((((xM - xC) * (xB - xC)) + ((yM - yC) * (yB - yC))) / (BC * CM))));
            double d = (SBAM + SCAM + SBCM) - SABC;
            if (d>0)
            {
                Console.WriteLine("Diem m nam ngoai tam giac ABC");
            }    
            else if (SBAM == 0|| SCAM == 0|| SBCM == 0)
            {
                Console.WriteLine("Diem m nam o canh cua tam giac ABC");
            }    
            else
            {
                Console.WriteLine("Diem m nam trong tam giac ABC");
            }    



        }
          
    }
}
    