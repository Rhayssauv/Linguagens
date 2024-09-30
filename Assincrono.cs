using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando a busca de dados...");
        
        // Chama a função assíncrona
        string resultado = await BuscarDadosAsync();

        Console.WriteLine($"Dados recebidos: {resultado}");
    }

    // Método assíncrono que simula a busca de dados
    static async Task<string> BuscarDadosAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            // Simula uma espera de 2 segundos
            await Task.Delay(2000); 

            // var response = await client.GetAsync("https://api.exemplo.com/dados");
            // return await response.Content.ReadAsStringAsync();

            // Retornando uma string simulada
            return "Dados simulados da API";
        }
    }
}
