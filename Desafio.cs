using System;

public class Desafio : Parte {
    public Desafio() : base("Desafio - Ordenar pilha") { }

    protected override void Executar() {
        int[] valores = { 4, 1, 6, 3, 5, 2 };
        Pilha p = new Pilha(valores.Length);
        foreach (int x in valores) {
            p.empilha(x);
        }
        Console.Write("entrada: ");
        p.mostra();

        Pilha ordenada = OrdenacaoPilha.ordenaPilha(p);
        Console.Write("saida: ");
        ordenada.mostra();
    }
}
