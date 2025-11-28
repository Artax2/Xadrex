using tabuleiro;

namespace xadrex {
    internal class PosicaoXadrex {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrex(char coluna, int linha) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
