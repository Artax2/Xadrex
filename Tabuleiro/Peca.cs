namespace tabuleiro {
    internal class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.posicao = null; // POSIÇÃO A SER DEFINIDA
            this.tabuleiro = tabuleiro;
            this.cor = cor;
        }

        public void IncrementarQteMovimentos() {
            qteMovimentos++;
        }
    }
}
