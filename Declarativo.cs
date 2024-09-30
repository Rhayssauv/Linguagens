using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Lista de números
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Consulta declarativa usando LINQ para filtrar números pares
        var numerosPares = from n in numeros
                           where n % 2 == 0
                           select n;

        // Exibindo os números pares
        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}
