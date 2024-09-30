using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int limite = Convert.ToInt32(Console.ReadLine());

        int soma = CalcularSoma(limite);

        Console.WriteLine($"A soma dos números de 1 a {limite} é: {soma}");
    }

    // Função para calcular a soma
    static int CalcularSoma(int limite)
    {
        int soma = 0;
        for (int i = 1; i <= limite; i++)
        {
            soma += i; // Adiciona o valor atual à soma
        }
        return soma;
    }
}
