using System;

namespace Luudo
{
    class baitap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           MENU          ");
            Console.WriteLine("=========================");
            Console.WriteLine("1. CF");
            Console.WriteLine("2. C");
            Console.WriteLine("3. HD");
            Console.WriteLine("4. DressWeaver");
            Console.WriteLine("5. RDBMS");
            Console.WriteLine("6. Learn Java by example");
            Console.WriteLine("=========================");
            Console.Write("\nChon: ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Ban chon CF");
                    break;
                case 2:
                    Console.WriteLine("Ban chon C");
                    break;
                case 3:
                    Console.WriteLine("Ban chon HD");
                    break;
                case 4:
                    Console.WriteLine("Ban chon DressWeaber");
                    break;
                case 5:
                    Console.WriteLine("Ban chon RDBMS");
                    break;
                case 6:
                    Console.WriteLine("Ban chon Learn Jave by example");
                    break;
                default:
                    Console.WriteLine("Ban da chon sai");
                    break;
            }

            
        }
          
    }
}
    