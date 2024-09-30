using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de números
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> numerosPares = new List<int>();

        // Lógica imperativa para filtrar números pares
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                numerosPares.Add(numero); // Adiciona número par à lista
            }
        }

        // Exibindo os números pares
        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}
