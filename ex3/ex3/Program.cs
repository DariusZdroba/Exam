using System;

namespace ex3
{
    class Program
    {    static void lista()
        {
            int n;
            int maxim1 = 0, maxim2 = 0, maxim3 = 0;
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            maxim1 = n;
            line = Console.ReadLine();
            n = int.Parse(line);
            if (n >= maxim1)
            {
                maxim2 = maxim1;
                maxim1 = n;
            }
            else
                maxim2 = n;
                while (n != 0)
            {
                line = Console.ReadLine();
                n = int.Parse(line);
                if ((n > maxim1)&&(n!=0))
                {
                    maxim3 = maxim2;
                    maxim2 = maxim1;
                    maxim1 = n;
                }
               
            }
            Console.WriteLine(maxim1 + " " + maxim2 + " " + maxim3);

        }   
        static void Main(string[] args)
        {

            lista();
        }
    }
}
