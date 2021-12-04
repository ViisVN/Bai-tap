using System;

namespace String
{
    class Program
    {
        static void menu(string n)
        {
           
                switch (Convert.ToInt32(n))
                {
                    case 1:
                        Console.Write("| Doing menu 1......                                                                                                   |\n"); break;
                    case 2:
                        Console.Write("| Doing menu 2......                                                                                                   |\n"); break;
                    case 3:
                        Console.Write("| Doing menu 3......                                                                                                   |\n"); break;
                    case 4:
                        Console.Write("| Doing menu 4......                                                                                                   |\n"); break;               
                }
            if (Convert.ToInt32(n) == 5)
            {
                        Console.Write("| Exit...............                                                                                                  |\n");
            }
            else
            {
                nhap(n);
            }
        }
        static void nhap(string n)
        {
            Console.Write("|            PLEASE CHOOSE: ");
            n = Console.ReadLine();
            if (n.Length>=2)
            {
                Console.Write("| Please choose again                                                                                                  |");
                nhap(n);

            }
            else 
            {
                if (Convert.ToChar(n) >= 'a' && Convert.ToChar(n) <= 'z' || Convert.ToChar(n) >= 'A' && Convert.ToChar(n) <= 'Z' || Convert.ToInt32(n) < 1 || Convert.ToInt32(n) > 5)
                {
                    Console.Write("| Please choose again                                                                                                  |");
                    nhap(n);

                }
                else
                {
                    menu(n);
                }
            }    
        }
        static void Main(string[] args)
        {
            string n="abc";
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                                      Menu                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| 1. Menu 1                                                                                                            |");
            Console.WriteLine("| 2. Menu 2                                                                                                            |");
            Console.WriteLine("| 3. Menu 3                                                                                                            |");
            Console.WriteLine("| 4. Menu 4                                                                                                            |");
            Console.WriteLine("| 5. Exit                                                                                                              |");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------+");
            nhap(n);
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------+");


        }
    }

}

            