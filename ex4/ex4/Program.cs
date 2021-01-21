using System;

namespace ex4
{
    class Program
    {
        static void sumaMatrice() {
            int n;
            int[,] v = new int[50,50];
            string line;
            line = Console.ReadLine();
            n = int.Parse(line);
            int suma = 0; // initializam suma cu 0
            for(int i=1;i<=n;i++)
                for(int j = 1; j <= n; j++)
                {
                    line = Console.ReadLine();
                    v[i, j] = int.Parse(line);
                    if (i + j > n + 1) suma = suma + v[i, j]; // verificam in timpul citirii daca se afla
                                                              //sau nu elementul sub diagonala secundara si facem suma  
                }
            Console.WriteLine(suma);

        }

        static void Main(string[] args)
        {

            sumaMatrice();
        }
    }
}
