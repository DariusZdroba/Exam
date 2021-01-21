using System;

namespace ex6
{
    class Program
    {   static void sir(int n)
        {
            int k;
            for(int i = 1; i <= n; i++)
            {
                k = 1;
                while (k <= i)
                {
                    for (int d = 1; d <= i; d++) Console.WriteLine(k + " ");
                    k++;
                }


            }


        }
        static void Main(string[] args)
        {
            int n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            sir(n);


        }
    }
}
