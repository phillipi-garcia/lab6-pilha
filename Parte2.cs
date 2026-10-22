using System;

public class Parte2 : Parte {
    public Parte2() : base("Parte 2 - Rastreio") { }

    protected override void Executar() {
        Pilha p = new Pilha(4);
        Empilha(p, 10);
        Empilha(p, 20);
        Desempilha(p);
        Empilha(p, 30);
        Empilha(p, 40);
        Desempilha(p);
        Desempilha(p);
        Empilha(p, 50);
        Console.WriteLine("tamanho: " + p.tamanho());
    }

    private void Empilha(Pilha p, int x) {
        p.empilha(x);
        Console.Write("empilha(" + x + ") -> ");
        p.mostra();
    }

    private void Desempilha(Pilha p) {
        int x = p.desempilha();
        Console.Write("desempilha() = " + x + " -> ");
        p.mostra();
    }
}
