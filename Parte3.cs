using System;

public class Parte3 : Parte {
    public Parte3() : base("Parte 3 - Usando a pilha") { }

    protected override void Executar() {
        Console.WriteLine("PUCMINAS -> " + TextoPilha.inverte("PUCMINAS"));

        string[] exprs = { "(a+b)*[c-d]", "{[()]}", "((a)", "a+b)", "([)]" };
        foreach (string e in exprs) {
            Console.WriteLine(e + " -> " + TextoPilha.balanceado(e));
        }
    }
}
