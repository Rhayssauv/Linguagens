using System;

class Program
{
    // Método genérico para encontrar o maior de dois valores
    static T Maior<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    static void Main(string[] args)
    {
        // Usando o método genérico para encontrar o maior número
        int maiorInt = Maior(10, 20);
        Console.WriteLine($"Maior entre 10 e 20: {maiorInt}");

        // Usando o método genérico para encontrar a maior string
        string maiorString = Maior("Apple", "Banana");
        Console.WriteLine($"Maior entre 'Apple' e 'Banana': {maiorString}");
    }
}
