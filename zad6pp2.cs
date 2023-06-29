using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int k = 0;
        int l = 9;

        while (liczba <= 100)
        {
            for (int j = k; j <= l; j++)
            {
                tablica[k, j] = liczba++;
            }
            for (int i = k + 1; i <= l; i++)
            {
                tablica[i, l] = liczba++;
            }
            for (int j = l - 1; j >= k; j--)
            {
                tablica[l, j] = liczba++;
            }
            for (int i = l - 1; i >= k + 1; i--)
            {
                tablica[i, k] = liczba++;
            }

            k++;
            l--;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
