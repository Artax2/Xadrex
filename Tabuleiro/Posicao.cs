namespace Tabuleiro {
    internal class Posicao {
        public int linha { get; set; }
        public int couluna { get; set; }

        public Posicao(int linha, int couluna) {
            this.linha = linha;
            this.couluna = couluna;
        }

        public override string ToString() {
            return linha
                + ","
                + couluna;
        }
    }
}
