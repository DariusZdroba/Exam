using System;

namespace Ex2
{
    class Program
    {   static void suma(int[] v, int k)
        {
            int j = 0; int d = 1;
            while (j < 9)
            {
                for (int i = d; i < 10; i++) // i-ul porneste de la d, care este incrementat
                                             // dupa fiecare parcurgere pentru a nu verifica de doua ori aceeasi
                                             //indici (ex 1 cu 2 si 2 cu 1)
                {
                    if (v[i] + v[j] == k) Console.WriteLine(i + " " + j);

                }
                j++;
                d++;
            }

        }
        static void Main(string[] args)
        {
            int t;
            int[] v = new int[50];
            string line;
            line = Console.ReadLine();
            t = int.Parse(line); // t este numarul specificat
            //Luam ca exemplu un vector de 10 elemente nefiind specificat numarul elementelor.
            
            for(int i = 0; i < 10; i++)
            {
                line = Console.ReadLine();
                v[i] = int.Parse(line);
            }
            suma(v,t);
        }
    }
}
