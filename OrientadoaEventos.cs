using System;

class Botao
{
    // Definindo um evento
    public event EventHandler Click;

    // Método que simula o clique do botão
    public void Clicar()
    {
        // Verifica se há inscritos e dispara o evento
        Click?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Botao botao = new Botao();

        // Inscrevendo um manipulador de eventos
        botao.Click += Botao_Click;

        // Simulando o clique no botão
        botao.Clicar();
    }

    // Método que trata o evento
    private static void Botao_Click(object sender, EventArgs e)
    {
        Console.WriteLine("O botão foi clicado!");
    }
}
