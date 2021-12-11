namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string s_1 = "";
            int length = 0;
            int j = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            while (n >= 2)
            {
                if (n % 2 == 0)
                {
                    s_1 = s_1.Insert(length, "0");
                    n = n / 2;
                    length++;
                }
                if (n % 2 == 1)
                {
                    s_1 = s_1.Insert(length, "1");
                    n = (n / 2);
                    length++;
                }
                

            }
            for(int i = s_1.Length-1;i>=0;i--)
            {
                Console.Write(s_1[i]);
            }
        }

    }
}


