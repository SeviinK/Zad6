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

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = i * rozmiar + j + 1;
                }
            }
            else
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i + 1) * rozmiar - j;
                }
            }
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
