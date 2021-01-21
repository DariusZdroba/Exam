using System;

namespace ex7
{
    class Program
       {
            static int minPar(int n)
        {
            if (n > 9)
            {
                if (n % 2 != 0) return minPar(n / 10);

                else if (n % 10 < minPar(n / 10) || minPar(n / 10) == -1) return n % 10;

                else return minPar(n / 10);

            }

            else if (n % 2 == 0) return n;

            else return -1;

        }
        static void Main(string[] args)
        {

          Console.WriteLine(minPar(1234));
        }
    }
}
