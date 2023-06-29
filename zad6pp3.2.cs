using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj rozmiar tablicy (liczbę wierszy i kolumn):");
        int rozmiar;
        while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0)
        {
            Console.WriteLine("Nieprawidłowe dane. Podaj poprawny rozmiar tablicy (liczbę większą od zera):");
        }

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;
        int k = 0;
        int l = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
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

        Console.WriteLine("Wygenerowana tablica:");
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
