// Classe Motor - Componente
public class Motor
{
    public string Tipo { get; set; }

    public Motor(string tipo)
    {
        Tipo = tipo;
    }

    public void Ligar() => Console.WriteLine($"Motor {Tipo} ligado.");
}

// Classe Carro - Componente que utiliza Motor
public class Carro
{
    private Motor motor;

    public Carro(Motor motor)
    {
        this.motor = motor; // Atribuindo o motor ao carro
    }

    public void LigarCarro()
    {
        motor.Ligar(); // Chama o método do motor
        Console.WriteLine("Carro pronto para andar.");
    }
}

// Classe Program - Para execução
class Program
{
    static void Main(string[] args)
    {
        Motor motor = new Motor("V8");
        Carro carro = new Carro(motor);
        carro.LigarCarro();
    }
}
