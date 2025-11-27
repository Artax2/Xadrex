namespace xadrex_console.tabuleiro {
    internal class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) {
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
        }
    }
}
