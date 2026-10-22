public interface IPilha {
    bool vazia();
    bool cheia();
    int tamanho();
    void empilha(int x);
    int desempilha();
    int consultaTopo();
    void mostra();
}
