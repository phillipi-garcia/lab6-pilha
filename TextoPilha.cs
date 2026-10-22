using System.Text;

public static class TextoPilha {
    public static string inverte(string s) {
        Pilha p = new Pilha(s.Length);
        foreach (char c in s) {
            p.empilha(c);
        }
        StringBuilder resultado = new StringBuilder();
        while (!p.vazia()) {
            resultado.Append((char) p.desempilha());
        }
        return resultado.ToString();
    }

    public static bool balanceado(string expr) {
        Pilha p = new Pilha(expr.Length);
        foreach (char c in expr) {
            if (c == '(' || c == '[' || c == '{') {
                p.empilha(c);
            } else if (c == ')' || c == ']' || c == '}') {
                if (p.vazia()) {
                    return false;
                }
                char abre = (char) p.desempilha();
                if (!combina(abre, c)) {
                    return false;
                }
            }
        }
        return p.vazia();
    }

    private static bool combina(char abre, char fecha) {
        return (abre == '(' && fecha == ')')
            || (abre == '[' && fecha == ']')
            || (abre == '{' && fecha == '}');
    }
}
