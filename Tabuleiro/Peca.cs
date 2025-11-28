namespace tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca() { }
        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.posicao = null; // POSIÇÃO A SER DEFINIDA
            this.tabuleiro = tabuleiro;
            this.cor = cor;
        }

        public void IncrementarQteMovimentos() {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

    }
}
