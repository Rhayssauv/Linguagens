class Animal {
    public virtual void Som() {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal {
    public override void Som() {
        Console.WriteLine("O cachorro late.");
    }
}

class Program {
    static void Main() {
        Animal meuAnimal = new Cachorro();
        meuAnimal.Som();  // Exibe: O cachorro late.
    }
}
