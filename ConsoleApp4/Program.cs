namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int range = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] a = new int[short.MaxValue];
            int[] v = new int[range];
            for (int i = 0; i < short.MaxValue; i++)
            {
                a[i] = i + 1;
            }
            for (int i = 0; i< short.MaxValue; i++)
            {
                for (int j = 0;j< short.MaxValue; j++)
                {
                    if(a[i]%(j+1)==0)
                    {
                        count++;
                    }
                    if (count == 2 && a[i] == (j + 1))
                    {
                        Console.WriteLine("a[" + i + "] "+a[i]);
                        v[n] = a[i];
                        n++;
                        count = 0;
                        break;
                    }
                }
                if(count >2)
                {
                    count = 0;
                }
                if(n==range)
                {
                    break;
                }
            }
            for(int i = 0; i<range;i++)
            {
                Console.WriteLine("v[" + i + "] " + v[i]);
            }
        }
    }

}


