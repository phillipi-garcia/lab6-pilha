using System;

public abstract class Parte {
    public string Nome { get; }

    protected Parte(string nome) {
        Nome = nome;
    }

    public void Rodar() {
        Console.WriteLine("--- " + Nome + " ---");
        Executar();
        Console.WriteLine();
    }

    protected abstract void Executar();
}
