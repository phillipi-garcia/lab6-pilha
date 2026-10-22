public static class OrdenacaoPilha {
    public static int[] bubblePilhas(int[] v, out int comparacoes) {
        comparacoes = 0;
        int n = v.Length;
        Pilha a = new Pilha(n);
        Pilha b = new Pilha(n);
        Pilha r = new Pilha(n);

        for (int i = 0; i < n; i++) {
            a.empilha(v[i]);
        }

        for (int restantes = n; restantes >= 1; restantes--) {
            int carry = a.desempilha();
            for (int i = 0; i < restantes - 1; i++) {
                int x = a.desempilha();
                comparacoes++;
                if (carry > x) {
                    b.empilha(x);
                } else {
                    b.empilha(carry);
                    carry = x;
                }
            }
            r.empilha(carry);

            Pilha aux = a;
            a = b;
            b = aux;
        }

        int[] resultado = new int[n];
        for (int i = 0; i < n; i++) {
            resultado[i] = r.desempilha();
        }
        return resultado;
    }

    public static Pilha ordenaPilha(Pilha p) {
        Pilha aux = new Pilha(p.tamanho());
        while (!p.vazia()) {
            int t = p.desempilha();
            while (!aux.vazia() && aux.consultaTopo() > t) {
                p.empilha(aux.desempilha());
            }
            aux.empilha(t);
        }
        return aux;
    }
}
