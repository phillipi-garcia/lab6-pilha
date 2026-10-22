using System;

public class Parte4 : Parte {
    public Parte4() : base("Parte 4 - Bubble Sort com pilhas") { }

    protected override void Executar() {
        Testa(new int[] { 5, 2, 9, 1, 7 });
        Testa(new int[] { 1, 2, 3, 4, 5 });
        Testa(new int[] { 5, 4, 3, 2, 1 });
    }

    private void Testa(int[] v) {
        int comparacoes;
        int[] ordenado = OrdenacaoPilha.bubblePilhas(v, out comparacoes);
        Console.WriteLine("{" + string.Join(", ", v) + "} -> {" + string.Join(", ", ordenado)
            + "} | comparacoes: " + comparacoes);
    }
}
