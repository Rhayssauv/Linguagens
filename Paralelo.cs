using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Cria um array de números
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Executa a soma dos números em paralelo
        Parallel.ForEach(numeros, numero =>
        {
            int resultado = numero * numero; // Calcula o quadrado do número
            Console.WriteLine($"O quadrado de {numero} é {resultado}");
        });
    }
}
