using System.Collections.Generic;

public class Program {
    static void Main() {
        List<Parte> partes = new List<Parte> {
            new Parte1(),
            new Parte2(),
            new Parte3(),
            new Parte4(),
            new Desafio()
        };

        foreach (Parte parte in partes) {
            parte.Rodar();
        }
    }
}
