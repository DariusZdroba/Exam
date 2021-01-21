using System;

namespace Ex
{
    class Program
    {   static int complement(int k)
        {
            int produs = 1, nr = 0,c;
            while (k != 0)
            {
                c = k % 10;
                c = 9 - c;
                k = k / 10;
                nr = c * produs + nr;
                produs = produs * 10;
            }
            return nr;
        }
        static void Main(string[] args)
        {
            int n;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            Console.WriteLine(complement(n));


        }
    }
}
